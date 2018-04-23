Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Control
' ...

Namespace BrickClick
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub printControl1_BrickClick(ByVal sender As Object, ByVal e As BrickEventArgs) _
        Handles printControl1.BrickClick
            If TryCast(e.Brick, VisualBrick) IsNot Nothing Then
                ' Change the background color.
                CType(e.Brick, VisualBrick).BackColor = Color.Red

                ' Redraw the brick.
                Me.printControl1.InvalidateBrick(e.Brick)
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            Dim brickGraph As BrickGraphics = printingSystem1.Graph
            Dim top As Integer = 0

            ' Start the report generation.
            printingSystem1.Begin()

            ' Specify a page area.
            brickGraph.Modifier = BrickModifier.Detail

            ' Specify formatting.
            brickGraph.StringFormat = New BrickStringFormat(StringAlignment.Center, StringAlignment.Center)
            brickGraph.BackColor = Color.Khaki
            brickGraph.BorderColor = Color.MidnightBlue
            brickGraph.Font = New Font("Tahoma", 14, FontStyle.Bold Or FontStyle.Italic)

            ' Draw bricks.
            brickGraph.DrawString("Developer Express", Color.MidnightBlue, _
                New RectangleF(0, 0, 150, 50), BorderSide.All)
            brickGraph.DrawString("100% Native", Color.MidnightBlue, _
                New RectangleF(0, top + 50, 150, 50), BorderSide.All)
            brickGraph.DrawString(".NET Tecnologies", Color.MidnightBlue, _
                New RectangleF(0, top + 100, 150, 50), BorderSide.All)

            ' Finish the report generation.
            printingSystem1.End()

            ' Assign current printing systenm to the PrintControl.
            printControl1.PrintingSystem = printingSystem1

            ' Show the report to the user.
            printControl1.Show()
        End Sub


	End Class
End Namespace
