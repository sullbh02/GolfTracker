<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoundResultsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoundResultsForm))
        Me.dgvStats = New System.Windows.Forms.DataGridView()
        Me.RoundIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseRatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SlopeRatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GolferIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GolfDatabaseDataSet = New GolfTracker.GolfDatabaseDataSet()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboGolfers = New System.Windows.Forms.ToolStripComboBox()
        Me.btnTest = New System.Windows.Forms.ToolStripButton()
        Me.StatsTableAdapter = New GolfTracker.GolfDatabaseDataSetTableAdapters.StatsTableAdapter()
        Me.RoundResultsFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GolfDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.RoundResultsFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStats
        '
        Me.dgvStats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStats.AutoGenerateColumns = False
        Me.dgvStats.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoundIdDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.ScoreDataGridViewTextBoxColumn, Me.CourseRatingDataGridViewTextBoxColumn, Me.SlopeRatingDataGridViewTextBoxColumn, Me.GolferIdDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.dgvStats.DataSource = Me.StatsBindingSource
        Me.dgvStats.Location = New System.Drawing.Point(12, 40)
        Me.dgvStats.Name = "dgvStats"
        Me.dgvStats.Size = New System.Drawing.Size(610, 134)
        Me.dgvStats.TabIndex = 0
        '
        'RoundIdDataGridViewTextBoxColumn
        '
        Me.RoundIdDataGridViewTextBoxColumn.DataPropertyName = "RoundId"
        Me.RoundIdDataGridViewTextBoxColumn.HeaderText = "RoundId"
        Me.RoundIdDataGridViewTextBoxColumn.Name = "RoundIdDataGridViewTextBoxColumn"
        Me.RoundIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'ScoreDataGridViewTextBoxColumn
        '
        Me.ScoreDataGridViewTextBoxColumn.DataPropertyName = "Score"
        Me.ScoreDataGridViewTextBoxColumn.HeaderText = "Score"
        Me.ScoreDataGridViewTextBoxColumn.Name = "ScoreDataGridViewTextBoxColumn"
        '
        'CourseRatingDataGridViewTextBoxColumn
        '
        Me.CourseRatingDataGridViewTextBoxColumn.DataPropertyName = "Course Rating"
        Me.CourseRatingDataGridViewTextBoxColumn.HeaderText = "Course Rating"
        Me.CourseRatingDataGridViewTextBoxColumn.Name = "CourseRatingDataGridViewTextBoxColumn"
        '
        'SlopeRatingDataGridViewTextBoxColumn
        '
        Me.SlopeRatingDataGridViewTextBoxColumn.DataPropertyName = "Slope Rating"
        Me.SlopeRatingDataGridViewTextBoxColumn.HeaderText = "Slope Rating"
        Me.SlopeRatingDataGridViewTextBoxColumn.Name = "SlopeRatingDataGridViewTextBoxColumn"
        '
        'GolferIdDataGridViewTextBoxColumn
        '
        Me.GolferIdDataGridViewTextBoxColumn.DataPropertyName = "GolferId"
        Me.GolferIdDataGridViewTextBoxColumn.HeaderText = "GolferId"
        Me.GolferIdDataGridViewTextBoxColumn.Name = "GolferIdDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'StatsBindingSource
        '
        Me.StatsBindingSource.DataMember = "Stats"
        Me.StatsBindingSource.DataSource = Me.GolfDatabaseDataSet
        '
        'GolfDatabaseDataSet
        '
        Me.GolfDatabaseDataSet.DataSetName = "GolfDatabaseDataSet"
        Me.GolfDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAll, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cboGolfers, Me.btnTest})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(634, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAll
        '
        Me.btnAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAll.Image = CType(resources.GetObject("btnAll.Image"), System.Drawing.Image)
        Me.btnAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(31, 22)
        Me.btnAll.Text = "ALL"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Name:"
        '
        'cboGolfers
        '
        Me.cboGolfers.Name = "cboGolfers"
        Me.cboGolfers.Size = New System.Drawing.Size(121, 25)
        '
        'btnTest
        '
        Me.btnTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnTest.Image = CType(resources.GetObject("btnTest.Image"), System.Drawing.Image)
        Me.btnTest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(69, 22)
        Me.btnTest.Text = "# of Scores"
        '
        'StatsTableAdapter
        '
        Me.StatsTableAdapter.ClearBeforeFill = True
        '
        'RoundResultsFormBindingSource
        '
        Me.RoundResultsFormBindingSource.DataSource = GetType(GolfTracker.RoundResultsForm)
        '
        'RoundResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 299)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvStats)
        Me.Name = "RoundResultsForm"
        Me.Text = "Round Results"
        CType(Me.dgvStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GolfDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.RoundResultsFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvStats As DataGridView
    Friend WithEvents cboGolfers As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnAll As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnTest As ToolStripButton
    Friend WithEvents RoundResultsFormBindingSource As BindingSource
    Friend WithEvents GolfDatabaseDataSet As GolfDatabaseDataSet
    Friend WithEvents StatsBindingSource As BindingSource
    Friend WithEvents StatsTableAdapter As GolfDatabaseDataSetTableAdapters.StatsTableAdapter
    Friend WithEvents RoundIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScoreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseRatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SlopeRatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GolferIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
