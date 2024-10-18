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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnload = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.datarecord = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        CType(Me.datarecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FULL NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EMAIL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD:"
        '
        'txtfullname
        '
        Me.txtfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.Location = New System.Drawing.Point(259, 112)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(147, 35)
        Me.txtfullname.TabIndex = 3
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(259, 179)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(147, 35)
        Me.txtemail.TabIndex = 4
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(259, 245)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(147, 35)
        Me.txtpassword.TabIndex = 5
        '
        'btnload
        '
        Me.btnload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.Location = New System.Drawing.Point(245, 342)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(122, 42)
        Me.btnload.TabIndex = 6
        Me.btnload.Text = "LOAD"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(405, 342)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(122, 42)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'datarecord
        '
        Me.datarecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datarecord.Location = New System.Drawing.Point(514, 112)
        Me.datarecord.Name = "datarecord"
        Me.datarecord.RowHeadersWidth = 62
        Me.datarecord.RowTemplate.Height = 28
        Me.datarecord.Size = New System.Drawing.Size(240, 168)
        Me.datarecord.TabIndex = 8
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(105, 342)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(106, 42)
        Me.btnadd.TabIndex = 9
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 490)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.datarecord)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Employee"
        CType(Me.datarecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnload As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents datarecord As DataGridView
    Friend WithEvents btnadd As Button
End Class
