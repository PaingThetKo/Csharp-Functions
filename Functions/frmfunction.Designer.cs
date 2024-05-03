namespace Functions
{
    partial class frmfunction
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
            button1 = new Button();
            txtgreeting = new TextBox();
            label1 = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            label2 = new Label();
            btnsum = new Button();
            label3 = new Label();
            txtsum = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(318, 25);
            button1.Name = "button1";
            button1.Size = new Size(147, 52);
            button1.TabIndex = 0;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtgreeting
            // 
            txtgreeting.Location = new Point(64, 38);
            txtgreeting.Name = "txtgreeting";
            txtgreeting.Size = new Size(182, 27);
            txtgreeting.TabIndex = 1;
            txtgreeting.KeyDown += txtgreeting_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 201);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "First Number";
            // 
            // txta
            // 
            txta.Location = new Point(154, 201);
            txta.Name = "txta";
            txta.Size = new Size(125, 27);
            txta.TabIndex = 3;
            // 
            // txtb
            // 
            txtb.Location = new Point(154, 264);
            txtb.Name = "txtb";
            txtb.Size = new Size(125, 27);
            txtb.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 264);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 4;
            label2.Text = "Second Number";
            // 
            // btnsum
            // 
            btnsum.Location = new Point(318, 201);
            btnsum.Name = "btnsum";
            btnsum.Size = new Size(147, 90);
            btnsum.TabIndex = 6;
            btnsum.Text = "Sum";
            btnsum.UseVisualStyleBackColor = true;
            btnsum.Click += btnsum_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 348);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Result";
            // 
            // txtsum
            // 
            txtsum.Location = new Point(154, 348);
            txtsum.Name = "txtsum";
            txtsum.Size = new Size(125, 27);
            txtsum.TabIndex = 8;
            // 
            // frmfunction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 469);
            Controls.Add(txtsum);
            Controls.Add(label3);
            Controls.Add(btnsum);
            Controls.Add(txtb);
            Controls.Add(label2);
            Controls.Add(txta);
            Controls.Add(label1);
            Controls.Add(txtgreeting);
            Controls.Add(button1);
            Name = "frmfunction";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtgreeting;
        private Label label1;
        private TextBox txta;
        private TextBox txtb;
        private Label label2;
        private Button btnsum;
        private Label label3;
        private TextBox txtsum;
    }
}
