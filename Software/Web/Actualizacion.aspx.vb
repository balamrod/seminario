
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

    Private Sub bloqueado(valor As Boolean)
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                CType(c, TextBox).Enabled = Not valor
            End If
        Next

        btnGuardar.Visible = Not valor
        btnModificar.Visible = valor
    End Sub


    Private Sub actualizarInformacion()

        Dim DsPersona As DataSet = ExecuteQuery("select correo,telefono_casa,celular,direccion from alumno where anio_carnet = 07 and correlativo_carnet = 2210 and id_carrera = 901", cadenaConexion)

        txtCorreo.Text = GetItem(DsPersona, "correo")
        txtCelular.Text = GetItem(DsPersona, "celular")
        txtDomicilio.Text = GetItem(DsPersona, "direccion")
        txtTelefono.Text = GetItem(DsPersona, "telefono_casa")

        bloqueado(True)
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Me.Page.IsPostBack Then
            actualizarInformacion()
        End If

    End Sub


    Protected Sub btnGuardar_Click(sender As Object, e As ImageClickEventArgs) Handles btnGuardar.Click
        BuildProcedure(2, "alumno", "correo = '" & txtCorreo.Text & "', celular = '" & txtCelular.Text & "', direccion = '" & txtDomicilio.Text & "', telefono_casa = '" & txtTelefono.Text & "'", "", "anio_carnet = 07 and correlativo_carnet = 2210 and id_carrera = 901", sCadenaConexion, Me)
        actualizarInformacion()
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As ImageClickEventArgs) Handles btnModificar.Click
        bloqueado(False)
    End Sub
End Class