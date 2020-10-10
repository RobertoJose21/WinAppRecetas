Public Class frmMEDICAMENTO
    Private Sub MEDICAMENTOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MEDICAMENTOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MEDICAMENTOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecetasDataSet)

    End Sub

    Private Sub frmMEDICAMENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecetasDataSet.MEDICAMENTO' Puede moverla o quitarla según sea necesario.
        Me.MEDICAMENTOTableAdapter.Fill(Me.BD_RecetasDataSet.MEDICAMENTO)

    End Sub
End Class