<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmF2H
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
        Me.btnInitialize = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.grid1 = New UJGrid.UJGrid()
        Me.SuspendLayout()
        '
        'btnInitialize
        '
        Me.btnInitialize.Location = New System.Drawing.Point(12, 12)
        Me.btnInitialize.Name = "btnInitialize"
        Me.btnInitialize.Size = New System.Drawing.Size(120, 46)
        Me.btnInitialize.TabIndex = 0
        Me.btnInitialize.Text = "INITIALIZE AND LABEL GRID"
        Me.btnInitialize.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(169, 12)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(122, 46)
        Me.btnCapture.TabIndex = 1
        Me.btnCapture.Text = "CAPTURE INFORMATION"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(326, 12)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(121, 46)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Location = New System.Drawing.Point(494, 12)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(119, 46)
        Me.btnMax.TabIndex = 3
        Me.btnMax.Text = "BUSIEST"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'grid1
        '
        Me.grid1.FixedCols = 1
        Me.grid1.FixedRows = 1
        Me.grid1.Location = New System.Drawing.Point(12, 65)
        Me.grid1.Name = "grid1"
        Me.grid1.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grid1.Size = New System.Drawing.Size(601, 290)
        Me.grid1.TabIndex = 4
        '
        'FrmF2H
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 363)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnInitialize)
        Me.Name = "FrmF2H"
        Me.Text = "FORM 2 HEALTH"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInitialize As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents grid1 As UJGrid.UJGrid
End Class
