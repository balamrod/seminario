Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports WindowsApplication1.Conexion
Imports System.Data
Imports WindowsApplication1.General
Imports WindowsApplication1.Globales


Public Class Query
#Region "Select"
    Public Shared Function ExecuteQuery(ByVal sSQL As String, ByVal sCadenaConexion As String) As DataSet
        Dim dsData As New DataSet
        Dim cmd As New MySqlCommand(sSQL, ConectarBD(sCadenaConexion))
        Try
            cmd.CommandType = CommandType.Text
            Dim objAdapter As New MySqlDataAdapter(cmd)
            objAdapter.Fill(dsData)
        Catch ex As Exception

        End Try
        Return dsData
    End Function
#End Region

#Region "Insert, Update, Delete"
    Public Shared Function ExecuteProcedure(ByVal sTabla As String, ByVal iTipo As Integer, ByVal sSQL As String, ByVal sCadenaConexion As String) As String
        Dim sError As String = ""
        Try
            Dim mSQL As MySqlConnection = ConectarBD(sCadenaConexion)
            Dim sqlTran As MySqlTransaction = mSQL.BeginTransaction
            Dim cmd As New MySqlCommand(sSQL, mSQL)
            Try
                cmd.ExecuteNonQuery()
                sqlTran.Commit()
                DesconectarBD(mSQL)
            Catch ex As Exception
                Try
                    sqlTran.Rollback()
                    DesconectarBD(mSQL)
                    sError = ex.Message
                Catch ex2 As Exception
                    DesconectarBD(mSQL)
                    sError = ex2.Message
                End Try
            End Try
        Catch ex As Exception
            Dim tError As String = ex.ToString()  
        End Try
        Return sError
    End Function

    Public Shared Sub llamarAplicacion(ByVal tempo As String, ByVal scadenaconexion As String)
        Dim arrPath As String = System.IO.Path.GetFileName(tempo)
        Dim paginasinasp() As String = arrPath.Split(".")
        Dim pagina1 As String = paginasinasp(0)
        Dim maximo As DataSet
        maximo = ExecuteQuery("select id_aplicacion from aplicacion where nombre = '" + pagina1 + "'", scadenaconexion)
        Dim temp As String = GetItem(maximo, "id_aplicacion")
        aplicacion = temp
    End Sub

#End Region

#Region "Transacciones"
    Public Shared Function EjecutarTransaccion(ByVal ListaSentencias As ArrayList, ByVal CadenaConexion As String) As Boolean
        Dim sError As String = ""
        Dim mSQL As MySqlConnection = ConectarBD(CadenaConexion)
        Dim sqlTran As MySqlTransaction = mSQL.BeginTransaction
        Dim cmd As MySqlCommand = mSQL.CreateCommand()
        cmd.Connection = mSQL
        cmd.Transaction = sqlTran
        Try
            Dim bandera As Boolean = False
            Dim objSentencia As Object
            Dim strSentencia As String = ""
            Try
                For Each objSentencia In ListaSentencias
                    strSentencia = objSentencia.ToString()
                    cmd.CommandText = strSentencia.ToString()
                    cmd.ExecuteNonQuery()
                Next
                sqlTran.Commit()
                DesconectarBD(mSQL)
                bandera = True
            Catch ex As Exception
                Try
                    sqlTran.Rollback()
                    DesconectarBD(mSQL)
                Catch ex2 As Exception
                    DesconectarBD(mSQL)
                End Try
            Finally
                DesconectarBD(mSQL)
            End Try
            Return bandera
        Catch ex3 As Exception
            DesconectarBD(mSQL)
        End Try
    End Function
#End Region
End Class