namespace WH_LangChange
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
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button4 = new Button();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI Black", 14F);
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(571, 91);
            label1.TabIndex = 0;
            label1.Text = "Windows 10\\11 Home\\Single Language Default UI Changer";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(15, 314);
            button1.Name = "button1";
            button1.Size = new Size(148, 34);
            button1.TabIndex = 1;
            button1.Text = "Scan system";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(15, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(148, 204);
            listBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(22, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 363);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Installed Languages";
            // 
            // label3
            // 
            label3.Location = new Point(15, 244);
            label3.Name = "label3";
            label3.Size = new Size(143, 30);
            label3.TabIndex = 7;
            label3.Text = "Active Language";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 277);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(148, 31);
            textBox2.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(212, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(381, 363);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Let's Adjust the System?";
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(15, 214);
            button3.Name = "button3";
            button3.Size = new Size(348, 124);
            button3.TabIndex = 5;
            button3.Text = "Apply patch to the \r\nSystem Registry \r\nand Reboot\r\n";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(248, 87);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Select file";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 90);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(227, 31);
            textBox1.TabIndex = 3;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 140);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(336, 54);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Yes! My language pack present in list, \r\nand currently selected\r\n";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(348, 54);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "No! There is no required langauge pack\r\nin the list. I need to install it.\r\n";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(22, 477);
            button4.Name = "button4";
            button4.Size = new Size(571, 34);
            button4.TabIndex = 7;
            button4.Text = "... show log ...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Highlight;
            textBox3.ForeColor = SystemColors.Info;
            textBox3.Location = new Point(22, 533);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(571, 461);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 524);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Win Home Lang Change";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
    }
}
