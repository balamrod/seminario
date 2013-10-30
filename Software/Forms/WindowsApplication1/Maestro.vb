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

    Private Sub AlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnoToolStripMenuItem.Click
        Dim ChildForm As New mstAlumno
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub SeccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeccionToolStripMenuItem.Click
        Dim ChildForm As New MstSeccion
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub HorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorarioToolStripMenuItem.Click
        Dim ChildForm As New mstHorario
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub BusquedaAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaAlumnoToolStripMenuItem.Click
        Dim ChildForm As New mstBusquedaAlumno
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub GradoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GradoToolStripMenuItem2.Click
        Dim ChildForm As New mstSalon
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub NuevaCarreraToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SeccionToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SeccionToolStripMenuItem2.Click
        Dim ChildForm As New TrsSeccion
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub AsignacionCatedraticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionCatedraticoToolStripMenuItem.Click
        Dim ChildForm As New TrsAsignacionCatedratico
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub NuevoCatedraticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoCatedraticoToolStripMenuItem.Click
        Dim ChildForm As New mstCatedratico1
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub
End Class
