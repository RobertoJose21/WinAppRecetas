<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRECETA
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
        Dim IdRecetaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim IdMedicoLabel As System.Windows.Forms.Label
        Dim IdPacienteLabel As System.Windows.Forms.Label
        Dim IdEnfermeraLabel As System.Windows.Forms.Label
        Dim IdConsultorioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRECETA))
        Me.BD_RecetasDataSet = New WinAppRecetas.BD_RecetasDataSet()
        Me.RECETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECETATableAdapter = New WinAppRecetas.BD_RecetasDataSetTableAdapters.RECETATableAdapter()
        Me.TableAdapterManager = New WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager()
        Me.DETALLE_RECETATableAdapter = New WinAppRecetas.BD_RecetasDataSetTableAdapters.DETALLE_RECETATableAdapter()
        Me.RECETABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RECETABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdRecetaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdMedicoTextBox = New System.Windows.Forms.TextBox()
        Me.IdPacienteTextBox = New System.Windows.Forms.TextBox()
        Me.IdEnfermeraTextBox = New System.Windows.Forms.TextBox()
        Me.IdConsultorioTextBox = New System.Windows.Forms.TextBox()
        Me.DETALLE_RECETABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DETALLE_RECETADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdRecetaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        IdMedicoLabel = New System.Windows.Forms.Label()
        IdPacienteLabel = New System.Windows.Forms.Label()
        IdEnfermeraLabel = New System.Windows.Forms.Label()
        IdConsultorioLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECETABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RECETABindingNavigator.SuspendLayout()
        CType(Me.DETALLE_RECETABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLE_RECETADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdRecetaLabel
        '
        IdRecetaLabel.AutoSize = True
        IdRecetaLabel.Location = New System.Drawing.Point(48, 66)
        IdRecetaLabel.Name = "IdRecetaLabel"
        IdRecetaLabel.Size = New System.Drawing.Size(72, 17)
        IdRecetaLabel.TabIndex = 1
        IdRecetaLabel.Text = "Id Receta:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(48, 100)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(51, 17)
        FechaLabel.TabIndex = 3
        FechaLabel.Text = "Fecha:"
        '
        'IdMedicoLabel
        '
        IdMedicoLabel.AutoSize = True
        IdMedicoLabel.Location = New System.Drawing.Point(48, 137)
        IdMedicoLabel.Name = "IdMedicoLabel"
        IdMedicoLabel.Size = New System.Drawing.Size(72, 17)
        IdMedicoLabel.TabIndex = 5
        IdMedicoLabel.Text = "Id Medico:"
        '
        'IdPacienteLabel
        '
        IdPacienteLabel.AutoSize = True
        IdPacienteLabel.Location = New System.Drawing.Point(405, 134)
        IdPacienteLabel.Name = "IdPacienteLabel"
        IdPacienteLabel.Size = New System.Drawing.Size(82, 17)
        IdPacienteLabel.TabIndex = 7
        IdPacienteLabel.Text = "Id Paciente:"
        '
        'IdEnfermeraLabel
        '
        IdEnfermeraLabel.AutoSize = True
        IdEnfermeraLabel.Location = New System.Drawing.Point(405, 66)
        IdEnfermeraLabel.Name = "IdEnfermeraLabel"
        IdEnfermeraLabel.Size = New System.Drawing.Size(93, 17)
        IdEnfermeraLabel.TabIndex = 9
        IdEnfermeraLabel.Text = "Id Enfermera:"
        '
        'IdConsultorioLabel
        '
        IdConsultorioLabel.AutoSize = True
        IdConsultorioLabel.Location = New System.Drawing.Point(400, 97)
        IdConsultorioLabel.Name = "IdConsultorioLabel"
        IdConsultorioLabel.Size = New System.Drawing.Size(98, 17)
        IdConsultorioLabel.TabIndex = 11
        IdConsultorioLabel.Text = "Id Consultorio:"
        '
        'BD_RecetasDataSet
        '
        Me.BD_RecetasDataSet.DataSetName = "BD_RecetasDataSet"
        Me.BD_RecetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RECETABindingSource
        '
        Me.RECETABindingSource.DataMember = "RECETA"
        Me.RECETABindingSource.DataSource = Me.BD_RecetasDataSet
        '
        'RECETATableAdapter
        '
        Me.RECETATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AREATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CONSULTORIOTableAdapter = Nothing
        Me.TableAdapterManager.DETALLE_RECETATableAdapter = Me.DETALLE_RECETATableAdapter
        Me.TableAdapterManager.ENFERMERATableAdapter = Nothing
        Me.TableAdapterManager.ESPECIALIDADTableAdapter = Nothing
        Me.TableAdapterManager.MEDICAMENTOTableAdapter = Nothing
        Me.TableAdapterManager.MEDICOTableAdapter = Nothing
        Me.TableAdapterManager.PACIENTETableAdapter = Nothing
        Me.TableAdapterManager.RECETATableAdapter = Me.RECETATableAdapter
        Me.TableAdapterManager.UpdateOrder = WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DETALLE_RECETATableAdapter
        '
        Me.DETALLE_RECETATableAdapter.ClearBeforeFill = True
        '
        'RECETABindingNavigator
        '
        Me.RECETABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RECETABindingNavigator.BindingSource = Me.RECETABindingSource
        Me.RECETABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RECETABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RECETABindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.RECETABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RECETABindingNavigatorSaveItem})
        Me.RECETABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RECETABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RECETABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RECETABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RECETABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RECETABindingNavigator.Name = "RECETABindingNavigator"
        Me.RECETABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RECETABindingNavigator.Size = New System.Drawing.Size(718, 31)
        Me.RECETABindingNavigator.TabIndex = 0
        Me.RECETABindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(45, 27)
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
        'RECETABindingNavigatorSaveItem
        '
        Me.RECETABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RECETABindingNavigatorSaveItem.Image = CType(resources.GetObject("RECETABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RECETABindingNavigatorSaveItem.Name = "RECETABindingNavigatorSaveItem"
        Me.RECETABindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.RECETABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdRecetaTextBox
        '
        Me.IdRecetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "IdReceta", True))
        Me.IdRecetaTextBox.Location = New System.Drawing.Point(152, 63)
        Me.IdRecetaTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdRecetaTextBox.Name = "IdRecetaTextBox"
        Me.IdRecetaTextBox.Size = New System.Drawing.Size(53, 22)
        Me.IdRecetaTextBox.TabIndex = 2
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RECETABindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(152, 97)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(178, 22)
        Me.FechaDateTimePicker.TabIndex = 4
        '
        'IdMedicoTextBox
        '
        Me.IdMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "IdMedico", True))
        Me.IdMedicoTextBox.Location = New System.Drawing.Point(152, 134)
        Me.IdMedicoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdMedicoTextBox.Name = "IdMedicoTextBox"
        Me.IdMedicoTextBox.Size = New System.Drawing.Size(53, 22)
        Me.IdMedicoTextBox.TabIndex = 6
        '
        'IdPacienteTextBox
        '
        Me.IdPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "IdPaciente", True))
        Me.IdPacienteTextBox.Location = New System.Drawing.Point(532, 137)
        Me.IdPacienteTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdPacienteTextBox.Name = "IdPacienteTextBox"
        Me.IdPacienteTextBox.Size = New System.Drawing.Size(53, 22)
        Me.IdPacienteTextBox.TabIndex = 8
        '
        'IdEnfermeraTextBox
        '
        Me.IdEnfermeraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "IdEnfermera", True))
        Me.IdEnfermeraTextBox.Location = New System.Drawing.Point(532, 63)
        Me.IdEnfermeraTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdEnfermeraTextBox.Name = "IdEnfermeraTextBox"
        Me.IdEnfermeraTextBox.Size = New System.Drawing.Size(53, 22)
        Me.IdEnfermeraTextBox.TabIndex = 10
        '
        'IdConsultorioTextBox
        '
        Me.IdConsultorioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RECETABindingSource, "IdConsultorio", True))
        Me.IdConsultorioTextBox.Location = New System.Drawing.Point(532, 99)
        Me.IdConsultorioTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdConsultorioTextBox.Name = "IdConsultorioTextBox"
        Me.IdConsultorioTextBox.Size = New System.Drawing.Size(53, 22)
        Me.IdConsultorioTextBox.TabIndex = 12
        '
        'DETALLE_RECETABindingSource
        '
        Me.DETALLE_RECETABindingSource.DataMember = "R_2"
        Me.DETALLE_RECETABindingSource.DataSource = Me.RECETABindingSource
        '
        'DETALLE_RECETADataGridView
        '
        Me.DETALLE_RECETADataGridView.AutoGenerateColumns = False
        Me.DETALLE_RECETADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLE_RECETADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DETALLE_RECETADataGridView.DataSource = Me.DETALLE_RECETABindingSource
        Me.DETALLE_RECETADataGridView.Location = New System.Drawing.Point(52, 234)
        Me.DETALLE_RECETADataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DETALLE_RECETADataGridView.Name = "DETALLE_RECETADataGridView"
        Me.DETALLE_RECETADataGridView.RowTemplate.Height = 28
        Me.DETALLE_RECETADataGridView.Size = New System.Drawing.Size(652, 256)
        Me.DETALLE_RECETADataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdReceta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdReceta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdMedicamento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdMedicamento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Indicaciones"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Indicaciones"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'frmRECETA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 500)
        Me.Controls.Add(Me.DETALLE_RECETADataGridView)
        Me.Controls.Add(IdRecetaLabel)
        Me.Controls.Add(Me.IdRecetaTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(IdMedicoLabel)
        Me.Controls.Add(Me.IdMedicoTextBox)
        Me.Controls.Add(IdPacienteLabel)
        Me.Controls.Add(Me.IdPacienteTextBox)
        Me.Controls.Add(IdEnfermeraLabel)
        Me.Controls.Add(Me.IdEnfermeraTextBox)
        Me.Controls.Add(IdConsultorioLabel)
        Me.Controls.Add(Me.IdConsultorioTextBox)
        Me.Controls.Add(Me.RECETABindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRECETA"
        Me.Text = "frmRECETA"
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECETABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RECETABindingNavigator.ResumeLayout(False)
        Me.RECETABindingNavigator.PerformLayout()
        CType(Me.DETALLE_RECETABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLE_RECETADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecetasDataSet As BD_RecetasDataSet
    Friend WithEvents RECETABindingSource As BindingSource
    Friend WithEvents RECETATableAdapter As BD_RecetasDataSetTableAdapters.RECETATableAdapter
    Friend WithEvents TableAdapterManager As BD_RecetasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RECETABindingNavigator As BindingNavigator
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
    Friend WithEvents RECETABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DETALLE_RECETATableAdapter As BD_RecetasDataSetTableAdapters.DETALLE_RECETATableAdapter
    Friend WithEvents IdRecetaTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents IdMedicoTextBox As TextBox
    Friend WithEvents IdPacienteTextBox As TextBox
    Friend WithEvents IdEnfermeraTextBox As TextBox
    Friend WithEvents IdConsultorioTextBox As TextBox
    Friend WithEvents DETALLE_RECETABindingSource As BindingSource
    Friend WithEvents DETALLE_RECETADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
