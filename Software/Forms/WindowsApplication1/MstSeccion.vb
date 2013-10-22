Imports WindowsApplication1.clsGlobales
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsABC
Public Class MstSeccion

#Region "variables"
    Dim iId As String
    Dim VectorTxt(5) As TextBox
#End Region

    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = txtNombre
        VectorTxt(1) = txtAnio
        VectorTxt(2) = txtCicloAnual

        VectorTxt(3) = New TextBox
        VectorTxt(3).Tag = "id_seccion" ''nombre bd
        If incluirID Then
            VectorTxt(3).Text = Guid.NewGuid.ToString
        Else
            VectorTxt(3).Text = iId
        End If

        VectorTxt(4) = New TextBox
        VectorTxt(4).Tag = "catedra_id_catedra"
        VectorTxt(4).Text = cbxCatedra.SelectedValue()

        VectorTxt(5) = New TextBox
        VectorTxt(5).Tag = "ciclo_id_ciclo"
        VectorTxt(5).Text = cbxCiclo.SelectedValue()
     


    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        LlenarTextBox(True)
        Dim sError As String = SaveData("seccion", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvSeccion, ExecuteQuery("Select * from seccion"))
            LimpiarTxtBox(Me)
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("seccion", "id_seccion = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvSeccion, ExecuteQuery("Select * from seccion"))
            LimpiarTxtBox(Me)
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("seccion", VectorTxt, "id_seccion = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvSeccion, ExecuteQuery("Select * from seccion"))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub MstSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DsComboSucursal As DataSet = ExecuteQuery("select id_catedra as id, nombre from catedra")
        FillComboBox(cbxCatedra, DsComboSucursal, "id", "nombre")

        Dim DsComboSucursal1 As DataSet = ExecuteQuery("select id_ciclo as id, nombre from ciclo")
        FillComboBox(cbxCiclo, DsComboSucursal1, "id", "nombre")


        FillDataGridView(dgvSeccion, ExecuteQuery("Select * from seccion"))
    End Sub

    Private Sub dgvSeccion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSeccion.CellContentClick

    End Sub

    Private Sub dgvSeccion_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSeccion.SelectionChanged
        iId = GetItem(dgvSeccion, "id_seccion")
        txtNombre.Text = GetItem(dgvSeccion, "nombre")
        txtAnio.Text = GetItem(dgvSeccion, "anio")
        txtCicloAnual.Text = GetItem(dgvSeccion, "ciclo_anual")
        cbxCatedra.SelectedValue = GetItem(dgvSeccion, "catedra_id_catedra")
        cbxCiclo.SelectedValue = GetItem(dgvSeccion, "ciclo_id_ciclo")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCatedra.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtCicloAnual.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAnio.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub gbIngresoDatos_Enter(sender As Object, e As EventArgs) Handles gbIngresoDatos.Enter

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class