<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPACIENTE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPACIENTE))
        Dim IdPacienteLabel As System.Windows.Forms.Label
        Dim NamePacienteLabel As System.Windows.Forms.Label
        Dim NroHistoriaLabel As System.Windows.Forms.Label
        Dim TipoSangreLabel As System.Windows.Forms.Label
        Dim FechaNacimientoLabel As System.Windows.Forms.Label
        Me.BD_RecetasDataSet = New WinAppRecetas.BD_RecetasDataSet()
        Me.PACIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PACIENTETableAdapter = New WinAppRecetas.BD_RecetasDataSetTableAdapters.PACIENTETableAdapter()
        Me.TableAdapterManager = New WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager()
        Me.PACIENTEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PACIENTEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPacienteTextBox = New System.Windows.Forms.TextBox()
        Me.NamePacienteTextBox = New System.Windows.Forms.TextBox()
        Me.NroHistoriaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoSangreTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        IdPacienteLabel = New System.Windows.Forms.Label()
        NamePacienteLabel = New System.Windows.Forms.Label()
        NroHistoriaLabel = New System.Windows.Forms.Label()
        TipoSangreLabel = New System.Windows.Forms.Label()
        FechaNacimientoLabel = New System.Windows.Forms.Label()
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PACIENTEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PACIENTEBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BD_RecetasDataSet
        '
        Me.BD_RecetasDataSet.DataSetName = "BD_RecetasDataSet"
        Me.BD_RecetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PACIENTEBindingSource
        '
        Me.PACIENTEBindingSource.DataMember = "PACIENTE"
        Me.PACIENTEBindingSource.DataSource = Me.BD_RecetasDataSet
        '
        'PACIENTETableAdapter
        '
        Me.PACIENTETableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.MEDICOTableAdapter = Nothing
        Me.TableAdapterManager.PACIENTETableAdapter = Me.PACIENTETableAdapter
        Me.TableAdapterManager.RECETATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WinAppRecetas.BD_RecetasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PACIENTEBindingNavigator
        '
        Me.PACIENTEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PACIENTEBindingNavigator.BindingSource = Me.PACIENTEBindingSource
        Me.PACIENTEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PACIENTEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PACIENTEBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.PACIENTEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PACIENTEBindingNavigatorSaveItem})
        Me.PACIENTEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PACIENTEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PACIENTEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PACIENTEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PACIENTEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PACIENTEBindingNavigator.Name = "PACIENTEBindingNavigator"
        Me.PACIENTEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PACIENTEBindingNavigator.Size = New System.Drawing.Size(545, 31)
        Me.PACIENTEBindingNavigator.TabIndex = 0
        Me.PACIENTEBindingNavigator.Text = "BindingNavigator1"
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
        'PACIENTEBindingNavigatorSaveItem
        '
        Me.PACIENTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PACIENTEBindingNavigatorSaveItem.Image = CType(resources.GetObject("PACIENTEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PACIENTEBindingNavigatorSaveItem.Name = "PACIENTEBindingNavigatorSaveItem"
        Me.PACIENTEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PACIENTEBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPacienteLabel
        '
        IdPacienteLabel.AutoSize = True
        IdPacienteLabel.Location = New System.Drawing.Point(82, 79)
        IdPacienteLabel.Name = "IdPacienteLabel"
        IdPacienteLabel.Size = New System.Drawing.Size(93, 20)
        IdPacienteLabel.TabIndex = 1
        IdPacienteLabel.Text = "Id Paciente:"
        '
        'IdPacienteTextBox
        '
        Me.IdPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTEBindingSource, "IdPaciente", True))
        Me.IdPacienteTextBox.Location = New System.Drawing.Point(229, 76)
        Me.IdPacienteTextBox.Name = "IdPacienteTextBox"
        Me.IdPacienteTextBox.Size = New System.Drawing.Size(44, 26)
        Me.IdPacienteTextBox.TabIndex = 2
        '
        'NamePacienteLabel
        '
        NamePacienteLabel.AutoSize = True
        NamePacienteLabel.Location = New System.Drawing.Point(82, 121)
        NamePacienteLabel.Name = "NamePacienteLabel"
        NamePacienteLabel.Size = New System.Drawing.Size(121, 20)
        NamePacienteLabel.TabIndex = 3
        NamePacienteLabel.Text = "Name Paciente:"
        '
        'NamePacienteTextBox
        '
        Me.NamePacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTEBindingSource, "NamePaciente", True))
        Me.NamePacienteTextBox.Location = New System.Drawing.Point(229, 118)
        Me.NamePacienteTextBox.Name = "NamePacienteTextBox"
        Me.NamePacienteTextBox.Size = New System.Drawing.Size(304, 26)
        Me.NamePacienteTextBox.TabIndex = 4
        '
        'NroHistoriaLabel
        '
        NroHistoriaLabel.AutoSize = True
        NroHistoriaLabel.Location = New System.Drawing.Point(82, 168)
        NroHistoriaLabel.Name = "NroHistoriaLabel"
        NroHistoriaLabel.Size = New System.Drawing.Size(96, 20)
        NroHistoriaLabel.TabIndex = 5
        NroHistoriaLabel.Text = "Nro Historia:"
        '
        'NroHistoriaTextBox
        '
        Me.NroHistoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTEBindingSource, "NroHistoria", True))
        Me.NroHistoriaTextBox.Location = New System.Drawing.Point(229, 165)
        Me.NroHistoriaTextBox.Name = "NroHistoriaTextBox"
        Me.NroHistoriaTextBox.Size = New System.Drawing.Size(62, 26)
        Me.NroHistoriaTextBox.TabIndex = 6
        '
        'TipoSangreLabel
        '
        TipoSangreLabel.AutoSize = True
        TipoSangreLabel.Location = New System.Drawing.Point(82, 214)
        TipoSangreLabel.Name = "TipoSangreLabel"
        TipoSangreLabel.Size = New System.Drawing.Size(99, 20)
        TipoSangreLabel.TabIndex = 7
        TipoSangreLabel.Text = "Tipo Sangre:"
        '
        'TipoSangreTextBox
        '
        Me.TipoSangreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PACIENTEBindingSource, "TipoSangre", True))
        Me.TipoSangreTextBox.Location = New System.Drawing.Point(229, 211)
        Me.TipoSangreTextBox.Name = "TipoSangreTextBox"
        Me.TipoSangreTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TipoSangreTextBox.TabIndex = 8
        '
        'FechaNacimientoLabel
        '
        FechaNacimientoLabel.AutoSize = True
        FechaNacimientoLabel.Location = New System.Drawing.Point(82, 261)
        FechaNacimientoLabel.Name = "FechaNacimientoLabel"
        FechaNacimientoLabel.Size = New System.Drawing.Size(141, 20)
        FechaNacimientoLabel.TabIndex = 9
        FechaNacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'FechaNacimientoDateTimePicker
        '
        Me.FechaNacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PACIENTEBindingSource, "FechaNacimiento", True))
        Me.FechaNacimientoDateTimePicker.Location = New System.Drawing.Point(229, 257)
        Me.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker"
        Me.FechaNacimientoDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.FechaNacimientoDateTimePicker.TabIndex = 10
        '
        'frmPACIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 532)
        Me.Controls.Add(IdPacienteLabel)
        Me.Controls.Add(Me.IdPacienteTextBox)
        Me.Controls.Add(NamePacienteLabel)
        Me.Controls.Add(Me.NamePacienteTextBox)
        Me.Controls.Add(NroHistoriaLabel)
        Me.Controls.Add(Me.NroHistoriaTextBox)
        Me.Controls.Add(TipoSangreLabel)
        Me.Controls.Add(Me.TipoSangreTextBox)
        Me.Controls.Add(FechaNacimientoLabel)
        Me.Controls.Add(Me.FechaNacimientoDateTimePicker)
        Me.Controls.Add(Me.PACIENTEBindingNavigator)
        Me.Name = "frmPACIENTE"
        Me.Text = "frmPACIENTE"
        CType(Me.BD_RecetasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PACIENTEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PACIENTEBindingNavigator.ResumeLayout(False)
        Me.PACIENTEBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_RecetasDataSet As BD_RecetasDataSet
    Friend WithEvents PACIENTEBindingSource As BindingSource
    Friend WithEvents PACIENTETableAdapter As BD_RecetasDataSetTableAdapters.PACIENTETableAdapter
    Friend WithEvents TableAdapterManager As BD_RecetasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PACIENTEBindingNavigator As BindingNavigator
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
    Friend WithEvents PACIENTEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdPacienteTextBox As TextBox
    Friend WithEvents NamePacienteTextBox As TextBox
    Friend WithEvents NroHistoriaTextBox As TextBox
    Friend WithEvents TipoSangreTextBox As TextBox
    Friend WithEvents FechaNacimientoDateTimePicker As DateTimePicker
End Class
