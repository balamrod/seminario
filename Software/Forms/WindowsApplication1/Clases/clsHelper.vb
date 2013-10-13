Imports System.Windows.Forms
''' <summary>
''' Soluciones Analíticas Empresariales S.A. 
''' Contiene Clases Generales
''' </summary>
''' <remarks></remarks>
Public Class clsHelper
#Region "Funcionalidades"
    ''' <summary>
    ''' Llena un ComboBox con un DataSet
    ''' </summary>
    Public Shared Sub FillComboBox(ByRef objCbx As System.Windows.Forms.ComboBox, ByVal dsData As DataSet, ByVal sID As String, ByVal sCampo As String)
        Try
            objCbx.DataSource = dsData.Tables(0).DefaultView
            objCbx.ValueMember = sID
            objCbx.DisplayMember = sCampo
        Catch ex As Exception
            MessageBox.Show("No se pudo cargar la lista, inténtalo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>  
    ''' Verifica si el valor es un punto decimal
    ''' </summary>   
    Public Shared Function IsDouble(ByVal sValor As String) As Boolean
        Try
            Convert.ToDouble(sValor)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary> 
    ''' Verifica si el valor es un entero
    ''' </summary>   
    Public Shared Function IsInteger(ByVal sValor As String) As Boolean
        Try
            Convert.ToInt32(sValor)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Llena un DataGridView con un DataSet.
    ''' </summary>   
    Public Shared Sub FillDataGridView(ByRef objDgv As System.Windows.Forms.DataGridView, ByVal dsData As DataSet)
        Try
            objDgv.DataSource = dsData.Tables(0)
            objDgv.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("No se pudo cargar la vista, inténtalo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>  
    ''' Obtiene el número de filas que contiene un DataSet
    ''' </summary>    
    Public Shared Function GetCanRows(ByVal dsData As DataSet)
        Dim iFilas As Integer
        Try
            iFilas = dsData.Tables(0).Rows.Count
        Catch ex As Exception
            iFilas = 0
        End Try
        Return iFilas
    End Function

    ''' <summary>  
    ''' Obtiene el número de columnas que contiene un DataSet
    ''' </summary>   
    Public Shared Function GetCanColumns(ByVal dsData As DataSet) As Integer
        Dim iColumnas As Integer
        Try
            iColumnas = dsData.Tables(0).Columns.Count
        Catch ex As Exception
            iColumnas = 0
        End Try
        Return iColumnas
    End Function
    ''' <summary>  
    ''' Obtiene un Item de una columna seleccionada de un DataSet
    ''' </summary>    
    Public Shared Function GetItem(ByVal dsData As DataSet, ByVal sNombreColumna As String) As String
        Dim sDato As String
        Dim iColumna As Integer
        Try
            iColumna = dsData.Tables(0).Columns(sNombreColumna).Ordinal
            sDato = dsData.Tables(0).Rows(0).ItemArray(iColumna).ToString()
        Catch ex As Exception
            sDato = ""
        End Try
        Return sDato
    End Function
    ''' <summary> 
    ''' Obtiene un Item de una columna y una fila seleccionada de un DataSet
    ''' </summary> 
    Public Shared Function GetItem(ByVal dsData As DataSet, ByVal sNombreColumna As String, ByVal iFila As Integer) As String
        Dim sDato As String
        Dim iColumna As Integer
        Try
            iColumna = dsData.Tables(0).Columns(sNombreColumna).Ordinal
            sDato = dsData.Tables(0).Rows(iFila).ItemArray(iColumna).ToString()
        Catch ex As Exception
            sDato = ""
        End Try
        Return sDato
    End Function

    ''' <summary> 
    ''' Obtiene un Item de una columna y una fila seleccionada de un Gridview
    ''' </summary> 
    Public Shared Function GetItem(ByVal gridView As DataGridView, ByVal e As DataGridViewCellEventArgs, ByVal columna As String) As String
        Dim sDato As String
        Try
            sDato = gridView.Rows(e.RowIndex).Cells(columna).Value.ToString
        Catch ex As Exception
            sDato = ""
        End Try
        Return sDato
    End Function

    ''' <summary> 
    ''' Obtiene un Item de una columna y una fila seleccionada de un Gridview
    ''' </summary> 
    Public Shared Function GetItem(ByVal gridView As DataGridView, ByVal columna As String) As String
        Dim sDato As String
        Try
            sDato = gridView.Rows(gridView.CurrentRow.Index).Cells(columna).Value.ToString
        Catch ex As Exception
            sDato = ""
        End Try
        Return sDato
    End Function

    ''' <summary> 
    ''' Convierte la fecha a formato aceptado por MYsql
    ''' </summary> 
    Public Shared Function FormatearFechaMysql(ByVal sFecha As String) As Object
        Try
            If sFecha <> "" Then
                sFecha = Convert.ToDateTime(sFecha).Year & "/" & Convert.ToDateTime(sFecha).Month & "/" & Convert.ToDateTime(sFecha).Day
            Else
                Return DBNull.Value
            End If
        Catch ex As Exception
            Return DBNull.Value
        End Try
        Return sFecha
    End Function

    ''' <summary> 
    ''' Detecta todos los controles tipo Textbox y les asigna el valor ""
    ''' </summary> 
    Public Shared Sub LimpiarTxtBox(miMismo As Form)
        For Each oControl As Control In miMismo.Controls
            'Si un control del Form resulta ser GroupBox?????????
            If TypeOf oControl Is GroupBox Then
                'Hacemos un chequeo por todos los controles del GroupBox
                For Each subControl As Control In oControl.Controls
                    'Si un control del GroupBox es un TextBox????
                    If TypeOf subControl Is TextBox Then
                        'Entonces borramos su texto
                        subControl.Text = ""
                    End If
                Next
            End If
            'Si un control del Form resulta ser TexBox???????????
            If TypeOf oControl Is TextBox Then
                'Entonces borramos su texto
                oControl.Text = ""
            End If
        Next
    End Sub
#End Region
End Class
