Imports System
Imports DevExpress.XtraEditors.Registrator
Imports System.ComponentModel
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing

Namespace ImageTextEdit

    <UserRepositoryItem("RegisterCustomIconTextEdit")>
    Public Class RepositoryItemCustomIconTextEdit
        Inherits RepositoryItemTextEdit
        Implements IIconSelector

        Private imageListField As Object

        Private imageIndexField As Integer

        Shared Sub New()
            Call RegisterCustomIconTextEdit()
        End Sub

        Public Sub New()
            imageListField = Nothing
            ImageIndex = -1
        End Sub

        Public Const CustomIconTextEditName As String = "CustomIconTextEdit"

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return CustomIconTextEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomIconTextEdit()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomIconTextEditName, GetType(CustomIconTextEdit), GetType(RepositoryItemCustomIconTextEdit), GetType(TextEditViewInfo), New TextEditPainter(), True))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            MyBase.Assign(item)
            Dim source As RepositoryItemCustomIconTextEdit = TryCast(item, RepositoryItemCustomIconTextEdit)
            Events.AddHandler(_iconClick, source.Events(_iconClick))
            Events.AddHandler(_onIconSelection, source.Events(_onIconSelection))
            imageListField = source.ImageList
            imageIndexField = source.ImageIndex
        End Sub

        Private Shared ReadOnly _iconClick As Object = New Object()

        Private Shared ReadOnly _onIconSelection As Object = New Object()

        Public Custom Event IconClick As IconClickEventHandler
            AddHandler(ByVal value As IconClickEventHandler)
                Events.AddHandler(_iconClick, value)
            End AddHandler

            RemoveHandler(ByVal value As IconClickEventHandler)
                Events.RemoveHandler(_iconClick, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As MouseEventArgs)
            End RaiseEvent
        End Event

        Protected Friend Overridable Sub RaiseIconClick(ByVal e As MouseEventArgs)
            Dim handler As IconClickEventHandler = CType(Events(_iconClick), IconClickEventHandler)
            If handler IsNot Nothing Then handler(GetEventSender(), e)
        End Sub

        Friend ReadOnly Property CanRaiseBeforeEditValueLoaded As Boolean
            Get
                Return CType(Events(_iconClick), IconClickEventHandler) IsNot Nothing
            End Get
        End Property

        Public Custom Event OnIconSelection As OnIconSelectionEventHandler Implements IIconSelector.OnIconSelection
            AddHandler(ByVal value As OnIconSelectionEventHandler)
                Events.AddHandler(_onIconSelection, value)
            End AddHandler

            RemoveHandler(ByVal value As OnIconSelectionEventHandler)
                Events.RemoveHandler(_onIconSelection, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As OnIconSelectionEventArgs)
            End RaiseEvent
        End Event

        Protected Friend Overridable Sub RaiseOnIconSelection(ByVal e As OnIconSelectionEventArgs)
            Dim handler As OnIconSelectionEventHandler = CType(Events(_onIconSelection), OnIconSelectionEventHandler)
            If handler IsNot Nothing Then handler(GetEventSender(), e)
        End Sub

        <Description("Gets or sets the source of images to be displayed within the editor."), Category(CategoryName.Appearance), TypeConverter(GetType(Design.ImageCollectionImagesConverter))>
        Public Overridable Property ImageList As Object
            Get
                Return imageListField
            End Get

            Set(ByVal value As Object)
                If ImageList Is value Then Return
                imageListField = value
                OnPropertiesChanged()
            End Set
        End Property

        <Description("Gets or sets the index of the image displayed on the editor."), Category(CategoryName.Appearance), DefaultValue(-1), Editor(GetType(Design.ImageIndexesEditor), GetType(System.Drawing.Design.UITypeEditor)), ImageList("ImageList")>
        Public Overridable Property ImageIndex As Integer
            Get
                Return imageIndexField
            End Get

            Set(ByVal value As Integer)
                If ImageIndex = value Then Return
                imageIndexField = value
                OnPropertiesChanged()
            End Set
        End Property

        Public Overrides Function CreateViewInfo() As BaseEditViewInfo
            Return New CustomIconTextEditViewInfo(Me)
        End Function

        Public Overrides Function CreatePainter() As BaseEditPainter
            Return New CustomIconTextEditPainter()
        End Function
    End Class

    Public Delegate Sub IconClickEventHandler(ByVal sender As Object, ByVal e As MouseEventArgs)

    Public Delegate Sub OnIconSelectionEventHandler(ByVal sender As Object, ByVal e As OnIconSelectionEventArgs)

    Public Class OnIconSelectionEventArgs
        Inherits EventArgs

        Private imageIndexField As Integer

        Private imageListField As Object

        Public Sub New(ByVal iconCollection As Object, ByVal iconIndex As Integer)
            imageListField = iconCollection
            imageIndexField = iconIndex
        End Sub

        Public Overridable Property ImageIndex As Integer
            Get
                Return imageIndexField
            End Get

            Set(ByVal value As Integer)
                imageIndexField = value
            End Set
        End Property

        Public Overridable ReadOnly Property ImageList As Object
            Get
                Return imageListField
            End Get
        'set { imageList = value; }
        End Property
    End Class

    Public Class CustomIconTextEdit
        Inherits TextEdit

        Shared Sub New()
            RepositoryItemCustomIconTextEdit.RegisterCustomIconTextEdit()
        End Sub

        Public Sub New()
            MyBase.New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return RepositoryItemCustomIconTextEdit.CustomIconTextEditName
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads ReadOnly Property Properties As RepositoryItemCustomIconTextEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomIconTextEdit)
            End Get
        End Property

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            Dim vi As CustomIconTextEditViewInfo = TryCast(ViewInfo, CustomIconTextEditViewInfo)
            If vi.IsIconClick(e.Location) Then
                Dim newX As Integer = e.X - vi.IconRect.Left
                Dim newY As Integer = e.Y - vi.IconRect.Top
                Dim ee As MouseEventArgs = New MouseEventArgs(e.Button, e.Clicks, newX, newY, e.Delta)
                Properties.RaiseIconClick(ee)
            End If

            MyBase.OnMouseDown(e)
        End Sub

        Public Custom Event IconClick As IconClickEventHandler
            AddHandler(ByVal value As IconClickEventHandler)
                AddHandler Properties.IconClick, value
            End AddHandler

            RemoveHandler(ByVal value As IconClickEventHandler)
                RemoveHandler Properties.IconClick, value
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As MouseEventArgs)
            End RaiseEvent
        End Event
    End Class

    Public Class CustomIconTextEditViewInfo
        Inherits TextEditViewInfo

        Private fIconRect As Rectangle

        Private SeparatorWidth As Integer = 3

        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
            fIconRect = Rectangle.Empty
        End Sub

        Protected Overridable Friend Function IsIconClick(ByVal p As Point) As Boolean
            If p.X > IconRect.Left AndAlso p.X < IconRect.Right AndAlso p.Y > IconRect.Top AndAlso p.Y < IconRect.Bottom Then
                Return True
            Else
                Return False
            End If
        End Function

        Public ReadOnly Property ImageList As Object
            Get
                Return Item.ImageList
            End Get
        End Property

        Public ReadOnly Property ImageIndex As Integer
            Get
                Return Item.ImageIndex
            End Get
        End Property

        Public Overridable Overloads ReadOnly Property Item As RepositoryItemCustomIconTextEdit
            Get
                Return TryCast(MyBase.Item, RepositoryItemCustomIconTextEdit)
            End Get
        End Property

        Protected Overrides Sub Assign(ByVal info As BaseControlViewInfo)
            MyBase.Assign(info)
            Dim be As CustomIconTextEditViewInfo = TryCast(info, CustomIconTextEditViewInfo)
            If be Is Nothing Then Return
            fIconRect = be.fIconRect
        End Sub

        Public Overrides Function CalcBestFit(ByVal g As Graphics) As Size
            Dim s As Size = MyBase.CalcBestFit(g)
            s.Width = s.Width + SeparatorWidth * 2 + GetImageSize().Width
            Return s
        End Function

        Protected Friend Overridable Property IconRect As Rectangle
            Get
                Return fIconRect
            End Get

            Set(ByVal value As Rectangle)
                fIconRect = value
            End Set
        End Property

        Public Overrides Sub Offset(ByVal x As Integer, ByVal y As Integer)
            MyBase.Offset(x, y)
            If Not fIconRect.IsEmpty Then fIconRect.Offset(x, y)
        End Sub

        Protected Overrides Function CalcMaskBoxRect(ByVal content As Rectangle, ByRef contextImageBounds As Rectangle) As Rectangle
            Dim r As Rectangle = MyBase.CalcMaskBoxRect(content, contextImageBounds)
            r.Width = r.Width - GetImageSize().Width - SeparatorWidth
            Return r
        End Function

        Protected Overrides Sub CalcContentRect(ByVal bounds As Rectangle)
            MyBase.CalcContentRect(bounds)
            fIconRect = CalcIconRect(ContentRect)
        End Sub

        Protected Overridable Function CalcIconRect(ByVal content As Rectangle) As Rectangle
            Dim r As Rectangle = fMaskBoxRect
            r.Size = GetImageSize()
            r.Location = New Point(fMaskBoxRect.Right + SeparatorWidth, content.Top + content.Height \ 2 - r.Height \ 2)
            Return r
        End Function

        Protected Function GetImageSize() As Size
            Dim ic As ImageCollection = TryCast(ImageList, ImageCollection)
            If ic IsNot Nothing Then Return ic.ImageSize
            Return New Size(0, 0)
        End Function

        Protected Overrides Function CalcMinHeightCore(ByVal g As Graphics) As Integer
            Dim imageHeight As Integer = 0
            If ImageList IsNot Nothing Then
                imageHeight = GetImageSize().Height
                If AllowDrawFocusRect Then imageHeight +=(FocusRectThin + 1) * 2
            End If

            Dim fontHeight As Integer = MyBase.CalcMinHeightCore(g)
            If imageHeight > fontHeight Then
                Return imageHeight
            Else
                Return fontHeight
            End If
        End Function
    End Class

    Public Class CustomIconTextEditPainter
        Inherits TextEditPainter

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Sub DrawContent(ByVal info As ControlGraphicsInfoArgs)
            MyBase.DrawContent(info)
            DrawIcon(info)
        End Sub

        Protected Overridable Sub DrawIcon(ByVal info As ControlGraphicsInfoArgs)
            Dim vi As CustomIconTextEditViewInfo = TryCast(info.ViewInfo, CustomIconTextEditViewInfo)
            Dim e As OnIconSelectionEventArgs = New OnIconSelectionEventArgs(vi.ImageList, vi.ImageIndex)
            vi.Item.RaiseOnIconSelection(e)
            If e.ImageList IsNot Nothing AndAlso e.ImageIndex <> -1 Then
                info.Cache.Paint.DrawImage(info.Cache, e.ImageList, e.ImageIndex, vi.IconRect, True)
            Else
                info.Graphics.FillRectangle(info.Cache.GetSolidBrush(Color.White), vi.IconRect)
            End If
        End Sub
    End Class

    Public Interface IIconSelector

        Event OnIconSelection As OnIconSelectionEventHandler

    End Interface
End Namespace
