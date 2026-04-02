<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage__Attration_form
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.txtfee = New System.Windows.Forms.TextBox()
        Me.dgvattraction = New System.Windows.Forms.DataGridView()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndlt = New System.Windows.Forms.Button()
        CType(Me.dgvattraction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Tourist Attraction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Attraction Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Entrance Fee"
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(436, 123)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(161, 36)
        Me.btnback.TabIndex = 5
        Me.btnback.Text = "Back To Dashboard"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(436, 59)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(161, 36)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(152, 59)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(206, 20)
        Me.txtname.TabIndex = 7
        '
        'txtlocation
        '
        Me.txtlocation.Location = New System.Drawing.Point(152, 105)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(206, 20)
        Me.txtlocation.TabIndex = 8
        '
        'txtfee
        '
        Me.txtfee.Location = New System.Drawing.Point(152, 160)
        Me.txtfee.Name = "txtfee"
        Me.txtfee.Size = New System.Drawing.Size(206, 20)
        Me.txtfee.TabIndex = 9
        '
        'dgvattraction
        '
        Me.dgvattraction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvattraction.Location = New System.Drawing.Point(139, 268)
        Me.dgvattraction.Name = "dgvattraction"
        Me.dgvattraction.Size = New System.Drawing.Size(457, 97)
        Me.dgvattraction.TabIndex = 11
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(553, 191)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(105, 36)
        Me.btnupdate.TabIndex = 14
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndlt
        '
        Me.btndlt.Location = New System.Drawing.Point(631, 242)
        Me.btndlt.Name = "btndlt"
        Me.btndlt.Size = New System.Drawing.Size(105, 36)
        Me.btndlt.TabIndex = 15
        Me.btndlt.Text = "DELETE"
        Me.btndlt.UseVisualStyleBackColor = True
        '
        'Manage__Attration_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btndlt)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.dgvattraction)
        Me.Controls.Add(Me.txtfee)
        Me.Controls.Add(Me.txtlocation)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Manage__Attration_form"
        Me.Text = "Manage__Attration_form"
        CType(Me.dgvattraction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnback As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents txtfee As TextBox
    Friend WithEvents dgvattraction As DataGridView
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndlt As Button
End Class
