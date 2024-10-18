<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtfullname = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(121, 321)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(117, 32)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtfullname
        '
        Me.txtfullname.AutoSize = True
        Me.txtfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.Location = New System.Drawing.Point(107, 133)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(148, 29)
        Me.txtfullname.TabIndex = 1
        Me.txtfullname.Text = "FULLNAME"
        '
        'txtusername
        '
        Me.txtusername.AutoSize = True
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(102, 194)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(156, 29)
        Me.txtusername.TabIndex = 2
        Me.txtusername.Text = "USERNAME"
        '
        'txtpassword
        '
        Me.txtpassword.AutoSize = True
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(99, 252)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(159, 29)
        Me.txtpassword.TabIndex = 3
        Me.txtpassword.Text = "PASSWORD"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(298, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 35)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(298, 194)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(136, 35)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(298, 252)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(136, 35)
        Me.TextBox3.TabIndex = 6
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(296, 321)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(102, 32)
        Me.btnback.TabIndex = 7
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 508)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.btnsave)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsave As Button
    Friend WithEvents txtfullname As Label
    Friend WithEvents txtusername As Label
    Friend WithEvents txtpassword As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnback As Button
End Class
