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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.txtnomor = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtlalu = New System.Windows.Forms.TextBox()
        Me.txtsekarang = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtpertama = New System.Windows.Forms.TextBox()
        Me.txtkedua = New System.Windows.Forms.TextBox()
        Me.txtketiga = New System.Windows.Forms.TextBox()
        Me.txtselebihnya = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.btnproses = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(252, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REKENING PDAM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NO Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pakai BLN lalu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Pelanggan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 393)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Pakai BLN Sekarang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Golongan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 452)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Pemakaian"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.Location = New System.Drawing.Point(522, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Perhitungan Biaya Air"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(486, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "10 Pertama Rp."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(486, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "10 Kedua Rp."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(487, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "10 Ketiga Rp."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(486, 393)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Selebihnya Rp."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(488, 458)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 20)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Total Bayar Rp."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(355, 458)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 20)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "M KUBIK"
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(190, 262)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(159, 28)
        Me.cmb1.TabIndex = 13
        '
        'txtnomor
        '
        Me.txtnomor.Location = New System.Drawing.Point(190, 122)
        Me.txtnomor.Name = "txtnomor"
        Me.txtnomor.Size = New System.Drawing.Size(159, 26)
        Me.txtnomor.TabIndex = 14
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(190, 189)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(159, 26)
        Me.txtnama.TabIndex = 15
        '
        'txtlalu
        '
        Me.txtlalu.Location = New System.Drawing.Point(190, 332)
        Me.txtlalu.Name = "txtlalu"
        Me.txtlalu.Size = New System.Drawing.Size(159, 26)
        Me.txtlalu.TabIndex = 16
        '
        'txtsekarang
        '
        Me.txtsekarang.Location = New System.Drawing.Point(190, 390)
        Me.txtsekarang.Name = "txtsekarang"
        Me.txtsekarang.Size = New System.Drawing.Size(159, 26)
        Me.txtsekarang.TabIndex = 17
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(190, 452)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(159, 26)
        Me.txttotal.TabIndex = 18
        '
        'txtpertama
        '
        Me.txtpertama.Location = New System.Drawing.Point(612, 196)
        Me.txtpertama.Name = "txtpertama"
        Me.txtpertama.Size = New System.Drawing.Size(159, 26)
        Me.txtpertama.TabIndex = 19
        '
        'txtkedua
        '
        Me.txtkedua.Location = New System.Drawing.Point(612, 259)
        Me.txtkedua.Name = "txtkedua"
        Me.txtkedua.Size = New System.Drawing.Size(159, 26)
        Me.txtkedua.TabIndex = 20
        '
        'txtketiga
        '
        Me.txtketiga.Location = New System.Drawing.Point(612, 329)
        Me.txtketiga.Name = "txtketiga"
        Me.txtketiga.Size = New System.Drawing.Size(159, 26)
        Me.txtketiga.TabIndex = 21
        '
        'txtselebihnya
        '
        Me.txtselebihnya.Location = New System.Drawing.Point(612, 390)
        Me.txtselebihnya.Name = "txtselebihnya"
        Me.txtselebihnya.Size = New System.Drawing.Size(159, 26)
        Me.txtselebihnya.TabIndex = 22
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(612, 458)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(159, 26)
        Me.txtbayar.TabIndex = 23
        '
        'btnproses
        '
        Me.btnproses.Location = New System.Drawing.Point(190, 507)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(107, 42)
        Me.btnproses.TabIndex = 24
        Me.btnproses.Text = "PROSES"
        Me.btnproses.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(612, 507)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(107, 42)
        Me.btnkeluar.TabIndex = 25
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 571)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnproses)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.txtselebihnya)
        Me.Controls.Add(Me.txtketiga)
        Me.Controls.Add(Me.txtkedua)
        Me.Controls.Add(Me.txtpertama)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtsekarang)
        Me.Controls.Add(Me.txtlalu)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnomor)
        Me.Controls.Add(Me.cmb1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtnomor As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtlalu As System.Windows.Forms.TextBox
    Friend WithEvents txtsekarang As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtpertama As System.Windows.Forms.TextBox
    Friend WithEvents txtkedua As System.Windows.Forms.TextBox
    Friend WithEvents txtketiga As System.Windows.Forms.TextBox
    Friend WithEvents txtselebihnya As System.Windows.Forms.TextBox
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents btnproses As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button

End Class
