<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoundsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HandicapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GolfersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StatisticsToolStripMenuItem, Me.GolfersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatisticsToolStripMenuItem
        '
        Me.StatisticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem"
        Me.StatisticsToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.StatisticsToolStripMenuItem.Text = "Statistics"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoundToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'RoundToolStripMenuItem
        '
        Me.RoundToolStripMenuItem.Name = "RoundToolStripMenuItem"
        Me.RoundToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.RoundToolStripMenuItem.Text = "Round"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoundsToolStripMenuItem, Me.HandicapToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'RoundsToolStripMenuItem
        '
        Me.RoundsToolStripMenuItem.Name = "RoundsToolStripMenuItem"
        Me.RoundsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.RoundsToolStripMenuItem.Text = "Rounds"
        '
        'HandicapToolStripMenuItem
        '
        Me.HandicapToolStripMenuItem.Name = "HandicapToolStripMenuItem"
        Me.HandicapToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.HandicapToolStripMenuItem.Text = "Handicap"
        '
        'GolfersToolStripMenuItem
        '
        Me.GolfersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem1, Me.AddToolStripMenuItem})
        Me.GolfersToolStripMenuItem.Name = "GolfersToolStripMenuItem"
        Me.GolfersToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.GolfersToolStripMenuItem.Text = "Golfers"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ViewToolStripMenuItem1.Text = "View"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Golf Tracker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoundsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GolfersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HandicapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
End Class
