Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputName.Focus()
        inputNIM.Text = 1
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        If String.IsNullOrEmpty(inputName.Text) OrElse String.IsNullOrEmpty(inputProdi.Text) Then
            MessageBox.Show("Tolong isi semua field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim studentDatum As String() = {inputNIM.Text, inputName.Text, inputProdi.Text}

        AddDataToList(studentDatum)
    End Sub

    Private Sub AddDataToList(studentDatum As String())
        ' Hindari inisialisasi dua kali
        Dim listItem As ListViewItem = ListMahasiswa.Items.Add(studentDatum(0))
        'listItem.SubItems.Add(studentDatum(1))
        'listItem.SubItems.Add(studentDatum(2))

        listItem.SubItems.AddRange({studentDatum(1), studentDatum(2)})

        ' Clear input
        inputNIM.Text = inputNIM.Text + 1
        inputName.Text = ""
        inputProdi.Text = ""
        inputName.Focus()
    End Sub
End Class
