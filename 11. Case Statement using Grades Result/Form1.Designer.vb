<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Label1 = New Label()
		Button1 = New Button()
		Label2 = New Label()
		TextBox2 = New TextBox()
		ComboBox1 = New ComboBox()
		Label3 = New Label()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(146, 96)
		Label1.Name = "Label1"
		Label1.Size = New Size(179, 25)
		Label1.TabIndex = 0
		Label1.Text = "Enter the Grade letter"
		' 
		' Button1
		' 
		Button1.Location = New Point(241, 256)
		Button1.Name = "Button1"
		Button1.Size = New Size(112, 34)
		Button1.TabIndex = 1
		Button1.Text = "Compute"
		Button1.UseVisualStyleBackColor = True
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(164, 154)
		Label2.Name = "Label2"
		Label2.Size = New Size(67, 25)
		Label2.TabIndex = 2
		Label2.Text = "Results"
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(348, 148)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(150, 31)
		TextBox2.TabIndex = 3
		' 
		' ComboBox1
		' 
		ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
		ComboBox1.FormattingEnabled = True
		ComboBox1.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F"})
		ComboBox1.Location = New Point(348, 88)
		ComboBox1.Name = "ComboBox1"
		ComboBox1.Size = New Size(182, 33)
		ComboBox1.TabIndex = 4
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Showcard Gothic", 16F, FontStyle.Underline, GraphicsUnit.Point)
		Label3.Location = New Point(178, 25)
		Label3.Name = "Label3"
		Label3.Size = New Size(244, 40)
		Label3.TabIndex = 5
		Label3.Text = "Grade Result"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.AppWorkspace
		ClientSize = New Size(800, 450)
		Controls.Add(Label3)
		Controls.Add(ComboBox1)
		Controls.Add(TextBox2)
		Controls.Add(Label2)
		Controls.Add(Button1)
		Controls.Add(Label1)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label3 As Label
End Class
