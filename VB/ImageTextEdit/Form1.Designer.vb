Imports Microsoft.VisualBasic
Imports System
Namespace ImageTextEdit
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.customIconTextEdit3 = New ImageTextEdit.CustomIconTextEdit()
			Me.customIconTextEdit2 = New ImageTextEdit.CustomIconTextEdit()
			Me.customIconTextEdit1 = New ImageTextEdit.CustomIconTextEdit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customIconTextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customIconTextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customIconTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageCollection1.Images.SetKeyName(0, "arrowleft_green_32_h.bmp")
			Me.imageCollection1.Images.SetKeyName(1, "arrowleft_green_32_d.bmp")
			Me.imageCollection1.Images.SetKeyName(2, "delete_x_32.bmp")
			' 
			' customIconTextEdit3
			' 
			Me.customIconTextEdit3.EditValue = "Disabled"
			Me.customIconTextEdit3.Enabled = False
			Me.customIconTextEdit3.Location = New System.Drawing.Point(12, 102)
			Me.customIconTextEdit3.Name = "customIconTextEdit3"
			Me.customIconTextEdit3.Properties.ImageIndex = 1
			Me.customIconTextEdit3.Properties.ImageList = Me.imageCollection1
'			Me.customIconTextEdit3.Properties.OnIconSelection += New ImageTextEdit.OnIconSelectionEventHandler(Me.customIconTextEdit1_Properties_OnIconSelection);
			Me.customIconTextEdit3.Size = New System.Drawing.Size(100, 38)
			Me.customIconTextEdit3.TabIndex = 2
'			Me.customIconTextEdit3.IconClick += New ImageTextEdit.IconClickEventHandler(Me.customIconTextEdit1_IconClick);
			' 
			' customIconTextEdit2
			' 
			Me.customIconTextEdit2.EditValue = "Second"
			Me.customIconTextEdit2.Location = New System.Drawing.Point(12, 56)
			Me.customIconTextEdit2.Name = "customIconTextEdit2"
			Me.customIconTextEdit2.Properties.ImageIndex = 1
			Me.customIconTextEdit2.Properties.ImageList = Me.imageCollection1
'			Me.customIconTextEdit2.Properties.OnIconSelection += New ImageTextEdit.OnIconSelectionEventHandler(Me.customIconTextEdit1_Properties_OnIconSelection);
			Me.customIconTextEdit2.Size = New System.Drawing.Size(100, 38)
			Me.customIconTextEdit2.TabIndex = 1
'			Me.customIconTextEdit2.IconClick += New ImageTextEdit.IconClickEventHandler(Me.customIconTextEdit1_IconClick);
			' 
			' customIconTextEdit1
			' 
			Me.customIconTextEdit1.EditValue = "First"
			Me.customIconTextEdit1.Location = New System.Drawing.Point(12, 12)
			Me.customIconTextEdit1.Name = "customIconTextEdit1"
			Me.customIconTextEdit1.Properties.ImageIndex = 1
			Me.customIconTextEdit1.Properties.ImageList = Me.imageCollection1
'			Me.customIconTextEdit1.Properties.OnIconSelection += New ImageTextEdit.OnIconSelectionEventHandler(Me.customIconTextEdit1_Properties_OnIconSelection);
			Me.customIconTextEdit1.Size = New System.Drawing.Size(100, 38)
			Me.customIconTextEdit1.TabIndex = 0
'			Me.customIconTextEdit1.IconClick += New ImageTextEdit.IconClickEventHandler(Me.customIconTextEdit1_IconClick);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(450, 196)
			Me.Controls.Add(Me.customIconTextEdit3)
			Me.Controls.Add(Me.customIconTextEdit2)
			Me.Controls.Add(Me.customIconTextEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customIconTextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customIconTextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customIconTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private WithEvents customIconTextEdit1 As CustomIconTextEdit
		Private WithEvents customIconTextEdit2 As CustomIconTextEdit
		Private WithEvents customIconTextEdit3 As CustomIconTextEdit

	End Class
End Namespace

