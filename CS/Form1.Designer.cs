namespace BrickClick {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.printControl1 = new DevExpress.XtraPrinting.Control.PrintControl();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.SuspendLayout();
            // 
            // printControl1
            // 
            this.printControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.printControl1.BackColor = System.Drawing.Color.Empty;
            this.printControl1.ForeColor = System.Drawing.Color.Empty;
            this.printControl1.IsMetric = false;
            this.printControl1.Location = new System.Drawing.Point(12, 52);
            this.printControl1.Name = "printControl1";
            this.printControl1.PrintingSystem = this.printingSystem1;
            this.printControl1.Size = new System.Drawing.Size(480, 414);
            this.printControl1.TabIndex = 1;
            this.printControl1.BrickClick += new DevExpress.XtraPrinting.Control.BrickEventHandler(this.printControl1_BrickClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click any brick...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPrinting.Control.PrintControl printControl1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private System.Windows.Forms.Label label1;
    }
}

