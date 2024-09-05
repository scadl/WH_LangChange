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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI Black", 14F);
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(632, 91);
            label1.TabIndex = 0;
            label1.Text = "Wellcome to Windows 10\\11 Home\\Single Language Default UI Changer";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(173, 106);
            button1.Name = "button1";
            button1.Size = new Size(329, 34);
            button1.TabIndex = 1;
            button1.Text = "1. Get my Installed Languages";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 533);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Win Home Lang Change";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}
