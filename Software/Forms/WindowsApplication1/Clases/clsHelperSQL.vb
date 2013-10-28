Imports MySql.Data.MySqlClient
''' <summary>
''' Soluciones Analíticas Empresariales S.A. 
''' Ejecuta las instrucciones SQL recibiendo un Query
''' </summary>
''' <remarks></remarks>
Public Class clsHelperSQL
#Region "Select"
    Public Shared Function ExecuteQuery(ByVal sSQL As String) As DataSet
        Dim dsData As New DataSet
        Dim cmd As New MySqlCommand(sSQL, clsConexion.Cnn())
        Try
            cmd.CommandType = CommandType.Text
            Dim objAdapter As New MySqlDataAdapter(cmd)
            objAdapter.Fill(dsData)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dsData
    End Function

    Public Shared Function ExecuteQueryDt(ByVal sSQL As String) As DataTable
        Dim dsData As New DataTable
        Dim cmd As New MySqlCommand(sSQL, clsConexion.Cnn())
        Try
            cmd.CommandType = CommandType.Text
            Dim objAdapter As New MySqlDataAdapter(cmd)
            dsData.Locale = System.Globalization.CultureInfo.InvariantCulture
            objAdapter.Fill(dsData)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dsData
    End Function
#End Region
#Region "Insert, Update, Delete"
    Public Shared Function ExecuteProcedure(ByVal sSQL As String) As String
        Dim sError As String = ""
        Dim sqlTran As MySqlTransaction = clsConexion.Cnn().BeginTransaction()
        Dim cmd As New MySqlCommand(sSQL, clsConexion.Cnn())
        Try
            cmd.ExecuteNonQuery()
            sqlTran.Commit()
            clsConexion.Cnn().Close()
        Catch ex As Exception
            Try
                sqlTran.Rollback()
                clsConexion.Cnn().Close()
                sError = ex.Message
            Catch ex2 As Exception
                clsConexion.Cnn().Close()
                sError = ex2.Message
            End Try
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return sError
    End Function
#End Region
End Class