Public Class Form1
    'geen variabele die de keren dat er wordt ingelogd telt en ook niet een functie die hierop controleert
    Public minLenghtPassword As Integer = 8
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Hide()
        Button2.Hide()
        Label2.Hide()
        WarningMsg.ForeColor() = Color.Red
        WarningMsg.Hide()
        WachtwoordTB.Hide()
        LoginButton.Hide()
        CheckBox1.Hide()

    End Sub

    Private Sub VoornaamTB_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub AchternaamTB_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub FirstOK_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Hide()
        Button1.Hide()
        TextBox2.Show()
        Button2.Show()
    End Sub

    Private Sub SecondOK_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "Welkom"
        Label2.Text = TextBox1.Text & " " & TextBox2.Text
        Button2.Hide()
        TextBox2.Hide()
        Label2.Show()
        WachtwoordTB.Show()
        LoginButton.Show()
        CheckBox1.Show()
    End Sub

    Private Sub Username_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub WachtwoordTB_TextChanged(sender As Object, e As EventArgs) Handles WachtwoordTB.TextChanged

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        'Speciaal teken is geen vereiste om in te loggen hier


        'Dim specialChar As Boolean
        'If InStr(1, "~`!@#$%^&*()-_=+';:,./<>", Me.WachtwoordTB.Text) > 0 Then
        '    specialChar = True
        'End If
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim alphabet As New System.Text.RegularExpressions.Regex("[A-Z],[a-z]")
        'Dim specialChar As New System.Text.RegularExpressions.Regex("~`!@#\$%\^&\*\(\)-_=\+;:,\./<>")
        'If WachtwoordTB.Text.Length < minLenghtPassword Then
        '    MsgBox("lengte 8 char")

        'ElseIf number.Matches(WachtwoordTB.Text).Count < 1 Then
        '    MsgBox("numbers")

        'ElseIf specialChar.Matches(WachtwoordTB.Text).Count < 1 Then
        '    MsgBox("specioals")
        'Else
        '    MsgBox("Succes!")
        'End If

        If WachtwoordTB.Text.Length < minLenghtPassword Or number.Matches(WachtwoordTB.Text).Count < 1 Then
            WarningMsg.Show()
        Else
            MsgBox("succes!")
        End If
    End Sub

    Private Sub WarningMsg_Click(sender As Object, e As EventArgs) Handles WarningMsg.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'opdracht was bij default in sterretjes te tonen, voor de rest werkt de functionaliteit zoals te verwachten


        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If CheckBox1.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOW THE TEXT
            WachtwoordTB.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN IT INTIO BULLETS.
            WachtwoordTB.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "Login"
        TextBox1.Text = "voornaam"
        TextBox1.Show()
        TextBox2.Text = "achternaam"
        Button1.Show()
        Button2.Hide()
        Label2.Hide()
        WarningMsg.Hide()
        WachtwoordTB.Hide()
        WachtwoordTB.Text = "wachtwoord"
        LoginButton.Hide()
        CheckBox1.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
