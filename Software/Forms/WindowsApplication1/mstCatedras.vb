<<<<<<< HEAD

﻿Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
=======
﻿Imports WindowsApplication1.clsGlobales
>>>>>>> v2. forms maestros FUNCIONALES
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsABC

Public Class mstCatedras
<<<<<<< HEAD
=======


#Region "variables"
    Dim iId As String
    Dim VectorTxt(4) As TextBox

#End Region

    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = txtNombre
        VectorTxt(1) = txtDescripcion
        VectorTxt(2) = txtCodigo

        VectorTxt(3) = New TextBox
        VectorTxt(3).Tag = "id_catedra" ''nombre bd
        If incluirID Then
            VectorTxt(3).Text = Guid.NewGuid.ToString
        Else
            VectorTxt(3).Text = iId
        End If

        VectorTxt(4) = New TextBox
        VectorTxt(4).Tag = "pensum_id_pensum"
        VectorTxt(4).Text = cbxPensum.SelectedValue()

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub gbIngresoDatos_Enter(sender As Object, e As EventArgs) Handles gbIngresoDatos.Enter

    End Sub

>>>>>>> v2. forms maestros FUNCIONALES
    Private Sub mstCatedras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DsComboSucursal As DataSet = ExecuteQuery("select id_catedra as id, nombre from catedra")
        FillComboBox(cbxPensum, DsComboSucursal, "id", "nombre")
        FillDataGridView(dgvCatedras, ExecuteQuery("Select * from catedra"))
    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click
        LlenarTextBox(True)
        Dim sError As String = SaveData("catedra", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvCatedras, ExecuteQuery("Select * from catedra"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("catedra", "id_catedra = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvCatedras, ExecuteQuery("Select * from catedra"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("catedra", VectorTxt, "id_catedra = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvCatedras, ExecuteQuery("Select * from catedra"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub dgvCatedras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatedras.CellContentClick

    End Sub

    Private Sub dgvCatedras_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCatedras.SelectionChanged
        iId = GetItem(dgvCatedras, "id_catedra")
        txtNombre.Text = GetItem(dgvCatedras, "nombre")
        txtDescripcion.Text = GetItem(dgvCatedras, "descripcion")
        txtCodigo.Text = GetItem(dgvCatedras, "codigo")
        cbxPensum.SelectedValue = GetItem(dgvCatedras, "pensum_id_pensum")
    End Sub
End Class