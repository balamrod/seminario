Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class login

    Private Sub btnAutenticar_Click(sender As Object, e As EventArgs) Handles btnAutenticar.Click
        Dim comprobar As Boolean = False

        If txtusuario.Text <> "" And txtPass.Text > "" Then
            comprobar = comprobarUsuario(txtusuario.Text, txtPass.Text)
        End If

        If Not comprobar Then
            MessageBox.Show("Usuario o contraseña no coinciden")
        Else
            Dim maestro As New Maestro
            Dim login As New login
            Me.Hide()
            maestro.Show()
        End If

    End Sub
    Protected Function comprobarUsuario(login As String, pass As String) As Boolean
        Dim Query As String
        Dim NuevaConexion As DataSet
        Dim temp As String

        Query = "Select contrasenia,esalumno,id_usuario from usuario Where alias='" & login & "'"

        NuevaConexion = ExecuteQuery(Query)
        temp = GetItem(NuevaConexion, "contrasenia")
        If (pass <> temp) Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class