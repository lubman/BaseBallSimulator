namespace BaseballSimulator1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtInning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstHomeTeam = new System.Windows.Forms.ListBox();
            this.lstAwayTeam = new System.Windows.Forms.ListBox();
            this.Inning = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBatter = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtScores = new System.Windows.Forms.DataGridView();
            this.btnPlayHalf = new System.Windows.Forms.Button();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.lblBatter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtScores)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 505);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 641);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtInning
            // 
            this.txtInning.Location = new System.Drawing.Point(126, 641);
            this.txtInning.Name = "txtInning";
            this.txtInning.Size = new System.Drawing.Size(100, 20);
            this.txtInning.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Away Team";
            // 
            // lstHomeTeam
            // 
            this.lstHomeTeam.FormattingEnabled = true;
            this.lstHomeTeam.Location = new System.Drawing.Point(17, 527);
            this.lstHomeTeam.Name = "lstHomeTeam";
            this.lstHomeTeam.Size = new System.Drawing.Size(120, 95);
            this.lstHomeTeam.TabIndex = 6;
            // 
            // lstAwayTeam
            // 
            this.lstAwayTeam.FormattingEnabled = true;
            this.lstAwayTeam.Location = new System.Drawing.Point(186, 527);
            this.lstAwayTeam.Name = "lstAwayTeam";
            this.lstAwayTeam.Size = new System.Drawing.Size(139, 95);
            this.lstAwayTeam.TabIndex = 7;
            // 
            // Inning
            // 
            this.Inning.AutoSize = true;
            this.Inning.Location = new System.Drawing.Point(123, 625);
            this.Inning.Name = "Inning";
            this.Inning.Size = new System.Drawing.Size(73, 13);
            this.Inning.TabIndex = 8;
            this.Inning.Text = "Current Inning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current Half Inning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current Batter";
            // 
            // txtBatter
            // 
            this.txtBatter.Location = new System.Drawing.Point(17, 641);
            this.txtBatter.Name = "txtBatter";
            this.txtBatter.Size = new System.Drawing.Size(100, 20);
            this.txtBatter.TabIndex = 11;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(399, 514);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(98, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load Teams";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Running Score";
            // 
            // dtScores
            // 
            this.dtScores.AllowUserToAddRows = false;
            this.dtScores.AllowUserToDeleteRows = false;
            this.dtScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtScores.Location = new System.Drawing.Point(399, 611);
            this.dtScores.Name = "dtScores";
            this.dtScores.ReadOnly = true;
            this.dtScores.Size = new System.Drawing.Size(240, 207);
            this.dtScores.TabIndex = 15;
            // 
            // btnPlayHalf
            // 
            this.btnPlayHalf.Location = new System.Drawing.Point(399, 560);
            this.btnPlayHalf.Name = "btnPlayHalf";
            this.btnPlayHalf.Size = new System.Drawing.Size(98, 23);
            this.btnPlayHalf.TabIndex = 16;
            this.btnPlayHalf.Text = "Play Half Inning";
            this.btnPlayHalf.UseVisualStyleBackColor = true;
            this.btnPlayHalf.Click += new System.EventHandler(this.btnPlayHalf_Click);
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(541, 514);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(98, 23);
            this.btnSimulate.TabIndex = 1;
            this.btnSimulate.Text = "Simulate Game";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // lblBatter
            // 
            this.lblBatter.AutoSize = true;
            this.lblBatter.Location = new System.Drawing.Point(310, 429);
            this.lblBatter.Name = "lblBatter";
            this.lblBatter.Size = new System.Drawing.Size(0, 13);
            this.lblBatter.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 820);
            this.Controls.Add(this.lblBatter);
            this.Controls.Add(this.btnPlayHalf);
            this.Controls.Add(this.dtScores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtBatter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Inning);
            this.Controls.Add(this.lstAwayTeam);
            this.Controls.Add(this.lstHomeTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInning);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Baseball Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtInning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstHomeTeam;
        private System.Windows.Forms.ListBox lstAwayTeam;
        private System.Windows.Forms.Label Inning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBatter;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtScores;
        private System.Windows.Forms.Button btnPlayHalf;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label lblBatter;
    }
}

