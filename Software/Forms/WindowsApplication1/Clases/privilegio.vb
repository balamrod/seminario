Imports WindowsApplication1.Maestros
Imports WindowsApplication1.Conexion
Imports WindowsApplication1.Query
Imports WindowsApplication1.General
Imports System.Data
Imports WindowsApplication1.Globales


Public Class privilegio
    Public Shared Function comprobarUsuario(ByVal sCadenaConexion As String, ByVal usuario As String, ByVal password As String) As Boolean
        Dim Query As String
        Dim NuevaConexion As DataSet
        Dim temp As String

        Query = "Select contrasenia,id_usuario from usuario Where alias='" & usuario & "' and estado= 1"
        Try
            NuevaConexion = ExecuteQuery(Query, sCadenaConexion)
            temp = GetItem(NuevaConexion, "contrasenia")
            If (password <> temp) Then
               
                Return True
            End If

            temp = GetItem(NuevaConexion, "id_usuario")
            id_empleado = temp
            HttpContext.Current.Session("usuario") = temp
            Query = "update usuario set enlinea = 1 where id_usuario = " & temp
            ExecuteProcedure("usuario", "2", Query, sCadenaConexion)

            HttpContext.Current.Session("perfilUsuario") = obtenerPerfil(usuario, password, sCadenaConexion)
        Catch ex As Exception

        End Try
    End Function

    Public Shared Function obtenerSqlModulo(ByVal modulo As Integer) As String
        Dim sSql As String = ""
        If modulo = 1 Then
            sSql = "select nombre from aplicacion where nombre like 'ins%'"
        End If

        If modulo = 2 Then
            sSql = "select nombre from aplicacion where nombre like 'reg%'"
        End If

        If modulo = 3 Then
            sSql = "select nombre from aplicacion where nombre like 'adm%'"
        End If

        If modulo = 4 Then
            sSql = "select nombre from aplicacion where nombre like 'con%'"
        End If

        If modulo = 5 Then
            sSql = "select nombre from aplicacion where nombre like 'seg%'"
        End If
        Return sSql
    End Function

    Public Shared Sub actualizarPrivilegiosMaster(ByVal paginaMaestro As MasterPage, ByVal Bloquear As Integer, ByVal modulo As Integer)
        Dim contentPlace As New ContentPlaceHolder
        Dim sSql As String
        Dim visible As Integer

        If Bloquear = 1 Then
            sSql = obtenerSqlModulo(modulo)
            visible = 0
        Else
            visible = 1
            sSql = "select a.nombre from asignacion_privilegios ap, aplicacion a where ap.id_aplicacion = a.id_aplicacion and ap.id_grupo = " & HttpContext.Current.Session("perfilUsuario")
        End If

        contentPlace = paginaMaestro.FindControl("ContentPlaceHolderMaster")

        actualizarPrivilegios(contentPlace, sSql, visible)
    End Sub


    Public Shared Sub actualizarPrivilegios(ByVal parent As Control, ByVal sSql As String, ByVal visible As Integer)
        Dim pnlGeneral As New Panel
        Dim sCadenaConexion As String = cadenaConexion

        Dim dsObtenerPrivilegio As DataSet

        Dim iColumna As Integer
        Dim nombre As String
        dsObtenerPrivilegio = ExecuteQuery(sSql, sCadenaConexion)

        For i = 0 To GetCanRows(dsObtenerPrivilegio) - 1
            iColumna = dsObtenerPrivilegio.Tables(0).Columns("nombre").Ordinal
            nombre = dsObtenerPrivilegio.Tables(0).Rows(i).ItemArray(iColumna).ToString()
            Try
                pnlGeneral = parent.FindControl(nombre)
                If visible = 1 Then
                    pnlGeneral.Visible = True
                Else
                    pnlGeneral.Visible = False
                End If

            Catch ex As Exception

            End Try

        Next

    End Sub

    Public Shared Function obtenerPerfil(ByVal usuario As String, ByVal pass As String, ByVal sCadenaConexion As String) As String
        Dim dsObtenerPerfil As DataSet
        Dim ObtenerPerf As String
        dsObtenerPerfil = ExecuteQuery("select id_grupo from usuario where alias = '" & usuario & "' and contrasenia = '" & pass & "'", sCadenaConexion)
        ObtenerPerf = GetItem(dsObtenerPerfil, "id_grupo")
        Return ObtenerPerf
    End Function

End Class

