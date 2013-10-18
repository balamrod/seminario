Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class mstAlumno
#Region "variables"
    Dim VectorTxt(9) As TextBox
    Dim sActualizarGrid As String = "select id_carrera as 'código', c.nombre, descripcion, s.nombre as sucursal , c.acuerdo, c.fecha_acuerdo as 'fecha acuerdo', sucursal_id_sucursal from carrera c inner join sucursal s on c.sucursal_id_sucursal = s.id_sucursal order by sucursal, c.nombre"

    Dim iId As String
#End Region

    Private Sub LlenarTextBox()
        VectorTxt(0) = txtNombres
        VectorTxt(1) = txtApellidos
        VectorTxt(2) = txtSexo
        VectorTxt(3) = txtFechaNacimiento
        VectorTxt(3).Text = FormatearFechaMysql(txtFechaNacimiento.Text)
        VectorTxt(4) = TxtCorreo
        VectorTxt(5) = txtDpi
        VectorTxt(6) = txtTelefono
        VectorTxt(7) = txtCelular
        VectorTxt(8) = txtColegioEgresado
        VectorTxt(9) = txtCarreraEgresado


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click
        LlenarTextBox()
        Dim sError As String = SaveData("alumno", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvAlumno, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub mstAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillDataGridView(dgvAlumno, ExecuteQuery(sActualizarGrid))
        LimpiarTxtBox(Me)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("alumno", "id_alumno = " & iId)
        If (sError = "") Then
            FillDataGridView(dgvAlumno, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub dgvAlumno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlumno.CellContentClick

    End Sub

    Private Sub dgvAlumno_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAlumno.SelectionChanged
        iId = GetItem(dgvAlumno, "Nombres")

        ''txtCodigo.Text = iId
        txtNombres.Text = GetItem(dgvAlumno, "nombres")
        txtApellidos.Text = GetItem(dgvAlumno, "apellidos")
        txtSexo.Text = GetItem(dgvAlumno, "sexo")
        txtFechaNacimiento.Text = GetItem(dgvAlumno, "fecha_nac")
        TxtCorreo.Text = GetItem(dgvAlumno, "correo")
        txtDpi.Text = GetItem(dgvAlumno, "dpi")
        txtTelefono.Text = GetItem(dgvAlumno, "telefono")
        txtCelular.Text = GetItem(dgvAlumno, "celular")
        txtColegioEgresado.Text = GetItem(dgvAlumno, "colegio_egresado")
        txtCarreraEgresado.Text = GetItem(dgvAlumno, "carrera_egresado")


    End Sub
End Class