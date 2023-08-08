namespace PRN_PROJECT
{
    partial class EOS_TOTALQUESTION
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
            label1 = new Label();
            nbTotalquestion = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nbTotalquestion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 104);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Totalquestion:";
            // 
            // nbTotalquestion
            // 
            nbTotalquestion.Location = new Point(136, 96);
            nbTotalquestion.Name = "nbTotalquestion";
            nbTotalquestion.Size = new Size(120, 23);
            nbTotalquestion.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(136, 163);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EOS_TOTALQUESTION
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 234);
            Controls.Add(button1);
            Controls.Add(nbTotalquestion);
            Controls.Add(label1);
            Name = "EOS_TOTALQUESTION";
            Text = "EOS_TOTALQUESTION";
            Load += EOS_TOTALQUESTION_Load;
            ((System.ComponentModel.ISupportInitialize)nbTotalquestion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nbTotalquestion;
        private Button button1;
    }
}