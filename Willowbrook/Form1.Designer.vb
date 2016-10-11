<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBasicFee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAdditionalFeesTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkRacquetball = New System.Windows.Forms.CheckBox()
        Me.chkTennis = New System.Windows.Forms.CheckBox()
        Me.chkGolf = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Basic fee:"
        '
        'txtBasicFee
        '
        Me.txtBasicFee.Location = New System.Drawing.Point(15, 25)
        Me.txtBasicFee.Name = "txtBasicFee"
        Me.txtBasicFee.Size = New System.Drawing.Size(100, 20)
        Me.txtBasicFee.TabIndex = 1
        Me.txtBasicFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Additional fees:"
        '
        'lblAdditionalFeesTotal
        '
        Me.lblAdditionalFeesTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdditionalFeesTotal.Location = New System.Drawing.Point(15, 99)
        Me.lblAdditionalFeesTotal.Name = "lblAdditionalFeesTotal"
        Me.lblAdditionalFeesTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblAdditionalFeesTotal.TabIndex = 3
        Me.lblAdditionalFeesTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Monthly Dues:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(15, 165)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 78)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = " "
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkRacquetball)
        Me.GroupBox1.Controls.Add(Me.chkTennis)
        Me.GroupBox1.Controls.Add(Me.chkGolf)
        Me.GroupBox1.Location = New System.Drawing.Point(140, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 113)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Additional activities:"
        '
        'chkRacquetball
        '
        Me.chkRacquetball.AutoSize = True
        Me.chkRacquetball.Location = New System.Drawing.Point(21, 76)
        Me.chkRacquetball.Name = "chkRacquetball"
        Me.chkRacquetball.Size = New System.Drawing.Size(83, 17)
        Me.chkRacquetball.TabIndex = 2
        Me.chkRacquetball.Text = "&Racquetball"
        Me.chkRacquetball.UseVisualStyleBackColor = True
        '
        'chkTennis
        '
        Me.chkTennis.AutoSize = True
        Me.chkTennis.Location = New System.Drawing.Point(21, 53)
        Me.chkTennis.Name = "chkTennis"
        Me.chkTennis.Size = New System.Drawing.Size(58, 17)
        Me.chkTennis.TabIndex = 1
        Me.chkTennis.Text = "&Tennis"
        Me.chkTennis.UseVisualStyleBackColor = True
        '
        'chkGolf
        '
        Me.chkGolf.AutoSize = True
        Me.chkGolf.Location = New System.Drawing.Point(21, 30)
        Me.chkGolf.Name = "chkGolf"
        Me.chkGolf.Size = New System.Drawing.Size(45, 17)
        Me.chkGolf.TabIndex = 0
        Me.chkGolf.Text = "&Golf"
        Me.chkGolf.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(140, 128)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(132, 86)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(140, 220)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAdditionalFeesTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBasicFee)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Willowbrook Health Club"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBasicFee As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAdditionalFeesTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkRacquetball As CheckBox
    Friend WithEvents chkTennis As CheckBox
    Friend WithEvents chkGolf As CheckBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
