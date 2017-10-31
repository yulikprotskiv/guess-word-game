namespace GameOfWords
{
    partial class mainWin
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
            this.grb_menu = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.rbtn_hard = new System.Windows.Forms.RadioButton();
            this.rbtn_medium = new System.Windows.Forms.RadioButton();
            this.rbtn_easy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.grb_word = new System.Windows.Forms.GroupBox();
            this.workLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.grb_tips = new System.Windows.Forms.GroupBox();
            this.tipsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_timeout = new System.Windows.Forms.Label();
            this.lbl_timer_header = new System.Windows.Forms.Label();
            this.lbl_cong = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.grb_menu.SuspendLayout();
            this.grb_word.SuspendLayout();
            this.grb_tips.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_menu
            // 
            this.grb_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_menu.Controls.Add(this.btn_stop);
            this.grb_menu.Controls.Add(this.btn_reset);
            this.grb_menu.Controls.Add(this.btn_start);
            this.grb_menu.Controls.Add(this.rbtn_hard);
            this.grb_menu.Controls.Add(this.rbtn_medium);
            this.grb_menu.Controls.Add(this.rbtn_easy);
            this.grb_menu.Controls.Add(this.label1);
            this.grb_menu.Location = new System.Drawing.Point(12, 12);
            this.grb_menu.Name = "grb_menu";
            this.grb_menu.Size = new System.Drawing.Size(976, 88);
            this.grb_menu.TabIndex = 0;
            this.grb_menu.TabStop = false;
            this.grb_menu.Text = "MENU";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reset.Location = new System.Drawing.Point(360, 16);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(186, 66);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Restart";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.Location = new System.Drawing.Point(6, 43);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(348, 39);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // rbtn_hard
            // 
            this.rbtn_hard.AutoSize = true;
            this.rbtn_hard.Checked = true;
            this.rbtn_hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_hard.ForeColor = System.Drawing.Color.DeepPink;
            this.rbtn_hard.Location = new System.Drawing.Point(285, 14);
            this.rbtn_hard.Name = "rbtn_hard";
            this.rbtn_hard.Size = new System.Drawing.Size(69, 28);
            this.rbtn_hard.TabIndex = 9;
            this.rbtn_hard.TabStop = true;
            this.rbtn_hard.Text = "Hard";
            this.rbtn_hard.UseVisualStyleBackColor = true;
            // 
            // rbtn_medium
            // 
            this.rbtn_medium.AutoSize = true;
            this.rbtn_medium.Checked = true;
            this.rbtn_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_medium.ForeColor = System.Drawing.Color.DeepPink;
            this.rbtn_medium.Location = new System.Drawing.Point(182, 14);
            this.rbtn_medium.Name = "rbtn_medium";
            this.rbtn_medium.Size = new System.Drawing.Size(97, 28);
            this.rbtn_medium.TabIndex = 8;
            this.rbtn_medium.TabStop = true;
            this.rbtn_medium.Text = "Medium";
            this.rbtn_medium.UseVisualStyleBackColor = true;
            // 
            // rbtn_easy
            // 
            this.rbtn_easy.AutoSize = true;
            this.rbtn_easy.Checked = true;
            this.rbtn_easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn_easy.ForeColor = System.Drawing.Color.DeepPink;
            this.rbtn_easy.Location = new System.Drawing.Point(107, 14);
            this.rbtn_easy.Name = "rbtn_easy";
            this.rbtn_easy.Size = new System.Drawing.Size(69, 28);
            this.rbtn_easy.TabIndex = 7;
            this.rbtn_easy.TabStop = true;
            this.rbtn_easy.Text = "Easy";
            this.rbtn_easy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Difficult:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Level:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_score.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_score.Location = new System.Drawing.Point(103, 113);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(27, 29);
            this.lbl_score.TabIndex = 13;
            this.lbl_score.Text = "0";
            // 
            // grb_word
            // 
            this.grb_word.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_word.Controls.Add(this.workLayout);
            this.grb_word.Location = new System.Drawing.Point(12, 145);
            this.grb_word.Name = "grb_word";
            this.grb_word.Size = new System.Drawing.Size(976, 150);
            this.grb_word.TabIndex = 14;
            this.grb_word.TabStop = false;
            this.grb_word.Text = "Word";
            // 
            // workLayout
            // 
            this.workLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workLayout.Location = new System.Drawing.Point(3, 16);
            this.workLayout.Name = "workLayout";
            this.workLayout.Size = new System.Drawing.Size(970, 131);
            this.workLayout.TabIndex = 0;
            // 
            // grb_tips
            // 
            this.grb_tips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_tips.Controls.Add(this.tipsPanel);
            this.grb_tips.Location = new System.Drawing.Point(12, 301);
            this.grb_tips.Name = "grb_tips";
            this.grb_tips.Size = new System.Drawing.Size(976, 164);
            this.grb_tips.TabIndex = 15;
            this.grb_tips.TabStop = false;
            this.grb_tips.Text = "Tips";
            // 
            // tipsPanel
            // 
            this.tipsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipsPanel.Location = new System.Drawing.Point(3, 16);
            this.tipsPanel.Name = "tipsPanel";
            this.tipsPanel.Size = new System.Drawing.Size(970, 145);
            this.tipsPanel.TabIndex = 1;
            // 
            // lbl_timeout
            // 
            this.lbl_timeout.AutoSize = true;
            this.lbl_timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timeout.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_timeout.Location = new System.Drawing.Point(408, 113);
            this.lbl_timeout.Name = "lbl_timeout";
            this.lbl_timeout.Size = new System.Drawing.Size(27, 29);
            this.lbl_timeout.TabIndex = 17;
            this.lbl_timeout.Text = "0";
            // 
            // lbl_timer_header
            // 
            this.lbl_timer_header.AutoSize = true;
            this.lbl_timer_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timer_header.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_timer_header.Location = new System.Drawing.Point(292, 113);
            this.lbl_timer_header.Name = "lbl_timer_header";
            this.lbl_timer_header.Size = new System.Drawing.Size(116, 29);
            this.lbl_timer_header.TabIndex = 16;
            this.lbl_timer_header.Text = "Timeout:";
            // 
            // lbl_cong
            // 
            this.lbl_cong.AutoSize = true;
            this.lbl_cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cong.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_cong.Location = new System.Drawing.Point(563, 113);
            this.lbl_cong.Name = "lbl_cong";
            this.lbl_cong.Size = new System.Drawing.Size(132, 29);
            this.lbl_cong.TabIndex = 18;
            this.lbl_cong.Text = "Level UP !";
            this.lbl_cong.Visible = false;
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stop.Location = new System.Drawing.Point(552, 16);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(186, 66);
            this.btn_stop.TabIndex = 12;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 477);
            this.Controls.Add(this.lbl_cong);
            this.Controls.Add(this.lbl_timeout);
            this.Controls.Add(this.lbl_timer_header);
            this.Controls.Add(this.grb_tips);
            this.Controls.Add(this.grb_word);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grb_menu);
            this.Name = "mainWin";
            this.Text = "Game of Words";
            this.grb_menu.ResumeLayout(false);
            this.grb_menu.PerformLayout();
            this.grb_word.ResumeLayout(false);
            this.grb_tips.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_menu;
        private System.Windows.Forms.RadioButton rbtn_hard;
        private System.Windows.Forms.RadioButton rbtn_medium;
        private System.Windows.Forms.RadioButton rbtn_easy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.GroupBox grb_word;
        private System.Windows.Forms.FlowLayoutPanel workLayout;
        private System.Windows.Forms.GroupBox grb_tips;
        private System.Windows.Forms.FlowLayoutPanel tipsPanel;
        private System.Windows.Forms.Label lbl_timeout;
        private System.Windows.Forms.Label lbl_timer_header;
        private System.Windows.Forms.Label lbl_cong;
        private System.Windows.Forms.Button btn_stop;
    }
}

