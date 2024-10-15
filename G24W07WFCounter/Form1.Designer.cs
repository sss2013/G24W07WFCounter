namespace G24W07WFCOUNTER
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
            labelCount = new Label();
            btnAdd = new Button();
            btnSub = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelCount
            // 
            labelCount.BackColor = SystemColors.Info;
            labelCount.Font = new Font("맑은 고딕", 36F);
            labelCount.Location = new Point(12, 9);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(420, 181);
            labelCount.TabIndex = 0;
            labelCount.Text = "0";
            labelCount.TextAlign = ContentAlignment.MiddleCenter;
            labelCount.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.AccessibleRole = AccessibleRole.None;
            btnAdd.Location = new Point(11, 205);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "증가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // btnSub
            // 
            btnSub.AccessibleRole = AccessibleRole.None;
            btnSub.Location = new Point(157, 205);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(126, 43);
            btnSub.TabIndex = 2;
            btnSub.Text = "감소";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += OnSub;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.Location = new Point(318, 205);
            button1.Name = "button1";
            button1.Size = new Size(126, 43);
            button1.TabIndex = 3;
            button1.Text = "초기화";
            button1.UseVisualStyleBackColor = true;
            button1.Click += On_init;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 260);
            Controls.Add(button1);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(labelCount);
            Name = "Form1";
            Text = "카운터";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelCount;
        private Button btnAdd;
        private Button btnSub;
        private Button button1;
    }
}
