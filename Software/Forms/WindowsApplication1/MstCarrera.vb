Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class MstCarrera

#Region "variables"
    Dim VectorTxt(5) As TextBox
    Dim sActualizarGrid As String = "select id_carrera as 'código', c.nombre, descripcion, s.nombre as sucursal , c.acuerdo, c.fecha_acuerdo as 'fecha acuerdo', sucursal_id_sucursal from carrera c inner join sucursal s on c.sucursal_id_sucursal = s.id_sucursal order by sucursal, c.nombre"

    Dim iId As String
#End Region

    Private Sub LlenarTextBox()
        VectorTxt(0) = txtCodigo
        VectorTxt(1) = txtNombre
        VectorTxt(2) = txtDescripcion
        VectorTxt(3) = txtFechaAcuerdo
        VectorTxt(3).Text = FormatearFechaMysql(txtFechaAcuerdo.Text)
        VectorTxt(4) = txtAcuerdo
        VectorTxt(5) = New TextBox
        VectorTxt(5).Tag = "sucursal_id_sucursal"
        VectorTxt(5).Text = cbSucursal.SelectedValue()

  
    End Sub

    ''' <summary>
    ''' bRodriguez
    ''' 13/10/2013
    ''' Inicializa valores de la forma de Carrera
    ''' </summary>
    Private Sub MstCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DsComboSucursal As DataSet = ExecuteQuery("select id_sucursal as id, nombre from sucursal")
        FillComboBox(cbSucursal, DsComboSucursal, "id", "nombre")

        FillDataGridView(dgvCarrera, ExecuteQuery(sActualizarGrid))
        ''dgvCarrera.Columns("sucursal_id_sucursal").Visible = False


        LimpiarTxtBox(Me)
    End Sub

    ''' <summary>
    ''' bRodriguez
    ''' 13/10/2013
    ''' Ingresa nuevos valores a la tabla carrera
    ''' </summary>
    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click
        LlenarTextBox()
        Dim sError As String = SaveData("carrera", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvCarrera, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    ''' <summary>
    ''' bRodriguez
    ''' 13/10/2013
    ''' elimina valores seleccionados en la forma en la tabla carrera
    ''' </summary>
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("carrera", "id_carrera = " & iId)
        If (sError = "") Then
            FillDataGridView(dgvCarrera, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub


    ''' <summary>
    ''' bRodriguez
    ''' 13/10/2013
    ''' limpia los controles textbox en la forma carrera
    ''' </summary>
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub


    ''' <summary>
    ''' bRodriguez
    ''' 13/10/2013
    ''' Obtiene los valores del dgvCarrera y los muestra en sus respectivos campos en la forma
    ''' </summary>
    Private Sub dgvCarrera_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCarrera.SelectionChanged
        iId = GetItem(dgvCarrera, "código")
        txtCodigo.Text = iId
        txtNombre.Text = GetItem(dgvCarrera, "nombre")
        txtDescripcion.Text = GetItem(dgvCarrera, "descripcion")
        txtFechaAcuerdo.Text = GetItem(dgvCarrera, "fecha acuerdo")
        txtAcuerdo.Text = GetItem(dgvCarrera, "acuerdo")
        cbSucursal.SelectedValue = GetItem(dgvCarrera, "sucursal_id_sucursal")
    End Sub

    ''' <summary>
    ''' bRodriguez
    ''' 13/10/2013
    ''' modifica los valores seleccionados en la forma en la tabla carrera
    ''' </summary>
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox()
        Dim sError As String = UpdateData("carrera", VectorTxt, "id_carrera = " & iId)
        If (sError = "") Then
            FillDataGridView(dgvCarrera, ExecuteQuery(sActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

   
End Class
