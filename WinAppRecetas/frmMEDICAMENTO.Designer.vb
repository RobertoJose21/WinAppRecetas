<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMEDICAMENTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMEDICAMENTO))
        Dim IdMedicamentoLabel As System.Windows.Forms.Label
        Dim NameMedicamentoLabel As System.Windows.Forms.Label
        Dim PrecioUnitarioLabel As System.Windows.Forms.Label
        Dim UnidadMedidaLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Me.BD_RecetasDataSet = New WinAppRecetas.BD_RecetasDataSet()
        Me.MEDICAMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICAMENTOTableAdapter = New WinAppRecetas.BD_RecetasDataSetTableAdapters.MEDICAMENTOTableAdapter()
        Me.TableAdapterManager = New WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager()
        Me.MEDICAMENTOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MEDICAMENTOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdMedicamentoTextBox = New System.Windows.Forms.TextBox()
        Me.NameMedicamentoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioUnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadMedidaTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        IdMedicamentoLabel = New System.Windows.Forms.Label()
        NameMedicamentoLabel = New System.Windows.Forms.Label()
        PrecioUnitarioLabel = New System.Windows.Forms.Label()
        UnidadMedidaLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MEDICAMENTOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_RecetasDataSet
        '
        Me.BD_RecetasDataSet.DataSetName = "BD_RecetasDataSet"
        Me.BD_RecetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICAMENTOBindingSource
        '
        Me.MEDICAMENTOBindingSource.DataMember = "MEDICAMENTO"
        Me.MEDICAMENTOBindingSource.DataSource = Me.BD_RecetasDataSet
        '
        'MEDICAMENTOTableAdapter
        '
        Me.MEDICAMENTOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTORIOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_RECETATableAdapter = Nothing
        Me.TableAdapterManager.ENFERMERATableAdapter = Nothing
        Me.TableAdapterManager.ESPECIALIDADTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAMENTOTableAdapter = Me.MEDICAMENTOTableAdapter
        Me.TableAdapterManager.MEDICOTableAdapter = Nothing
        Me.TableAdapterManager.PACIENTETableAdapter = Nothing
        Me.TableAdapterManager.RECETATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MEDICAMENTOBindingNavigator
        '
        Me.MEDICAMENTOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MEDICAMENTOBindingNavigator.BindingSource = Me.MEDICAMENTOBindingSource
        Me.MEDICAMENTOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MEDICAMENTOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MEDICAMENTOBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MEDICAMENTOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MEDICAMENTOBindingNavigatorSaveItem})
        Me.MEDICAMENTOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MEDICAMENTOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MEDICAMENTOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MEDICAMENTOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MEDICAMENTOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MEDICAMENTOBindingNavigator.Name = "MEDICAMENTOBindingNavigator"
        Me.MEDICAMENTOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MEDICAMENTOBindingNavigator.Size = New System.Drawing.Size(538, 31)
        Me.MEDICAMENTOBindingNavigator.TabIndex = 0
        Me.MEDICAMENTOBindingNavigator.Text = "BindingNavigator1"
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
        'MEDICAMENTOBindingNavigatorSaveItem
        '
        Me.MEDICAMENTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MEDICAMENTOBindingNavigatorSaveItem.Image = CType(resources.GetObject("MEDICAMENTOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MEDICAMENTOBindingNavigatorSaveItem.Name = "MEDICAMENTOBindingNavigatorSaveItem"
        Me.MEDICAMENTOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MEDICAMENTOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdMedicamentoLabel
        '
        IdMedicamentoLabel.AutoSize = True
        IdMedicamentoLabel.Location = New System.Drawing.Point(84, 87)
        IdMedicamentoLabel.Name = "IdMedicamentoLabel"
        IdMedicamentoLabel.Size = New System.Drawing.Size(127, 20)
        IdMedicamentoLabel.TabIndex = 1
        IdMedicamentoLabel.Text = "Id Medicamento:"
        '
        'IdMedicamentoTextBox
        '
        Me.IdMedicamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOBindingSource, "IdMedicamento", True))
        Me.IdMedicamentoTextBox.Location = New System.Drawing.Point(245, 84)
        Me.IdMedicamentoTextBox.Name = "IdMedicamentoTextBox"
        Me.IdMedicamentoTextBox.Size = New System.Drawing.Size(65, 26)
        Me.IdMedicamentoTextBox.TabIndex = 2
        '
        'NameMedicamentoLabel
        '
        NameMedicamentoLabel.AutoSize = True
        NameMedicamentoLabel.Location = New System.Drawing.Point(84, 134)
        NameMedicamentoLabel.Name = "NameMedicamentoLabel"
        NameMedicamentoLabel.Size = New System.Drawing.Size(155, 20)
        NameMedicamentoLabel.TabIndex = 3
        NameMedicamentoLabel.Text = "Name Medicamento:"
        '
        'NameMedicamentoTextBox
        '
        Me.NameMedicamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOBindingSource, "NameMedicamento", True))
        Me.NameMedicamentoTextBox.Location = New System.Drawing.Point(245, 131)
        Me.NameMedicamentoTextBox.Name = "NameMedicamentoTextBox"
        Me.NameMedicamentoTextBox.Size = New System.Drawing.Size(281, 26)
        Me.NameMedicamentoTextBox.TabIndex = 4
        '
        'PrecioUnitarioLabel
        '
        PrecioUnitarioLabel.AutoSize = True
        PrecioUnitarioLabel.Location = New System.Drawing.Point(84, 182)
        PrecioUnitarioLabel.Name = "PrecioUnitarioLabel"
        PrecioUnitarioLabel.Size = New System.Drawing.Size(116, 20)
        PrecioUnitarioLabel.TabIndex = 5
        PrecioUnitarioLabel.Text = "Precio Unitario:"
        '
        'PrecioUnitarioTextBox
        '
        Me.PrecioUnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOBindingSource, "PrecioUnitario", True))
        Me.PrecioUnitarioTextBox.Location = New System.Drawing.Point(245, 179)
        Me.PrecioUnitarioTextBox.Name = "PrecioUnitarioTextBox"
        Me.PrecioUnitarioTextBox.Size = New System.Drawing.Size(65, 26)
        Me.PrecioUnitarioTextBox.TabIndex = 6
        '
        'UnidadMedidaLabel
        '
        UnidadMedidaLabel.AutoSize = True
        UnidadMedidaLabel.Location = New System.Drawing.Point(84, 226)
        UnidadMedidaLabel.Name = "UnidadMedidaLabel"
        UnidadMedidaLabel.Size = New System.Drawing.Size(120, 20)
        UnidadMedidaLabel.TabIndex = 7
        UnidadMedidaLabel.Text = "Unidad Medida:"
        '
        'UnidadMedidaTextBox
        '
        Me.UnidadMedidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOBindingSource, "UnidadMedida", True))
        Me.UnidadMedidaTextBox.Location = New System.Drawing.Point(245, 223)
        Me.UnidadMedidaTextBox.Name = "UnidadMedidaTextBox"
        Me.UnidadMedidaTextBox.Size = New System.Drawing.Size(111, 26)
        Me.UnidadMedidaTextBox.TabIndex = 8
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(84, 273)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(54, 20)
        StockLabel.TabIndex = 9
        StockLabel.Text = "Stock:"
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICAMENTOBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(245, 270)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(65, 26)
        Me.StockTextBox.TabIndex = 10
        '
        'frmMEDICAMENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 503)
        Me.Controls.Add(IdMedicamentoLabel)
        Me.Controls.Add(Me.IdMedicamentoTextBox)
        Me.Controls.Add(NameMedicamentoLabel)
        Me.Controls.Add(Me.NameMedicamentoTextBox)
        Me.Controls.Add(PrecioUnitarioLabel)
        Me.Controls.Add(Me.PrecioUnitarioTextBox)
        Me.Controls.Add(UnidadMedidaLabel)
        Me.Controls.Add(Me.UnidadMedidaTextBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Me.MEDICAMENTOBindingNavigator)
        Me.Name = "frmMEDICAMENTO"
        Me.Text = "frmMEDICAMENTO"
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MEDICAMENTOBindingNavigator.ResumeLayout(False)
        Me.MEDICAMENTOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecetasDataSet As BD_RecetasDataSet
    Friend WithEvents MEDICAMENTOBindingSource As BindingSource
    Friend WithEvents MEDICAMENTOTableAdapter As BD_RecetasDataSetTableAdapters.MEDICAMENTOTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecetasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MEDICAMENTOBindingNavigator As BindingNavigator
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
    Friend WithEvents MEDICAMENTOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdMedicamentoTextBox As TextBox
    Friend WithEvents NameMedicamentoTextBox As TextBox
    Friend WithEvents PrecioUnitarioTextBox As TextBox
    Friend WithEvents UnidadMedidaTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
End Class
