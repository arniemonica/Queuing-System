Imports System.Globalization

Public Class Form4

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        GunaLabel7.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Form4_Activated(sender As Object, e As EventArgs) Handles Me.Activated
     
        


    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dt As String = ""
        Dim dtfinfo As DateTimeFormatInfo
        Dim dtstyle As String = "ddd,dd MMMM yyyy"

        dtfinfo = DateTimeFormatInfo.InvariantInfo
        dt = DateTime.Now.ToString(dtstyle, dtfinfo)
        GunaLabel6.Text = dt


        Timer1.Enabled = True

        GunaLabel7.Text = Date.Now.ToString("hh:mm:ss")




    End Sub

    Private Sub Form4_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        

    End Sub
End Class