namespace Frazione2
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
            listBox1 = new ListBox();
            btn1 = new Button();
            btn2 = new Button();
            txt1 = new TextBox();
            label1 = new Label();
            btn3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(230, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(145, 124);
            listBox1.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(446, 136);
            btn1.Name = "btn1";
            btn1.Size = new Size(104, 34);
            btn1.TabIndex = 1;
            btn1.Text = "aggiungi";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(446, 191);
            btn2.Name = "btn2";
            btn2.Size = new Size(104, 32);
            btn2.TabIndex = 2;
            btn2.Text = "somma";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(430, 73);
            txt1.Name = "txt1";
            txt1.Size = new Size(134, 27);
            txt1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 256);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Result";
            // 
            // btn3
            // 
            btn3.Location = new Point(446, 249);
            btn3.Name = "btn3";
            btn3.Size = new Size(104, 27);
            btn3.TabIndex = 5;
            btn3.Text = "Clear";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 512);
            Controls.Add(btn3);
            Controls.Add(label1);
            Controls.Add(txt1);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btn1;
        private Button btn2;
        private TextBox txt1;
        private Label label1;
        private Button btn3;
    }
}
