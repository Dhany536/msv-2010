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
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.DG = New System.Windows.Forms.DataGridView()
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
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtTempattanggal = New System.Windows.Forms.TextBox()
        Me.rbPria = New System.Windows.Forms.RadioButton()
        Me.rbWanita = New System.Windows.Forms.RadioButton()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtRTRW = New System.Windows.Forms.TextBox()
        Me.txtKelDesa = New System.Windows.Forms.TextBox()
        Me.txtKecamatan = New System.Windows.Forms.TextBox()
        Me.cbAgama = New System.Windows.Forms.ComboBox()
        Me.txtPekerjaan = New System.Windows.Forms.TextBox()
        Me.txtKewarganegaraan = New System.Windows.Forms.TextBox()
        Me.txtBerlakuHingga = New System.Windows.Forms.TextBox()
        Me.cbKawin = New System.Windows.Forms.CheckBox()
        Me.rbKawin = New System.Windows.Forms.RadioButton()
        Me.rbBelumKawin = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(39, 529)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(112, 35)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(211, 529)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(112, 35)
        Me.BtnSimpan.TabIndex = 1
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(401, 529)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(112, 35)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(590, 529)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(112, 35)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'DG
        '
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(18, 591)
        Me.DG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(1166, 125)
        Me.DG.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NIK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 206)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tempat/Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 291)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 366)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(135, 408)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "RT/RW"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(135, 445)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Kel/Desa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(135, 480)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Kecamatan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(584, 97)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Agama"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(584, 149)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Status Perkawinan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(584, 206)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Pekerjaan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(584, 297)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 20)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Kewarganegaraan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(584, 366)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 20)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Berlaku Hingga"
        '
        'txtNIK
        '
        Me.txtNIK.Location = New System.Drawing.Point(262, 92)
        Me.txtNIK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(264, 26)
        Me.txtNIK.TabIndex = 18
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(262, 145)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(264, 26)
        Me.txtNama.TabIndex = 19
        '
        'txtTempattanggal
        '
        Me.txtTempattanggal.Location = New System.Drawing.Point(262, 202)
        Me.txtTempattanggal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTempattanggal.Name = "txtTempattanggal"
        Me.txtTempattanggal.Size = New System.Drawing.Size(264, 26)
        Me.txtTempattanggal.TabIndex = 20
        '
        'rbPria
        '
        Me.rbPria.AutoSize = True
        Me.rbPria.Location = New System.Drawing.Point(262, 291)
        Me.rbPria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbPria.Name = "rbPria"
        Me.rbPria.Size = New System.Drawing.Size(61, 24)
        Me.rbPria.TabIndex = 21
        Me.rbPria.TabStop = True
        Me.rbPria.Text = "Pria"
        Me.rbPria.UseVisualStyleBackColor = True
        '
        'rbWanita
        '
        Me.rbWanita.AutoSize = True
        Me.rbWanita.Location = New System.Drawing.Point(388, 291)
        Me.rbWanita.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbWanita.Name = "rbWanita"
        Me.rbWanita.Size = New System.Drawing.Size(84, 24)
        Me.rbWanita.TabIndex = 22
        Me.rbWanita.TabStop = True
        Me.rbWanita.Text = "Wanita"
        Me.rbWanita.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(262, 355)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(264, 26)
        Me.txtAlamat.TabIndex = 23
        '
        'txtRTRW
        '
        Me.txtRTRW.Location = New System.Drawing.Point(262, 395)
        Me.txtRTRW.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRTRW.Name = "txtRTRW"
        Me.txtRTRW.Size = New System.Drawing.Size(264, 26)
        Me.txtRTRW.TabIndex = 24
        '
        'txtKelDesa
        '
        Me.txtKelDesa.Location = New System.Drawing.Point(262, 435)
        Me.txtKelDesa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKelDesa.Name = "txtKelDesa"
        Me.txtKelDesa.Size = New System.Drawing.Size(264, 26)
        Me.txtKelDesa.TabIndex = 25
        '
        'txtKecamatan
        '
        Me.txtKecamatan.Location = New System.Drawing.Point(262, 475)
        Me.txtKecamatan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKecamatan.Name = "txtKecamatan"
        Me.txtKecamatan.Size = New System.Drawing.Size(264, 26)
        Me.txtKecamatan.TabIndex = 26
        '
        'cbAgama
        '
        Me.cbAgama.FormattingEnabled = True
        Me.cbAgama.Items.AddRange(New Object() {"ISLAM", "KRISTEN", "KATOLIK", "BUDHA", "KONG HU CHU"})
        Me.cbAgama.Location = New System.Drawing.Point(770, 85)
        Me.cbAgama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbAgama.Name = "cbAgama"
        Me.cbAgama.Size = New System.Drawing.Size(174, 28)
        Me.cbAgama.TabIndex = 27
        '
        'txtPekerjaan
        '
        Me.txtPekerjaan.Location = New System.Drawing.Point(770, 202)
        Me.txtPekerjaan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPekerjaan.Name = "txtPekerjaan"
        Me.txtPekerjaan.Size = New System.Drawing.Size(238, 26)
        Me.txtPekerjaan.TabIndex = 30
        '
        'txtKewarganegaraan
        '
        Me.txtKewarganegaraan.Location = New System.Drawing.Point(770, 289)
        Me.txtKewarganegaraan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKewarganegaraan.Name = "txtKewarganegaraan"
        Me.txtKewarganegaraan.Size = New System.Drawing.Size(148, 26)
        Me.txtKewarganegaraan.TabIndex = 31
        '
        'txtBerlakuHingga
        '
        Me.txtBerlakuHingga.Location = New System.Drawing.Point(770, 355)
        Me.txtBerlakuHingga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBerlakuHingga.Name = "txtBerlakuHingga"
        Me.txtBerlakuHingga.Size = New System.Drawing.Size(148, 26)
        Me.txtBerlakuHingga.TabIndex = 32
        '
        'cbKawin
        '
        Me.cbKawin.AutoSize = True
        Me.cbKawin.Location = New System.Drawing.Point(770, 149)
        Me.cbKawin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbKawin.Name = "cbKawin"
        Me.cbKawin.Size = New System.Drawing.Size(77, 24)
        Me.cbKawin.TabIndex = 33
        Me.cbKawin.Text = "Kawin"
        Me.cbKawin.UseVisualStyleBackColor = True
        '
        'rbKawin
        '
        Me.rbKawin.AutoSize = True
        Me.rbKawin.Location = New System.Drawing.Point(1051, 408)
        Me.rbKawin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbKawin.Name = "rbKawin"
        Me.rbKawin.Size = New System.Drawing.Size(76, 24)
        Me.rbKawin.TabIndex = 28
        Me.rbKawin.TabStop = True
        Me.rbKawin.Text = "Kawin"
        Me.rbKawin.UseVisualStyleBackColor = True
        '
        'rbBelumKawin
        '
        Me.rbBelumKawin.AutoSize = True
        Me.rbBelumKawin.Location = New System.Drawing.Point(883, 408)
        Me.rbBelumKawin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbBelumKawin.Name = "rbBelumKawin"
        Me.rbBelumKawin.Size = New System.Drawing.Size(125, 24)
        Me.rbBelumKawin.TabIndex = 29
        Me.rbBelumKawin.TabStop = True
        Me.rbBelumKawin.Text = "Belum Kawin"
        Me.rbBelumKawin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(783, 529)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(355, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(368, 37)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Kartu Tanda Penduduk"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(883, 149)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(126, 24)
        Me.CheckBox1.TabIndex = 36
        Me.CheckBox1.Text = "Belum Kawin"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 778)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbKawin)
        Me.Controls.Add(Me.txtBerlakuHingga)
        Me.Controls.Add(Me.txtKewarganegaraan)
        Me.Controls.Add(Me.txtPekerjaan)
        Me.Controls.Add(Me.rbBelumKawin)
        Me.Controls.Add(Me.rbKawin)
        Me.Controls.Add(Me.cbAgama)
        Me.Controls.Add(Me.txtKecamatan)
        Me.Controls.Add(Me.txtKelDesa)
        Me.Controls.Add(Me.txtRTRW)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.rbWanita)
        Me.Controls.Add(Me.rbPria)
        Me.Controls.Add(Me.txtTempattanggal)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIK)
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
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.btnTambah)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents DG As System.Windows.Forms.DataGridView
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
    Friend WithEvents txtNIK As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtTempattanggal As System.Windows.Forms.TextBox
    Friend WithEvents rbPria As System.Windows.Forms.RadioButton
    Friend WithEvents rbWanita As System.Windows.Forms.RadioButton
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtRTRW As System.Windows.Forms.TextBox
    Friend WithEvents txtKelDesa As System.Windows.Forms.TextBox
    Friend WithEvents txtKecamatan As System.Windows.Forms.TextBox
    Friend WithEvents cbAgama As System.Windows.Forms.ComboBox
    Friend WithEvents txtPekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents txtKewarganegaraan As System.Windows.Forms.TextBox
    Friend WithEvents txtBerlakuHingga As System.Windows.Forms.TextBox
    Friend WithEvents cbKawin As System.Windows.Forms.CheckBox
    Friend WithEvents rbKawin As System.Windows.Forms.RadioButton
    Friend WithEvents rbBelumKawin As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
