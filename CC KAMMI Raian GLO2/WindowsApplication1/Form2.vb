Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Buttonretour_Click(sender As Object, e As EventArgs) Handles Buttonretour.Click
        Form1.Show()
    End Sub

    Private Sub Buttonvalider_Click(sender As Object, e As EventArgs) Handles Buttonvalider.Click
        Dim valide As New Medicament()

        valide.Idprod = Textid.Text
        valide.Nomprod = Textnommedicament.Text
        valide.prixprod = Textprix.Text
        valide.quantitestock = Textqte.Text

        If valide.valider() = True Then

            Form3.DataGridView1.Rows.Add(valide.Idprod, valide.Nomprod, valide.prixprod, valide.quantitestock)

            Form3.Show()

        End If

    End Sub

    Private Sub Buttonmodif_Click(sender As Object, e As EventArgs) Handles Buttonmodif.Click
        Form3.DataGridView1.CurrentRow.Cells(0).Value = Textid.Text
        Form3.DataGridView1.CurrentRow.Cells(1).Value = Textnommedicament.Text
        Form3.DataGridView1.CurrentRow.Cells(2).Value = Textprix.Text
        Form3.DataGridView1.CurrentRow.Cells(3).Value = Textqte.Text


        Form3.Show()
        Me.Hide()
    End Sub
End Class