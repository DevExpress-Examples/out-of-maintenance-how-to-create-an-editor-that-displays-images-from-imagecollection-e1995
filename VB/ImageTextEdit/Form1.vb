Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace ImageTextEdit

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub customIconTextEdit1_Properties_OnIconSelection(ByVal sender As Object, ByVal e As OnIconSelectionEventArgs)
            Dim editor As CustomIconTextEdit = TryCast(sender, CustomIconTextEdit)
            If editor IsNot Nothing Then
                If editor.Enabled Then
                    If editor.ContainsFocus Then
                        e.ImageIndex = 0
                    Else
                        e.ImageIndex = 1
                    End If
                Else
                    e.ImageIndex = 2
                End If
            End If
        End Sub

        Private Sub customIconTextEdit1_IconClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim editor As CustomIconTextEdit = TryCast(sender, CustomIconTextEdit)
            If editor IsNot Nothing Then
                Text = editor.Name & ".Text = " & editor.Text
            End If
        End Sub
    End Class
End Namespace
