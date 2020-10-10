Public Class frmENFERMERA
    Private Sub ENFERMERABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ENFERMERABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ENFERMERABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecetasDataSet)

    End Sub

    Private Sub frmENFERMERA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecetasDataSet.ENFERMERA' Puede moverla o quitarla según sea necesario.
        Me.ENFERMERATableAdapter.Fill(Me.BD_RecetasDataSet.ENFERMERA)

    End Sub
End Class