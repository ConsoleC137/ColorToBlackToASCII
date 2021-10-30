
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.BlackCheckBox = new System.Windows.Forms.CheckBox();
            this.NegativeCheckBox = new System.Windows.Forms.CheckBox();
            this.ASCIICheckBox = new System.Windows.Forms.CheckBox();
            this.Hide = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Преобразовать изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BlackCheckBox
            // 
            this.BlackCheckBox.AutoSize = true;
            this.BlackCheckBox.Location = new System.Drawing.Point(12, 88);
            this.BlackCheckBox.Name = "BlackCheckBox";
            this.BlackCheckBox.Size = new System.Drawing.Size(187, 18);
            this.BlackCheckBox.TabIndex = 1;
            this.BlackCheckBox.Text = "Чёрно-белое изображение";
            this.BlackCheckBox.UseVisualStyleBackColor = true;
            // 
            // NegativeCheckBox
            // 
            this.NegativeCheckBox.AutoSize = true;
            this.NegativeCheckBox.Location = new System.Drawing.Point(12, 64);
            this.NegativeCheckBox.Name = "NegativeCheckBox";
            this.NegativeCheckBox.Size = new System.Drawing.Size(180, 18);
            this.NegativeCheckBox.TabIndex = 2;
            this.NegativeCheckBox.Text = "Негативное изображение";
            this.NegativeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ASCIICheckBox
            // 
            this.ASCIICheckBox.AutoSize = true;
            this.ASCIICheckBox.Location = new System.Drawing.Point(12, 112);
            this.ASCIICheckBox.Name = "ASCIICheckBox";
            this.ASCIICheckBox.Size = new System.Drawing.Size(145, 18);
            this.ASCIICheckBox.TabIndex = 3;
            this.ASCIICheckBox.Text = "ASCII изображение";
            this.ASCIICheckBox.UseVisualStyleBackColor = true;
            // 
            // Hide
            // 
            this.Hide.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide.FlatAppearance.BorderSize = 0;
            this.Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide.Location = new System.Drawing.Point(205, 0);
            this.Hide.Margin = new System.Windows.Forms.Padding(0);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(40, 25);
            this.Hide.TabIndex = 5;
            this.Hide.Text = "_";
            this.Hide.UseVisualStyleBackColor = false;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(245, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(40, 25);
            this.Close.TabIndex = 5;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "ColorToBlackToASCII";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(198, 68);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(21, 14);
            this.labelB.TabIndex = 7;
            this.labelB.Text = "0%";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(205, 89);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(21, 14);
            this.labelN.TabIndex = 8;
            this.labelN.Text = "0%";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(163, 113);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(21, 14);
            this.labelA.TabIndex = 9;
            this.labelA.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 138);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 167);
            this.progressBar2.Maximum = 10;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(256, 23);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 11;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(13, 196);
            this.progressBar3.Maximum = 10;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(256, 23);
            this.progressBar3.TabIndex = 12;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(64, 36);
            this.textBoxWidth.MaxLength = 4;
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(33, 22);
            this.textBoxWidth.TabIndex = 13;
            this.textBoxWidth.Text = "520";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(12, 39);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(49, 14);
            this.labelWidth.TabIndex = 14;
            this.labelWidth.Text = "Ширина";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(124, 39);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(49, 14);
            this.labelHeight.TabIndex = 15;
            this.labelHeight.Text = "Высота";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(175, 36);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(33, 22);
            this.textBoxHeight.TabIndex = 16;
            this.textBoxHeight.Text = "2.98";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(280, 280);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.ASCIICheckBox);
            this.Controls.Add(this.NegativeCheckBox);
            this.Controls.Add(this.BlackCheckBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorToBlackToASCII";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox BlackCheckBox;
        private System.Windows.Forms.CheckBox NegativeCheckBox;
        private System.Windows.Forms.CheckBox ASCIICheckBox;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxHeight;
    }
}

