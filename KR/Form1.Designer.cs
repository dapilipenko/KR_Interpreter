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
            components = new System.ComponentModel.Container();
            resultLabel = new System.Windows.Forms.Label();
            input = new System.Windows.Forms.TextBox();
            end = new System.Windows.Forms.Button();
            contextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            Item1 = new System.Windows.Forms.ToolStripMenuItem();
            Item2 = new System.Windows.Forms.ToolStripMenuItem();
            Item3 = new System.Windows.Forms.ToolStripMenuItem();
            Item4 = new System.Windows.Forms.ToolStripMenuItem();
            Item5 = new System.Windows.Forms.ToolStripMenuItem();
            roundType = new System.Windows.Forms.ComboBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            clearButton = new System.Windows.Forms.Button();
            listBox = new System.Windows.Forms.ListBox();
            contextMenu.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            resultLabel.Location = new System.Drawing.Point(463, 6);
            resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(170, 31);
            resultLabel.TabIndex = 1;
            resultLabel.Text = "Результат:      ";
            // 
            // input
            // 
            input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            input.Location = new System.Drawing.Point(7, 6);
            input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            input.Multiline = true;
            input.Name = "input";
            input.PlaceholderText = "Введіть вираз:";
            input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            input.Size = new System.Drawing.Size(448, 103);
            input.TabIndex = 2;
            // 
            // end
            // 
            end.ContextMenuStrip = contextMenu;
            end.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            end.Location = new System.Drawing.Point(545, 82);
            end.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            end.Name = "end";
            end.Size = new System.Drawing.Size(88, 27);
            end.TabIndex = 3;
            end.Text = "Обчислити";
            end.UseVisualStyleBackColor = true;
            end.Click += GetResult;
            // 
            // contextMenu
            // 
            contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Item1, Item2, Item3, Item4, Item5 });
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.Size = new System.Drawing.Size(81, 114);
            contextMenu.Text = "Виберіть округлення";
            contextMenu.Click += GetResult;
            // 
            // Item1
            // 
            Item1.Name = "Item1";
            Item1.Size = new System.Drawing.Size(80, 22);
            Item1.Text = "0";
            // 
            // Item2
            // 
            Item2.Name = "Item2";
            Item2.Size = new System.Drawing.Size(80, 22);
            Item2.Text = "1";
            // 
            // Item3
            // 
            Item3.Name = "Item3";
            Item3.Size = new System.Drawing.Size(80, 22);
            Item3.Text = "2";
            // 
            // Item4
            // 
            Item4.Name = "Item4";
            Item4.Size = new System.Drawing.Size(80, 22);
            Item4.Text = "3";
            // 
            // Item5
            // 
            Item5.Name = "Item5";
            Item5.Size = new System.Drawing.Size(80, 22);
            Item5.Text = "4";
            // 
            // roundType
            // 
            roundType.FormattingEnabled = true;
            roundType.Items.AddRange(new object[] { "0", "1", "2", "3", "4" });
            roundType.Location = new System.Drawing.Point(480, 80);
            roundType.Name = "roundType";
            roundType.Size = new System.Drawing.Size(48, 29);
            roundType.TabIndex = 5;
            roundType.Text = "0";
            roundType.SelectedValueChanged += roundType_SelectedValueChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            tabControl1.Location = new System.Drawing.Point(0, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(934, 508);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(input);
            tabPage1.Controls.Add(end);
            tabPage1.Controls.Add(roundType);
            tabPage1.Controls.Add(resultLabel);
            tabPage1.Location = new System.Drawing.Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(926, 474);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Меню";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(clearButton);
            tabPage2.Controls.Add(listBox);
            tabPage2.Location = new System.Drawing.Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(926, 474);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Історія розрахунків";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new System.Drawing.Point(794, 432);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(104, 30);
            clearButton.TabIndex = 1;
            clearButton.Text = "Очистити";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // listBox
            // 
            listBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            listBox.FormattingEnabled = true;
            listBox.HorizontalScrollbar = true;
            listBox.Location = new System.Drawing.Point(3, 2);
            listBox.Name = "listBox";
            listBox.ScrollAlwaysVisible = true;
            listBox.Size = new System.Drawing.Size(923, 424);
            listBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            ContextMenuStrip = contextMenu;
            Controls.Add(tabControl1);
            Font = new System.Drawing.Font("Times New Roman", 9.75F);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Сalculator";
            contextMenu.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem Item1;
        private System.Windows.Forms.ToolStripMenuItem Item2;
        private System.Windows.Forms.ToolStripMenuItem Item3;
        private System.Windows.Forms.ToolStripMenuItem Item4;
        private System.Windows.Forms.ToolStripMenuItem Item5;
        private System.Windows.Forms.ComboBox roundType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button clearButton;
    }
}

