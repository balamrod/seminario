Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class TrsAsignacion
#Region "variables"
    Dim sActualizarGrid As String = "select c.codigo, c.nombre as catedra, cic.nombre as ciclo from  catedra c inner join pensum p on c.pensum_id_pensum = p.id_pensum 	inner join carrera car on car.id_carrera = p.carrera_id_carrera 	inner join detalle_catedra dc on dc.catedra_id_catedra = c.id_catedra 	inner join ciclo cic on cic.id_ciclo = dc.ciclo_id_ciclo 	inner join alumno a on a.id_carrera = car.id_carrera  order by cic.nombre, c.codigo, c.nombre"
    Private MiDataSet As New DataSet()
    Private MiEnlazador As New BindingSource
#End Region

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        FillDataGridView(dgvCursosDisponibles, ExecuteQuery(sActualizarGrid))

        Me.dgvCursosPorAsignar.ColumnCount = Me.dgvCursosDisponibles.ColumnCount
        For x = 0 To (Me.dgvCursosDisponibles.ColumnCount - 1)
            Me.dgvCursosPorAsignar.Columns(x).Name = Me.dgvCursosDisponibles.Columns(x).Name
            Me.dgvCursosPorAsignar.Columns(x).HeaderText = Me.dgvCursosDisponibles.Columns(x).HeaderText
        Next
    End Sub

    Private Sub btnCopiarAsignacion_Click(sender As Object, e As EventArgs) Handles btnCopiarAsignacion.Click
        MoverSeleccionadosDGV1aDGV2()
    End Sub
    

    Private Sub MoverSeleccionadosDGV1aDGV2()
        'Para cada fila seleccionada
        For Each Seleccion As DataGridViewRow In dgvCursosDisponibles.SelectedRows
            'Añadir los valores obtenidos de la fila seleccionada
            'al segundo datagridview
            Me.dgvCursosPorAsignar.Rows.Add(ObtenerValoresFila(Seleccion))
            'eliminar la fila del DataGridView origen
            dgvCursosDisponibles.Rows.Remove(Seleccion)
        Next
    End Sub

    Private Function ObtenerValoresFila(ByVal fila As DataGridViewRow) As String()
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(Me.dgvCursosPorAsignar.ColumnCount - 1) As String
        'Rellenar el contenido con el valor de las celdas de la fila
        For Ndx = 0 To (Contenido.Length - 1)
            Contenido(Ndx) = fila.Cells(Ndx).Value
        Next
        Return Contenido
    End Function

End Class