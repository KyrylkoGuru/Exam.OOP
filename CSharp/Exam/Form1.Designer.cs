namespace Exam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetDate = new System.Windows.Forms.Button();
            this.btnAddDays = new System.Windows.Forms.Button();
            this.btnGetDayOfWeek = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAddMonths = new System.Windows.Forms.Button();
            this.btnAddYears = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetDate
            // 
            this.btnSetDate.Location = new System.Drawing.Point(311, 137);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(205, 32);
            this.btnSetDate.TabIndex = 0;
            this.btnSetDate.Text = "Встановити дату";
            this.btnSetDate.UseVisualStyleBackColor = true;
            this.btnSetDate.Click += new System.EventHandler(this.BtnSetDate_Click);
            // 
            // btnAddDays
            // 
            this.btnAddDays.Location = new System.Drawing.Point(100, 213);
            this.btnAddDays.Name = "btnAddDays";
            this.btnAddDays.Size = new System.Drawing.Size(205, 32);
            this.btnAddDays.TabIndex = 1;
            this.btnAddDays.Text = "Додати дні";
            this.btnAddDays.UseVisualStyleBackColor = true;
            this.btnAddDays.Click += new System.EventHandler(this.BtnAddDays_Click);
            // 
            // btnGetDayOfWeek
            // 
            this.btnGetDayOfWeek.Location = new System.Drawing.Point(311, 175);
            this.btnGetDayOfWeek.Name = "btnGetDayOfWeek";
            this.btnGetDayOfWeek.Size = new System.Drawing.Size(205, 32);
            this.btnGetDayOfWeek.TabIndex = 2;
            this.btnGetDayOfWeek.Text = "Визначити день тижня";
            this.btnGetDayOfWeek.UseVisualStyleBackColor = true;
            this.btnGetDayOfWeek.Click += new System.EventHandler(this.BtnGetDayOfWeek_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(307, 268);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(60, 22);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label1";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(239, 109);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(100, 22);
            this.txtDay.TabIndex = 4;
            this.txtDay.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(361, 109);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 22);
            this.txtMonth.TabIndex = 5;
            this.txtMonth.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(482, 109);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 6;
            this.txtYear.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // btnAddMonths
            // 
            this.btnAddMonths.Location = new System.Drawing.Point(311, 213);
            this.btnAddMonths.Name = "btnAddMonths";
            this.btnAddMonths.Size = new System.Drawing.Size(205, 32);
            this.btnAddMonths.TabIndex = 9;
            this.btnAddMonths.Text = "Додати місяці";
            this.btnAddMonths.UseVisualStyleBackColor = true;
            this.btnAddMonths.Click += new System.EventHandler(this.BtnAddMonths_Click);
            // 
            // btnAddYears
            // 
            this.btnAddYears.Location = new System.Drawing.Point(522, 213);
            this.btnAddYears.Name = "btnAddYears";
            this.btnAddYears.Size = new System.Drawing.Size(205, 32);
            this.btnAddYears.TabIndex = 10;
            this.btnAddYears.Text = "Додати роки";
            this.btnAddYears.UseVisualStyleBackColor = true;
            this.btnAddYears.Click += new System.EventHandler(this.BtnAddYears_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddYears);
            this.Controls.Add(this.btnAddMonths);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGetDayOfWeek);
            this.Controls.Add(this.btnAddDays);
            this.Controls.Add(this.btnSetDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetDate;
        private System.Windows.Forms.Button btnAddDays;
        private System.Windows.Forms.Button btnGetDayOfWeek;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAddMonths;
        private System.Windows.Forms.Button btnAddYears;
    }
}

