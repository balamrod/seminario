Imports WindowsApplication1.clsGlobales
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsABC

Public Class mstSalon

#Region "variables"
    Dim iId As String
    Dim VectorTxt(3) As TextBox
#End Region

    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = txtCantidad
        VectorTxt(1) = txtNombre
        VectorTxt(2) = txtDescripcion

        VectorTxt(3) = New TextBox
        VectorTxt(3).Tag = "id_salon" ''nombre bd
        If incluirID Then
            VectorTxt(3).Text = Guid.NewGuid.ToString
        Else
            VectorTxt(3).Text = iId
        End If

    End Sub


    Private Sub mstSalon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''grid
        FillDataGridView(dgvSalon, ExecuteQuery("Select * from salon"))
        ''dgvCarrera.Columns("sucursal_id_sucursal").Visible = False
    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click
        LlenarTextBox(True)
        Dim sError As String = SaveData("salon", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvSalon, ExecuteQuery("Select * from salon"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("salon", "id_salon = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvSalon, ExecuteQuery("Select * from salon"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("salon", VectorTxt, "id_salon = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvSalon, ExecuteQuery("Select * from salon"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub dgvSalon_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSalon.SelectionChanged
        iId = GetItem(dgvSalon, "id_salon")

        txtNombre.Text = GetItem(dgvSalon, "nombre")
        txtDescripcion.Text = GetItem(dgvSalon, "observacion")
        txtCantidad.Text = GetItem(dgvSalon, "capacidad") ''nombre de la bd
       
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub
End Class