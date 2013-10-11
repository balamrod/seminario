Imports MySql.Data.MySqlClient

Public Class Conexion

    ''' <summary>
    ''' Clase que conecta a la Base de Datos
    ''' </summary>
    ''' <param name="sCadenaConexion">Cadena de Conexión</param>
    ''' <returns>MySqlConnection</returns>
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
            'System.Web.HttpContext.Current.Response.Redirect("errorConexion.aspx")
        End Try
        Return Cnn
    End Function

    Public Shared Function ConectarBDError(ByVal sCadenaConexion As String) As Boolean
        Dim Cnn As New MySqlConnection(sCadenaConexion)
        'Abrimos la conexión
        Dim bError As Boolean = False
        Dim HuboError As Boolean = False
        Try
            Cnn.Open()
            bError = True
        Catch ex As Exception
            Cnn.Close()
            HuboError = True
        End Try
        Return HuboError
    End Function


    ''' <summary>
    ''' Clase que desconecta a la Base de Datos
    ''' </summary>
    ''' <param name="Cnn">Variable de MySqlConnection</param>
    ''' <remarks></remarks>
    Public Shared Sub DesconectarBD(ByVal Cnn As MySqlConnection)
        Try
            Cnn.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class

