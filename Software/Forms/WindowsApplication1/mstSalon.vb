Imports WindowsApplication1.clsGlobales
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsABC

Public Class mstSalon

#Region "variables"
    Dim iId As String
    Dim VectorTxt(3) As TextBox
    Dim ActualizarGrid As String = "select id_salon as 'Id Salon', nombre as 'Nombre', capacidad as 'Capacidad', observacion as 'Observacion' from salon"
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
    Sub tip()
        ToolTip1.SetToolTip(btnAniadir, "GUARDAR")
        ToolTip2.SetToolTip(btnEliminar, "BORRAR")
        ToolTip3.SetToolTip(btnModificar, "MODIFICAR")
        ToolTip4.SetToolTip(btnLimpiar, "LIMPIAR")

    End Sub

    Private Sub mstSalon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tip()
        FillDataGridView(dgvSalon, ExecuteQuery(ActualizarGrid))
        dgvSalon.Columns("Id Salon").Visible = False
        LimpiarTxtBox(Me)
    End Sub

    Private Sub btnAniadir_Click(sender As Object, e As EventArgs) Handles btnAniadir.Click
        LlenarTextBox(True)
        Dim sError As String = SaveData("salon", VectorTxt)
        If (sError = "") Then
            FillDataGridView(dgvSalon, ExecuteQuery(ActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim sError As String = DeleteData("salon", "id_salon = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvSalon, ExecuteQuery(ActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        LlenarTextBox(False)
        Dim sError As String = UpdateData("salon", VectorTxt, "id_salon = '" & iId & "'")
        If (sError = "") Then
            FillDataGridView(dgvSalon, ExecuteQuery(ActualizarGrid))
            LimpiarTxtBox(Me)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTxtBox(Me)
    End Sub

    Private Sub dgvSalon_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSalon.SelectionChanged
        iId = GetItem(dgvSalon, "Id Salon")
        txtNombre.Text = GetItem(dgvSalon, "Nombre")
        txtDescripcion.Text = GetItem(dgvSalon, "Observacion")
        txtCantidad.Text = GetItem(dgvSalon, "Capacidad") ''nombre de la bd
       
    End Sub

End Class