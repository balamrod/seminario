Imports WindowsApplication1.clsABC
Imports WindowsApplication1.clsHelperSQL
Imports WindowsApplication1.clsHelper
Imports WindowsApplication1.clsGlobales

Public Class TrsAsignacion
#Region "variables"
    Dim inscripcion As String = "e2d700c8-23cb-4bb3-9902-6e19d538d8fe"
#End Region

    Private Sub FillComboBox(ByRef objCbx As DataGridViewComboBoxCell, ByVal dsData As DataSet, ByVal sID As String, ByVal sCampo As String)
        Try
            objCbx.DataSource = dsData.Tables(0).DefaultView
            objCbx.ValueMember = sID
            objCbx.DisplayMember = sCampo
            objCbx.Value = dsData.Tables(0).DefaultView
        Catch ex As Exception

        End Try
    End Sub

    Private Sub actualizarCombosColumnas(grid As DataGridView)
        
        Dim cell As DataGridViewComboBoxCell


        For Each row As DataGridViewRow In grid.Rows
            cell = row.Cells("seccion")
            cell.Items.AddRange({"fsdf", "sdfds", "sdfsd"})
           
            Dim DsComboSucursal As DataSet = ExecuteQuery("select id_sucursal as id, nombre from sucursal")
            FillComboBox(cell, DsComboSucursal, "id", "nombre")
        Next
    End Sub

    Private Sub contruirGrid()
        Dim ActualizarGrid As String = "select se.catedra_id_catedra,se.ciclo_id_ciclo, cat.codigo,cat.nombre from catedra cat " +
                                        "	inner join seccion se on se.catedra_id_catedra = cat.id_catedra " +
                                        "	inner join detalle_seccion ds on ds.seccion_id_seccion = se.id_seccion " +
                                        "	inner join inscripcion ins on ins.ciclo_escolar = se.ciclo_anual " +
                                        "	inner join ciclo cic on cic.id_ciclo = se.ciclo_id_ciclo	 " +
                                        "where ins.id_inscripcion = '" + inscripcion +
                                      "' and se.anio = year(ins.fecha) " +
                                        "and cic.nombre = '8vo.' " +
                                        "group by se.catedra_id_catedra,se.ciclo_id_ciclo, cat.codigo,cat.nombre " +
                                        "order by anio, ciclo_anual "

        FillDataGridView(dgv1, ExecuteQuery(ActualizarGrid))
        dgv1.Columns("ciclo_id_ciclo").Visible = False
        dgv1.Columns("catedra_id_catedra").Visible = False

      
        Dim CboCiudadesColumn As New DataGridViewComboBoxColumn()
        CboCiudadesColumn.Name = "Seccion"
        CboCiudadesColumn.DataPropertyName = "f_Desc"
        dgv1.Columns.Add(CboCiudadesColumn)


        actualizarCombosColumnas(dgv1)
    End Sub

    Private Sub TrsAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contruirGrid()

    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        If e.ColumnIndex = 0 Then
            If Not dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
            Else
                dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim array(5) As String
        Dim pcount As Integer = 0
      

        For Each row As DataGridViewRow In dgv1.Rows
            Dim cb As DataGridViewCheckBoxCell = CType(row.Cells(0), DataGridViewCheckBoxCell)
            If cb.Value = True Then
                array(pcount) = row.Cells("id_asignacion_catedratico").Value
                pcount += 1
            End If
        Next

        MessageBox.Show("seleccionados: " + pcount.ToString() + " --- " + array(0))
    End Sub

  
    Private Sub dgv1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellEnter


       
    End Sub
End Class