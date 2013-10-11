Imports System.Data

Public Class Maestros
    Public tusuario As String

#Region "Funciones"

    Public Shared Function BuildQuery(ByVal sTabala As String, ByVal sCampos As String, ByVal sCondicion As String, ByVal sOrderBy As String, ByVal sTypeOrder As String, ByVal sCadenaConexion As String) As DataSet
        Dim sSQL As String
        sSQL = "SELECT " & sCampos
        sSQL += " FROM " & sTabala
        If (sCondicion <> "") Then
            sSQL += " WHERE " & sCondicion
        End If
        If (sOrderBy <> "") Then
            sSQL += " ORDER BY " & sOrderBy & " " & sTypeOrder
        End If
        Return Query.ExecuteQuery(sSQL, sCadenaConexion)
    End Function

    Public Shared Function BuildProcedure(ByVal iTipo As Integer, ByVal sTabla As String, ByVal sCampos As String, ByVal sValues As String, ByVal sCondicion As String, ByVal sCadenaConexion As String, ByVal parent As Control) As String
        Dim sSQL As String
        Dim script As String
        Dim sError As String
        Dim tAplicacion As String = Globales.aplicacion

        If (iTipo = 1) Then
            sSQL = "INSERT INTO " & sTabla & "(" & sCampos & ") VALUES (" & sValues & ")"
        Else
            If (iTipo = 2) Then
                sSQL = "UPDATE " & sTabla & " SET " & sCampos
                If (sCondicion <> "") Then
                    sSQL += " WHERE " & sCondicion
                End If
            Else
                If (iTipo = 3) Then
                    sSQL = "DELETE FROM " + sTabla
                    If (sCondicion <> "") Then
                        sSQL += " WHERE " + sCondicion
                    End If
                Else
                    Return "Error en la construcción, por favor intentalo más tarde"
                End If
            End If
        End If
        sError = Query.ExecuteProcedure(sTabla, iTipo, sSQL, sCadenaConexion)
        If sError <> "" Then
            Select Case iTipo
                Case 1
                    script = "<script type='text/javascript'>" & _
                                       "alert('Error al ingresar, intentelo nuevamente');" & _
                                   "</script>"
                Case 2
                    script = "<script type='text/javascript'>" & _
                                      "alert('Error al modificar, intentelo nuevamente');" & _
                                  "</script>"
                Case 3
                    script = "<script type='text/javascript'>" & _
                                      "alert('Error al eliminar, intentelo nuevamente');" & _
                                  "</script>"
            End Select

        Else
            Select Case iTipo
                Case 1
                    script = "<script type='text/javascript'>" & _
                                       "alert('Datos Ingresados Correctamente');" & _
                                   "</script>"

                Case 2
                    script = "<script type='text/javascript'>" & _
                                      "alert('Datos Modificados Correctamente');" & _
                                  "</script>"

                Case 3
                    script = "<script type='text/javascript'>" & _
                                      "alert('Datos Eliminados Correctamente');" & _
                                  "</script>"

            End Select

        End If
        Return sError
    End Function

    'Public Shared Function SaveData(ByVal sTabla As String, ByVal sCampos As String, ByVal sValores As String, ByVal sCadenaConexion As String) As String
    '    Dim sSQL As String
    '    Dim sError As String
    '    sSQL = "INSERT INTO " & sTabla & "(" & sCampos & ") VALUES(" & sValores & ")"
    '    sError = Query.ExecuteProcedure(sSQL, sCadenaConexion)
    '    Return sError
    'End Function

    'Public Shared Function UpdateData(ByVal sTabla As String, ByVal sCamposValores As String, ByVal sCondicion As String, ByVal sCadenaConexion As String) As String
    '    Dim sSQL As String
    '    Dim sError As String
    '    sSQL = "UPDATE " & sTabla & " SET " & sCamposValores
    '    If (sCondicion <> "") Then
    '        sSQL += " WHERE " & sCondicion
    '    End If
    '    sError = Query.ExecuteProcedure(sSQL, sCadenaConexion)
    '    If (sError = "") Then
    '        RegistrarMovimiento("actualizacion", "actualizacion a la tabla " + sTabla, sCadenaConexion)
    '    End If
    '    Return sError
    'End Function

    'Public Shared Function DeleteData(ByVal sTabla As String, ByVal sCondicion As String, ByVal sCadenaConexion As String) As String
    '    Dim sError As String = ""
    '    Dim sSQL As String
    '    sSQL = "DELETE FROM " & sTabla & " WHERE " & sCondicion
    '    sError = Query.ExecuteProcedure(sSQL, sCadenaConexion)
    '    If (sError = "") Then
    '        RegistrarMovimiento("eliminacion", "elimina de la tabla " + sTabla, sCadenaConexion)
    '    End If
    '    Return sError
    'End Function

    Public Shared Function QueryMostrar(ByVal ColumnasMostrar As String, ByVal tabla As String, ByVal Condicion As String, ByVal columnaOrderBy As String, ByVal orderBy As String, ByVal CadenaConexion As String) As DataSet
        If Condicion <> "" Then
            Return BuildQuery(ColumnasMostrar, tabla, Condicion, columnaOrderBy, orderBy, CadenaConexion)
        End If
        Return BuildQuery(ColumnasMostrar, tabla, Condicion, columnaOrderBy, orderBy, CadenaConexion)
    End Function

    Public Shared Sub LimpiarControl(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If (c.Controls.Count > 0) Then
                LimpiarControl(c)
            Else
                If TypeOf c Is TextBox Then
                    CType(c, TextBox).Text = ""
                End If
            End If
        Next
    End Sub
#End Region
End Class