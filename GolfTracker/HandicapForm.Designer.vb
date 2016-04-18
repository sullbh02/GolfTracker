<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HandicapForm
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
        Me.dgvHandicap = New System.Windows.Forms.DataGridView()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblDifferential = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLow = New System.Windows.Forms.Label()
        CType(Me.dgvHandicap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHandicap
        '
        Me.dgvHandicap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHandicap.Location = New System.Drawing.Point(138, 122)
        Me.dgvHandicap.Name = "dgvHandicap"
        Me.dgvHandicap.Size = New System.Drawing.Size(10, 10)
        Me.dgvHandicap.TabIndex = 0
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(112, 9)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(0, 13)
        Me.lblCount.TabIndex = 2
        '
        'lblDifferential
        '
        Me.lblDifferential.AutoSize = True
        Me.lblDifferential.Location = New System.Drawing.Point(112, 50)
        Me.lblDifferential.Name = "lblDifferential"
        Me.lblDifferential.Size = New System.Drawing.Size(0, 13)
        Me.lblDifferential.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Handicap Index:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Number of Rounds: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Lowest Score: "
        '
        'lblLow
        '
        Me.lblLow.AutoSize = True
        Me.lblLow.Location = New System.Drawing.Point(112, 32)
        Me.lblLow.Name = "lblLow"
        Me.lblLow.Size = New System.Drawing.Size(0, 13)
        Me.lblLow.TabIndex = 8
        '
        'HandicapForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 151)
        Me.Controls.Add(Me.lblLow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDifferential)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.dgvHandicap)
        Me.Name = "HandicapForm"
        Me.Text = "Handicap"
        CType(Me.dgvHandicap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHandicap As DataGridView
    Friend WithEvents lblCount As Label
    Friend WithEvents lblDifferential As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLow As Label
End Class
