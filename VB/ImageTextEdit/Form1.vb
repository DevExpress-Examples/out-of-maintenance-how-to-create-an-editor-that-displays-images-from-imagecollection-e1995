Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace ImageTextEdit
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub customIconTextEdit1_Properties_OnIconSelection(ByVal sender As Object, ByVal e As OnIconSelectionEventArgs) Handles customIconTextEdit3.Properties.OnIconSelection, customIconTextEdit2.Properties.OnIconSelection, customIconTextEdit1.Properties.OnIconSelection
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

		Private Sub customIconTextEdit1_IconClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles customIconTextEdit3.IconClick, customIconTextEdit2.IconClick, customIconTextEdit1.IconClick
			Dim editor As CustomIconTextEdit = TryCast(sender, CustomIconTextEdit)
			If editor IsNot Nothing Then
				Me.Text = editor.Name & ".Text = " & editor.Text
			End If
		End Sub
	End Class
End Namespace