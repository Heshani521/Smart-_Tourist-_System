<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_form
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
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.chkshow = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Location = New System.Drawing.Point(412, 299)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(220, 44)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD"
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.Location = New System.Drawing.Point(195, 110)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(224, 20)
        Me.txtusername.TabIndex = 3
        '
        'txtpw
        '
        Me.txtpw.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpw.Location = New System.Drawing.Point(195, 203)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Size = New System.Drawing.Size(224, 20)
        Me.txtpw.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(247, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SMART TOURIST INFORMATION SYSTEM"
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(175, 299)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(161, 58)
        Me.btnclr.TabIndex = 6
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(12, 299)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(117, 61)
        Me.btnexit.TabIndex = 7
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'chkshow
        '
        Me.chkshow.AutoSize = True
        Me.chkshow.Location = New System.Drawing.Point(194, 233)
        Me.chkshow.Name = "chkshow"
        Me.chkshow.Size = New System.Drawing.Size(102, 17)
        Me.chkshow.TabIndex = 8
        Me.chkshow.Text = "Show Password"
        Me.chkshow.UseVisualStyleBackColor = True
        '
        'login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(704, 450)
        Me.Controls.Add(Me.chkshow)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlogin)
        Me.Name = "login_form"
        Me.Text = "Login_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnlogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnclr As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents chkshow As CheckBox
End Class
