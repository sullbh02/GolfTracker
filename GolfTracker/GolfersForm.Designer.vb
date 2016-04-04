﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GolfersForm
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
        Me.dgvGolfers = New System.Windows.Forms.DataGridView()
        Me.GolferIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomeCourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GolfersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GolfDatabaseDataSet = New GolfTracker.GolfDatabaseDataSet()
        Me.GolfersTableAdapter = New GolfTracker.GolfDatabaseDataSetTableAdapters.GolfersTableAdapter()
        CType(Me.dgvGolfers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GolfersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GolfDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGolfers
        '
        Me.dgvGolfers.AutoGenerateColumns = False
        Me.dgvGolfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGolfers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GolferIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.HomeCourseDataGridViewTextBoxColumn})
        Me.dgvGolfers.DataSource = Me.GolfersBindingSource
        Me.dgvGolfers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGolfers.Location = New System.Drawing.Point(0, 0)
        Me.dgvGolfers.Name = "dgvGolfers"
        Me.dgvGolfers.Size = New System.Drawing.Size(342, 254)
        Me.dgvGolfers.TabIndex = 0
        '
        'GolferIdDataGridViewTextBoxColumn
        '
        Me.GolferIdDataGridViewTextBoxColumn.DataPropertyName = "GolferId"
        Me.GolferIdDataGridViewTextBoxColumn.HeaderText = "GolferId"
        Me.GolferIdDataGridViewTextBoxColumn.Name = "GolferIdDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'HomeCourseDataGridViewTextBoxColumn
        '
        Me.HomeCourseDataGridViewTextBoxColumn.DataPropertyName = "Home Course"
        Me.HomeCourseDataGridViewTextBoxColumn.HeaderText = "Home Course"
        Me.HomeCourseDataGridViewTextBoxColumn.Name = "HomeCourseDataGridViewTextBoxColumn"
        '
        'GolfersBindingSource
        '
        Me.GolfersBindingSource.DataMember = "Golfers"
        Me.GolfersBindingSource.DataSource = Me.GolfDatabaseDataSet
        '
        'GolfDatabaseDataSet
        '
        Me.GolfDatabaseDataSet.DataSetName = "GolfDatabaseDataSet"
        Me.GolfDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GolfersTableAdapter
        '
        Me.GolfersTableAdapter.ClearBeforeFill = True
        '
        'GolfersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 254)
        Me.Controls.Add(Me.dgvGolfers)
        Me.Name = "GolfersForm"
        Me.Text = "Golfers"
        CType(Me.dgvGolfers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GolfersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GolfDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvGolfers As DataGridView
    Friend WithEvents GolfDatabaseDataSet As GolfDatabaseDataSet
    Friend WithEvents GolfersBindingSource As BindingSource
    Friend WithEvents GolfersTableAdapter As GolfDatabaseDataSetTableAdapters.GolfersTableAdapter
    Friend WithEvents GolferIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HomeCourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
