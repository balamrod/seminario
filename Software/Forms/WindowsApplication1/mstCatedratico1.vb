Imports WindowsApplication1.clsGlobales
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsABC

Public Class mstCatedratico1
#Region "variables"
    Dim iId As String
    Dim VectorTxt(10) As TextBox
    Dim sActualizarGrid As String = "select e.id_empleado, e.tipo_empleado_id_tipo_emp, e.nombres as 'Nombres', e.apellidos as 'Apellidos', e.no_cedula as 'Cedula', e.direccion as 'Direccion', e.celular as 'Celular', e.telefono_casa as 'Telefono', e.correo as 'Email', te.nombre as 'Tipo Empleado', fecha_ingreso as 'Fecha Ingreso', fecha_egreso as 'Fecha Egreso' from  empleado as e inner join tipo_empleado as te on te.id_tipo_emp=e.tipo_empleado_id_tipo_emp "
#End Region

    Private Sub LlenarTextBox(incluirID As Boolean)
        VectorTxt(0) = txtNombre
        VectorTxt(1) = txtApellido
        VectorTxt(2) = txtDireccion
        VectorTxt(3) = txtCelular
        VectorTxt(4) = txtTelefono
        VectorTxt(5) = txtCedula
        VectorTxt(6) = txtFechaIngreso
        VectorTxt(6).Text = FormatearFechaMysql(txtFechaIngreso.Text)
        VectorTxt(7) = txtFechaEgreso
        VectorTxt(7).Text = FormatearFechaMysql(txtFechaEgreso.Text)
        VectorTxt(10) = txtCorreo


        VectorTxt(8) = New TextBox
        VectorTxt(8).Tag = "id_empleado" ''nombre bd
        If incluirID Then
            VectorTxt(8).Text = Guid.NewGuid.ToString
        Else
            VectorTxt(8).Text = iId
        End If
        VectorTxt(9) = New TextBox
        VectorTxt(9).Tag = "tipo_empleado_id_tipo_emp"
        VectorTxt(9).Text = cbxEmpleado.SelectedValue()
    End Sub
    Private Sub dgvEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellContentClick

    End Sub
    Sub tip()
        ToolTip1.SetToolTip(btnAniadir, "GUARDAR")
        ToolTip2.SetToolTip(btnEliminar, "ELIMINAR")
        ToolTip3.SetToolTip(btnModificar, "MODIFICAR")
        ToolTip4.SetToolTip(btnLimpiar, "LIMPIAR")
    End Sub
    Private Sub mstCatedratico1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DsComboSucursal As DataSet = ExecuteQuery("select id_tipo_emp as id, nombre from tipo_empleado")
        FillComboBox(cbxEmpleado, DsComboSucursal, "id", "nombre")
        tip()
        FillDataGridView(dgvEmpleado, ExecuteQuery(sActualizarGrid))
        dgvEmpleado.Columns("Id_empleado").Visible = False
        dgvEmpleado.Columns("tipo_empleado_id_tipo_emp").Visible = False
        LimpiarTxtBox(Me)
    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click
        LlenarTextBox(True)
        Dim sError As String = SaveData("empleado", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvEmpleado, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("empleado", "id_empleado = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvEmpleado, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("empleado", VectorTxt, "id_empleado = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvEmpleado, ExecuteQuery(sActualizarGrid))

            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub dgvEmpleado_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmpleado.SelectionChanged
        iId = GetItem(dgvEmpleado, "id_empleado")
        txtNombre.Text = GetItem(dgvEmpleado, "Nombres")
        txtApellido.Text = GetItem(dgvEmpleado, "Apellidos")
        txtDireccion.Text = GetItem(dgvEmpleado, "Direccion")
        txtCelular.Text = GetItem(dgvEmpleado, "Celular")
        txtTelefono.Text = GetItem(dgvEmpleado, "Telefono")
        txtCedula.Text = GetItem(dgvEmpleado, "Cedula")
        txtFechaIngreso.Text = GetItem(dgvEmpleado, "Fecha Ingreso")
        txtFechaEgreso.Text = GetItem(dgvEmpleado, "Fecha Egreso")
        txtCorreo.Text = GetItem(dgvEmpleado, "Email")
        cbxEmpleado.SelectedValue = GetItem(dgvEmpleado, "tipo_empleado_id_tipo_emp")


    End Sub
End Class