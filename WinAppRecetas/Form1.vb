Public Class Form1
    Private Sub MedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoToolStripMenuItem.Click
        Dim objMedico As New frmMEDICO
        objMedico.MdiParent = Me
        objMedico.Show()

    End Sub

    Private Sub EnfermeraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnfermeraToolStripMenuItem.Click
        Dim objEnfermera As New frmENFERMERA
        objEnfermera.MdiParent = Me
        objEnfermera.Show()
    End Sub

    Private Sub MedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicamentoToolStripMenuItem.Click
        Dim objMedicamento As New frmMEDICAMENTO
        objMedicamento.MdiParent = Me
        objMedicamento.Show()
    End Sub

    Private Sub ConsultorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultorioToolStripMenuItem.Click
        Dim objConsultorio As New frmCONSULTORIO
        objConsultorio.MdiParent = Me
        objConsultorio.Show()
    End Sub

    Private Sub PacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteToolStripMenuItem.Click
        Dim objPaciente As New frmPACIENTE
        objPaciente.MdiParent = Me
        objPaciente.Show()
    End Sub

    Private Sub RecetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecetaToolStripMenuItem.Click
        Dim objReceta As New frmRECETA
        objReceta.MdiParent = Me
        objReceta.Show()
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(0)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(1)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(2)
    End Sub

    Private Sub OrganizarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizarTodoToolStripMenuItem.Click
        Me.LayoutMdi(3)
    End Sub

    Private Sub AreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaToolStripMenuItem.Click
        Dim objArea As New frmAREA
        objArea.MdiParent = Me
        objArea.Show()
    End Sub

    Private Sub EspecialidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecialidadToolStripMenuItem.Click
        Dim objEspecialidad As New frmAREA
        objEspecialidad.MdiParent = Me
        objEspecialidad.Show()
    End Sub
End Class
