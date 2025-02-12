<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nomoragt = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.namaagt = New System.Windows.Forms.TextBox()
        Me.telephone = New System.Windows.Forms.TextBox()
        Me.tempatlahir = New System.Windows.Forms.TextBox()
        Me.L = New System.Windows.Forms.RadioButton()
        Me.P = New System.Windows.Forms.RadioButton()
        Me.tgllahir = New System.Windows.Forms.DateTimePicker()
        Me.agama = New System.Windows.Forms.ComboBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database71DataSet = New WindowsApplication4.Database71DataSet()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database71DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENTRY DATA ANGGOTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor Anggota "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 234)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nomor Telepon "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 288)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tempat Lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 340)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tanggal Lahir"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 403)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Jenis Kelamin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(84, 449)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "AGAMA"
        '
        'nomoragt
        '
        Me.nomoragt.Location = New System.Drawing.Point(231, 80)
        Me.nomoragt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nomoragt.Name = "nomoragt"
        Me.nomoragt.Size = New System.Drawing.Size(271, 26)
        Me.nomoragt.TabIndex = 9
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(231, 182)
        Me.alamat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(478, 26)
        Me.alamat.TabIndex = 10
        '
        'namaagt
        '
        Me.namaagt.Location = New System.Drawing.Point(231, 139)
        Me.namaagt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.namaagt.Name = "namaagt"
        Me.namaagt.Size = New System.Drawing.Size(478, 26)
        Me.namaagt.TabIndex = 11
        '
        'telephone
        '
        Me.telephone.Location = New System.Drawing.Point(231, 234)
        Me.telephone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.telephone.Name = "telephone"
        Me.telephone.Size = New System.Drawing.Size(271, 26)
        Me.telephone.TabIndex = 12
        '
        'tempatlahir
        '
        Me.tempatlahir.Location = New System.Drawing.Point(231, 282)
        Me.tempatlahir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tempatlahir.Name = "tempatlahir"
        Me.tempatlahir.Size = New System.Drawing.Size(271, 26)
        Me.tempatlahir.TabIndex = 13
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.Location = New System.Drawing.Point(231, 399)
        Me.L.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(111, 24)
        Me.L.TabIndex = 16
        Me.L.TabStop = True
        Me.L.Text = "Laki-Laki"
        Me.L.UseVisualStyleBackColor = True
        '
        'P
        '
        Me.P.AutoSize = True
        Me.P.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P.Location = New System.Drawing.Point(374, 399)
        Me.P.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(128, 24)
        Me.P.TabIndex = 17
        Me.P.TabStop = True
        Me.P.Text = "Perempuan"
        Me.P.UseVisualStyleBackColor = True
        '
        'tgllahir
        '
        Me.tgllahir.Location = New System.Drawing.Point(231, 340)
        Me.tgllahir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tgllahir.Name = "tgllahir"
        Me.tgllahir.Size = New System.Drawing.Size(298, 26)
        Me.tgllahir.TabIndex = 18
        '
        'agama
        '
        Me.agama.FormattingEnabled = True
        Me.agama.Items.AddRange(New Object() {"ISLAM", "KRISTEN", "KATHOLIK", "HINDU", "BUDHA"})
        Me.agama.Location = New System.Drawing.Point(231, 446)
        Me.agama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.agama.Name = "agama"
        Me.agama.Size = New System.Drawing.Size(180, 28)
        Me.agama.TabIndex = 19
        '
        'DG
        '
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(21, 512)
        Me.DG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(874, 209)
        Me.DG.TabIndex = 20
        '
        'btntambah
        '
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.Location = New System.Drawing.Point(732, 80)
        Me.btntambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(130, 47)
        Me.btntambah.TabIndex = 21
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(732, 137)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(130, 55)
        Me.btnsimpan.TabIndex = 22
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(732, 202)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(130, 47)
        Me.btnedit.TabIndex = 23
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(732, 272)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(130, 46)
        Me.btnhapus.TabIndex = 24
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(732, 340)
        Me.btnkeluar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(130, 49)
        Me.btnkeluar.TabIndex = 25
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.Database71DataSet
        Me.BindingSource1.Position = 0
        '
        'Database71DataSet
        '
        Me.Database71DataSet.DataSetName = "Database71DataSet"
        Me.Database71DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 745)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.agama)
        Me.Controls.Add(Me.tgllahir)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.tempatlahir)
        Me.Controls.Add(Me.telephone)
        Me.Controls.Add(Me.namaagt)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.nomoragt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form2"
        Me.Text = "Form Anggota"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database71DataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents nomoragt As System.Windows.Forms.TextBox
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents namaagt As System.Windows.Forms.TextBox
    Friend WithEvents telephone As System.Windows.Forms.TextBox
    Friend WithEvents tempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents L As System.Windows.Forms.RadioButton
    Friend WithEvents P As System.Windows.Forms.RadioButton
    Friend WithEvents tgllahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents agama As System.Windows.Forms.ComboBox
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Database71DataSet As WindowsApplication4.Database71DataSet
End Class
