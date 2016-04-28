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
        Me.StatsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GolfDatabaseDataSet = New GolfTracker.GolfDatabaseDataSet()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboGolfers = New System.Windows.Forms.ToolStripComboBox()
        Me.btnTest = New System.Windows.Forms.ToolStripButton()
        Me.btnHandicap = New System.Windows.Forms.ToolStripButton()
        Me.StatsTableAdapter = New GolfTracker.GolfDatabaseDataSetTableAdapters.StatsTableAdapter()
        Me.lblLow = New System.Windows.Forms.Label()
        Me.lblDifferential = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RoundIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseRatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SlopeRatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GolferIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoundResultsFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAll, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cboGolfers, Me.btnTest, Me.btnHandicap, Me.ToolStripButton1})
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
        'btnHandicap
        '
        Me.btnHandicap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnHandicap.Image = CType(resources.GetObject("btnHandicap.Image"), System.Drawing.Image)
        Me.btnHandicap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHandicap.Name = "btnHandicap"
        Me.btnHandicap.Size = New System.Drawing.Size(112, 22)
        Me.btnHandicap.Text = "Generate Handicap"
        '
        'StatsTableAdapter
        '
        Me.StatsTableAdapter.ClearBeforeFill = True
        '
        'lblLow
        '
        Me.lblLow.AutoSize = True
        Me.lblLow.Location = New System.Drawing.Point(123, 199)
        Me.lblLow.Name = "lblLow"
        Me.lblLow.Size = New System.Drawing.Size(0, 13)
        Me.lblLow.TabIndex = 3
        '
        'lblDifferential
        '
        Me.lblDifferential.AutoSize = True
        Me.lblDifferential.Location = New System.Drawing.Point(123, 223)
        Me.lblDifferential.Name = "lblDifferential"
        Me.lblDifferential.Size = New System.Drawing.Size(0, 13)
        Me.lblDifferential.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Lowest Score: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Handicap: "
        '
        'RoundIdDataGridViewTextBoxColumn
        '
        Me.RoundIdDataGridViewTextBoxColumn.DataPropertyName = "RoundId"
        Me.RoundIdDataGridViewTextBoxColumn.HeaderText = "RoundId"
        Me.RoundIdDataGridViewTextBoxColumn.Name = "RoundIdDataGridViewTextBoxColumn"
        Me.RoundIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoundIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ScoreDataGridViewTextBoxColumn
        '
        Me.ScoreDataGridViewTextBoxColumn.DataPropertyName = "Score"
        Me.ScoreDataGridViewTextBoxColumn.HeaderText = "Score"
        Me.ScoreDataGridViewTextBoxColumn.Name = "ScoreDataGridViewTextBoxColumn"
        Me.ScoreDataGridViewTextBoxColumn.ReadOnly = True
        Me.ScoreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CourseRatingDataGridViewTextBoxColumn
        '
        Me.CourseRatingDataGridViewTextBoxColumn.DataPropertyName = "Course Rating"
        Me.CourseRatingDataGridViewTextBoxColumn.HeaderText = "Course Rating"
        Me.CourseRatingDataGridViewTextBoxColumn.Name = "CourseRatingDataGridViewTextBoxColumn"
        Me.CourseRatingDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseRatingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SlopeRatingDataGridViewTextBoxColumn
        '
        Me.SlopeRatingDataGridViewTextBoxColumn.DataPropertyName = "Slope Rating"
        Me.SlopeRatingDataGridViewTextBoxColumn.HeaderText = "Slope Rating"
        Me.SlopeRatingDataGridViewTextBoxColumn.Name = "SlopeRatingDataGridViewTextBoxColumn"
        Me.SlopeRatingDataGridViewTextBoxColumn.ReadOnly = True
        Me.SlopeRatingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'GolferIdDataGridViewTextBoxColumn
        '
        Me.GolferIdDataGridViewTextBoxColumn.DataPropertyName = "GolferId"
        Me.GolferIdDataGridViewTextBoxColumn.HeaderText = "GolferId"
        Me.GolferIdDataGridViewTextBoxColumn.Name = "GolferIdDataGridViewTextBoxColumn"
        Me.GolferIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.GolferIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'RoundResultsFormBindingSource
        '
        Me.RoundResultsFormBindingSource.DataSource = GetType(GolfTracker.RoundResultsForm)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButton1.Text = "Delete"
        '
        'RoundResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 299)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDifferential)
        Me.Controls.Add(Me.lblLow)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvStats)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents btnHandicap As ToolStripButton
    Friend WithEvents lblLow As Label
    Friend WithEvents lblDifferential As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScoreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseRatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SlopeRatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GolferIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
