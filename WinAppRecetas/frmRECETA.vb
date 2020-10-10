Public Class frmRECETA
    Private Sub RECETABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RECETABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RECETABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecetasDataSet)

    End Sub

    Private Sub frmRECETA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecetasDataSet.DETALLE_RECETA' Puede moverla o quitarla según sea necesario.
        Me.DETALLE_RECETATableAdapter.Fill(Me.BD_RecetasDataSet.DETALLE_RECETA)
        'TODO: esta línea de código carga datos en la tabla 'BD_RecetasDataSet.RECETA' Puede moverla o quitarla según sea necesario.
        Me.RECETATableAdapter.Fill(Me.BD_RecetasDataSet.RECETA)

    End Sub
End Class