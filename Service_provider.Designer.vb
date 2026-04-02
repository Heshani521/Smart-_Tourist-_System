<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Service_provider
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcn = New System.Windows.Forms.TextBox()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.dgvprovider = New System.Windows.Forms.DataGridView()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndash = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnup = New System.Windows.Forms.Button()
        Me.btndlt = New System.Windows.Forms.Button()
        CType(Me.dgvprovider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Service Provider"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Provider Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Description:"
        '
        'cmbtype
        '
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"Hotels ", "Transport"})
        Me.cmbtype.Location = New System.Drawing.Point(198, 81)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(127, 21)
        Me.cmbtype.TabIndex = 6
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(198, 125)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(265, 20)
        Me.txtname.TabIndex = 7
        '
        'txtcn
        '
        Me.txtcn.Location = New System.Drawing.Point(198, 174)
        Me.txtcn.Name = "txtcn"
        Me.txtcn.Size = New System.Drawing.Size(265, 20)
        Me.txtcn.TabIndex = 8
        '
        'txtdes
        '
        Me.txtdes.Location = New System.Drawing.Point(198, 221)
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(265, 20)
        Me.txtdes.TabIndex = 9
        '
        'dgvprovider
        '
        Me.dgvprovider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvprovider.Location = New System.Drawing.Point(52, 296)
        Me.dgvprovider.Name = "dgvprovider"
        Me.dgvprovider.Size = New System.Drawing.Size(340, 99)
        Me.dgvprovider.TabIndex = 10
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(560, 250)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(189, 37)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndash
        '
        Me.btndash.Location = New System.Drawing.Point(560, 309)
        Me.btndash.Name = "btndash"
        Me.btndash.Size = New System.Drawing.Size(189, 37)
        Me.btndash.TabIndex = 12
        Me.btndash.Text = "Back To Dashboard"
        Me.btndash.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(560, 50)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(188, 20)
        Me.txtid.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(486, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ID"
        '
        'btnup
        '
        Me.btnup.Location = New System.Drawing.Point(559, 133)
        Me.btnup.Name = "btnup"
        Me.btnup.Size = New System.Drawing.Size(168, 28)
        Me.btnup.TabIndex = 15
        Me.btnup.Text = "Update"
        Me.btnup.UseVisualStyleBackColor = True
        '
        'btndlt
        '
        Me.btndlt.Location = New System.Drawing.Point(560, 190)
        Me.btndlt.Name = "btndlt"
        Me.btndlt.Size = New System.Drawing.Size(168, 28)
        Me.btndlt.TabIndex = 16
        Me.btndlt.Text = "Delete"
        Me.btndlt.UseVisualStyleBackColor = True
        '
        'Service_provider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btndlt)
        Me.Controls.Add(Me.btnup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btndash)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dgvprovider)
        Me.Controls.Add(Me.txtdes)
        Me.Controls.Add(Me.txtcn)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Service_provider"
        Me.Text = "Service_provider"
        CType(Me.dgvprovider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbtype As ComboBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtcn As TextBox
    Friend WithEvents txtdes As TextBox
    Friend WithEvents dgvprovider As DataGridView
    Friend WithEvents btnsave As Button
    Friend WithEvents btndash As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnup As Button
    Friend WithEvents btndlt As Button
End Class
