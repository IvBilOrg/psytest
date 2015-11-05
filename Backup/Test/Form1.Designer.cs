namespace Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.radioButtonVariantA = new System.Windows.Forms.RadioButton();
            this.radioButtonVariantB = new System.Windows.Forms.RadioButton();
            this.labelStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.button1.Location = new System.Drawing.Point(176, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.labelQuestion.Location = new System.Drawing.Point(52, 20);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(66, 25);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "label1";
            // 
            // radioButtonVariantA
            // 
            this.radioButtonVariantA.AutoSize = true;
            this.radioButtonVariantA.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.radioButtonVariantA.Location = new System.Drawing.Point(57, 67);
            this.radioButtonVariantA.Name = "radioButtonVariantA";
            this.radioButtonVariantA.Size = new System.Drawing.Size(144, 29);
            this.radioButtonVariantA.TabIndex = 4;
            this.radioButtonVariantA.TabStop = true;
            this.radioButtonVariantA.Text = "radioButton1";
            this.radioButtonVariantA.UseVisualStyleBackColor = true;
            // 
            // radioButtonVariantB
            // 
            this.radioButtonVariantB.AutoSize = true;
            this.radioButtonVariantB.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.radioButtonVariantB.Location = new System.Drawing.Point(57, 102);
            this.radioButtonVariantB.Name = "radioButtonVariantB";
            this.radioButtonVariantB.Size = new System.Drawing.Size(144, 29);
            this.radioButtonVariantB.TabIndex = 5;
            this.radioButtonVariantB.TabStop = true;
            this.radioButtonVariantB.Text = "radioButton2";
            this.radioButtonVariantB.UseVisualStyleBackColor = true;
            this.radioButtonVariantB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelStart
            // 
            this.labelStart.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.labelStart.Location = new System.Drawing.Point(8, 197);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = this.Size;
            this.labelStart.TabIndex = 6;
            this.labelStart.Text = "Приветствуем Вас. \n Чтоб начать тест кликните мышкой";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 325);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.radioButtonVariantB);
            this.Controls.Add(this.radioButtonVariantA);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton radioButtonVariantA;
        private System.Windows.Forms.RadioButton radioButtonVariantB;
        private System.Windows.Forms.Label labelStart;
    }
}

