Public Class frmMEDICO
    Private Sub MEDICOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MEDICOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MEDICOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecetasDataSet)

    End Sub

    Private Sub frmMEDICO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecetasDataSet.MEDICO' Puede moverla o quitarla según sea necesario.
        Me.MEDICOTableAdapter.Fill(Me.BD_RecetasDataSet.MEDICO)

    End Sub
End Class