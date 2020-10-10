Public Class frmPACIENTE
    Private Sub PACIENTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PACIENTEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PACIENTEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecetasDataSet)

    End Sub

    Private Sub frmPACIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecetasDataSet.PACIENTE' Puede moverla o quitarla según sea necesario.
        Me.PACIENTETableAdapter.Fill(Me.BD_RecetasDataSet.PACIENTE)

    End Sub
End Class