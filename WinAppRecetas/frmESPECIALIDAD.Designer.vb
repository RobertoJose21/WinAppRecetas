<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESPECIALIDAD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESPECIALIDAD))
        Dim IdEspecialidadLabel As System.Windows.Forms.Label
        Dim NameEspecialidadLabel As System.Windows.Forms.Label
        Me.BD_RecetasDataSet = New WinAppRecetas.BD_RecetasDataSet()
        Me.ESPECIALIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESPECIALIDADTableAdapter = New WinAppRecetas.BD_RecetasDataSetTableAdapters.ESPECIALIDADTableAdapter()
        Me.TableAdapterManager = New WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager()
        Me.ESPECIALIDADBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ESPECIALIDADBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEspecialidadTextBox = New System.Windows.Forms.TextBox()
        Me.NameEspecialidadTextBox = New System.Windows.Forms.TextBox()
        IdEspecialidadLabel = New System.Windows.Forms.Label()
        NameEspecialidadLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIALIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIALIDADBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ESPECIALIDADBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_RecetasDataSet
        '
        Me.BD_RecetasDataSet.DataSetName = "BD_RecetasDataSet"
        Me.BD_RecetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ESPECIALIDADBindingSource
        '
        Me.ESPECIALIDADBindingSource.DataMember = "ESPECIALIDAD"
        Me.ESPECIALIDADBindingSource.DataSource = Me.BD_RecetasDataSet
        '
        'ESPECIALIDADTableAdapter
        '
        Me.ESPECIALIDADTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTORIOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_RECETATableAdapter = Nothing
        Me.TableAdapterManager.ENFERMERATableAdapter = Nothing
        Me.TableAdapterManager.ESPECIALIDADTableAdapter = Me.ESPECIALIDADTableAdapter
        Me.TableAdapterManager.MEDICAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.MEDICOTableAdapter = Nothing
        Me.TableAdapterManager.PACIENTETableAdapter = Nothing
        Me.TableAdapterManager.RECETATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ESPECIALIDADBindingNavigator
        '
        Me.ESPECIALIDADBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ESPECIALIDADBindingNavigator.BindingSource = Me.ESPECIALIDADBindingSource
        Me.ESPECIALIDADBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ESPECIALIDADBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ESPECIALIDADBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ESPECIALIDADBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ESPECIALIDADBindingNavigatorSaveItem})
        Me.ESPECIALIDADBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ESPECIALIDADBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ESPECIALIDADBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ESPECIALIDADBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ESPECIALIDADBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ESPECIALIDADBindingNavigator.Name = "ESPECIALIDADBindingNavigator"
        Me.ESPECIALIDADBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ESPECIALIDADBindingNavigator.Size = New System.Drawing.Size(560, 31)
        Me.ESPECIALIDADBindingNavigator.TabIndex = 0
        Me.ESPECIALIDADBindingNavigator.Text = "BindingNavigator1"
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
        'ESPECIALIDADBindingNavigatorSaveItem
        '
        Me.ESPECIALIDADBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ESPECIALIDADBindingNavigatorSaveItem.Image = CType(resources.GetObject("ESPECIALIDADBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ESPECIALIDADBindingNavigatorSaveItem.Name = "ESPECIALIDADBindingNavigatorSaveItem"
        Me.ESPECIALIDADBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ESPECIALIDADBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEspecialidadLabel
        '
        IdEspecialidadLabel.AutoSize = True
        IdEspecialidadLabel.Location = New System.Drawing.Point(67, 100)
        IdEspecialidadLabel.Name = "IdEspecialidadLabel"
        IdEspecialidadLabel.Size = New System.Drawing.Size(121, 20)
        IdEspecialidadLabel.TabIndex = 1
        IdEspecialidadLabel.Text = "Id Especialidad:"
        '
        'IdEspecialidadTextBox
        '
        Me.IdEspecialidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ESPECIALIDADBindingSource, "IdEspecialidad", True))
        Me.IdEspecialidadTextBox.Location = New System.Drawing.Point(222, 97)
        Me.IdEspecialidadTextBox.Name = "IdEspecialidadTextBox"
        Me.IdEspecialidadTextBox.Size = New System.Drawing.Size(58, 26)
        Me.IdEspecialidadTextBox.TabIndex = 2
        '
        'NameEspecialidadLabel
        '
        NameEspecialidadLabel.AutoSize = True
        NameEspecialidadLabel.Location = New System.Drawing.Point(67, 157)
        NameEspecialidadLabel.Name = "NameEspecialidadLabel"
        NameEspecialidadLabel.Size = New System.Drawing.Size(149, 20)
        NameEspecialidadLabel.TabIndex = 3
        NameEspecialidadLabel.Text = "Name Especialidad:"
        '
        'NameEspecialidadTextBox
        '
        Me.NameEspecialidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ESPECIALIDADBindingSource, "NameEspecialidad", True))
        Me.NameEspecialidadTextBox.Location = New System.Drawing.Point(222, 154)
        Me.NameEspecialidadTextBox.Name = "NameEspecialidadTextBox"
        Me.NameEspecialidadTextBox.Size = New System.Drawing.Size(205, 26)
        Me.NameEspecialidadTextBox.TabIndex = 4
        '
        'frmESPECIALIDAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 592)
        Me.Controls.Add(IdEspecialidadLabel)
        Me.Controls.Add(Me.IdEspecialidadTextBox)
        Me.Controls.Add(NameEspecialidadLabel)
        Me.Controls.Add(Me.NameEspecialidadTextBox)
        Me.Controls.Add(Me.ESPECIALIDADBindingNavigator)
        Me.Name = "frmESPECIALIDAD"
        Me.Text = "frmESPECIALIDAD"
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIALIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIALIDADBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ESPECIALIDADBindingNavigator.ResumeLayout(False)
        Me.ESPECIALIDADBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecetasDataSet As BD_RecetasDataSet
    Friend WithEvents ESPECIALIDADBindingSource As BindingSource
    Friend WithEvents ESPECIALIDADTableAdapter As BD_RecetasDataSetTableAdapters.ESPECIALIDADTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecetasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ESPECIALIDADBindingNavigator As BindingNavigator
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
    Friend WithEvents ESPECIALIDADBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdEspecialidadTextBox As TextBox
    Friend WithEvents NameEspecialidadTextBox As TextBox
End Class
