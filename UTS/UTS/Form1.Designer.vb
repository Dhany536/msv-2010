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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.N1 = New System.Windows.Forms.TextBox()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.N2 = New System.Windows.Forms.TextBox()
        Me.N3 = New System.Windows.Forms.TextBox()
        Me.N5 = New System.Windows.Forms.TextBox()
        Me.N6 = New System.Windows.Forms.TextBox()
        Me.N7 = New System.Windows.Forms.TextBox()
        Me.L = New System.Windows.Forms.RadioButton()
        Me.P = New System.Windows.Forms.RadioButton()
        Me.C2 = New System.Windows.Forms.ComboBox()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.CH1 = New System.Windows.Forms.CheckBox()
        Me.CH2 = New System.Windows.Forms.CheckBox()
        Me.CH3 = New System.Windows.Forms.CheckBox()
        Me.CH4 = New System.Windows.Forms.CheckBox()
        Me.N4 = New System.Windows.Forms.TextBox()
        Me.N8 = New System.Windows.Forms.TextBox()
        Me.C1 = New System.Windows.Forms.ComboBox()
        Me.EktpDataSet = New UTS.ektpDataSet()
        Me.EktpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EktpTableAdapter = New UTS.ektpDataSetTableAdapters.ektpTableAdapter()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EktpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EktpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM PENDAFTARAN E-KTP"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(45, 588)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'N1
        '
        Me.N1.Location = New System.Drawing.Point(234, 83)
        Me.N1.Name = "N1"
        Me.N1.Size = New System.Drawing.Size(192, 26)
        Me.N1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nomor Pendaftaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tempat/Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(63, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 445)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Provinsi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(63, 489)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Kota"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(663, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Agama"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(663, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Status Perkawinan"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(278, 588)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(526, 588)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 35)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(790, 588)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 35)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1005, 588)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 35)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'N2
        '
        Me.N2.Location = New System.Drawing.Point(184, 142)
        Me.N2.Name = "N2"
        Me.N2.Size = New System.Drawing.Size(192, 26)
        Me.N2.TabIndex = 20
        '
        'N3
        '
        Me.N3.Location = New System.Drawing.Point(252, 191)
        Me.N3.Name = "N3"
        Me.N3.Size = New System.Drawing.Size(192, 26)
        Me.N3.TabIndex = 21
        '
        'N5
        '
        Me.N5.Location = New System.Drawing.Point(184, 329)
        Me.N5.Name = "N5"
        Me.N5.Size = New System.Drawing.Size(192, 26)
        Me.N5.TabIndex = 22
        '
        'N6
        '
        Me.N6.Location = New System.Drawing.Point(184, 392)
        Me.N6.Name = "N6"
        Me.N6.Size = New System.Drawing.Size(192, 26)
        Me.N6.TabIndex = 23
        '
        'N7
        '
        Me.N7.Location = New System.Drawing.Point(184, 489)
        Me.N7.Name = "N7"
        Me.N7.Size = New System.Drawing.Size(192, 26)
        Me.N7.TabIndex = 28
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.Location = New System.Drawing.Point(184, 262)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(105, 24)
        Me.L.TabIndex = 29
        Me.L.TabStop = True
        Me.L.Text = "Laki Laki"
        Me.L.UseVisualStyleBackColor = True
        '
        'P
        '
        Me.P.AutoSize = True
        Me.P.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P.Location = New System.Drawing.Point(324, 262)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(125, 24)
        Me.P.TabIndex = 30
        Me.P.TabStop = True
        Me.P.Text = "Perempuan"
        Me.P.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.FormattingEnabled = True
        Me.C2.Items.AddRange(New Object() {"ISLAM", "KRISTEN", "KATHOLIK", "HINDU", "BUDHA"})
        Me.C2.Location = New System.Drawing.Point(778, 80)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(187, 28)
        Me.C2.TabIndex = 31
        '
        'DG
        '
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(481, 296)
        Me.DG.Name = "DG"
        Me.DG.RowTemplate.Height = 28
        Me.DG.Size = New System.Drawing.Size(808, 188)
        Me.DG.TabIndex = 34
        '
        'CH1
        '
        Me.CH1.AutoSize = True
        Me.CH1.Location = New System.Drawing.Point(828, 148)
        Me.CH1.Name = "CH1"
        Me.CH1.Size = New System.Drawing.Size(95, 24)
        Me.CH1.TabIndex = 35
        Me.CH1.Text = "Menikah"
        Me.CH1.UseVisualStyleBackColor = True
        '
        'CH2
        '
        Me.CH2.AutoSize = True
        Me.CH2.Location = New System.Drawing.Point(828, 194)
        Me.CH2.Name = "CH2"
        Me.CH2.Size = New System.Drawing.Size(144, 24)
        Me.CH2.TabIndex = 36
        Me.CH2.Text = "Belum Menikah"
        Me.CH2.UseVisualStyleBackColor = True
        '
        'CH3
        '
        Me.CH3.AutoSize = True
        Me.CH3.Location = New System.Drawing.Point(1001, 148)
        Me.CH3.Name = "CH3"
        Me.CH3.Size = New System.Drawing.Size(79, 24)
        Me.CH3.TabIndex = 37
        Me.CH3.Text = "Janda"
        Me.CH3.UseVisualStyleBackColor = True
        '
        'CH4
        '
        Me.CH4.AutoSize = True
        Me.CH4.Location = New System.Drawing.Point(1001, 194)
        Me.CH4.Name = "CH4"
        Me.CH4.Size = New System.Drawing.Size(74, 24)
        Me.CH4.TabIndex = 38
        Me.CH4.Text = "Duda"
        Me.CH4.UseVisualStyleBackColor = True
        '
        'N4
        '
        Me.N4.Location = New System.Drawing.Point(469, 194)
        Me.N4.Name = "N4"
        Me.N4.Size = New System.Drawing.Size(192, 26)
        Me.N4.TabIndex = 39
        '
        'N8
        '
        Me.N8.Location = New System.Drawing.Point(405, 490)
        Me.N8.Name = "N8"
        Me.N8.Size = New System.Drawing.Size(192, 26)
        Me.N8.TabIndex = 40
        '
        'C1
        '
        Me.C1.FormattingEnabled = True
        Me.C1.Items.AddRange(New Object() {"jawa tengah", "jawa timur", "jawa barat"})
        Me.C1.Location = New System.Drawing.Point(189, 442)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(187, 28)
        Me.C1.TabIndex = 41
        '
        'EktpDataSet
        '
        Me.EktpDataSet.DataSetName = "ektpDataSet"
        Me.EktpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EktpBindingSource
        '
        Me.EktpBindingSource.DataMember = "ektp"
        Me.EktpBindingSource.DataSource = Me.EktpDataSet
        '
        'EktpTableAdapter
        '
        Me.EktpTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 652)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.N8)
        Me.Controls.Add(Me.N4)
        Me.Controls.Add(Me.CH4)
        Me.Controls.Add(Me.CH3)
        Me.Controls.Add(Me.CH2)
        Me.Controls.Add(Me.CH1)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.N7)
        Me.Controls.Add(Me.N6)
        Me.Controls.Add(Me.N5)
        Me.Controls.Add(Me.N3)
        Me.Controls.Add(Me.N2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
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
        Me.Controls.Add(Me.N1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EktpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EktpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents N1 As System.Windows.Forms.TextBox
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents N2 As System.Windows.Forms.TextBox
    Friend WithEvents N3 As System.Windows.Forms.TextBox
    Friend WithEvents N5 As System.Windows.Forms.TextBox
    Friend WithEvents N6 As System.Windows.Forms.TextBox
    Friend WithEvents N7 As System.Windows.Forms.TextBox
    Friend WithEvents L As System.Windows.Forms.RadioButton
    Friend WithEvents P As System.Windows.Forms.RadioButton
    Friend WithEvents C2 As System.Windows.Forms.ComboBox
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents CH1 As System.Windows.Forms.CheckBox
    Friend WithEvents CH2 As System.Windows.Forms.CheckBox
    Friend WithEvents CH3 As System.Windows.Forms.CheckBox
    Friend WithEvents CH4 As System.Windows.Forms.CheckBox
    Friend WithEvents N4 As System.Windows.Forms.TextBox
    Friend WithEvents N8 As System.Windows.Forms.TextBox
    Friend WithEvents C1 As System.Windows.Forms.ComboBox
    Friend WithEvents EktpDataSet As UTS.ektpDataSet
    Friend WithEvents EktpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EktpTableAdapter As UTS.ektpDataSetTableAdapters.ektpTableAdapter

End Class
