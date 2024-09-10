namespace QuarterFinder
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(187, 12);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCalculate.Location = new System.Drawing.Point(104, 68);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Знайти";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 100);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 16);
            this.labelResult.TabIndex = 3;
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.Location = new System.Drawing.Point(331, 12);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(243, 237);
            this.pictureBoxGraph.TabIndex = 4;
            this.pictureBoxGraph.TabStop = false;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(187, 40);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 22);
            this.textBoxY.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть координати X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введіть координати Y:";
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(721, 426);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxGraph);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Name = "Form1";
            this.Text = "Quarter Finder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
