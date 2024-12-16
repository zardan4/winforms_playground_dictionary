namespace dictionary
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditTranslation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UkrainianTranslation = new System.Windows.Forms.TextBox();
            this.EnglishTranslation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Translate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ToTranslateInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserWord = new System.Windows.Forms.Label();
            this.OutputWord = new System.Windows.Forms.Label();
            this.Dictionary = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditTranslation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UkrainianTranslation);
            this.groupBox1.Controls.Add(this.EnglishTranslation);
            this.groupBox1.Location = new System.Drawing.Point(224, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit the translation";
            // 
            // EditTranslation
            // 
            this.EditTranslation.Location = new System.Drawing.Point(9, 131);
            this.EditTranslation.Name = "EditTranslation";
            this.EditTranslation.Size = new System.Drawing.Size(200, 23);
            this.EditTranslation.TabIndex = 4;
            this.EditTranslation.Text = "Submit";
            this.EditTranslation.UseVisualStyleBackColor = true;
            this.EditTranslation.Click += new System.EventHandler(this.EditTranslation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukrainian translation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "English word";
            // 
            // UkrainianTranslation
            // 
            this.UkrainianTranslation.Location = new System.Drawing.Point(6, 90);
            this.UkrainianTranslation.Name = "UkrainianTranslation";
            this.UkrainianTranslation.Size = new System.Drawing.Size(203, 20);
            this.UkrainianTranslation.TabIndex = 1;
            // 
            // EnglishTranslation
            // 
            this.EnglishTranslation.Location = new System.Drawing.Point(6, 39);
            this.EnglishTranslation.Name = "EnglishTranslation";
            this.EnglishTranslation.Size = new System.Drawing.Size(203, 20);
            this.EnglishTranslation.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Translate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ToTranslateInput);
            this.groupBox2.Location = new System.Drawing.Point(224, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 115);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Translate word";
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(6, 74);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(200, 23);
            this.Translate.TabIndex = 5;
            this.Translate.Text = "Submit";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Word in any language";
            // 
            // ToTranslateInput
            // 
            this.ToTranslateInput.Location = new System.Drawing.Point(6, 39);
            this.ToTranslateInput.Name = "ToTranslateInput";
            this.ToTranslateInput.Size = new System.Drawing.Size(203, 20);
            this.ToTranslateInput.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(478, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Translation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(478, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Your word";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserWord
            // 
            this.UserWord.AutoSize = true;
            this.UserWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserWord.Location = new System.Drawing.Point(478, 62);
            this.UserWord.Name = "UserWord";
            this.UserWord.Size = new System.Drawing.Size(0, 29);
            this.UserWord.TabIndex = 8;
            // 
            // OutputWord
            // 
            this.OutputWord.AutoSize = true;
            this.OutputWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputWord.Location = new System.Drawing.Point(478, 198);
            this.OutputWord.Name = "OutputWord";
            this.OutputWord.Size = new System.Drawing.Size(0, 29);
            this.OutputWord.TabIndex = 9;
            // 
            // Dictionary
            // 
            this.Dictionary.FormattingEnabled = true;
            this.Dictionary.Location = new System.Drawing.Point(12, 12);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(196, 303);
            this.Dictionary.TabIndex = 10;
            this.Dictionary.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.Dictionary);
            this.Controls.Add(this.OutputWord);
            this.Controls.Add(this.UserWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EditTranslation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UkrainianTranslation;
        private System.Windows.Forms.TextBox EnglishTranslation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ToTranslateInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UserWord;
        private System.Windows.Forms.Label OutputWord;
        private System.Windows.Forms.ListBox Dictionary;
    }
}

