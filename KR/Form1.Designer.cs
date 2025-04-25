namespace KR
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            resultLabel = new System.Windows.Forms.Label();
            input = new System.Windows.Forms.TextBox();
            end = new System.Windows.Forms.Button();
            PolishInverseReselt = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            resultLabel.Location = new System.Drawing.Point(440, 237);
            resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(38, 15);
            resultLabel.TabIndex = 1;
            resultLabel.Text = "label2";
            // 
            // input
            // 
            input.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            input.Location = new System.Drawing.Point(216, 233);
            input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            input.Name = "input";
            input.Size = new System.Drawing.Size(116, 22);
            input.TabIndex = 2;
            // 
            // end
            // 
            end.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            end.Location = new System.Drawing.Point(327, 336);
            end.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            end.Name = "end";
            end.Size = new System.Drawing.Size(88, 27);
            end.TabIndex = 3;
            end.Text = "button1";
            end.UseVisualStyleBackColor = true;
            end.Click += GetResult;
            // 
            // PolishInverseReselt
            // 
            PolishInverseReselt.AutoSize = true;
            PolishInverseReselt.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            PolishInverseReselt.Location = new System.Drawing.Point(353, 183);
            PolishInverseReselt.Name = "PolishInverseReselt";
            PolishInverseReselt.Size = new System.Drawing.Size(38, 15);
            PolishInverseReselt.TabIndex = 4;
            PolishInverseReselt.Text = "label1";
            PolishInverseReselt.Click += GetResult;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(PolishInverseReselt);
            Controls.Add(end);
            Controls.Add(input);
            Controls.Add(resultLabel);
            Font = new System.Drawing.Font("Times New Roman", 9.75F);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Label PolishInverseReselt;
    }
}

