Public Class frmCONSULTORIO
    Private Sub CONSULTORIOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CONSULTORIOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CONSULTORIOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecetasDataSet)

    End Sub

    Private Sub frmCONSULTORIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecetasDataSet.CONSULTORIO' Puede moverla o quitarla según sea necesario.
        Me.CONSULTORIOTableAdapter.Fill(Me.BD_RecetasDataSet.CONSULTORIO)

    End Sub
End Class