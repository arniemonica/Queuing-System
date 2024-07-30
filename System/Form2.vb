
Imports System.Globalization

Public Class Form2

    Private Sub GunaGradientButton1_Click(sender As System.Object, e As System.EventArgs) Handles GunaGradientButton1.Click
        If GunaGradientButton1.Enabled = True Then
            GunaLabel8.Text = ListBox1.SelectedItem

            GunaLabel10.Text = Val(GunaLabel10.Text) - 1
        End If
        If GunaLabel10.Text = "0" Then
            GunaGradientButton1.Enabled = False
        Else
            GunaGradientButton1.Enabled = True

        End If

        GunaLabel9.Text = ListBox2.SelectedItem


        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        If GunaGradientButton1.Enabled = True Then
            ListBox1.SelectedIndex += 1
            ListBox2.SelectedIndex += 1
        End If


        Form4.GunaLabel8.Text = Form4.ListBox1.SelectedItem

        Form4.GunaLabel9.Text = Form4.ListBox2.SelectedItem

        Form4.ListBox1.Items.RemoveAt(Form4.ListBox1.SelectedIndex)
        Form4.ListBox2.Items.RemoveAt(Form4.ListBox2.SelectedIndex)
        If GunaGradientButton1.Enabled = True Then
            Form4.ListBox1.SelectedIndex += 1
            Form4.ListBox2.SelectedIndex += 1
        End If



    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        




        GunaLabel11.Text = Form1.GunaTextBox3.Text

        If GunaLabel10.Text = 0 Then
            GunaGradientButton1.Enabled = False
        Else
            GunaGradientButton1.Enabled = True

        End If
        If Form1.GunaTextBox3.Text = 1 Then
            GunaLabel9.Text = Form1.GunaTextBox1.Text
        End If


    End Sub

    Private Sub Form2_AutoSizeChanged(sender As Object, e As EventArgs) Handles Me.AutoSizeChanged

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        Form4.ListBox1.SetSelected(0, True)
        Form4.ListBox2.SetSelected(0, True)
        ListBox1.SetSelected(0, True)
        ListBox2.SetSelected(0, True)


        Dim dt As String = ""
        Dim dtfinfo As DateTimeFormatInfo
        Dim dtstyle As String = "ddd,dd MMMM yyyy"

        dtfinfo = DateTimeFormatInfo.InvariantInfo
        dt = DateTime.Now.ToString(dtstyle, dtfinfo)
        GunaLabel6.Text = dt

        If Form1.GunaTextBox3.Text = 1 Then
            GunaLabel9.Text = Form1.GunaTextBox1.Text


        End If

        Timer1.Enabled = True

        GunaLabel7.Text = Date.Now.ToString("hh:mm:ss")
        ListBox1.SetSelected(0, True)
        ListBox2.SetSelected(0, True)


    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        GunaLabel7.Text = Date.Now.ToString("hh:mm:ss")
    End Sub


    Private Sub Form2_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate


    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox2.SelectedIndexChanged


    End Sub
End Class