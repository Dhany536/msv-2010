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
        Me.rbfaktorial = New System.Windows.Forms.RadioButton()
        Me.rbcombinasi = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncobalagi = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.txtnilaifaktorial = New System.Windows.Forms.TextBox()
        Me.txthasilfaktorial = New System.Windows.Forms.TextBox()
        Me.txtcombn = New System.Windows.Forms.TextBox()
        Me.txtcombm = New System.Windows.Forms.TextBox()
        Me.txtcombnm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rbfaktorial
        '
        Me.rbfaktorial.AutoSize = True
        Me.rbfaktorial.Location = New System.Drawing.Point(23, 119)
        Me.rbfaktorial.Name = "rbfaktorial"
        Me.rbfaktorial.Size = New System.Drawing.Size(179, 24)
        Me.rbfaktorial.TabIndex = 0
        Me.rbfaktorial.TabStop = True
        Me.rbfaktorial.Text = "Hitung Nilai Faktorial"
        Me.rbfaktorial.UseVisualStyleBackColor = True
        '
        'rbcombinasi
        '
        Me.rbcombinasi.AutoSize = True
        Me.rbcombinasi.Location = New System.Drawing.Point(23, 169)
        Me.rbcombinasi.Name = "rbcombinasi"
        Me.rbcombinasi.Size = New System.Drawing.Size(192, 24)
        Me.rbcombinasi.TabIndex = 1
        Me.rbcombinasi.TabStop = True
        Me.rbcombinasi.Text = "Hitung Nilai Combinasi"
        Me.rbcombinasi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hitung Nilai Faktorial & Combinasi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(549, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bilangan Comb N"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(549, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Bilangan Comb M"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(549, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Hasil Nilai Comb N dan M"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Masukkan Nilai Faktorial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Hasil Faktorial"
        '
        'btncobalagi
        '
        Me.btncobalagi.Location = New System.Drawing.Point(132, 453)
        Me.btncobalagi.Name = "btncobalagi"
        Me.btncobalagi.Size = New System.Drawing.Size(115, 36)
        Me.btncobalagi.TabIndex = 8
        Me.btncobalagi.Text = "Coba Lagi"
        Me.btncobalagi.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(462, 449)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(98, 40)
        Me.btnkeluar.TabIndex = 9
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'txtnilaifaktorial
        '
        Me.txtnilaifaktorial.Location = New System.Drawing.Point(23, 268)
        Me.txtnilaifaktorial.Name = "txtnilaifaktorial"
        Me.txtnilaifaktorial.Size = New System.Drawing.Size(192, 26)
        Me.txtnilaifaktorial.TabIndex = 15
        '
        'txthasilfaktorial
        '
        Me.txthasilfaktorial.Location = New System.Drawing.Point(23, 360)
        Me.txthasilfaktorial.Name = "txthasilfaktorial"
        Me.txthasilfaktorial.Size = New System.Drawing.Size(192, 26)
        Me.txthasilfaktorial.TabIndex = 16
        '
        'txtcombn
        '
        Me.txtcombn.Location = New System.Drawing.Point(553, 146)
        Me.txtcombn.Name = "txtcombn"
        Me.txtcombn.Size = New System.Drawing.Size(192, 26)
        Me.txtcombn.TabIndex = 17
        '
        'txtcombm
        '
        Me.txtcombm.Location = New System.Drawing.Point(553, 236)
        Me.txtcombm.Name = "txtcombm"
        Me.txtcombm.Size = New System.Drawing.Size(192, 26)
        Me.txtcombm.TabIndex = 18
        '
        'txtcombnm
        '
        Me.txtcombnm.Location = New System.Drawing.Point(553, 339)
        Me.txtcombnm.Name = "txtcombnm"
        Me.txtcombnm.Size = New System.Drawing.Size(192, 26)
        Me.txtcombnm.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 525)
        Me.Controls.Add(Me.txtcombnm)
        Me.Controls.Add(Me.txtcombm)
        Me.Controls.Add(Me.txtcombn)
        Me.Controls.Add(Me.txthasilfaktorial)
        Me.Controls.Add(Me.txtnilaifaktorial)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btncobalagi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbcombinasi)
        Me.Controls.Add(Me.rbfaktorial)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbfaktorial As System.Windows.Forms.RadioButton
    Friend WithEvents rbcombinasi As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btncobalagi As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents txtnilaifaktorial As System.Windows.Forms.TextBox
    Friend WithEvents txthasilfaktorial As System.Windows.Forms.TextBox
    Friend WithEvents txtcombn As System.Windows.Forms.TextBox
    Friend WithEvents txtcombm As System.Windows.Forms.TextBox
    Friend WithEvents txtcombnm As System.Windows.Forms.TextBox

End Class
