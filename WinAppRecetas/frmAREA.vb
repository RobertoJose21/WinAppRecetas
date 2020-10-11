Public Class frmAREA
    Private Sub AREABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AREABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AREABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecetasDataSet)

    End Sub

    Private Sub frmAREA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecetasDataSet.AREA' Puede moverla o quitarla según sea necesario.
        Me.AREATableAdapter.Fill(Me.BD_RecetasDataSet.AREA)

    End Sub

    Private Sub IdAreaTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdAreaTextBox.TextChanged

    End Sub
End Class