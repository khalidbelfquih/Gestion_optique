Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class RoundedCornerTextbox
    Inherits TextBox

    Declare Function GetWindowDC Lib "user32" (ByVal hwnd As IntPtr) As IntPtr
    Declare Function ReleaseDC Lib "user32.dll" _
       (ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Integer

#Region "Globals"
    Private mLeavingEventlist As ArrayList
    Private _OriText As String = ""
    Private _NewText As String = ""
    Private _Texthaschanged As Boolean = False
    Dim state As states = states.normal
    Dim BorderPen As Pen
    Dim ArrowBrush, ButtonBrush, TextBrush As Brush
    Dim MainRect As Rectangle
    Dim pointArrow(2) As PointF
    Dim VerticalMiddle As Integer
    Dim ArrowPath As GraphicsPath = New GraphicsPath
    Dim TxtLoc As PointF

    Enum states
        normal
        focused
        disabled
    End Enum

#End Region

#Region "Public properties"
    Public Property Texthaschanged() As Boolean
        Get
            Return _Texthaschanged
        End Get
        Set(ByVal value As Boolean)
            _Texthaschanged = value
        End Set
    End Property

    Public Property OriText() As String
        Get
            Return _OriText
        End Get
        Set(ByVal value As String)
            _OriText = value
        End Set
    End Property

    Public Property NewText() As String
        Get
            Return _NewText
        End Get
        Set(ByVal value As String)
            _NewText = value
        End Set
    End Property

#End Region

#Region "Events"


    Public Custom Event BijLeaving As EventHandler
        AddHandler(ByVal value As EventHandler)
            If mLeavingEventlist Is Nothing Then
                mLeavingEventlist = New ArrayList
            End If
            mLeavingEventlist.Add(value)
        End AddHandler
        RemoveHandler(ByVal value As EventHandler)
            mLeavingEventlist.Remove(value)
        End RemoveHandler
        RaiseEvent(ByVal sender As Object, ByVal ea As EventArgs)
            If mLeavingEventlist IsNot Nothing Then
                For Each handler As EventHandler In mLeavingEventlist
                    If handler IsNot Nothing Then
                        handler.BeginInvoke(sender, ea, Nothing, Nothing)
                    End If
                Next
            End If
        End RaiseEvent
    End Event

#End Region

#Region "Listeners"

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        ElseIf msg.WParam.ToInt32() = CInt(Keys.Decimal) Then
            SendKeys.Send(",")
            Return True
        End If
    End Function

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Select Case m.Msg

            Case &HF

                Dim rect As New Rectangle(0, 0, MyBase.Width, MyBase.Height)

                Dim hDC As IntPtr = GetWindowDC(Me.Handle)
                Dim g As Graphics = Graphics.FromHdc(hDC)
                If Me.Enabled Then
                    g.Clear(Color.White)
                Else
                    g.Clear(Color.FromName("control"))
                End If
                DrawBorder(g)
                DrawText(g)
                ReleaseDC(Me.Handle, hDC)
                g.Dispose()

            Case &H7, &H8, &H200, &H2A3


                UpdateState()

        End Select

    End Sub

    Private Sub Enabled_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.EnabledChanged
        UpdateState()
    End Sub

    Private WithEvents Timer As Timer = New Timer

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
        UpdateState()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal e As Boolean)
        Me.Timer.Enabled = False
        MyBase.Dispose(e)
    End Sub

    Private Sub UpdateState()

        Dim temp As states = state

        If Me.Enabled Then
            If ClientRectangle.Contains(PointToClient(Control.MousePosition)) Then
                Me.state = states.focused
            ElseIf Me.Focused Then
                Me.state = states.focused
            Else
                Me.state = states.normal
            End If
        Else
            Me.state = states.disabled
        End If

        If state <> temp Then
            Me.Invalidate()
        End If
    End Sub

#End Region

#Region "Initialisation"
    Sub New()
        MyBase.New()
        MyBase.Multiline = True
        MyBase.Height = 23
        Timer.Interval = 20
        Timer.Enabled = True

    End Sub
#End Region

#Region " Drawing functions "

    Private Sub TekenRondeRechthoek(ByVal g As Graphics, ByVal pen As Pen, ByVal rectangle As Rectangle, ByVal radius As Single)
        Dim size As Single = (radius * 3.5!)
        Dim gp As GraphicsPath = New GraphicsPath
        gp.AddArc(rectangle.X, rectangle.Y, size, size, 180, 90)
        gp.AddArc((rectangle.X _
                        + (rectangle.Width - size)), rectangle.Y, size, size, 270, 90)
        gp.AddArc((rectangle.X _
                        + (rectangle.Width - size)), (rectangle.Y _
                        + (rectangle.Height - size)), size, size, 0, 90)
        gp.AddArc(rectangle.X, (rectangle.Y _
                        + (rectangle.Height - size)), size, size, 90, 90)
        gp.CloseFigure()
        g.DrawPath(pen, gp)
        gp.Dispose()
    End Sub

    Private Sub DrawBorder(ByVal g As Graphics)
        MainRect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Select Case state
            Case states.focused
                BorderPen = New Pen(Color.Green)
            Case states.disabled
                BorderPen = New Pen(Color.DarkGray)
            Case states.normal
                BorderPen = New Pen(Color.Teal)
            Case Else
                Exit Sub
        End Select
        TekenRondeRechthoek(g, BorderPen, MainRect, 3.0!)

    End Sub

    Private Sub DrawText(ByVal g As Graphics)
        Dim text As String = ""
        Select Case state
            Case states.normal, states.focused
                TextBrush = New SolidBrush(Me.ForeColor)
            Case states.disabled
                TextBrush = New SolidBrush(Color.DarkGray)
        End Select
        If g.MeasureString(Me.Text, Me.Font).Width > Me.Width - 30 Then
            Dim i As Integer = -1
            Do
                i += 1
                If g.MeasureString(text, Me.Font).Width > Me.Width - 30 Then Exit Do
                text &= Me.Text.Substring(i, 1)
            Loop
        Else
            text = Me.Text
        End If
        If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
            TxtLoc = New PointF(1, 4)
        Else
            Dim temp As Single = Me.Width - (g.MeasureString(text, Me.Font).Width)
            TxtLoc = New PointF(temp, 4)
        End If
        g.DrawString(text, Me.Font, TextBrush, TxtLoc)
    End Sub
#End Region

#Region "Overrides"

    Protected Overrides Sub OnEnter(ByVal e As System.EventArgs)
        If Not Me.Text = "" Then
            OriText = Me.Text
        End If
    End Sub

    Protected Overrides Sub OnLeave(ByVal e As System.EventArgs)
        If Me.Text <> OriText Then
            Texthaschanged = True
            If Not Me.Text = "" Then
                NewText = Me.Text
            End If
            RaiseEvent BijLeaving(Me, EventArgs.Empty)
        End If
    End Sub

#End Region
End Class
