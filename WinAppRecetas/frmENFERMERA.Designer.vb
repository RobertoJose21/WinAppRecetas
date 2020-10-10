<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmENFERMERA
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmENFERMERA))
        Dim IdEnfermeraLabel As System.Windows.Forms.Label
        Dim NameEnfermeraLabel As System.Windows.Forms.Label
        Dim IdAreaLabel As System.Windows.Forms.Label
        Me.BD_RecetasDataSet = New WinAppRecetas.BD_RecetasDataSet()
        Me.ENFERMERABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENFERMERATableAdapter = New WinAppRecetas.BD_RecetasDataSetTableAdapters.ENFERMERATableAdapter()
        Me.TableAdapterManager = New WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager()
        Me.ENFERMERABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ENFERMERABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEnfermeraTextBox = New System.Windows.Forms.TextBox()
        Me.NameEnfermeraTextBox = New System.Windows.Forms.TextBox()
        Me.IdAreaTextBox = New System.Windows.Forms.TextBox()
        IdEnfermeraLabel = New System.Windows.Forms.Label()
        NameEnfermeraLabel = New System.Windows.Forms.Label()
        IdAreaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENFERMERABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENFERMERABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ENFERMERABindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_RecetasDataSet
        '
        Me.BD_RecetasDataSet.DataSetName = "BD_RecetasDataSet"
        Me.BD_RecetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ENFERMERABindingSource
        '
        Me.ENFERMERABindingSource.DataMember = "ENFERMERA"
        Me.ENFERMERABindingSource.DataSource = Me.BD_RecetasDataSet
        '
        'ENFERMERATableAdapter
        '
        Me.ENFERMERATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTORIOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_RECETATableAdapter = Nothing
        Me.TableAdapterManager.ENFERMERATableAdapter = Me.ENFERMERATableAdapter
        Me.TableAdapterManager.ESPECIALIDADTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.MEDICOTableAdapter = Nothing
        Me.TableAdapterManager.PACIENTETableAdapter = Nothing
        Me.TableAdapterManager.RECETATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ENFERMERABindingNavigator
        '
        Me.ENFERMERABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ENFERMERABindingNavigator.BindingSource = Me.ENFERMERABindingSource
        Me.ENFERMERABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ENFERMERABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ENFERMERABindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ENFERMERABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ENFERMERABindingNavigatorSaveItem})
        Me.ENFERMERABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ENFERMERABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ENFERMERABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ENFERMERABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ENFERMERABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ENFERMERABindingNavigator.Name = "ENFERMERABindingNavigator"
        Me.ENFERMERABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ENFERMERABindingNavigator.Size = New System.Drawing.Size(566, 31)
        Me.ENFERMERABindingNavigator.TabIndex = 0
        Me.ENFERMERABindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 25)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ENFERMERABindingNavigatorSaveItem
        '
        Me.ENFERMERABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ENFERMERABindingNavigatorSaveItem.Image = CType(resources.GetObject("ENFERMERABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ENFERMERABindingNavigatorSaveItem.Name = "ENFERMERABindingNavigatorSaveItem"
        Me.ENFERMERABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ENFERMERABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEnfermeraLabel
        '
        IdEnfermeraLabel.AutoSize = True
        IdEnfermeraLabel.Location = New System.Drawing.Point(72, 71)
        IdEnfermeraLabel.Name = "IdEnfermeraLabel"
        IdEnfermeraLabel.Size = New System.Drawing.Size(106, 20)
        IdEnfermeraLabel.TabIndex = 1
        IdEnfermeraLabel.Text = "Id Enfermera:"
        '
        'IdEnfermeraTextBox
        '
        Me.IdEnfermeraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENFERMERABindingSource, "IdEnfermera", True))
        Me.IdEnfermeraTextBox.Location = New System.Drawing.Point(212, 68)
        Me.IdEnfermeraTextBox.Name = "IdEnfermeraTextBox"
        Me.IdEnfermeraTextBox.Size = New System.Drawing.Size(55, 26)
        Me.IdEnfermeraTextBox.TabIndex = 2
        '
        'NameEnfermeraLabel
        '
        NameEnfermeraLabel.AutoSize = True
        NameEnfermeraLabel.Location = New System.Drawing.Point(72, 125)
        NameEnfermeraLabel.Name = "NameEnfermeraLabel"
        NameEnfermeraLabel.Size = New System.Drawing.Size(134, 20)
        NameEnfermeraLabel.TabIndex = 3
        NameEnfermeraLabel.Text = "Name Enfermera:"
        '
        'NameEnfermeraTextBox
        '
        Me.NameEnfermeraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENFERMERABindingSource, "NameEnfermera", True))
        Me.NameEnfermeraTextBox.Location = New System.Drawing.Point(212, 122)
        Me.NameEnfermeraTextBox.Name = "NameEnfermeraTextBox"
        Me.NameEnfermeraTextBox.Size = New System.Drawing.Size(277, 26)
        Me.NameEnfermeraTextBox.TabIndex = 4
        '
        'IdAreaLabel
        '
        IdAreaLabel.AutoSize = True
        IdAreaLabel.Location = New System.Drawing.Point(72, 180)
        IdAreaLabel.Name = "IdAreaLabel"
        IdAreaLabel.Size = New System.Drawing.Size(65, 20)
        IdAreaLabel.TabIndex = 5
        IdAreaLabel.Text = "Id Area:"
        '
        'IdAreaTextBox
        '
        Me.IdAreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENFERMERABindingSource, "IdArea", True))
        Me.IdAreaTextBox.Location = New System.Drawing.Point(212, 177)
        Me.IdAreaTextBox.Name = "IdAreaTextBox"
        Me.IdAreaTextBox.Size = New System.Drawing.Size(55, 26)
        Me.IdAreaTextBox.TabIndex = 6
        '
        'frmENFERMERA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 542)
        Me.Controls.Add(IdEnfermeraLabel)
        Me.Controls.Add(Me.IdEnfermeraTextBox)
        Me.Controls.Add(NameEnfermeraLabel)
        Me.Controls.Add(Me.NameEnfermeraTextBox)
        Me.Controls.Add(IdAreaLabel)
        Me.Controls.Add(Me.IdAreaTextBox)
        Me.Controls.Add(Me.ENFERMERABindingNavigator)
        Me.Name = "frmENFERMERA"
        Me.Text = "frmENFERMERA"
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENFERMERABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENFERMERABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ENFERMERABindingNavigator.ResumeLayout(False)
        Me.ENFERMERABindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecetasDataSet As BD_RecetasDataSet
    Friend WithEvents ENFERMERABindingSource As BindingSource
    Friend WithEvents ENFERMERATableAdapter As BD_RecetasDataSetTableAdapters.ENFERMERATableAdapter
    Friend WithEvents TableAdapterManager As BD_RecetasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ENFERMERABindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ENFERMERABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdEnfermeraTextBox As TextBox
    Friend WithEvents NameEnfermeraTextBox As TextBox
    Friend WithEvents IdAreaTextBox As TextBox
End Class
