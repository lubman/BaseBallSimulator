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
            this.txtInning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstHomeTeam = new System.Windows.Forms.ListBox();
            this.lstAwayTeam = new System.Windows.Forms.ListBox();
            this.Inning = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtHomeScores = new System.Windows.Forms.DataGridView();
            this.btnPlayHalf = new System.Windows.Forms.Button();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.lblBatter = new System.Windows.Forms.Label();
            this.dtAwayTeamScores = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtHomeTeamName = new System.Windows.Forms.TextBox();
            this.txtAwayTeamName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHomeScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAwayTeamScores)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtInning
            // 
            this.txtInning.Location = new System.Drawing.Point(494, 179);
            this.txtInning.Name = "txtInning";
            this.txtInning.Size = new System.Drawing.Size(115, 20);
            this.txtInning.TabIndex = 3;
            this.txtInning.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home Team Name && Roster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Away Team Name && Roster";
            // 
            // lstHomeTeam
            // 
            this.lstHomeTeam.FormattingEnabled = true;
            this.lstHomeTeam.Location = new System.Drawing.Point(492, 65);
            this.lstHomeTeam.Name = "lstHomeTeam";
            this.lstHomeTeam.Size = new System.Drawing.Size(154, 95);
            this.lstHomeTeam.TabIndex = 6;
            // 
            // lstAwayTeam
            // 
            this.lstAwayTeam.FormattingEnabled = true;
            this.lstAwayTeam.Location = new System.Drawing.Point(492, 246);
            this.lstAwayTeam.Name = "lstAwayTeam";
            this.lstAwayTeam.Size = new System.Drawing.Size(154, 95);
            this.lstAwayTeam.TabIndex = 7;
            // 
            // Inning
            // 
            this.Inning.AutoSize = true;
            this.Inning.Location = new System.Drawing.Point(491, 163);
            this.Inning.Name = "Inning";
            this.Inning.Size = new System.Drawing.Size(73, 13);
            this.Inning.TabIndex = 8;
            this.Inning.Text = "Current Inning";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 358);
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
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Home team scores";
            // 
            // dtHomeScores
            // 
            this.dtHomeScores.AllowUserToAddRows = false;
            this.dtHomeScores.AllowUserToDeleteRows = false;
            this.dtHomeScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHomeScores.Location = new System.Drawing.Point(15, 400);
            this.dtHomeScores.Name = "dtHomeScores";
            this.dtHomeScores.ReadOnly = true;
            this.dtHomeScores.Size = new System.Drawing.Size(631, 156);
            this.dtHomeScores.TabIndex = 15;
            // 
            // btnPlayHalf
            // 
            this.btnPlayHalf.Location = new System.Drawing.Point(190, 358);
            this.btnPlayHalf.Name = "btnPlayHalf";
            this.btnPlayHalf.Size = new System.Drawing.Size(98, 23);
            this.btnPlayHalf.TabIndex = 16;
            this.btnPlayHalf.Text = "Play Half Inning";
            this.btnPlayHalf.UseVisualStyleBackColor = true;
            this.btnPlayHalf.Click += new System.EventHandler(this.btnPlayHalf_Click);
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(372, 358);
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
            // dtAwayTeamScores
            // 
            this.dtAwayTeamScores.AllowUserToAddRows = false;
            this.dtAwayTeamScores.AllowUserToDeleteRows = false;
            this.dtAwayTeamScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAwayTeamScores.Location = new System.Drawing.Point(20, 611);
            this.dtAwayTeamScores.Name = "dtAwayTeamScores";
            this.dtAwayTeamScores.ReadOnly = true;
            this.dtAwayTeamScores.Size = new System.Drawing.Size(626, 156);
            this.dtAwayTeamScores.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Away team scores";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(524, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save Scores to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHomeTeamName
            // 
            this.txtHomeTeamName.Location = new System.Drawing.Point(492, 39);
            this.txtHomeTeamName.Name = "txtHomeTeamName";
            this.txtHomeTeamName.Size = new System.Drawing.Size(154, 20);
            this.txtHomeTeamName.TabIndex = 21;
            this.txtHomeTeamName.Text = "Phillies";
            // 
            // txtAwayTeamName
            // 
            this.txtAwayTeamName.Location = new System.Drawing.Point(492, 220);
            this.txtAwayTeamName.Name = "txtAwayTeamName";
            this.txtAwayTeamName.Size = new System.Drawing.Size(149, 20);
            this.txtAwayTeamName.TabIndex = 22;
            this.txtAwayTeamName.Text = "Diamondbacks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 776);
            this.Controls.Add(this.txtAwayTeamName);
            this.Controls.Add(this.txtHomeTeamName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtAwayTeamScores);
            this.Controls.Add(this.lblBatter);
            this.Controls.Add(this.btnPlayHalf);
            this.Controls.Add(this.dtHomeScores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.Inning);
            this.Controls.Add(this.lstAwayTeam);
            this.Controls.Add(this.lstHomeTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInning);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Baseball Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHomeScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAwayTeamScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtInning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstHomeTeam;
        private System.Windows.Forms.ListBox lstAwayTeam;
        private System.Windows.Forms.Label Inning;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtHomeScores;
        private System.Windows.Forms.Button btnPlayHalf;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label lblBatter;
        private System.Windows.Forms.DataGridView dtAwayTeamScores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtHomeTeamName;
        private System.Windows.Forms.TextBox txtAwayTeamName;
    }
}

