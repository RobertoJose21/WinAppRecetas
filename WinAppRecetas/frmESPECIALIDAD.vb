Public Class frmESPECIALIDAD
    Private Sub ESPECIALIDADBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ESPECIALIDADBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ESPECIALIDADBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecetasDataSet)

    End Sub

    Private Sub frmESPECIALIDAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecetasDataSet.ESPECIALIDAD' Puede moverla o quitarla según sea necesario.
        Me.ESPECIALIDADTableAdapter.Fill(Me.BD_RecetasDataSet.ESPECIALIDAD)

    End Sub
End Class