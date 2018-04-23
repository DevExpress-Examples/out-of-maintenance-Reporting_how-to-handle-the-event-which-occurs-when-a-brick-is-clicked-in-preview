using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
// ...

namespace BrickClick {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void printControl1_BrickClick(object sender, BrickEventArgs e) {
            if (e.Brick as VisualBrick != null) {
                // Change the background color.
                (e.Brick as VisualBrick).BackColor = Color.Red;

                // Redraw the brick.
                this.printControl1.InvalidateBrick(e.Brick);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            BrickGraphics brickGraph = printingSystem1.Graph;
            int top = 0;

            // Start the report generation.
            printingSystem1.Begin();

            // Specify a page area.
            brickGraph.Modifier = BrickModifier.Detail;

            // Specify formatting.
            brickGraph.StringFormat = new BrickStringFormat(StringAlignment.Center,
                StringAlignment.Center);
            brickGraph.BackColor = Color.Khaki;
            brickGraph.BorderColor = Color.MidnightBlue;
            brickGraph.Font = new Font("Tahoma", 14, FontStyle.Bold | FontStyle.Italic);

            // Draw bricks.
            brickGraph.DrawString("Developer Express", Color.MidnightBlue,
                new RectangleF(0, 0, 150, 50), BorderSide.All);
            brickGraph.DrawString("100% Native", Color.MidnightBlue,
                new RectangleF(0, top += 50, 150, 50), BorderSide.All);
            brickGraph.DrawString(".NET Tecnologies", Color.MidnightBlue,
                new RectangleF(0, top += 50, 150, 50), BorderSide.All);

            // Finish the report generation.
            printingSystem1.End();

            // Assign current printing systenm to the PrintControl.
            printControl1.PrintingSystem = printingSystem1;

            // Show the report to the user.
            printControl1.Show();
        }


    }
}
