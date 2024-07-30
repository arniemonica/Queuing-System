Public Class Form3

    Private Sub GunaGradientButton1_Click(sender As System.Object, e As System.EventArgs) Handles GunaGradientButton1.Click



       If GunaTextBox1.Text = "admin" And GunaTextBox2.Text = "admin" Then

            If Form1.GunaTextBox3.Text = 0 Then
                MessageBox.Show("No Enrollees", "",
                                 MessageBoxButtons.OK, MessageBoxIcon.Stop)
                
                Me.Hide()
                Form1.Show()

            Else
                Form2.Show()
                Me.Hide()
                GunaTextBox1.Text = ""
                GunaTextBox2.Text = ""
               
            End If
        Else

            MessageBox.Show("Cannot Access to this Server", "No entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Hide()
            Form1.Show()
            GunaTextBox1.Text = ""
            GunaTextBox2.Text = ""
        End If
    End Sub

    Private Sub GunaGradientButton1_Resize(sender As Object, e As EventArgs) Handles GunaGradientButton1.Resize
      
    End Sub

    Private Sub Form3_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        


    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      
    End Sub
End Class