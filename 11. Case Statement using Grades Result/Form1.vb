Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim Grade As String
		Grade = ComboBox1.Text ' User is only allowed to chose but not to edit

		Select Case Grade
			Case "A"
				TextBox2.Text = "High Distinction"

			Case "A-"
				TextBox2.Text = "Distinction"

			Case "B"
				TextBox2.Text = "Credit"


			Case "C"
				TextBox2.Text = "Pass"

			Case Else
				TextBox2.Text = "Fail"
		End Select
	End Sub
End Class
