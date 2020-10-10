<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMEDICO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMEDICO))
        Dim IdMedicoLabel As System.Windows.Forms.Label
        Dim NameMedicoLabel As System.Windows.Forms.Label
        Dim EmailMedicoLabel As System.Windows.Forms.Label
        Dim IdEspecialidadLabel As System.Windows.Forms.Label
        Me.BD_RecetasDataSet = New WinAppRecetas.BD_RecetasDataSet()
        Me.MEDICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICOTableAdapter = New WinAppRecetas.BD_RecetasDataSetTableAdapters.MEDICOTableAdapter()
        Me.TableAdapterManager = New WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager()
        Me.MEDICOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MEDICOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdMedicoTextBox = New System.Windows.Forms.TextBox()
        Me.NameMedicoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailMedicoTextBox = New System.Windows.Forms.TextBox()
        Me.IdEspecialidadTextBox = New System.Windows.Forms.TextBox()
        IdMedicoLabel = New System.Windows.Forms.Label()
        NameMedicoLabel = New System.Windows.Forms.Label()
        EmailMedicoLabel = New System.Windows.Forms.Label()
        IdEspecialidadLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MEDICOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_RecetasDataSet
        '
        Me.BD_RecetasDataSet.DataSetName = "BD_RecetasDataSet"
        Me.BD_RecetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICOBindingSource
        '
        Me.MEDICOBindingSource.DataMember = "MEDICO"
        Me.MEDICOBindingSource.DataSource = Me.BD_RecetasDataSet
        '
        'MEDICOTableAdapter
        '
        Me.MEDICOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTORIOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_RECETATableAdapter = Nothing
        Me.TableAdapterManager.ENFERMERATableAdapter = Nothing
        Me.TableAdapterManager.ESPECIALIDADTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.MEDICOTableAdapter = Me.MEDICOTableAdapter
        Me.TableAdapterManager.PACIENTETableAdapter = Nothing
        Me.TableAdapterManager.RECETATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MEDICOBindingNavigator
        '
        Me.MEDICOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MEDICOBindingNavigator.BindingSource = Me.MEDICOBindingSource
        Me.MEDICOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MEDICOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MEDICOBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MEDICOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MEDICOBindingNavigatorSaveItem})
        Me.MEDICOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MEDICOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MEDICOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MEDICOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MEDICOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MEDICOBindingNavigator.Name = "MEDICOBindingNavigator"
        Me.MEDICOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MEDICOBindingNavigator.Size = New System.Drawing.Size(580, 31)
        Me.MEDICOBindingNavigator.TabIndex = 0
        Me.MEDICOBindingNavigator.Text = "BindingNavigator1"
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
        'MEDICOBindingNavigatorSaveItem
        '
        Me.MEDICOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MEDICOBindingNavigatorSaveItem.Image = CType(resources.GetObject("MEDICOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MEDICOBindingNavigatorSaveItem.Name = "MEDICOBindingNavigatorSaveItem"
        Me.MEDICOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MEDICOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdMedicoLabel
        '
        IdMedicoLabel.AutoSize = True
        IdMedicoLabel.Location = New System.Drawing.Point(104, 74)
        IdMedicoLabel.Name = "IdMedicoLabel"
        IdMedicoLabel.Size = New System.Drawing.Size(82, 20)
        IdMedicoLabel.TabIndex = 1
        IdMedicoLabel.Text = "Id Medico:"
        '
        'IdMedicoTextBox
        '
        Me.IdMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "IdMedico", True))
        Me.IdMedicoTextBox.Location = New System.Drawing.Point(231, 71)
        Me.IdMedicoTextBox.Name = "IdMedicoTextBox"
        Me.IdMedicoTextBox.Size = New System.Drawing.Size(59, 26)
        Me.IdMedicoTextBox.TabIndex = 2
        '
        'NameMedicoLabel
        '
        NameMedicoLabel.AutoSize = True
        NameMedicoLabel.Location = New System.Drawing.Point(104, 119)
        NameMedicoLabel.Name = "NameMedicoLabel"
        NameMedicoLabel.Size = New System.Drawing.Size(110, 20)
        NameMedicoLabel.TabIndex = 3
        NameMedicoLabel.Text = "Name Medico:"
        '
        'NameMedicoTextBox
        '
        Me.NameMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "NameMedico", True))
        Me.NameMedicoTextBox.Location = New System.Drawing.Point(231, 116)
        Me.NameMedicoTextBox.Name = "NameMedicoTextBox"
        Me.NameMedicoTextBox.Size = New System.Drawing.Size(318, 26)
        Me.NameMedicoTextBox.TabIndex = 4
        '
        'EmailMedicoLabel
        '
        EmailMedicoLabel.AutoSize = True
        EmailMedicoLabel.Location = New System.Drawing.Point(104, 165)
        EmailMedicoLabel.Name = "EmailMedicoLabel"
        EmailMedicoLabel.Size = New System.Drawing.Size(107, 20)
        EmailMedicoLabel.TabIndex = 5
        EmailMedicoLabel.Text = "Email Medico:"
        '
        'EmailMedicoTextBox
        '
        Me.EmailMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "EmailMedico", True))
        Me.EmailMedicoTextBox.Location = New System.Drawing.Point(231, 162)
        Me.EmailMedicoTextBox.Name = "EmailMedicoTextBox"
        Me.EmailMedicoTextBox.Size = New System.Drawing.Size(318, 26)
        Me.EmailMedicoTextBox.TabIndex = 6
        '
        'IdEspecialidadLabel
        '
        IdEspecialidadLabel.AutoSize = True
        IdEspecialidadLabel.Location = New System.Drawing.Point(104, 213)
        IdEspecialidadLabel.Name = "IdEspecialidadLabel"
        IdEspecialidadLabel.Size = New System.Drawing.Size(121, 20)
        IdEspecialidadLabel.TabIndex = 7
        IdEspecialidadLabel.Text = "Id Especialidad:"
        '
        'IdEspecialidadTextBox
        '
        Me.IdEspecialidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "IdEspecialidad", True))
        Me.IdEspecialidadTextBox.Location = New System.Drawing.Point(231, 210)
        Me.IdEspecialidadTextBox.Name = "IdEspecialidadTextBox"
        Me.IdEspecialidadTextBox.Size = New System.Drawing.Size(59, 26)
        Me.IdEspecialidadTextBox.TabIndex = 8
        '
        'frmMEDICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 519)
        Me.Controls.Add(IdMedicoLabel)
        Me.Controls.Add(Me.IdMedicoTextBox)
        Me.Controls.Add(NameMedicoLabel)
        Me.Controls.Add(Me.NameMedicoTextBox)
        Me.Controls.Add(EmailMedicoLabel)
        Me.Controls.Add(Me.EmailMedicoTextBox)
        Me.Controls.Add(IdEspecialidadLabel)
        Me.Controls.Add(Me.IdEspecialidadTextBox)
        Me.Controls.Add(Me.MEDICOBindingNavigator)
        Me.Name = "frmMEDICO"
        Me.Text = "frmMEDICO"
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MEDICOBindingNavigator.ResumeLayout(False)
        Me.MEDICOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecetasDataSet As BD_RecetasDataSet
    Friend WithEvents MEDICOBindingSource As BindingSource
    Friend WithEvents MEDICOTableAdapter As BD_RecetasDataSetTableAdapters.MEDICOTableAdapter
    Friend WithEvents TableAdapterManager As BD_RecetasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MEDICOBindingNavigator As BindingNavigator
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
    Friend WithEvents MEDICOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdMedicoTextBox As TextBox
    Friend WithEvents NameMedicoTextBox As TextBox
    Friend WithEvents EmailMedicoTextBox As TextBox
    Friend WithEvents IdEspecialidadTextBox As TextBox
End Class
