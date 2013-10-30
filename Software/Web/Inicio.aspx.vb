
Imports MySql.Data.MySqlClient
Imports Maestros
Imports General
Imports System.Data
Imports Conexion
Imports Query
Imports Globales


Partial Class inicio
    Inherits Page

#Region "variables"
    Dim sCadenaConexion As String = cadenaConexion
#End Region


    Protected Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate

        Dim comprobar As Boolean = False

        If Login1.UserName <> "" And Login1.Password <> "" Then
            comprobar = comprobarUsuario(sCadenaConexion, Login1.UserName, Login1.Password)
        End If

        e.Authenticated = comprobar
    End Sub

    Protected Function comprobarUsuario(sCadenaConexion As String, login As String, pass As String) As Boolean
        Dim Query As String
        Dim NuevaConexion As DataSet
        Dim temp As String

        Query = "Select contrasenia,esalumno,id_usuario from usuario Where alias='" & login & "'"

        NuevaConexion = ExecuteQuery(Query, sCadenaConexion)
        temp = GetItem(NuevaConexion, "contrasenia")
        If (pass <> temp) Then
            Return False
        Else
            esAlumno = GetItem(NuevaConexion, "esalumno")
            idUsuario = GetItem(NuevaConexion, "id_usuario")
            Return True
        End If

    End Function

    Protected Sub Login1_LoggedIn(sender As Object, e As EventArgs) Handles Login1.LoggedIn
        Master.FindControl("menuActualizacion").Visible = True
        Master.FindControl("menuOperaciones").Visible = True
        Master.FindControl("menuContactenos").Visible = True
        If esAlumno = "1" Then
            Master.FindControl("menuVerNotas").Visible = False
            Master.FindControl("menuConsultarNotas").Visible = True
        Else
            Master.FindControl("menuVerNotas").Visible = True
            Master.FindControl("menuConsultarNotas").Visible = False

        End If
        usuarioEstaOnline = True
        Response.Redirect("~/actualizacion.aspx")
    End Sub
End Class