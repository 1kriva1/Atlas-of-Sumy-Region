namespace HandGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_paper = new System.Windows.Forms.Panel();
            this.pictureBox_paper = new System.Windows.Forms.PictureBox();
            this.panel_scissors = new System.Windows.Forms.Panel();
            this.pictureBox_scissors = new System.Windows.Forms.PictureBox();
            this.panel_stone = new System.Windows.Forms.Panel();
            this.pictureBox_stone = new System.Windows.Forms.PictureBox();
            this.panel_comp = new System.Windows.Forms.Panel();
            this.comp_scissors = new System.Windows.Forms.PictureBox();
            this.comp_paper = new System.Windows.Forms.PictureBox();
            this.comp_stone = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_nessege = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label_comp = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_paper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_paper)).BeginInit();
            this.panel_scissors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_scissors)).BeginInit();
            this.panel_stone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stone)).BeginInit();
            this.panel_comp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comp_scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_stone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_paper
            // 
            this.panel_paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_paper.Controls.Add(this.pictureBox_paper);
            this.panel_paper.Location = new System.Drawing.Point(178, 56);
            this.panel_paper.Name = "panel_paper";
            this.panel_paper.Size = new System.Drawing.Size(150, 150);
            this.panel_paper.TabIndex = 0;
            this.panel_paper.Tag = "paper";
            this.panel_paper.MouseEnter += new System.EventHandler(this.panel_stone_MouseEnter);
            // 
            // pictureBox_paper
            // 
            this.pictureBox_paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_paper.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_paper.Image")));
            this.pictureBox_paper.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_paper.Name = "pictureBox_paper";
            this.pictureBox_paper.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_paper.TabIndex = 4;
            this.pictureBox_paper.TabStop = false;
            this.pictureBox_paper.Tag = "";
            this.pictureBox_paper.Visible = false;
            this.pictureBox_paper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_stone_MouseClick);
            // 
            // panel_scissors
            // 
            this.panel_scissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_scissors.Controls.Add(this.pictureBox_scissors);
            this.panel_scissors.Location = new System.Drawing.Point(343, 56);
            this.panel_scissors.Name = "panel_scissors";
            this.panel_scissors.Size = new System.Drawing.Size(150, 150);
            this.panel_scissors.TabIndex = 1;
            this.panel_scissors.Tag = "scissors";
            this.panel_scissors.MouseEnter += new System.EventHandler(this.panel_stone_MouseEnter);
            // 
            // pictureBox_scissors
            // 
            this.pictureBox_scissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_scissors.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_scissors.Image")));
            this.pictureBox_scissors.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_scissors.Name = "pictureBox_scissors";
            this.pictureBox_scissors.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_scissors.TabIndex = 3;
            this.pictureBox_scissors.TabStop = false;
            this.pictureBox_scissors.Tag = "";
            this.pictureBox_scissors.Visible = false;
            this.pictureBox_scissors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_stone_MouseClick);
            // 
            // panel_stone
            // 
            this.panel_stone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_stone.Controls.Add(this.pictureBox_stone);
            this.panel_stone.Location = new System.Drawing.Point(12, 56);
            this.panel_stone.Name = "panel_stone";
            this.panel_stone.Size = new System.Drawing.Size(150, 150);
            this.panel_stone.TabIndex = 1;
            this.panel_stone.Tag = "stone";
            this.panel_stone.MouseEnter += new System.EventHandler(this.panel_stone_MouseEnter);
            // 
            // pictureBox_stone
            // 
            this.pictureBox_stone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_stone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_stone.Image")));
            this.pictureBox_stone.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_stone.Name = "pictureBox_stone";
            this.pictureBox_stone.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_stone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_stone.TabIndex = 2;
            this.pictureBox_stone.TabStop = false;
            this.pictureBox_stone.Tag = "";
            this.pictureBox_stone.Visible = false;
            this.pictureBox_stone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_stone_MouseClick);
            // 
            // panel_comp
            // 
            this.panel_comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_comp.Controls.Add(this.comp_scissors);
            this.panel_comp.Controls.Add(this.comp_paper);
            this.panel_comp.Controls.Add(this.comp_stone);
            this.panel_comp.Location = new System.Drawing.Point(602, 56);
            this.panel_comp.Name = "panel_comp";
            this.panel_comp.Size = new System.Drawing.Size(150, 150);
            this.panel_comp.TabIndex = 1;
            // 
            // comp_scissors
            // 
            this.comp_scissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comp_scissors.Image = ((System.Drawing.Image)(resources.GetObject("comp_scissors.Image")));
            this.comp_scissors.Location = new System.Drawing.Point(0, 0);
            this.comp_scissors.Name = "comp_scissors";
            this.comp_scissors.Size = new System.Drawing.Size(150, 150);
            this.comp_scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_scissors.TabIndex = 7;
            this.comp_scissors.TabStop = false;
            // 
            // comp_paper
            // 
            this.comp_paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comp_paper.Image = ((System.Drawing.Image)(resources.GetObject("comp_paper.Image")));
            this.comp_paper.Location = new System.Drawing.Point(0, 0);
            this.comp_paper.Name = "comp_paper";
            this.comp_paper.Size = new System.Drawing.Size(150, 150);
            this.comp_paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_paper.TabIndex = 6;
            this.comp_paper.TabStop = false;
            // 
            // comp_stone
            // 
            this.comp_stone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comp_stone.Image = ((System.Drawing.Image)(resources.GetObject("comp_stone.Image")));
            this.comp_stone.Location = new System.Drawing.Point(0, 0);
            this.comp_stone.Name = "comp_stone";
            this.comp_stone.Size = new System.Drawing.Size(150, 150);
            this.comp_stone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_stone.TabIndex = 5;
            this.comp_stone.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_nessege
            // 
            this.label_nessege.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_nessege.Location = new System.Drawing.Point(13, 23);
            this.label_nessege.Name = "label_nessege";
            this.label_nessege.Size = new System.Drawing.Size(480, 27);
            this.label_nessege.TabIndex = 2;
            this.label_nessege.Text = "Вибери свою фігуру";
            this.label_nessege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_result
            // 
            this.label_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_result.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(13, 296);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(740, 45);
            this.label_result.TabIndex = 3;
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_comp
            // 
            this.label_comp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_comp.Location = new System.Drawing.Point(585, 9);
            this.label_comp.Name = "label_comp";
            this.label_comp.Size = new System.Drawing.Size(186, 41);
            this.label_comp.TabIndex = 4;
            this.label_comp.Text = "Рука комп\'ютера";
            this.label_comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(297, 248);
            this.trackBar.Maximum = 5;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(197, 45);
            this.trackBar.TabIndex = 5;
            this.trackBar.Value = 3;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(325, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Рівень гри:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(783, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label_comp);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_nessege);
            this.Controls.Add(this.panel_scissors);
            this.Controls.Add(this.panel_stone);
            this.Controls.Add(this.panel_comp);
            this.Controls.Add(this.panel_paper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камінь ножиці бумага";
            this.panel_paper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_paper)).EndInit();
            this.panel_scissors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_scissors)).EndInit();
            this.panel_stone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stone)).EndInit();
            this.panel_comp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comp_scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_stone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_paper;
        private System.Windows.Forms.PictureBox pictureBox_paper;
        private System.Windows.Forms.Panel panel_scissors;
        private System.Windows.Forms.PictureBox pictureBox_scissors;
        private System.Windows.Forms.Panel panel_stone;
        private System.Windows.Forms.PictureBox pictureBox_stone;
        private System.Windows.Forms.Panel panel_comp;
        private System.Windows.Forms.PictureBox comp_stone;
        private System.Windows.Forms.PictureBox comp_scissors;
        private System.Windows.Forms.PictureBox comp_paper;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_nessege;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_comp;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label1;
    }
}

