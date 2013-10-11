Imports System.Windows.Forms
Imports System.Data
Imports MySql.Data.MySqlClient
Imports WindowsApplication1.Conexion

Public Class General

    Public Shared Function FillDataGridView(ByVal sCadenaConexion As String, ByVal stringTabla As String, ByVal nomTabla As String) As DataView
        Dim dSet As DataSet
        Dim dView As DataView
        Dim cmd As New MySqlCommand(stringTabla, ConectarBD(sCadenaConexion))

        cmd.CommandType = CommandType.Text
        Dim sqlDapter As New MySqlDataAdapter(cmd)

        dSet = New DataSet()

        sqlDapter.Fill(dSet, nomTabla)
        dView = dSet.Tables(nomTabla).DefaultView
        Return dView
    End Function
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

    Public Shared Function GetItem(ByVal dtData As DataTable, ByVal sNombreColumna As String) As String
        Dim sDato As String
        Dim iColumna As Integer
        Try
            iColumna = dtData.Columns(sNombreColumna).Ordinal
            sDato = dtData.Rows(0).ItemArray(iColumna).ToString()
        Catch ex As Exception
            sDato = ""
        End Try
        Return sDato
    End Function

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

    Public Shared Function FormatDate(ByVal objCalendar As MonthCalendar) As String
        Dim sFecha As String
        Try
            'sFecha = objCalendar.SelectedDate.Year.ToString & "/" & objCalendar.SelectedDate.Month.ToString & "/" & objCalendar.SelectedDate.Day.ToString
        Catch ex As Exception
            sFecha = ""
        End Try
        Return sFecha
    End Function

    Public Shared Function FormatDate(ByVal sFecha As String) As Object
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

    Public Shared Function GetCanColumns(ByVal dsData As DataSet) As Integer
        Dim iColumnas As Integer
        Try
            iColumnas = dsData.Tables(0).Columns.Count
        Catch ex As Exception
            iColumnas = 0
        End Try
        Return iColumnas
    End Function

    'Public Shared Sub FillComboBox(ByVal objCbx As ComboBox, ByVal dtData As DataTable, ByVal sID As String, ByVal sCampo As String)
    ' Try
    '     objCbx.DataSource = dtData.DefaultView
    '     objCbx.DataTextField = sCampo
    '       objCbx.DataMember = sID
    'objCbx.DataBind()
    '  Catch ex As Exception
    '
    '   End Try
    ' End Sub

    'Public Shared Sub FillComboBox(ByRef objCbx As ComboBox, ByVal dsData As DataSet, ByVal sID As String, ByVal sCampo As String)
    '    Try
    '        objCbx.DataSource = dsData.Tables(0).DefaultView
    '        objCbx.DataTextField = sCampo
    'objCbx.DataMember = sID
    '       objCbx.DataValueField = sID
    '   Catch ex As Exception
    'MessageBox.Show("No se pudo cargar la lista, inténtalo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    ' End Sub
    Public Shared Function GetCanRows(ByVal dsData As DataSet) As Integer
        Dim iFilas As Integer
        Try
            iFilas = dsData.Tables(0).Rows.Count
        Catch ex As Exception
            iFilas = 0
        End Try
        Return iFilas
    End Function

    Public Shared Function GetCanRows(ByVal dtData As DataTable) As Integer
        Dim iFilas As Integer
        Try
            iFilas = dtData.Rows.Count
        Catch ex As Exception
            iFilas = 0
        End Try
        Return iFilas
    End Function
End Class


