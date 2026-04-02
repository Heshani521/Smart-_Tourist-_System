<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports_Form
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltotalat = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltotalhotels = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltotaltr = New System.Windows.Forms.Label()
        Me.btndash = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System Overview & Reports"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Attractions:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'lbltotalat
        '
        Me.lbltotalat.AutoSize = True
        Me.lbltotalat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalat.Location = New System.Drawing.Point(133, 115)
        Me.lbltotalat.Name = "lbltotalat"
        Me.lbltotalat.Size = New System.Drawing.Size(26, 29)
        Me.lbltotalat.TabIndex = 3
        Me.lbltotalat.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Hotels:"
        '
        'lbltotalhotels
        '
        Me.lbltotalhotels.AutoSize = True
        Me.lbltotalhotels.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalhotels.Location = New System.Drawing.Point(133, 219)
        Me.lbltotalhotels.Name = "lbltotalhotels"
        Me.lbltotalhotels.Size = New System.Drawing.Size(26, 29)
        Me.lbltotalhotels.TabIndex = 5
        Me.lbltotalhotels.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(133, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Transport"
        '
        'lbltotaltr
        '
        Me.lbltotaltr.AutoSize = True
        Me.lbltotaltr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotaltr.Location = New System.Drawing.Point(133, 318)
        Me.lbltotaltr.Name = "lbltotaltr"
        Me.lbltotaltr.Size = New System.Drawing.Size(26, 29)
        Me.lbltotaltr.TabIndex = 7
        Me.lbltotaltr.Text = "0"
        '
        'btndash
        '
        Me.btndash.Location = New System.Drawing.Point(365, 299)
        Me.btndash.Name = "btndash"
        Me.btndash.Size = New System.Drawing.Size(253, 63)
        Me.btndash.TabIndex = 8
        Me.btndash.Text = "Back To Dashboartd"
        Me.btndash.UseVisualStyleBackColor = True
        '
        'Reports_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btndash)
        Me.Controls.Add(Me.lbltotaltr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbltotalhotels)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbltotalat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reports_Form"
        Me.Text = "Reports_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltotalat As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbltotalhotels As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbltotaltr As Label
    Friend WithEvents btndash As Button
End Class
