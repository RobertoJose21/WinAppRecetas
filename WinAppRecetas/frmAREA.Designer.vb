<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAREA
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
        Dim IdAreaLabel As System.Windows.Forms.Label
        Dim AreaEnfermeraLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAREA))
        Me.BD_RecetasDataSet = New WinAppRecetas.BD_RecetasDataSet()
        Me.AREABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AREATableAdapter = New WinAppRecetas.BD_RecetasDataSetTableAdapters.AREATableAdapter()
        Me.TableAdapterManager = New WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager()
        Me.AREABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AREABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdAreaTextBox = New System.Windows.Forms.TextBox()
        Me.AreaEnfermeraTextBox = New System.Windows.Forms.TextBox()
        Me.AREADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdAreaLabel = New System.Windows.Forms.Label()
        AreaEnfermeraLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AREABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AREABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AREABindingNavigator.SuspendLayout()
        CType(Me.AREADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdAreaLabel
        '
        IdAreaLabel.AutoSize = True
        IdAreaLabel.Location = New System.Drawing.Point(26, 60)
        IdAreaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdAreaLabel.Name = "IdAreaLabel"
        IdAreaLabel.Size = New System.Drawing.Size(44, 13)
        IdAreaLabel.TabIndex = 1
        IdAreaLabel.Text = "Id Area:"
        '
        'AreaEnfermeraLabel
        '
        AreaEnfermeraLabel.AutoSize = True
        AreaEnfermeraLabel.Location = New System.Drawing.Point(26, 114)
        AreaEnfermeraLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AreaEnfermeraLabel.Name = "AreaEnfermeraLabel"
        AreaEnfermeraLabel.Size = New System.Drawing.Size(83, 13)
        AreaEnfermeraLabel.TabIndex = 3
        AreaEnfermeraLabel.Text = "Area Enfermera:"
        '
        'BD_RecetasDataSet
        '
        Me.BD_RecetasDataSet.DataSetName = "BD_RecetasDataSet"
        Me.BD_RecetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AREABindingSource
        '
        Me.AREABindingSource.DataMember = "AREA"
        Me.AREABindingSource.DataSource = Me.BD_RecetasDataSet
        '
        'AREATableAdapter
        '
        Me.AREATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Me.AREATableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTORIOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_RECETATableAdapter = Nothing
        Me.TableAdapterManager.ENFERMERATableAdapter = Nothing
        Me.TableAdapterManager.ESPECIALIDADTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.MEDICOTableAdapter = Nothing
        Me.TableAdapterManager.PACIENTETableAdapter = Nothing
        Me.TableAdapterManager.RECETATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AREABindingNavigator
        '
        Me.AREABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AREABindingNavigator.BindingSource = Me.AREABindingSource
        Me.AREABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AREABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AREABindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.AREABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AREABindingNavigatorSaveItem})
        Me.AREABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AREABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AREABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AREABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AREABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AREABindingNavigator.Name = "AREABindingNavigator"
        Me.AREABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AREABindingNavigator.Size = New System.Drawing.Size(375, 31)
        Me.AREABindingNavigator.TabIndex = 0
        Me.AREABindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(35, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'AREABindingNavigatorSaveItem
        '
        Me.AREABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AREABindingNavigatorSaveItem.Image = CType(resources.GetObject("AREABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AREABindingNavigatorSaveItem.Name = "AREABindingNavigatorSaveItem"
        Me.AREABindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.AREABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdAreaTextBox
        '
        Me.IdAreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AREABindingSource, "IdArea", True))
        Me.IdAreaTextBox.Location = New System.Drawing.Point(125, 60)
        Me.IdAreaTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IdAreaTextBox.Name = "IdAreaTextBox"
        Me.IdAreaTextBox.Size = New System.Drawing.Size(46, 20)
        Me.IdAreaTextBox.TabIndex = 2
        '
        'AreaEnfermeraTextBox
        '
        Me.AreaEnfermeraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AREABindingSource, "AreaEnfermera", True))
        Me.AreaEnfermeraTextBox.Location = New System.Drawing.Point(125, 112)
        Me.AreaEnfermeraTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AreaEnfermeraTextBox.Name = "AreaEnfermeraTextBox"
        Me.AreaEnfermeraTextBox.Size = New System.Drawing.Size(132, 20)
        Me.AreaEnfermeraTextBox.TabIndex = 4
        '
        'AREADataGridView
        '
        Me.AREADataGridView.AutoGenerateColumns = False
        Me.AREADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AREADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.AREADataGridView.DataSource = Me.AREABindingSource
        Me.AREADataGridView.Location = New System.Drawing.Point(29, 156)
        Me.AREADataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AREADataGridView.Name = "AREADataGridView"
        Me.AREADataGridView.RowTemplate.Height = 28
        Me.AREADataGridView.Size = New System.Drawing.Size(270, 55)
        Me.AREADataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdArea"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdArea"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AreaEnfermera"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AreaEnfermera"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmAREA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 233)
        Me.Controls.Add(Me.AREADataGridView)
        Me.Controls.Add(IdAreaLabel)
        Me.Controls.Add(Me.IdAreaTextBox)
        Me.Controls.Add(AreaEnfermeraLabel)
        Me.Controls.Add(Me.AreaEnfermeraTextBox)
        Me.Controls.Add(Me.AREABindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmAREA"
        Me.Text = "frmAREA"
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AREABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AREABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AREABindingNavigator.ResumeLayout(False)
        Me.AREABindingNavigator.PerformLayout()
        CType(Me.AREADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecetasDataSet As BD_RecetasDataSet
    Friend WithEvents AREABindingSource As BindingSource
    Friend WithEvents AREATableAdapter As BD_RecetasDataSetTableAdapters.AREATableAdapter
    Friend WithEvents TableAdapterManager As BD_RecetasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AREABindingNavigator As BindingNavigator
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
    Friend WithEvents AREABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdAreaTextBox As TextBox
    Friend WithEvents AreaEnfermeraTextBox As TextBox
    Friend WithEvents AREADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
