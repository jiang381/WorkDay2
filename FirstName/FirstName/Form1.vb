Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String
        'Read the input from the user
        fullname = txtFullName.Text

        'Trim the input so as to remove leading spaces
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()


        'find the index of first space

        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")

        'Extract the first name
        Dim firstname As String
        firstname = fullnameTrimmed.Substring(0, idxSpace)



        'Display the result to the user
        TextFirstName.Text = firstname









    End Sub

    Private Function txtFirstName() As Object
        Throw New NotImplementedException
    End Function

End Class
