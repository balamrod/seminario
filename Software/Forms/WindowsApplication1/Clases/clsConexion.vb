Imports MySql.Data.MySqlClient
Imports WindowsApplication1.clsGlobales

''' <summary>
''' Soluciones Analíticas Empresariales S.A. 
''' Clase que conecta a la Base de Datos
''' </summary>
''' <remarks></remarks>
Friend Class clsConexion
#Region "Constantes"
    Private Const _sCnn As String = cadenaConexion
#End Region
#Region "Conexión"
    Public Shared Function Cnn() As MySqlConnection
        Dim conn As New MySqlConnection(_sCnn)
        Try
            conn.Open()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return conn
    End Function
#End Region
End Class
