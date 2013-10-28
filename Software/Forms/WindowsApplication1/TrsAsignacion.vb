Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class TrsAsignacion
#Region "variables"
    Public inscripcion As String
    Public anio As String

    Dim currentRowIndex As Integer
#End Region

    Private Sub asignar(asignaciones() As String, inscripcion As String)
        Dim sAsignar As String = ""
        Dim sAsigIndividual As String = ""
        Dim sActividad As String = ""

        For Each item As String In asignaciones
            If item <> "" Then
                sAsigIndividual = "insert into asignacion() values ('" + FormatearFechaMysql(Now) + "','" + item + "','" + inscripcion + "');"
                sActividad = sActividad + "insert into actividad() values ('" + Guid.NewGuid.ToString + "','','','C7ED6B4A-380D-44A5-9972-7329EAE3AD24','" + item + "','" + inscripcion + "');" +
                                          "insert into actividad() values ('" + Guid.NewGuid.ToString + "','','','DF77F9F8-51AF-43A0-83B0-AE171BC68137','" + item + "','" + inscripcion + "');" +
                                          "insert into actividad() values ('" + Guid.NewGuid.ToString + "','','','480FAD54-D66A-46BF-B677-24386135AB9B','" + item + "','" + inscripcion + "');" +
                                          "insert into actividad() values ('" + Guid.NewGuid.ToString + "','','','883AB84B-F7DF-4CC9-BE9B-B291C5039F97','" + item + "','" + inscripcion + "');"
                sAsignar = sAsignar + sAsigIndividual
            End If
        Next

        Try
            Dim sFinal As String = sAsignar + sActividad
            ExecuteQuery(sFinal)
            MessageBox.Show("Asignación completada satisfactoriamente")
        Catch ex As Exception
            MessageBox.Show("Intentelo mas tarde")
        End Try

    End Sub

    Public Function ObtenerSecciones(row As DataGridViewRow) As String
        Return "select  ds.id_asignacion_catedratico, sec.nombre from seccion sec inner join detalle_seccion ds " +
                "	on sec.id_seccion = ds.seccion_id_seccion " +
                "	where sec.catedra_id_catedra = '" + row.Cells("catedra_id_catedra").Value.ToString() +
                "'  and sec.ciclo_id_ciclo = '" + row.Cells("ciclo_id_ciclo").Value.ToString() +
                "'	and sec.anio = '" + anio + "' " +
                "	and sec.ciclo_anual = '2' order by sec.nombre"
    End Function

    Private Sub actualizarCombosColumnas(grid As DataGridView)

        Dim cell As DataGridViewComboBoxCell


        For Each row As DataGridViewRow In grid.Rows
            cell = row.Cells(6)

            Dim sObtenerSecciones As String = ObtenerSecciones(row)
            Dim dt As DataTable = ExecuteQueryDt(sObtenerSecciones)
            cell.DataSource = dt
            cell.ValueMember = "id_asignacion_catedratico"
            cell.DisplayMember = "nombre"
            cell.Value = dt.Rows(0).Item(0).ToString()

            ' cell.Value = "4BF997A9-3F87-4C3E-A7FE-E8878DBFE15D"

            Dim sObtenerHorario As String = "select concat(hora_inicial, ' - ',hora_final) as horario from horario h inner join  detalle_seccion ds " +
                                      "	on ds.horario_id_horario = h.id_horario " +
                                      "where ds.id_asignacion_catedratico = '" + dt.Rows(0).Item(0).ToString() + "' "

            Dim dc As DataSet = ExecuteQuery(sObtenerHorario)

            Dim testing As DataGridViewTextBoxCell = row.Cells("horario")
            testing.Value = GetItem(dc, "horario")
        Next
    End Sub

    Private Function CreateComboBoxColumn() _
       As DataGridViewComboBoxColumn
        Dim column As New DataGridViewComboBoxColumn()

        With column
            .DataPropertyName = "id_seccion"
            .HeaderText = ""
            .DropDownWidth = 160
            .Width = 90
            .FlatStyle = FlatStyle.Flat
            .AutoComplete = True
        End With
        Return column
    End Function

    Private Sub AddComboBoxColumns(dgv As DataGridView)

        Dim comboboxColumn As DataGridViewComboBoxColumn
        comboboxColumn = CreateComboBoxColumn()
        SetAlternateChoicesUsingDataSource(comboboxColumn)
        comboboxColumn.HeaderText = "Seccion"
        dgv.Columns.Add(comboboxColumn)
    End Sub

    Private Sub contruirGrid(dgv As DataGridView, ciclo As String)
        Dim ActualizarGrid As String = "select se.catedra_id_catedra,se.ciclo_id_ciclo, cat.codigo,cat.nombre, 'ZZZZZZZZZZZZZZZZ' as Horario from catedra cat " +
                                        "	inner join seccion se on se.catedra_id_catedra = cat.id_catedra " +
                                        "	inner join detalle_seccion ds on ds.seccion_id_seccion = se.id_seccion " +
                                        "	inner join inscripcion ins on ins.ciclo_escolar = se.ciclo_anual " +
                                        "	inner join ciclo cic on cic.id_ciclo = se.ciclo_id_ciclo	 " +
                                        "where se.anio = year(ins.fecha) " +
                                        "and cic.nombre = '" + ciclo + "' " +
                                        "and ins.id_inscripcion = '" + inscripcion +
                                        "' group by se.catedra_id_catedra,se.ciclo_id_ciclo, cat.codigo,cat.nombre "

        ' dgv1.VirtualMode = True no me dejaba colocar un valor en el combo dentro del grid
        ' dgv1.TopLeftHeaderCell.Value = "seccion"  coloca nombre ala primera columna del grid (columna para seleccionar)

        dgv.DataSource = ExecuteQueryDt(ActualizarGrid)
        dgv.EditMode = DataGridViewEditMode.EditOnEnter
        dgv.AutoResizeColumns()

        dgv.Columns("ciclo_id_ciclo").Visible = False
        dgv.Columns("catedra_id_catedra").Visible = False
        dgv.RowHeadersVisible = False  'no muestra la columna para seleccionar.
        AddComboBoxColumns(dgv)
        actualizarCombosColumnas(dgv)
    End Sub

    Private Sub obtenerDatosAlumno()
        Dim sObtenerDatosAlumno As String = "select  concat(a.id_carrera,'-', a.anio_carnet,'-', a.correlativo_carnet) as carnet , concat (nombres, ' ', apellidos) as nombre " +
                            "from inscripcion ins inner join  alumno a " +
                                 "on ins.numero_carnet = a.correlativo_carnet " +
                                 "and ins.id_carrera = a.id_carrera " +
                                 "and ins.anio_carnet = a.anio_carnet " +
                           "where ins.id_inscripcion = '" + inscripcion + "'"

        Dim dsDatos As DataSet = ExecuteQuery(sObtenerDatosAlumno)
        txtCarrera.Text = GetItem(dsDatos, "carnet")
        txtAlumno.Text = GetItem(dsDatos, "nombre")
    End Sub

    Private Sub TrsAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatosAlumno()

        contruirGrid(dgv1, "2do.")
        contruirGrid(dgv2, "4to.")
        contruirGrid(dgv3, "6to.")
        contruirGrid(dgv4, "8vo.")
        contruirGrid(dgv5, "10mo.")
    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick, dgv3.CellClick, dgv2.CellClick, dgv4.CellClick, dgv5.CellClick
        currentRowIndex = e.RowIndex
        'MessageBox.Show("le dista a: " + e.ColumnIndex.ToString)
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim array(5) As String
        Dim pcount As Integer = 0


        For Each grid As Control In gbCursos.Controls
            If TypeOf grid Is DataGridView Then

                Dim newGrid As DataGridView = grid
                For Each row As DataGridViewRow In newGrid.Rows
                    Dim cb As DataGridViewCheckBoxCell = CType(row.Cells(0), DataGridViewCheckBoxCell)
                    If cb.Value = True Then
                        array(pcount) = row.Cells(6).Value
                        pcount += 1
                    End If
                Next
            End If

        Next

        If pcount <> 0 And pcount < 7 Then
            asignar(array, inscripcion)
        ElseIf pcount = 0 Then
            MessageBox.Show("Debe al menos seleccionar un curso")
        ElseIf pcount > 6 Then
            MessageBox.Show("Solo puede asignarse 6 cursos")
        End If

    End Sub

    Private Sub dgv1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv1.CurrentCellDirtyStateChanged, dgv2.CurrentCellDirtyStateChanged, dgv3.CurrentCellDirtyStateChanged, dgv4.CurrentCellDirtyStateChanged, dgv5.CurrentCellDirtyStateChanged
        Dim grv As DataGridView = sender

        If grv.IsCurrentCellDirty Then
            grv.CommitEdit(DataGridViewDataErrorContexts.Commit)
            Dim sObtenerHorario As String = "select concat(hora_inicial, ' - ',hora_final) as horario from horario h inner join  detalle_seccion ds " +
                                      "	on ds.horario_id_horario = h.id_horario " +
                                      "where ds.id_asignacion_catedratico = '" + grv.Rows(currentRowIndex).Cells(6).Value + "' "

            Dim dc As DataSet = ExecuteQuery(sObtenerHorario)
            Dim cell As DataGridViewTextBoxCell = grv.Rows(currentRowIndex).Cells("horario")
            cell.Value = GetItem(dc, "horario")
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick, dgv2.CellContentClick, dgv3.CellContentClick, dgv4.CellContentClick, dgv5.CellContentClick
        Dim grv As DataGridView = sender

        If e.ColumnIndex = 0 Then
            If Not grv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                grv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
            Else
                grv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
            End If
        End If
    End Sub

    Public Sub SetAlternateChoicesUsingDataSource(ByVal comboboxColumn As DataGridViewComboBoxColumn)
        With comboboxColumn
            .DataSource = ExecuteQueryDt("select id_seccion, nombre from seccion")
            .ValueMember = "id_seccion"
            .DisplayMember = "nombre"
        End With
    End Sub

    Private Shared Sub SetAlternateChoicesUsingItems(ByVal comboboxColumn As DataGridViewComboBoxColumn)

        comboboxColumn.Items.AddRange("Central", "a", "b")

    End Sub

End Class