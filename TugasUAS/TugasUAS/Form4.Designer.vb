<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.TextBox()
        Me.c = New System.Windows.Forms.TextBox()
        Me.d = New System.Windows.Forms.TextBox()
        Me.cb2 = New System.Windows.Forms.ComboBox()
        Me.f = New System.Windows.Forms.TextBox()
        Me.g = New System.Windows.Forms.TextBox()
        Me.h = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cb3 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(184, 141)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(193, 28)
        Me.cb1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATA RENTAL"
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(184, 64)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(193, 26)
        Me.a.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(563, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "TAMBAH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(727, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "SIMPAN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(563, 179)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 41)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(727, 179)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 41)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "KELUAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DG
        '
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(12, 396)
        Me.DG.Name = "DG"
        Me.DG.RowTemplate.Height = 28
        Me.DG.Size = New System.Drawing.Size(859, 109)
        Me.DG.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nomor Peminjaman"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tanggal Pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nomor ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nama Peminjam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nomor HP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Plat Nomor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Nomor Rangka"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Nomor Mesin"
        '
        'b
        '
        Me.b.Location = New System.Drawing.Point(184, 101)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(193, 26)
        Me.b.TabIndex = 16
        '
        'c
        '
        Me.c.Location = New System.Drawing.Point(184, 189)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(193, 26)
        Me.c.TabIndex = 17
        '
        'd
        '
        Me.d.Location = New System.Drawing.Point(184, 226)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(193, 26)
        Me.d.TabIndex = 18
        '
        'cb2
        '
        Me.cb2.FormattingEnabled = True
        Me.cb2.Location = New System.Drawing.Point(184, 261)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(193, 28)
        Me.cb2.TabIndex = 19
        '
        'f
        '
        Me.f.Location = New System.Drawing.Point(184, 298)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(193, 26)
        Me.f.TabIndex = 20
        '
        'g
        '
        Me.g.Location = New System.Drawing.Point(184, 334)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(193, 26)
        Me.g.TabIndex = 21
        '
        'h
        '
        Me.h.Location = New System.Drawing.Point(604, 331)
        Me.h.Name = "h"
        Me.h.Size = New System.Drawing.Size(193, 26)
        Me.h.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(428, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(170, 20)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Total Keseluruhan Unit"
        '
        'cb3
        '
        Me.cb3.FormattingEnabled = True
        Me.cb3.Items.AddRange(New Object() {"YA", "TIDAK"})
        Me.cb3.Location = New System.Drawing.Point(604, 282)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(193, 28)
        Me.cb3.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(428, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Status"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 517)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cb3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.h)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.f)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents b As System.Windows.Forms.TextBox
    Friend WithEvents c As System.Windows.Forms.TextBox
    Friend WithEvents d As System.Windows.Forms.TextBox
    Friend WithEvents cb2 As System.Windows.Forms.ComboBox
    Friend WithEvents f As System.Windows.Forms.TextBox
    Friend WithEvents g As System.Windows.Forms.TextBox
    Friend WithEvents h As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cb3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
