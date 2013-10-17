
Imports MySql.Data.MySqlClient
Imports Maestros
Imports General
Imports System.Data
Imports Conexion
Imports Query
Imports Globales

Partial Class _Default
    Inherits Page

#Region "variables"
    Dim sCadenaConexion As String = cadenaConexion
    Dim maximo As DataSet
    Dim temp As String
    Dim nuevo As String

#End Region

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        BuildProcedure(1, "alumno", "", TextBox1.Text & ", '" & TextBox2.Text & "'", "", sCadenaConexion, Me)

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class