Imports Microsoft.VisualBasic
Imports System
Namespace BrickClick
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
			Me.printControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printControl1
			' 
			Me.printControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.printControl1.BackColor = System.Drawing.Color.Empty
			Me.printControl1.ForeColor = System.Drawing.Color.Empty
			Me.printControl1.IsMetric = False
			Me.printControl1.Location = New System.Drawing.Point(12, 52)
			Me.printControl1.Name = "printControl1"
			Me.printControl1.PrintingSystem = Me.printingSystem1
			Me.printControl1.Size = New System.Drawing.Size(480, 414)
			Me.printControl1.TabIndex = 1
'			Me.printControl1.BrickClick += New DevExpress.XtraPrinting.Control.BrickEventHandler(Me.printControl1_BrickClick);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.label1.Location = New System.Drawing.Point(12, 19)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(116, 18)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Click any brick..."
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(504, 478)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.printControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents printControl1 As DevExpress.XtraPrinting.Control.PrintControl
		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace

