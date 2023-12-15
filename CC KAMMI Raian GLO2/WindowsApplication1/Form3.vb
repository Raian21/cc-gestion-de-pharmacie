Public Class Form3
    Private Sub Buttonretour2_Click(sender As Object, e As EventArgs) Handles Buttonretour2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Buttonmodifier_Click(sender As Object, e As EventArgs) Handles Buttonmodifier.Click
        Dim Idprod As String = DataGridView1.CurrentRow.Cells(0).Value
        Dim Nomprod As String = DataGridView1.CurrentRow.Cells(1).Value
        Dim prixprod As Integer = DataGridView1.CurrentRow.Cells(2).Value
        Dim quantitestock As Integer = DataGridView1.CurrentRow.Cells(3).Value



        Form2.Textid.Text = Idprod
        Form2.Textnommedicament.Text = Nomprod
        Form2.Textprix.Text = prixprod
        Form2.Textqte.Text = quantitestock
        Form2.Buttonvalider.Enabled() = False
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Buttonsupp_Click(sender As Object, e As EventArgs) Handles Buttonsupp.Click
        Dim position = DataGridView1.CurrentRow.Index
        DataGridView1.Rows.RemoveAt(position)
    End Sub
End Class