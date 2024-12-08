<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        inputNIM = New TextBox()
        inputName = New TextBox()
        Label2 = New Label()
        inputProdi = New TextBox()
        Label3 = New Label()
        ListMahasiswa = New ListView()
        colNIM = New ColumnHeader()
        colName = New ColumnHeader()
        colProdi = New ColumnHeader()
        addButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(88, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 45)
        Label1.TabIndex = 0
        Label1.Text = "NIM"
        ' 
        ' inputNIM
        ' 
        inputNIM.Enabled = False
        inputNIM.Font = New Font("Segoe UI", 12F)
        inputNIM.Location = New Point(252, 52)
        inputNIM.Name = "inputNIM"
        inputNIM.Size = New Size(539, 50)
        inputNIM.TabIndex = 1
        ' 
        ' inputName
        ' 
        inputName.Font = New Font("Segoe UI", 12F)
        inputName.Location = New Point(252, 146)
        inputName.Name = "inputName"
        inputName.Size = New Size(539, 50)
        inputName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(88, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 45)
        Label2.TabIndex = 2
        Label2.Text = "Nama"
        ' 
        ' inputProdi
        ' 
        inputProdi.Font = New Font("Segoe UI", 12F)
        inputProdi.Location = New Point(252, 252)
        inputProdi.Name = "inputProdi"
        inputProdi.Size = New Size(539, 50)
        inputProdi.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(88, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 45)
        Label3.TabIndex = 4
        Label3.Text = "Prodi"
        ' 
        ' ListMahasiswa
        ' 
        ListMahasiswa.Columns.AddRange(New ColumnHeader() {colNIM, colName, colProdi})
        ListMahasiswa.GridLines = True
        ListMahasiswa.Location = New Point(88, 407)
        ListMahasiswa.Name = "ListMahasiswa"
        ListMahasiswa.Size = New Size(703, 247)
        ListMahasiswa.TabIndex = 6
        ListMahasiswa.UseCompatibleStateImageBehavior = False
        ListMahasiswa.View = View.Details
        ' 
        ' colNIM
        ' 
        colNIM.Text = "NIM"
        colNIM.Width = 100
        ' 
        ' colName
        ' 
        colName.Text = "Name"
        colName.Width = 300
        ' 
        ' colProdi
        ' 
        colProdi.Text = "Prodi"
        colProdi.Width = 400
        ' 
        ' addButton
        ' 
        addButton.Location = New Point(451, 335)
        addButton.Name = "addButton"
        addButton.Size = New Size(150, 46)
        addButton.TabIndex = 7
        addButton.Text = "Tambah"
        addButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(844, 697)
        Controls.Add(addButton)
        Controls.Add(ListMahasiswa)
        Controls.Add(inputProdi)
        Controls.Add(Label3)
        Controls.Add(inputName)
        Controls.Add(Label2)
        Controls.Add(inputNIM)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Daftar Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputNIM As TextBox
    Friend WithEvents inputName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents inputProdi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListMahasiswa As ListView
    Friend WithEvents colNIM As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colProdi As ColumnHeader
    Friend WithEvents addButton As Button

End Class
