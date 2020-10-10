<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONSULTORIO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCONSULTORIO))
        Dim IdConsultorioLabel As System.Windows.Forms.Label
        Dim EstadoConsultorioLabel As System.Windows.Forms.Label
        Dim AforoLabel As System.Windows.Forms.Label
        Me.BD_RecetasDataSet = New WinAppRecetas.BD_RecetasDataSet()
        Me.CONSULTORIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTORIOTableAdapter = New WinAppRecetas.BD_RecetasDataSetTableAdapters.CONSULTORIOTableAdapter()
        Me.TableAdapterManager = New WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager()
        Me.CONSULTORIOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CONSULTORIOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdConsultorioTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoConsultorioTextBox = New System.Windows.Forms.TextBox()
        Me.AforoTextBox = New System.Windows.Forms.TextBox()
        IdConsultorioLabel = New System.Windows.Forms.Label()
        EstadoConsultorioLabel = New System.Windows.Forms.Label()
        AforoLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTORIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTORIOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONSULTORIOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_RecetasDataSet
        '
        Me.BD_RecetasDataSet.DataSetName = "BD_RecetasDataSet"
        Me.BD_RecetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTORIOBindingSource
        '
        Me.CONSULTORIOBindingSource.DataMember = "CONSULTORIO"
        Me.CONSULTORIOBindingSource.DataSource = Me.BD_RecetasDataSet
        '
        'CONSULTORIOTableAdapter
        '
        Me.CONSULTORIOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTORIOTableAdapter = Me.CONSULTORIOTableAdapter
        Me.TableAdapterManager.DETALLE_RECETATableAdapter = Nothing
        Me.TableAdapterManager.ENFERMERATableAdapter = Nothing
        Me.TableAdapterManager.ESPECIALIDADTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.MEDICOTableAdapter = Nothing
        Me.TableAdapterManager.PACIENTETableAdapter = Nothing
        Me.TableAdapterManager.RECETATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CONSULTORIOBindingNavigator
        '
        Me.CONSULTORIOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CONSULTORIOBindingNavigator.BindingSource = Me.CONSULTORIOBindingSource
        Me.CONSULTORIOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CONSULTORIOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CONSULTORIOBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CONSULTORIOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CONSULTORIOBindingNavigatorSaveItem})
        Me.CONSULTORIOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CONSULTORIOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CONSULTORIOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CONSULTORIOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CONSULTORIOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CONSULTORIOBindingNavigator.Name = "CONSULTORIOBindingNavigator"
        Me.CONSULTORIOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CONSULTORIOBindingNavigator.Size = New System.Drawing.Size(533, 31)
        Me.CONSULTORIOBindingNavigator.TabIndex = 0
        Me.CONSULTORIOBindingNavigator.Text = "BindingNavigator1"
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
        'CONSULTORIOBindingNavigatorSaveItem
        '
        Me.CONSULTORIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CONSULTORIOBindingNavigatorSaveItem.Image = CType(resources.GetObject("CONSULTORIOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CONSULTORIOBindingNavigatorSaveItem.Name = "CONSULTORIOBindingNavigatorSaveItem"
        Me.CONSULTORIOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CONSULTORIOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdConsultorioLabel
        '
        IdConsultorioLabel.AutoSize = True
        IdConsultorioLabel.Location = New System.Drawing.Point(50, 71)
        IdConsultorioLabel.Name = "IdConsultorioLabel"
        IdConsultorioLabel.Size = New System.Drawing.Size(111, 20)
        IdConsultorioLabel.TabIndex = 1
        IdConsultorioLabel.Text = "Id Consultorio:"
        '
        'IdConsultorioTextBox
        '
        Me.IdConsultorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTORIOBindingSource, "IdConsultorio", True))
        Me.IdConsultorioTextBox.Location = New System.Drawing.Point(224, 68)
        Me.IdConsultorioTextBox.Name = "IdConsultorioTextBox"
        Me.IdConsultorioTextBox.Size = New System.Drawing.Size(55, 26)
        Me.IdConsultorioTextBox.TabIndex = 2
        '
        'EstadoConsultorioLabel
        '
        EstadoConsultorioLabel.AutoSize = True
        EstadoConsultorioLabel.Location = New System.Drawing.Point(50, 125)
        EstadoConsultorioLabel.Name = "EstadoConsultorioLabel"
        EstadoConsultorioLabel.Size = New System.Drawing.Size(148, 20)
        EstadoConsultorioLabel.TabIndex = 3
        EstadoConsultorioLabel.Text = "Estado Consultorio:"
        '
        'EstadoConsultorioTextBox
        '
        Me.EstadoConsultorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTORIOBindingSource, "EstadoConsultorio", True))
        Me.EstadoConsultorioTextBox.Location = New System.Drawing.Point(224, 122)
        Me.EstadoConsultorioTextBox.Name = "EstadoConsultorioTextBox"
        Me.EstadoConsultorioTextBox.Size = New System.Drawing.Size(55, 26)
        Me.EstadoConsultorioTextBox.TabIndex = 4
        '
        'AforoLabel
        '
        AforoLabel.AutoSize = True
        AforoLabel.Location = New System.Drawing.Point(50, 179)
        AforoLabel.Name = "AforoLabel"
        AforoLabel.Size = New System.Drawing.Size(52, 20)
        AforoLabel.TabIndex = 5
        AforoLabel.Text = "Aforo:"
        '
        'AforoTextBox
        '
        Me.AforoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONSULTORIOBindingSource, "Aforo", True))
        Me.AforoTextBox.Location = New System.Drawing.Point(224, 176)
        Me.AforoTextBox.Name = "AforoTextBox"
        Me.AforoTextBox.Size = New System.Drawing.Size(55, 26)
        Me.AforoTextBox.TabIndex = 6
        '
        'frmCONSULTORIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 530)
        Me.Controls.Add(IdConsultorioLabel)
        Me.Controls.Add(Me.IdConsultorioTextBox)
        Me.Controls.Add(EstadoConsultorioLabel)
        Me.Controls.Add(Me.EstadoConsultorioTextBox)
        Me.Controls.Add(AforoLabel)
        Me.Controls.Add(Me.AforoTextBox)
        Me.Controls.Add(Me.CONSULTORIOBindingNavigator)
        Me.Name = "frmCONSULTORIO"
        Me.Text = "frmCONSULTORIO"
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTORIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTORIOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONSULTORIOBindingNavigator.ResumeLayout(False)
        Me.CONSULTORIOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecetasDataSet As BD_RecetasDataSet
    Friend WithEvents CONSULTORIOBindingSource As BindingSource
    Friend WithEvents CONSULTORIOTableAdapter As BD_RecetasDataSetTableAdapters.CONSULTORIOTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecetasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONSULTORIOBindingNavigator As BindingNavigator
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
    Friend WithEvents CONSULTORIOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdConsultorioTextBox As TextBox
    Friend WithEvents EstadoConsultorioTextBox As TextBox
    Friend WithEvents AforoTextBox As TextBox
End Class
