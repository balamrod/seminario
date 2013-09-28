
Imports MySql.Data.MySqlClient
Imports Maestros
Imports General
Imports System.Data
Imports Conexion
Imports Query
Imports Globales
Imports Bitacora

Partial Class _Default
    Inherits Page

#Region "variables"
    Dim sCadenaConexion As String = cadenaConexion
    Dim maximo As DataSet
    Dim temp As String
    Dim nuevo As String

#End Region

    Public Sub construirGrid()
        'maximo = ExecuteQuery("select concat(descripcion,'-',anio) as descripcion1 from pensum where id_pensum = " & ddlCodPensum.Text, sCadenaConexion)
        'temp = GetItem(maximo, "descripcion1")
        Dim dView As DataView = FillDataGridView(sCadenaConexion, "select * from alumno", "alumno")
        GridView1.DataSource = dView
        GridView1.DataBind()
    End Sub

    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        BuildProcedure(1, "alumno", "", TextBox1.Text & ", '" & TextBox2.Text & "'", "", sCadenaConexion, Me)
        construirGrid()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        construirGrid()
    End Sub
End Class