
namespace Calculation_of_ppm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GetResult = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.procAlc = new System.Windows.Forms.MaskedTextBox();
            this.massAlc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Woman = new System.Windows.Forms.RadioButton();
            this.Man = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Result = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.massBody = new System.Windows.Forms.MaskedTextBox();
            this.Info = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetResult
            // 
            this.GetResult.Location = new System.Drawing.Point(191, 179);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(99, 59);
            this.GetResult.TabIndex = 0;
            this.GetResult.Text = "Посчитать";
            this.GetResult.UseVisualStyleBackColor = true;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.procAlc);
            this.groupBox1.Controls.Add(this.massAlc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алкоголь";
            // 
            // procAlc
            // 
            this.procAlc.Location = new System.Drawing.Point(6, 57);
            this.procAlc.Name = "procAlc";
            this.procAlc.Size = new System.Drawing.Size(125, 27);
            this.procAlc.TabIndex = 3;
            this.procAlc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.procAlc.ValidatingType = typeof(int);
            // 
            // massAlc
            // 
            this.massAlc.Location = new System.Drawing.Point(6, 25);
            this.massAlc.Name = "massAlc";
            this.massAlc.Size = new System.Drawing.Size(125, 27);
            this.massAlc.TabIndex = 2;
            this.massAlc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.massAlc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "гр";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Woman);
            this.groupBox2.Controls.Add(this.Man);
            this.groupBox2.Location = new System.Drawing.Point(191, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ваш пол";
            // 
            // Woman
            // 
            this.Woman.AutoSize = true;
            this.Woman.Location = new System.Drawing.Point(5, 58);
            this.Woman.Name = "Woman";
            this.Woman.Size = new System.Drawing.Size(93, 24);
            this.Woman.TabIndex = 1;
            this.Woman.TabStop = true;
            this.Woman.Text = "женский";
            this.Woman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Woman.UseVisualStyleBackColor = true;
            // 
            // Man
            // 
            this.Man.AutoSize = true;
            this.Man.Location = new System.Drawing.Point(5, 26);
            this.Man.Name = "Man";
            this.Man.Size = new System.Drawing.Size(93, 24);
            this.Man.TabIndex = 0;
            this.Man.TabStop = true;
            this.Man.Text = "мужской";
            this.Man.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Man.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Result);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 59);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(6, 26);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(125, 27);
            this.Result.TabIndex = 5;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "‰";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.massBody);
            this.groupBox4.Location = new System.Drawing.Point(12, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 66);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "кг";
            // 
            // massBody
            // 
            this.massBody.Location = new System.Drawing.Point(6, 26);
            this.massBody.Name = "massBody";
            this.massBody.Size = new System.Drawing.Size(125, 27);
            this.massBody.TabIndex = 5;
            this.massBody.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(191, 107);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(99, 66);
            this.Info.TabIndex = 5;
            this.Info.Text = "Подробнее";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 248);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GetResult);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Промилле";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox procAlc;
        private System.Windows.Forms.MaskedTextBox massAlc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Woman;
        private System.Windows.Forms.RadioButton Man;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox massBody;
        private System.Windows.Forms.Button Info;
    }
}

