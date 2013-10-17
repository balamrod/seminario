Imports MySql.Data.MySqlClient

Public Class Conexion
''' <summary>
    ''' Soluciones Analíticas Empresariales S.A. 
    ''' Clase que conecta a la Base de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Function ConectarBD(ByVal sCadenaConexion As String) As MySqlConnection
        Dim Cnn As New MySqlConnection(sCadenaConexion)
        'Abrimos la conexión
        Dim bError As Boolean = False
        Try
            Cnn.Open()
            bError = True
        Catch ex As Exception
            Cnn.Close()
            System.Web.HttpContext.Current.Response.Redirect("errorConexion.aspx")
        End Try
        Return Cnn
    End Function

  ''' <summary>
    ''' Soluciones Analíticas Empresariales S.A. 
    ''' Clase que desconecta a la Base de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub DesconectarBD(ByVal Cnn As MySqlConnection)
        Try
            Cnn.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class

