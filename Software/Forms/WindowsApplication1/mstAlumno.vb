Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class mstAlumno
#Region "variables"
    Dim VectorTxt(13) As TextBox
    Dim sActualizarGrid As String = "select anio_carnet as 'Anio Carnet', correlativo_carnet as 'Correlativo Carnet', id_carrera as 'Id Carrera', direccion as 'Direccion', sexo as 'Sexo', nombres as 'Nombres', apellidos as 'Apellidos', correo as 'Email', telefono_casa as 'Telefono', celular as 'Celular', fecha_nac as 'Fecha Nacimiento', dpi as 'DPI', colegio_egresado as 'Colegio Egresado', carrera_egresado as 'Carrera Egresado', usuario_id_usuario as 'Id Usuario' from alumno"

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

        tip()

        FillDataGridView(dgvAlumno, ExecuteQuery(sActualizarGrid))
        dgvAlumno.Columns("Id Carrera").Visible = False
        dgvAlumno.Columns("Id Usuario").Visible = False
        LimpiarTxtBox(Me)
    End Sub
    Sub tip()
        ToolTip1.SetToolTip(btnAniadir, "GUARDAR")
        ToolTip2.SetToolTip(btnEliminar, "ELIMINAR")
        ToolTip3.SetToolTip(btnModificar, "MODIFICAR")
        ToolTip4.SetToolTip(btnLimpiar, "LIMPIAR")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("alumno", "id_carrera = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvAlumno, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub dgvAlumno_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAlumno.SelectionChanged
        iId = GetItem(dgvAlumno, "Id_carrera")
        txtNombres.Text = GetItem(dgvAlumno, "Nombres")
        txtApellidos.Text = GetItem(dgvAlumno, "Apellidos")
        txtSexo.Text = GetItem(dgvAlumno, "Sexo")
        txtFechaNacimiento.Text = GetItem(dgvAlumno, "Fecha Nacimiento")
        TxtCorreo.Text = GetItem(dgvAlumno, "Email")
        txtDpi.Text = GetItem(dgvAlumno, "DPI")
        txtTelefono.Text = GetItem(dgvAlumno, "Telefono")
        txtCelular.Text = GetItem(dgvAlumno, "Celular")
        txtDireccion.Text = GetItem(dgvAlumno, "Direccion")
        txtAnio.Text = GetItem(dgvAlumno, "Anio Carnet")
        txtCorrelativo.Text = GetItem(dgvAlumno, "Correlativo Carnet")
        txtColegioEgresado.Text = GetItem(dgvAlumno, "Colegio Egresado")
        txtCarreraEgresado.Text = GetItem(dgvAlumno, "Carrera Egresado")
        cbxCarrera.SelectedValue = GetItem(dgvAlumno, "Id Carrera")

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("alumno", VectorTxt, "id_carrera = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvAlumno, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub dgvAlumno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlumno.CellContentClick

    End Sub
End Class