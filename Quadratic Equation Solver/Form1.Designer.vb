<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl0 = New System.Windows.Forms.Label()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.txtCoeffa = New System.Windows.Forms.TextBox()
        Me.txtCoeffb = New System.Windows.Forms.TextBox()
        Me.txtCoeffc = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl0
        '
        Me.lbl0.AutoSize = True
        Me.lbl0.Location = New System.Drawing.Point(204, 15)
        Me.lbl0.Name = "lbl0"
        Me.lbl0.Size = New System.Drawing.Size(22, 13)
        Me.lbl0.TabIndex = 0
        Me.lbl0.Text = "= 0"
        '
        'lblX2
        '
        Me.lblX2.AutoSize = True
        Me.lblX2.Location = New System.Drawing.Point(57, 15)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.Size = New System.Drawing.Size(24, 13)
        Me.lblX2.TabIndex = 2
        Me.lblX2.Text = "x² +"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(132, 15)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(21, 13)
        Me.lblX.TabIndex = 4
        Me.lblX.Text = "x +"
        '
        'txtCoeffa
        '
        Me.txtCoeffa.Location = New System.Drawing.Point(12, 12)
        Me.txtCoeffa.Name = "txtCoeffa"
        Me.txtCoeffa.Size = New System.Drawing.Size(39, 20)
        Me.txtCoeffa.TabIndex = 5
        '
        'txtCoeffb
        '
        Me.txtCoeffb.Location = New System.Drawing.Point(87, 12)
        Me.txtCoeffb.Name = "txtCoeffb"
        Me.txtCoeffb.Size = New System.Drawing.Size(39, 20)
        Me.txtCoeffb.TabIndex = 6
        '
        'txtCoeffc
        '
        Me.txtCoeffc.Location = New System.Drawing.Point(159, 12)
        Me.txtCoeffc.Name = "txtCoeffc"
        Me.txtCoeffc.Size = New System.Drawing.Size(39, 20)
        Me.txtCoeffc.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 38)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(108, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate the roots!"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(126, 38)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(64, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(196, 38)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCoeffc)
        Me.Controls.Add(Me.txtCoeffb)
        Me.Controls.Add(Me.txtCoeffa)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblX2)
        Me.Controls.Add(Me.lbl0)
        Me.Name = "Form1"
        Me.Text = "a"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl0 As System.Windows.Forms.Label
    Friend WithEvents lblX2 As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents txtCoeffa As System.Windows.Forms.TextBox
    Friend WithEvents txtCoeffb As System.Windows.Forms.TextBox
    Friend WithEvents txtCoeffc As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
