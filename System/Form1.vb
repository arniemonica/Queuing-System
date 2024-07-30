Imports System.Data.OleDb
Public Class Form1
    Dim provider As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
   

    Private Sub GunaGradientButton1_Click(sender As System.Object, e As System.EventArgs) Handles GunaGradientButton1.Click
        
        GunaTextBox3.Text = Val(GunaTextBox3.Text) + 1

        provider = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\genden0902\Documents\System\System.accdb"
        connstring = provider
        myconnection.ConnectionString = connstring
        myconnection.Open()

        Dim str As String
        str = "Insert into Table1([First],[Middle],[Last],[Contact],[Number]) Values (?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.Add(New OleDbParameter("First", CType(GunaTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Middle", CType(GunaTextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Last", CType(GunaTextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Contact", CType(GunaTextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Number", CType(GunaTextBox3.Text, String)))
        Try

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()




        Catch ex As Exception


        End Try
        If GunaTextBox1.Text = "" And GunaTextBox2.Text = "" And GunaTextBox4.Text = "" And GunaTextBox5.Text = "" Then
            MessageBox.Show("input necessary information first", "No entry",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            GunaTextBox3.Text = 0


        Else
            Form2.GunaLabel10.Text = Val(Form2.GunaLabel10.Text) + 1
            Form2.ListBox2.Items.Add(GunaTextBox1.Text + Environment.NewLine + " " + GunaTextBox4.Text + Environment.NewLine + " " + GunaTextBox5.Text)
            Form2.ListBox1.Items.Add(GunaTextBox3.Text)
            Form4.ListBox2.Items.Add(GunaTextBox1.Text + Environment.NewLine + " " + GunaTextBox4.Text + Environment.NewLine + " " + GunaTextBox5.Text)
            Form4.ListBox1.Items.Add(GunaTextBox3.Text)
            MsgBox("Your Number is   " + GunaTextBox3.Text)
            GunaTextBox1.Text = ""
            GunaTextBox2.Text = ""
            GunaTextBox4.Text = ""
            GunaTextBox5.Text = ""
            Form4.Show()
            Form4.ListBox1.SetSelected(0, True)
            Form4.ListBox2.SetSelected(0, True)
            Form2.ListBox1.SetSelected(0, True)
            Form2.ListBox2.SetSelected(0, True)
        End If


    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        GunaTextBox3.Visible = False

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Process.Start("https://www.youtube.com/channel/UCmX-QuWML5HAqZvhdt2OAwQ")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Process.Start("https://www.facebook.com/InformaticsCaviteSeniorHigh")
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs)
        Process.Start("https://www.youtube.com/channel/UCmX-QuWML5HAqZvhdt2OAwQ")
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs)
        Process.Start("https://www.facebook.com/InformaticsCaviteSeniorHigh")
    End Sub

    Private Sub GunaTextBox2_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles GunaTextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

   
    Private Sub GunaGradientButton2_Click(sender As System.Object, e As System.EventArgs) Handles GunaGradientButton2.Click

        Form3.Show()
       



    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As System.Object, e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.settings.setMode("Loop", True)
    End Sub

End Class
