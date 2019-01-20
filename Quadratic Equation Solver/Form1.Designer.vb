<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuadraticEquationSolver
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
        Me.lblStep01 = New System.Windows.Forms.Label()
        Me.lblDiscriminantEquals = New System.Windows.Forms.Label()
        Me.txtDiscriminantVal = New System.Windows.Forms.TextBox()
        Me.txtDiscriminantPosOrNegValue = New System.Windows.Forms.TextBox()
        Me.lblDiscriminantPosOrNeg = New System.Windows.Forms.Label()
        Me.lblStep02 = New System.Windows.Forms.Label()
        Me.txtNatureOfRoots = New System.Windows.Forms.TextBox()
        Me.lblNatureOfRoots = New System.Windows.Forms.Label()
        Me.lblRoots = New System.Windows.Forms.Label()
        Me.txtRoot01 = New System.Windows.Forms.TextBox()
        Me.txtRoot02 = New System.Windows.Forms.TextBox()
        Me.lblAnd = New System.Windows.Forms.Label()
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
        'lblStep01
        '
        Me.lblStep01.AutoSize = True
        Me.lblStep01.Location = New System.Drawing.Point(13, 68)
        Me.lblStep01.Name = "lblStep01"
        Me.lblStep01.Size = New System.Drawing.Size(146, 13)
        Me.lblStep01.TabIndex = 11
        Me.lblStep01.Text = "Step 1: Calculate discriminant"
        '
        'lblDiscriminantEquals
        '
        Me.lblDiscriminantEquals.AutoSize = True
        Me.lblDiscriminantEquals.Location = New System.Drawing.Point(37, 92)
        Me.lblDiscriminantEquals.Name = "lblDiscriminantEquals"
        Me.lblDiscriminantEquals.Size = New System.Drawing.Size(72, 13)
        Me.lblDiscriminantEquals.TabIndex = 12
        Me.lblDiscriminantEquals.Text = "D = b² - 4ac ="
        '
        'txtDiscriminantVal
        '
        Me.txtDiscriminantVal.Location = New System.Drawing.Point(115, 89)
        Me.txtDiscriminantVal.Name = "txtDiscriminantVal"
        Me.txtDiscriminantVal.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscriminantVal.TabIndex = 13
        '
        'txtDiscriminantPosOrNegValue
        '
        Me.txtDiscriminantPosOrNegValue.Location = New System.Drawing.Point(164, 143)
        Me.txtDiscriminantPosOrNegValue.Name = "txtDiscriminantPosOrNegValue"
        Me.txtDiscriminantPosOrNegValue.Size = New System.Drawing.Size(97, 20)
        Me.txtDiscriminantPosOrNegValue.TabIndex = 16
        '
        'lblDiscriminantPosOrNeg
        '
        Me.lblDiscriminantPosOrNeg.AutoSize = True
        Me.lblDiscriminantPosOrNeg.Location = New System.Drawing.Point(37, 146)
        Me.lblDiscriminantPosOrNeg.Name = "lblDiscriminantPosOrNeg"
        Me.lblDiscriminantPosOrNeg.Size = New System.Drawing.Size(114, 13)
        Me.lblDiscriminantPosOrNeg.TabIndex = 15
        Me.lblDiscriminantPosOrNeg.Text = "Value of discriminant is"
        '
        'lblStep02
        '
        Me.lblStep02.AutoSize = True
        Me.lblStep02.Location = New System.Drawing.Point(13, 122)
        Me.lblStep02.Name = "lblStep02"
        Me.lblStep02.Size = New System.Drawing.Size(118, 13)
        Me.lblStep02.TabIndex = 14
        Me.lblStep02.Text = "Step 2: Determine roots"
        '
        'txtNatureOfRoots
        '
        Me.txtNatureOfRoots.Location = New System.Drawing.Point(164, 169)
        Me.txtNatureOfRoots.Name = "txtNatureOfRoots"
        Me.txtNatureOfRoots.Size = New System.Drawing.Size(97, 20)
        Me.txtNatureOfRoots.TabIndex = 18
        '
        'lblNatureOfRoots
        '
        Me.lblNatureOfRoots.AutoSize = True
        Me.lblNatureOfRoots.Location = New System.Drawing.Point(37, 172)
        Me.lblNatureOfRoots.Name = "lblNatureOfRoots"
        Me.lblNatureOfRoots.Size = New System.Drawing.Size(121, 13)
        Me.lblNatureOfRoots.TabIndex = 17
        Me.lblNatureOfRoots.Text = "Hence the two roots are"
        '
        'lblRoots
        '
        Me.lblRoots.AutoSize = True
        Me.lblRoots.Location = New System.Drawing.Point(37, 198)
        Me.lblRoots.Name = "lblRoots"
        Me.lblRoots.Size = New System.Drawing.Size(38, 13)
        Me.lblRoots.TabIndex = 19
        Me.lblRoots.Text = "Roots:"
        '
        'txtRoot01
        '
        Me.txtRoot01.Location = New System.Drawing.Point(80, 195)
        Me.txtRoot01.Name = "txtRoot01"
        Me.txtRoot01.Size = New System.Drawing.Size(71, 20)
        Me.txtRoot01.TabIndex = 20
        '
        'txtRoot02
        '
        Me.txtRoot02.Location = New System.Drawing.Point(189, 195)
        Me.txtRoot02.Name = "txtRoot02"
        Me.txtRoot02.Size = New System.Drawing.Size(71, 20)
        Me.txtRoot02.TabIndex = 21
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(158, 198)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(25, 13)
        Me.lblAnd.TabIndex = 22
        Me.lblAnd.Text = "and"
        '
        'QuadraticEquationSolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.txtRoot02)
        Me.Controls.Add(Me.txtRoot01)
        Me.Controls.Add(Me.lblRoots)
        Me.Controls.Add(Me.txtNatureOfRoots)
        Me.Controls.Add(Me.lblNatureOfRoots)
        Me.Controls.Add(Me.txtDiscriminantPosOrNegValue)
        Me.Controls.Add(Me.lblDiscriminantPosOrNeg)
        Me.Controls.Add(Me.lblStep02)
        Me.Controls.Add(Me.txtDiscriminantVal)
        Me.Controls.Add(Me.lblDiscriminantEquals)
        Me.Controls.Add(Me.lblStep01)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCoeffc)
        Me.Controls.Add(Me.txtCoeffb)
        Me.Controls.Add(Me.txtCoeffa)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblX2)
        Me.Controls.Add(Me.lbl0)
        Me.Name = "QuadraticEquationSolver"
        Me.Text = "Quadratic Equation Solver"
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
    Friend WithEvents lblStep01 As System.Windows.Forms.Label
    Friend WithEvents lblDiscriminantEquals As System.Windows.Forms.Label
    Friend WithEvents txtDiscriminantVal As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscriminantPosOrNegValue As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscriminantPosOrNeg As System.Windows.Forms.Label
    Friend WithEvents lblStep02 As System.Windows.Forms.Label
    Friend WithEvents txtNatureOfRoots As System.Windows.Forms.TextBox
    Friend WithEvents lblNatureOfRoots As System.Windows.Forms.Label
    Friend WithEvents lblRoots As System.Windows.Forms.Label
    Friend WithEvents txtRoot01 As System.Windows.Forms.TextBox
    Friend WithEvents txtRoot02 As System.Windows.Forms.TextBox
    Friend WithEvents lblAnd As System.Windows.Forms.Label

End Class
