<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FullViewForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QualityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhostDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DemonDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WitchDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BoogiemanDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GhoulDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HouseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CemetaryDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PrisonDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LighthouseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OtherDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DestinationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewDestinationDataSet = New FinalVBProject.ViewDestinationDataSet()
        Me.DestinationTableAdapter = New FinalVBProject.ViewDestinationDataSetTableAdapters.DestinationTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewDestinationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.QualityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.GhostDataGridViewCheckBoxColumn, Me.DemonDataGridViewCheckBoxColumn, Me.WitchDataGridViewCheckBoxColumn, Me.BoogiemanDataGridViewCheckBoxColumn, Me.GhoulDataGridViewCheckBoxColumn, Me.HouseDataGridViewCheckBoxColumn, Me.CemetaryDataGridViewCheckBoxColumn, Me.PrisonDataGridViewCheckBoxColumn, Me.LighthouseDataGridViewCheckBoxColumn, Me.OtherDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.DestinationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(444, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QualityDataGridViewTextBoxColumn
        '
        Me.QualityDataGridViewTextBoxColumn.DataPropertyName = "Quality"
        Me.QualityDataGridViewTextBoxColumn.HeaderText = "Quality"
        Me.QualityDataGridViewTextBoxColumn.Name = "QualityDataGridViewTextBoxColumn"
        Me.QualityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GhostDataGridViewCheckBoxColumn
        '
        Me.GhostDataGridViewCheckBoxColumn.DataPropertyName = "Ghost"
        Me.GhostDataGridViewCheckBoxColumn.HeaderText = "Ghost"
        Me.GhostDataGridViewCheckBoxColumn.Name = "GhostDataGridViewCheckBoxColumn"
        Me.GhostDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'DemonDataGridViewCheckBoxColumn
        '
        Me.DemonDataGridViewCheckBoxColumn.DataPropertyName = "Demon"
        Me.DemonDataGridViewCheckBoxColumn.HeaderText = "Demon"
        Me.DemonDataGridViewCheckBoxColumn.Name = "DemonDataGridViewCheckBoxColumn"
        Me.DemonDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'WitchDataGridViewCheckBoxColumn
        '
        Me.WitchDataGridViewCheckBoxColumn.DataPropertyName = "Witch"
        Me.WitchDataGridViewCheckBoxColumn.HeaderText = "Witch"
        Me.WitchDataGridViewCheckBoxColumn.Name = "WitchDataGridViewCheckBoxColumn"
        Me.WitchDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'BoogiemanDataGridViewCheckBoxColumn
        '
        Me.BoogiemanDataGridViewCheckBoxColumn.DataPropertyName = "Boogieman"
        Me.BoogiemanDataGridViewCheckBoxColumn.HeaderText = "Boogieman"
        Me.BoogiemanDataGridViewCheckBoxColumn.Name = "BoogiemanDataGridViewCheckBoxColumn"
        Me.BoogiemanDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'GhoulDataGridViewCheckBoxColumn
        '
        Me.GhoulDataGridViewCheckBoxColumn.DataPropertyName = "Ghoul"
        Me.GhoulDataGridViewCheckBoxColumn.HeaderText = "Ghoul"
        Me.GhoulDataGridViewCheckBoxColumn.Name = "GhoulDataGridViewCheckBoxColumn"
        Me.GhoulDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'HouseDataGridViewCheckBoxColumn
        '
        Me.HouseDataGridViewCheckBoxColumn.DataPropertyName = "House"
        Me.HouseDataGridViewCheckBoxColumn.HeaderText = "House"
        Me.HouseDataGridViewCheckBoxColumn.Name = "HouseDataGridViewCheckBoxColumn"
        Me.HouseDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CemetaryDataGridViewCheckBoxColumn
        '
        Me.CemetaryDataGridViewCheckBoxColumn.DataPropertyName = "Cemetary"
        Me.CemetaryDataGridViewCheckBoxColumn.HeaderText = "Cemetary"
        Me.CemetaryDataGridViewCheckBoxColumn.Name = "CemetaryDataGridViewCheckBoxColumn"
        Me.CemetaryDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PrisonDataGridViewCheckBoxColumn
        '
        Me.PrisonDataGridViewCheckBoxColumn.DataPropertyName = "Prison"
        Me.PrisonDataGridViewCheckBoxColumn.HeaderText = "Prison"
        Me.PrisonDataGridViewCheckBoxColumn.Name = "PrisonDataGridViewCheckBoxColumn"
        Me.PrisonDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'LighthouseDataGridViewCheckBoxColumn
        '
        Me.LighthouseDataGridViewCheckBoxColumn.DataPropertyName = "Lighthouse"
        Me.LighthouseDataGridViewCheckBoxColumn.HeaderText = "Lighthouse"
        Me.LighthouseDataGridViewCheckBoxColumn.Name = "LighthouseDataGridViewCheckBoxColumn"
        Me.LighthouseDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'OtherDataGridViewCheckBoxColumn
        '
        Me.OtherDataGridViewCheckBoxColumn.DataPropertyName = "Other"
        Me.OtherDataGridViewCheckBoxColumn.HeaderText = "Other"
        Me.OtherDataGridViewCheckBoxColumn.Name = "OtherDataGridViewCheckBoxColumn"
        Me.OtherDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'DestinationBindingSource
        '
        Me.DestinationBindingSource.DataMember = "Destination"
        Me.DestinationBindingSource.DataSource = Me.ViewDestinationDataSet
        '
        'ViewDestinationDataSet
        '
        Me.ViewDestinationDataSet.DataSetName = "ViewDestinationDataSet"
        Me.ViewDestinationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DestinationTableAdapter
        '
        Me.DestinationTableAdapter.ClearBeforeFill = True
        '
        'FullViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 178)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FullViewForm"
        Me.Text = "FullViewForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewDestinationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QualityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhostDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DemonDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents WitchDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BoogiemanDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GhoulDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HouseDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CemetaryDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PrisonDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LighthouseDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents OtherDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DestinationBindingSource As BindingSource
    Friend WithEvents ViewDestinationDataSet As ViewDestinationDataSet
    Friend WithEvents DestinationTableAdapter As ViewDestinationDataSetTableAdapters.DestinationTableAdapter
End Class
