Imports WindowsApplication1.clsGlobales
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsABC

Public Class MstPensum

#Region "variables"
    Dim iId As String
    Dim VectorTxt(3) As TextBox
    Dim sActualizarGrid As String = "select p.id_pensum as 'Id Pensum', p.anio as 'Anio', c.nombre as 'Carrera', p.descripcion as 'Descripcion', p.carrera_id_carrera as 'id Carrera' from pensum as p, carrera as c where c.id_carrera=p.carrera_id_carrera"
#End Region

    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = txtAnio
        VectorTxt(1) = txtDescripcion

        VectorTxt(2) = New TextBox
        VectorTxt(2).Tag = "id_pensum" ''nombre bd
        If incluirID Then
            VectorTxt(2).Text = Guid.NewGuid.ToString
        Else
            VectorTxt(2).Text = iId
        End If

        VectorTxt(3) = New TextBox
        VectorTxt(3).Tag = "carrera_id_carrera"
        VectorTxt(3).Text = cbxCarrera.SelectedValue()

    End Sub
    Sub tip()
        ToolTip1.SetToolTip(btnAgregar, "GUARDAR")
        ToolTip2.SetToolTip(btnEliminar, "ELIMINAR")
        ToolTip3.SetToolTip(btnModificar, "MODIFICAR")
        ToolTip4.SetToolTip(btnLimpiar, "LIMPIAR")
    End Sub

    Private Sub MstPensum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DsComboSucursal As DataSet = ExecuteQuery("select id_carrera as id, nombre from carrera")
        FillComboBox(cbxCarrera, DsComboSucursal, "id", "nombre")

        FillDataGridView(dgvPensum, ExecuteQuery(sActualizarGrid))
        dgvPensum.Columns("Id Pensum").Visible = False
        dgvPensum.Columns("Id Carrera").Visible = False
        tip()
        LimpiarTxtBox(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        LlenarTextBox(True)
        Dim sError As String = SaveData("pensum", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvPensum, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("pensum", "id_pensum = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvPensum, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("pensum", VectorTxt, "id_pensum = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvPensum, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub dgvPensum_SelectionChanged1(sender As Object, e As EventArgs) Handles dgvPensum.SelectionChanged
        iId = GetItem(dgvPensum, "id_pensum")
        txtAnio.Text = GetItem(dgvPensum, "Anio")
        txtDescripcion.Text = GetItem(dgvPensum, "Descripcion")
        cbxCarrera.SelectedValue = GetItem(dgvPensum, "Id Carrera")
    End Sub

End Class