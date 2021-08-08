<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDestinationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim QualityLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Me.DestinationDatabaseDataSet = New FinalVBProject.DestinationDatabaseDataSet()
        Me.DestinationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DestinationTableAdapter = New FinalVBProject.DestinationDatabaseDataSetTableAdapters.DestinationTableAdapter()
        Me.TableAdapterManager = New FinalVBProject.DestinationDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAndCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseWithoutSavingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.QualityTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.GhostCheckBox = New System.Windows.Forms.CheckBox()
        Me.DemonCheckBox = New System.Windows.Forms.CheckBox()
        Me.WitchCheckBox = New System.Windows.Forms.CheckBox()
        Me.BoogiemanCheckBox = New System.Windows.Forms.CheckBox()
        Me.GhoulCheckBox = New System.Windows.Forms.CheckBox()
        Me.HouseRadioButton = New System.Windows.Forms.RadioButton()
        Me.CemetaryRadioButton = New System.Windows.Forms.RadioButton()
        Me.PrisonRadioButton = New System.Windows.Forms.RadioButton()
        Me.LighthouseRadioButton = New System.Windows.Forms.RadioButton()
        Me.OtherRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        QualityLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.DestinationDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Chiller", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(15, 26)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 20)
        NameLabel.TabIndex = 29
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Chiller", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(15, 52)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 20)
        AddressLabel.TabIndex = 31
        AddressLabel.Text = "Address:"
        '
        'QualityLabel
        '
        QualityLabel.AutoSize = True
        QualityLabel.Font = New System.Drawing.Font("Chiller", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QualityLabel.Location = New System.Drawing.Point(15, 78)
        QualityLabel.Name = "QualityLabel"
        QualityLabel.Size = New System.Drawing.Size(81, 20)
        QualityLabel.TabIndex = 33
        QualityLabel.Text = "Quality (1-5):"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Chiller", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.Location = New System.Drawing.Point(15, 104)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(70, 20)
        PriceLabel.TabIndex = 35
        PriceLabel.Text = "Price (1-5):"
        '
        'DestinationDatabaseDataSet
        '
        Me.DestinationDatabaseDataSet.DataSetName = "DestinationDatabaseDataSet"
        Me.DestinationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DestinationBindingSource
        '
        Me.DestinationBindingSource.DataMember = "Destination"
        Me.DestinationBindingSource.DataSource = Me.DestinationDatabaseDataSet
        '
        'DestinationTableAdapter
        '
        Me.DestinationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DestinationTableAdapter = Me.DestinationTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalVBProject.DestinationDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(264, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAndCloseToolStripMenuItem, Me.CloseWithoutSavingToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveAndCloseToolStripMenuItem
        '
        Me.SaveAndCloseToolStripMenuItem.Name = "SaveAndCloseToolStripMenuItem"
        Me.SaveAndCloseToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SaveAndCloseToolStripMenuItem.Text = "Save and Close"
        '
        'CloseWithoutSavingToolStripMenuItem
        '
        Me.CloseWithoutSavingToolStripMenuItem.Name = "CloseWithoutSavingToolStripMenuItem"
        Me.CloseWithoutSavingToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CloseWithoutSavingToolStripMenuItem.Text = "Close without Saving"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DestinationBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(84, 27)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(158, 20)
        Me.NameTextBox.TabIndex = 30
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DestinationBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(84, 53)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(158, 20)
        Me.AddressTextBox.TabIndex = 32
        '
        'QualityTextBox
        '
        Me.QualityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DestinationBindingSource, "Quality", True))
        Me.QualityTextBox.Location = New System.Drawing.Point(100, 80)
        Me.QualityTextBox.Name = "QualityTextBox"
        Me.QualityTextBox.Size = New System.Drawing.Size(104, 20)
        Me.QualityTextBox.TabIndex = 34
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DestinationBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(100, 105)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PriceTextBox.TabIndex = 36
        '
        'GhostCheckBox
        '
        Me.GhostCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DestinationBindingSource, "Ghost", True))
        Me.GhostCheckBox.Location = New System.Drawing.Point(4, 19)
        Me.GhostCheckBox.Name = "GhostCheckBox"
        Me.GhostCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.GhostCheckBox.TabIndex = 38
        Me.GhostCheckBox.Text = "Ghost"
        Me.GhostCheckBox.UseVisualStyleBackColor = True
        '
        'DemonCheckBox
        '
        Me.DemonCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DestinationBindingSource, "Demon", True))
        Me.DemonCheckBox.Location = New System.Drawing.Point(4, 49)
        Me.DemonCheckBox.Name = "DemonCheckBox"
        Me.DemonCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DemonCheckBox.TabIndex = 40
        Me.DemonCheckBox.Text = "Demon"
        Me.DemonCheckBox.UseVisualStyleBackColor = True
        '
        'WitchCheckBox
        '
        Me.WitchCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DestinationBindingSource, "Witch", True))
        Me.WitchCheckBox.Location = New System.Drawing.Point(4, 79)
        Me.WitchCheckBox.Name = "WitchCheckBox"
        Me.WitchCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.WitchCheckBox.TabIndex = 42
        Me.WitchCheckBox.Text = "Witch"
        Me.WitchCheckBox.UseVisualStyleBackColor = True
        '
        'BoogiemanCheckBox
        '
        Me.BoogiemanCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DestinationBindingSource, "Boogieman", True))
        Me.BoogiemanCheckBox.Location = New System.Drawing.Point(4, 109)
        Me.BoogiemanCheckBox.Name = "BoogiemanCheckBox"
        Me.BoogiemanCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.BoogiemanCheckBox.TabIndex = 44
        Me.BoogiemanCheckBox.Text = "Boogieman"
        Me.BoogiemanCheckBox.UseVisualStyleBackColor = True
        '
        'GhoulCheckBox
        '
        Me.GhoulCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DestinationBindingSource, "Ghoul", True))
        Me.GhoulCheckBox.Location = New System.Drawing.Point(4, 139)
        Me.GhoulCheckBox.Name = "GhoulCheckBox"
        Me.GhoulCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.GhoulCheckBox.TabIndex = 46
        Me.GhoulCheckBox.Text = "Ghoul"
        Me.GhoulCheckBox.UseVisualStyleBackColor = True
        '
        'HouseRadioButton
        '
        Me.HouseRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DestinationBindingSource, "House", True))
        Me.HouseRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.HouseRadioButton.Name = "HouseRadioButton"
        Me.HouseRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.HouseRadioButton.TabIndex = 48
        Me.HouseRadioButton.TabStop = True
        Me.HouseRadioButton.Text = "House"
        Me.HouseRadioButton.UseVisualStyleBackColor = True
        '
        'CemetaryRadioButton
        '
        Me.CemetaryRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DestinationBindingSource, "Cemetary", True))
        Me.CemetaryRadioButton.Location = New System.Drawing.Point(6, 49)
        Me.CemetaryRadioButton.Name = "CemetaryRadioButton"
        Me.CemetaryRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.CemetaryRadioButton.TabIndex = 50
        Me.CemetaryRadioButton.TabStop = True
        Me.CemetaryRadioButton.Text = "Cemetary"
        Me.CemetaryRadioButton.UseVisualStyleBackColor = True
        '
        'PrisonRadioButton
        '
        Me.PrisonRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DestinationBindingSource, "Prison", True))
        Me.PrisonRadioButton.Location = New System.Drawing.Point(4, 79)
        Me.PrisonRadioButton.Name = "PrisonRadioButton"
        Me.PrisonRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.PrisonRadioButton.TabIndex = 52
        Me.PrisonRadioButton.TabStop = True
        Me.PrisonRadioButton.Text = "Prison"
        Me.PrisonRadioButton.UseVisualStyleBackColor = True
        '
        'LighthouseRadioButton
        '
        Me.LighthouseRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DestinationBindingSource, "Lighthouse", True))
        Me.LighthouseRadioButton.Location = New System.Drawing.Point(4, 109)
        Me.LighthouseRadioButton.Name = "LighthouseRadioButton"
        Me.LighthouseRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.LighthouseRadioButton.TabIndex = 54
        Me.LighthouseRadioButton.TabStop = True
        Me.LighthouseRadioButton.Text = "Lighthouse"
        Me.LighthouseRadioButton.UseVisualStyleBackColor = True
        '
        'OtherRadioButton
        '
        Me.OtherRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DestinationBindingSource, "Other", True))
        Me.OtherRadioButton.Location = New System.Drawing.Point(4, 138)
        Me.OtherRadioButton.Name = "OtherRadioButton"
        Me.OtherRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.OtherRadioButton.TabIndex = 56
        Me.OtherRadioButton.TabStop = True
        Me.OtherRadioButton.Text = "Other"
        Me.OtherRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HouseRadioButton)
        Me.GroupBox1.Controls.Add(Me.CemetaryRadioButton)
        Me.GroupBox1.Controls.Add(Me.PrisonRadioButton)
        Me.GroupBox1.Controls.Add(Me.LighthouseRadioButton)
        Me.GroupBox1.Controls.Add(Me.OtherRadioButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Chiller", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(138, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 168)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destination Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GhostCheckBox)
        Me.GroupBox2.Controls.Add(Me.DemonCheckBox)
        Me.GroupBox2.Controls.Add(Me.WitchCheckBox)
        Me.GroupBox2.Controls.Add(Me.BoogiemanCheckBox)
        Me.GroupBox2.Controls.Add(Me.GhoulCheckBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Chiller", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(114, 169)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Haunt Type"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(9, 310)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 45)
        Me.btnSave.TabIndex = 59
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(134, 311)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(114, 43)
        Me.btnCancel.TabIndex = 60
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AddDestinationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 367)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(QualityLabel)
        Me.Controls.Add(Me.QualityTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AddDestinationForm"
        Me.Text = "Add Destination"
        CType(Me.DestinationDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DestinationDatabaseDataSet As DestinationDatabaseDataSet
    Friend WithEvents DestinationBindingSource As BindingSource
    Friend WithEvents DestinationTableAdapter As DestinationDatabaseDataSetTableAdapters.DestinationTableAdapter
    Friend WithEvents TableAdapterManager As DestinationDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAndCloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseWithoutSavingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents QualityTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents GhostCheckBox As CheckBox
    Friend WithEvents DemonCheckBox As CheckBox
    Friend WithEvents WitchCheckBox As CheckBox
    Friend WithEvents BoogiemanCheckBox As CheckBox
    Friend WithEvents GhoulCheckBox As CheckBox
    Friend WithEvents HouseRadioButton As RadioButton
    Friend WithEvents CemetaryRadioButton As RadioButton
    Friend WithEvents PrisonRadioButton As RadioButton
    Friend WithEvents LighthouseRadioButton As RadioButton
    Friend WithEvents OtherRadioButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
