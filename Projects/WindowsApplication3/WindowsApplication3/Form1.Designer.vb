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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnilai = New System.Windows.Forms.TextBox()
        Me.l = New System.Windows.Forms.Label()
        Me.q = New System.Windows.Forms.Label()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcombnm = New System.Windows.Forms.TextBox()
        Me.txtcombn = New System.Windows.Forms.TextBox()
        Me.txtcombm = New System.Windows.Forms.TextBox()
        Me.txtx = New System.Windows.Forms.TextBox()
        Me.txty = New System.Windows.Forms.TextBox()
        Me.txtxy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Coba Lagi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(535, 383)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Items.AddRange(New Object() {"Hitung Faktorial", "Hitung Combinasi", "Hitung Pangkat"})
        Me.cmb1.Location = New System.Drawing.Point(12, 73)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(187, 28)
        Me.cmb1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(671, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Soal Ujian Tengah Semester : Pemrograman Database 1"
        '
        'txtnilai
        '
        Me.txtnilai.Location = New System.Drawing.Point(16, 161)
        Me.txtnilai.Name = "txtnilai"
        Me.txtnilai.Size = New System.Drawing.Size(183, 26)
        Me.txtnilai.TabIndex = 4
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(12, 138)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(103, 20)
        Me.l.TabIndex = 5
        Me.l.Text = "Nilai Faktorial"
        '
        'q
        '
        Me.q.AutoSize = True
        Me.q.Location = New System.Drawing.Point(12, 227)
        Me.q.Name = "q"
        Me.q.Size = New System.Drawing.Size(109, 20)
        Me.q.TabIndex = 6
        Me.q.Text = "Hasil Faktorial"
        '
        'txthasil
        '
        Me.txthasil.Location = New System.Drawing.Point(12, 250)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(183, 26)
        Me.txthasil.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bilangan Comb N"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Bilangan Comb M"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Hasil Nilai Comb NM"
        '
        'txtcombnm
        '
        Me.txtcombnm.Location = New System.Drawing.Point(344, 250)
        Me.txtcombnm.Name = "txtcombnm"
        Me.txtcombnm.Size = New System.Drawing.Size(183, 26)
        Me.txtcombnm.TabIndex = 11
        '
        'txtcombn
        '
        Me.txtcombn.Location = New System.Drawing.Point(344, 86)
        Me.txtcombn.Name = "txtcombn"
        Me.txtcombn.Size = New System.Drawing.Size(183, 26)
        Me.txtcombn.TabIndex = 12
        '
        'txtcombm
        '
        Me.txtcombm.Location = New System.Drawing.Point(344, 161)
        Me.txtcombm.Name = "txtcombm"
        Me.txtcombm.Size = New System.Drawing.Size(183, 26)
        Me.txtcombm.TabIndex = 13
        '
        'txtx
        '
        Me.txtx.Location = New System.Drawing.Point(737, 86)
        Me.txtx.Name = "txtx"
        Me.txtx.Size = New System.Drawing.Size(183, 26)
        Me.txtx.TabIndex = 14
        '
        'txty
        '
        Me.txty.Location = New System.Drawing.Point(737, 161)
        Me.txty.Name = "txty"
        Me.txty.Size = New System.Drawing.Size(183, 26)
        Me.txty.TabIndex = 15
        '
        'txtxy
        '
        Me.txtxy.Location = New System.Drawing.Point(737, 250)
        Me.txtxy.Name = "txtxy"
        Me.txtxy.Size = New System.Drawing.Size(183, 26)
        Me.txtxy.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(733, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Bilangan X"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(733, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Pangkat Y"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(733, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Hasil Bilangan X pangkat Y"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 539)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtxy)
        Me.Controls.Add(Me.txty)
        Me.Controls.Add(Me.txtx)
        Me.Controls.Add(Me.txtcombm)
        Me.Controls.Add(Me.txtcombn)
        Me.Controls.Add(Me.txtcombnm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.q)
        Me.Controls.Add(Me.l)
        Me.Controls.Add(Me.txtnilai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmb1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnilai As System.Windows.Forms.TextBox
    Friend WithEvents l As System.Windows.Forms.Label
    Friend WithEvents q As System.Windows.Forms.Label
    Friend WithEvents txthasil As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcombnm As System.Windows.Forms.TextBox
    Friend WithEvents txtcombn As System.Windows.Forms.TextBox
    Friend WithEvents txtcombm As System.Windows.Forms.TextBox
    Friend WithEvents txtx As System.Windows.Forms.TextBox
    Friend WithEvents txty As System.Windows.Forms.TextBox
    Friend WithEvents txtxy As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
