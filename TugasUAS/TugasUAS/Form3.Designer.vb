<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c = New System.Windows.Forms.TextBox()
        Me.d = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.k = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.f = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.TextBox()
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.h = New System.Windows.Forms.TextBox()
        Me.g = New System.Windows.Forms.TextBox()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(926, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(926, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 45)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(926, 212)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(926, 280)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 45)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DG
        '
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(12, 381)
        Me.DG.Name = "DG"
        Me.DG.RowTemplate.Height = 28
        Me.DG.Size = New System.Drawing.Size(1026, 123)
        Me.DG.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(419, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Identitas Motor"
        '
        'b
        '
        Me.b.Location = New System.Drawing.Point(179, 126)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(169, 26)
        Me.b.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Plat Nomor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tipe Motor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Merk Motor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(458, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Kondisi Motor"
        '
        'c
        '
        Me.c.Location = New System.Drawing.Point(179, 171)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(169, 26)
        Me.c.TabIndex = 14
        '
        'd
        '
        Me.d.Location = New System.Drawing.Point(179, 221)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(169, 26)
        Me.d.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nomor Rangka"
        '
        'k
        '
        Me.k.Location = New System.Drawing.Point(179, 268)
        Me.k.Name = "k"
        Me.k.Size = New System.Drawing.Size(169, 26)
        Me.k.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Nomor Mesin"
        '
        'f
        '
        Me.f.Location = New System.Drawing.Point(179, 323)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(169, 26)
        Me.f.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(457, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(248, 29)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "1 Hari Rp. 40 000,00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Ciri Khas"
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(179, 70)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(169, 26)
        Me.a.TabIndex = 22
        '
        'CB1
        '
        Me.CB1.FormattingEnabled = True
        Me.CB1.Items.AddRange(New Object() {"HABIS SERVICE", "BELUM SERVICE"})
        Me.CB1.Location = New System.Drawing.Point(595, 198)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(157, 28)
        Me.CB1.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(458, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(458, 254)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(170, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Total Keseluruhan Unit"
        '
        'h
        '
        Me.h.Location = New System.Drawing.Point(634, 248)
        Me.h.Name = "h"
        Me.h.Size = New System.Drawing.Size(193, 26)
        Me.h.TabIndex = 26
        '
        'g
        '
        Me.g.Location = New System.Drawing.Point(595, 73)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(193, 26)
        Me.g.TabIndex = 27
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 516)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.h)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB1)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.f)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.k)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents c As System.Windows.Forms.TextBox
    Friend WithEvents d As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents k As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents f As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.TextBox
    Friend WithEvents CB1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents h As System.Windows.Forms.TextBox
    Friend WithEvents g As System.Windows.Forms.TextBox
End Class
