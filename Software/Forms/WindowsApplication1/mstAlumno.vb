Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class mstAlumno
#Region "variables"
    Dim VectorTxt(13) As TextBox
    Dim sActualizarGrid As String = "select * from alumno"
    Dim iId As String
#End Region

    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = txtNombres
        VectorTxt(1) = txtApellidos
        VectorTxt(2) = txtSexo

        VectorTxt(3) = txtFechaNacimiento
        VectorTxt(3).Text = FormatearFechaMysql(txtFechaNacimiento.Text)

        VectorTxt(4) = TxtCorreo
        VectorTxt(5) = txtDpi
        VectorTxt(6) = txtTelefono
        VectorTxt(7) = txtCelular
        VectorTxt(8) = txtAnio
        VectorTxt(9) = txtCorrelativo
        VectorTxt(10) = txtColegioEgresado
        VectorTxt(11) = txtCarreraEgresado
        VectorTxt(12) = New TextBox
        VectorTxt(12).Tag = "id_carrera"
        VectorTxt(12).Text = cbxCarrera.SelectedValue()
        VectorTxt(13) = txtDireccion

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click
        LlenarTextBox(True)
        Dim sError As String = SaveData("alumno", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvAlumno, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub mstAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DsComboSucursal As DataSet = ExecuteQuery("select id_carrera as id, nombre from carrera")
        FillComboBox(cbxCarrera, DsComboSucursal, "id", "nombre")

        FillDataGridView(dgvAlumno, ExecuteQuery(sActualizarGrid))
        LimpiarTxtBox(Me)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("alumno", "id_carrera = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvAlumno, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub dgvAlumno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlumno.CellContentClick

    End Sub

    Private Sub dgvAlumno_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAlumno.SelectionChanged
        iId = GetItem(dgvAlumno, "id_carrera")
        txtNombres.Text = GetItem(dgvAlumno, "nombres")
        txtApellidos.Text = GetItem(dgvAlumno, "apellidos")
        txtSexo.Text = GetItem(dgvAlumno, "sexo")
        txtFechaNacimiento.Text = GetItem(dgvAlumno, "fecha_nac")
        TxtCorreo.Text = GetItem(dgvAlumno, "correo")
        txtDpi.Text = GetItem(dgvAlumno, "dpi")
        txtTelefono.Text = GetItem(dgvAlumno, "telefono_casa")
        txtCelular.Text = GetItem(dgvAlumno, "celular")
        txtDireccion.Text = GetItem(dgvAlumno, "direccion")
        txtAnio.Text = GetItem(dgvAlumno, "anio_carnet")
        txtCorrelativo.Text = GetItem(dgvAlumno, "correlativo_carnet")
        txtColegioEgresado.Text = GetItem(dgvAlumno, "colegio_egresado")
        txtCarreraEgresado.Text = GetItem(dgvAlumno, "carrera_egresado")
        cbxCarrera.SelectedValue = GetItem(dgvAlumno, "id_carrera")

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("alumno", VectorTxt, "id_carrera = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvAlumno, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub cbxIdCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCarrera.SelectedIndexChanged

    End Sub
End Class