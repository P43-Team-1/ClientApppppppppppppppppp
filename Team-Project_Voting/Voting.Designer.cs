namespace Team_Project_Voting
{
    partial class Voting
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
            Statistic = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Statistic
            // 
            Statistic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Statistic.AutoSize = true;
            Statistic.Cursor = Cursors.Hand;
            Statistic.Location = new Point(1, 421);
            Statistic.Name = "Statistic";
            Statistic.Size = new Size(174, 20);
            Statistic.TabIndex = 3;
            Statistic.Text = "Переглянути статистику";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Location = new Point(16, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(398, 333);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 9);
            label1.MaximumSize = new Size(300, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.SizeChanged += label1_SizeChanged;
            // 
            // Voting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(428, 445);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Statistic);
            Name = "Voting";
            Text = "Voting";
            Load += Voting_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Statistic;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
    }
}