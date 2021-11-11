Public Class Form1
    Dim I1 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Then
            MsgBox("Nu ati completat ambele texbox-uri!")
        Else
            If ListBox1.Items.Contains(Me.TextBox1.Text) = False And ListBox2.Items.Contains(Me.TextBox2.Text) = False Then
                Me.ListBox1.Items.Add(Me.TextBox1.Text)
                Me.ListBox2.Items.Add(Me.TextBox2.Text)
                Me.TextBox1.Clear()
                Me.TextBox2.Clear()
            Else
                MsgBox("Aveti deja acest produs in lista!")
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Trim(TextBox1.Text) = "" Then
            MsgBox("Nu ati completat texbox-ul!")
        Else
            If ListBox1.Items.Contains(Me.TextBox1.Text) = False Then
                Me.ListBox1.Items.Add(Me.TextBox1.Text)
                Me.ListBox2.Items.Add(Me.TextBox2.Text)
                Me.TextBox1.Clear()

            Else
                MsgBox("Aveti deja acest produs in lista!")
            End If
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Trim(TextBox2.Text) = "" Then
            MsgBox("Nu ati completat texbox-ul!")
        Else
            If ListBox1.Items.Contains(Me.TextBox2.Text) = False Then
                Me.ListBox2.Items.Add(Me.TextBox2.Text)
                Me.ListBox1.Items.Add(Me.TextBox1.Text)
                Me.TextBox2.Clear()
            Else
                MsgBox("Aveti deja acest produs in lista!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        I1 = ListBox1.SelectedIndex
        If I1 >= 0 Then
            Me.ListBox1.Items.RemoveAt(I1)
            Me.ListBox2.Items.RemoveAt(I1)
        ElseIf Trim(TextBox1.Text) = "" Then
            MsgBox("Din pacate va trebui sa adaugati inca un produs in lista 1 pentru a il putea sterge pe acesta!")
        ElseIf Trim(TextBox2.Text) = "" Then
            MsgBox("Din pacate va trebui sa adaugati inca un produs in lista 2 pentru a il putea sterge pe acesta!")
        Else
            MsgBox("Selectati din lista produsul pe care doriti sa il stergeti!")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Trim(TextBox1.Text) = "" Then
            MsgBox("Pentru a inlocui, scrieti in textbox numele noului produs!")
        Else
            I1 = ListBox1.SelectedIndex
            If I1 >= 0 Then
                Me.ListBox1.Items.Item(I1) = Me.TextBox1.Text
                Me.TextBox1.Clear()
            End If
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Trim(TextBox2.Text) = "" Then
            MsgBox("Pentru a inlocui, scrieti in textbox numele noului produs!")
        Else
            I1 = ListBox2.SelectedIndex
            If I1 >= 0 Then
                Me.ListBox2.Items.Item(I1) = Me.TextBox2.Text
                Me.TextBox2.Clear()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        Me.RadioButton3.Checked = False
        Me.RadioButton4.Checked = False
        Me.RadioButton1.Visible = True
        Me.RadioButton2.Visible = True
        Me.RadioButton3.Visible = True
        Me.RadioButton4.Visible = True

        If ListBox1.SelectedIndex >= 0 Then
            ListBox1.SetSelected(ListBox1.SelectedIndex, False)
        End If
        If ListBox2.SelectedIndex >= 0 Then
            ListBox2.SetSelected(ListBox2.SelectedIndex, False)
        End If

    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Me.Button1.BackColor = Color.DarkGreen
        Me.Button1.ForeColor = Color.White
        Me.Button1.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackColor = Color.OrangeRed
        Me.Button1.ForeColor = Color.White
        Me.Button1.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Me.Button2.BackColor = Color.DarkGreen
        Me.Button2.ForeColor = Color.White
        Me.Button2.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackColor = Color.OrangeRed
        Me.Button2.ForeColor = Color.White
        Me.Button2.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Me.Button3.BackColor = Color.DarkGreen
        Me.Button3.ForeColor = Color.White
        Me.Button3.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Me.Button3.BackColor = Color.OrangeRed
        Me.Button3.ForeColor = Color.White
        Me.Button3.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub
    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Me.Button4.BackColor = Color.Crimson
        Me.Button4.ForeColor = Color.White
        Me.Button4.Font = New Font("Times New Roman", 15, FontStyle.Regular)
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Me.Button4.BackColor = Color.Red
        Me.Button4.ForeColor = Color.White
        Me.Button4.Font = New Font("SegoeUI", 11, FontStyle.Regular)
    End Sub
    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Me.Button5.BackColor = Color.DarkGreen
        Me.Button5.ForeColor = Color.White
        Me.Button5.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Me.Button5.BackColor = Color.OrangeRed
        Me.Button5.ForeColor = Color.White
        Me.Button5.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub
    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        Me.Button6.BackColor = Color.DarkGreen
        Me.Button6.ForeColor = Color.White
        Me.Button6.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Me.Button6.BackColor = Color.OrangeRed
        Me.Button6.ForeColor = Color.White
        Me.Button6.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub
    Private Sub Button7_MouseHover(sender As Object, e As EventArgs) Handles Button7.MouseHover
        Me.Button7.BackColor = Color.DarkGreen
        Me.Button7.ForeColor = Color.White
        Me.Button7.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Me.Button7.BackColor = Color.Coral
        Me.Button7.ForeColor = Color.White
        Me.Button7.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub
    Private Sub Button8_MouseHover(sender As Object, e As EventArgs) Handles Button8.MouseHover
        Me.Button8.BackColor = Color.DarkGreen
        Me.Button8.ForeColor = Color.White
        Me.Button8.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Me.Button8.BackColor = Color.Coral
        Me.Button8.ForeColor = Color.White
        Me.Button8.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub
    Private Sub Button9_MouseHover(sender As Object, e As EventArgs) Handles Button9.MouseHover
        Me.Button9.BackColor = Color.DarkGreen
        Me.Button9.ForeColor = Color.White
        Me.Button9.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button9_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        Me.Button9.BackColor = Color.OrangeRed
        Me.Button9.ForeColor = Color.White
        Me.Button9.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub
    Private Sub Button10_MouseHover(sender As Object, e As EventArgs) Handles Button10.MouseHover
        Me.Button10.BackColor = Color.DarkGreen
        Me.Button10.ForeColor = Color.White
        Me.Button10.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button10_MouseLeave(sender As Object, e As EventArgs) Handles Button10.MouseLeave
        Me.Button10.BackColor = Color.OrangeRed
        Me.Button10.ForeColor = Color.White
        Me.Button10.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub
    Private Sub Button11_MouseHover(sender As Object, e As EventArgs) Handles Button11.MouseHover
        Me.Button11.BackColor = Color.DarkGreen
        Me.Button11.ForeColor = Color.White
        Me.Button11.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button11_MouseLeave(sender As Object, e As EventArgs) Handles Button11.MouseLeave
        Me.Button11.BackColor = Color.Coral
        Me.Button11.ForeColor = Color.White
        Me.Button11.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub
    Private Sub Button12_MouseHover(sender As Object, e As EventArgs) Handles Button12.MouseHover
        Me.Button12.BackColor = Color.DarkGreen
        Me.Button12.ForeColor = Color.White
        Me.Button12.Font = New Font("Times New Roman", 11, FontStyle.Regular)
    End Sub
    Private Sub Button12_MouseLeave(sender As Object, e As EventArgs) Handles Button12.MouseLeave
        Me.Button12.BackColor = Color.Coral
        Me.Button12.ForeColor = Color.White
        Me.Button12.Font = New Font("SegoeUI", 10, FontStyle.Regular)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.RadioButton1.Visible = True
            Me.RadioButton2.Visible = True
            Me.RadioButton3.Visible = True
            Me.RadioButton4.Visible = True
            Me.Button1.Visible = True
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = False
            Me.Button7.Visible = True
            Me.Button8.Visible = True
            Me.Button9.Visible = False
            Me.Button10.Visible = False
            Me.Button11.Visible = False
            Me.Button12.Visible = False


        Else
            Me.RadioButton1.Visible = False
            Me.RadioButton2.Visible = False
            Me.RadioButton3.Visible = False
            Me.RadioButton4.Visible = False
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = True
            Me.Button8.Visible = True
            Me.Button9.Visible = True
            Me.Button10.Visible = True
            Me.Button11.Visible = True
            Me.Button12.Visible = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton2.Checked = True Then
            Me.RadioButton1.Visible = True
            Me.RadioButton2.Visible = True
            Me.RadioButton3.Visible = True
            Me.RadioButton4.Visible = True
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = False
            Me.Button8.Visible = False
            Me.Button9.Visible = False
            Me.Button10.Visible = False
            Me.Button11.Visible = False
            Me.Button12.Visible = False

        Else
            Me.RadioButton1.Visible = False
            Me.RadioButton2.Visible = False
            Me.RadioButton3.Visible = False
            Me.RadioButton4.Visible = False
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = True
            Me.Button8.Visible = True
            Me.Button9.Visible = True
            Me.Button10.Visible = True
            Me.Button11.Visible = True
            Me.Button12.Visible = True
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If Me.RadioButton3.Checked = True Then
            Me.RadioButton1.Visible = True
            Me.RadioButton2.Visible = True
            Me.RadioButton3.Visible = True
            Me.RadioButton4.Visible = True
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = False
            Me.Button7.Visible = False
            Me.Button8.Visible = False
            Me.Button9.Visible = True
            Me.Button10.Visible = True
            Me.Button11.Visible = False
            Me.Button12.Visible = False

        Else
            Me.RadioButton1.Visible = False
            Me.RadioButton2.Visible = False
            Me.RadioButton3.Visible = False
            Me.RadioButton4.Visible = False
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = True
            Me.Button8.Visible = True
            Me.Button9.Visible = True
            Me.Button10.Visible = True
            Me.Button11.Visible = True
            Me.Button12.Visible = True
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Trim(TextBox1.Text) = "" Then
            MsgBox("Introduceti in prima lista produsul pe care il cautati!")
        Else
            For i = 0 To ListBox1.Items.Count - 1
                If ListBox1.Items(i).ToString.IndexOf(TextBox1.Text) >= 0 Then
                    MsgBox("Aveti acest produs in lista!")
                    ListBox1.SetSelected(i, True)
                    ListBox2.SetSelected(i, True)
                    Exit For
                Else
                    If i = ListBox1.Items.Count - 1 Then
                        MsgBox("Nu aveti acest produs in lista!")
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Trim(TextBox2.Text) = "" Then
            MsgBox("Introduceti in prima lista produsul pe care il cautati!")
        Else
            For i = 0 To ListBox2.Items.Count - 1
                If ListBox2.Items(i).ToString.IndexOf(TextBox2.Text) >= 0 Then
                    MsgBox("Aveti acest produs in lista!")
                    ListBox1.SetSelected(i, True)
                    ListBox2.SetSelected(i, True)
                    Exit For
                Else
                    If i = ListBox2.Items.Count - 1 Then
                        MsgBox("Nu aveti acest produs in lista!")
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        I1 = ListBox1.SelectedIndex
        If I1 >= 0 Then
            Me.ListBox1.Items.RemoveAt(I1)
        Else
            MsgBox("Selectati din lista produsul pe care doriti sa il stergeti!")
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        I1 = ListBox2.SelectedIndex
        If I1 >= 0 Then
            Me.ListBox2.Items.RemoveAt(I1)
        Else
            MsgBox("Selectati din lista produsul pe care doriti sa il stergeti!")
        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If Me.RadioButton4.Checked = True Then
            Me.RadioButton1.Visible = True
            Me.RadioButton2.Visible = True
            Me.RadioButton3.Visible = True
            Me.RadioButton4.Visible = True
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = False
            Me.Button7.Visible = False
            Me.Button8.Visible = False
            Me.Button9.Visible = False
            Me.Button10.Visible = False
            Me.Button11.Visible = True
            Me.Button12.Visible = True

        Else
            Me.RadioButton1.Visible = False
            Me.RadioButton2.Visible = False
            Me.RadioButton3.Visible = False
            Me.RadioButton4.Visible = False
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = True
            Me.Button8.Visible = True
            Me.Button9.Visible = True
            Me.Button10.Visible = True
            Me.Button11.Visible = True
            Me.Button12.Visible = True
        End If
    End Sub
End Class
