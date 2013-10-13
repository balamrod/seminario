Imports System.Windows.Forms

Public Class Maestro

    Private Sub NuevaInscripciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaInscripciónToolStripMenuItem.Click
        Dim ChildForm As New TrsInscripcion
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub CarreraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarreraToolStripMenuItem.Click
        Dim ChildForm As New MstCarrera
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub PensumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PensumToolStripMenuItem.Click
        Dim ChildForm As New MstPensum
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub AsignaciónAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignaciónAlumnoToolStripMenuItem.Click
        Dim ChildForm As New TrsAsignacion
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub
End Class
