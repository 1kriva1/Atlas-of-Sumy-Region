namespace FlyFighter
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_info_frags = new System.Windows.Forms.Label();
            this.label_frags = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pict_ball_1 = new System.Windows.Forms.PictureBox();
            this.pict_fire = new System.Windows.Forms.PictureBox();
            this.pict_ball = new System.Windows.Forms.PictureBox();
            this.pict_ship = new System.Windows.Forms.PictureBox();
            this.label_show_level = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_ball_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_ship)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_info_frags
            // 
            this.label_info_frags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_info_frags.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_frags.Location = new System.Drawing.Point(577, 9);
            this.label_info_frags.Name = "label_info_frags";
            this.label_info_frags.Size = new System.Drawing.Size(120, 28);
            this.label_info_frags.TabIndex = 1;
            this.label_info_frags.Text = "Збитті НЛО:";
            this.label_info_frags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_frags
            // 
            this.label_frags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_frags.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_frags.Location = new System.Drawing.Point(601, 46);
            this.label_frags.Name = "label_frags";
            this.label_frags.Size = new System.Drawing.Size(76, 28);
            this.label_frags.TabIndex = 2;
            this.label_frags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.pict_ball_1);
            this.panel.Controls.Add(this.pict_fire);
            this.panel.Controls.Add(this.pict_ball);
            this.panel.Controls.Add(this.pict_ship);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(571, 403);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // pict_ball_1
            // 
            this.pict_ball_1.Image = ((System.Drawing.Image)(resources.GetObject("pict_ball_1.Image")));
            this.pict_ball_1.Location = new System.Drawing.Point(253, 169);
            this.pict_ball_1.Name = "pict_ball_1";
            this.pict_ball_1.Size = new System.Drawing.Size(64, 64);
            this.pict_ball_1.TabIndex = 3;
            this.pict_ball_1.TabStop = false;
            this.pict_ball_1.Visible = false;
            // 
            // pict_fire
            // 
            this.pict_fire.Image = ((System.Drawing.Image)(resources.GetObject("pict_fire.Image")));
            this.pict_fire.Location = new System.Drawing.Point(36, 315);
            this.pict_fire.Name = "pict_fire";
            this.pict_fire.Size = new System.Drawing.Size(11, 11);
            this.pict_fire.TabIndex = 2;
            this.pict_fire.TabStop = false;
            this.pict_fire.Visible = false;
            this.pict_fire.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // pict_ball
            // 
            this.pict_ball.Image = ((System.Drawing.Image)(resources.GetObject("pict_ball.Image")));
            this.pict_ball.Location = new System.Drawing.Point(154, 75);
            this.pict_ball.Name = "pict_ball";
            this.pict_ball.Size = new System.Drawing.Size(64, 64);
            this.pict_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_ball.TabIndex = 1;
            this.pict_ball.TabStop = false;
            this.pict_ball.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.pict_ball.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // pict_ship
            // 
            this.pict_ship.Image = ((System.Drawing.Image)(resources.GetObject("pict_ship.Image")));
            this.pict_ship.Location = new System.Drawing.Point(11, 332);
            this.pict_ship.Name = "pict_ship";
            this.pict_ship.Size = new System.Drawing.Size(64, 64);
            this.pict_ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_ship.TabIndex = 0;
            this.pict_ship.TabStop = false;
            this.pict_ship.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.pict_ship.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // label_show_level
            // 
            this.label_show_level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_show_level.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_level.Location = new System.Drawing.Point(577, 101);
            this.label_show_level.Name = "label_show_level";
            this.label_show_level.Size = new System.Drawing.Size(120, 28);
            this.label_show_level.TabIndex = 3;
            this.label_show_level.Text = "Рівень:";
            this.label_show_level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_level
            // 
            this.label_level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_level.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_level.Location = new System.Drawing.Point(601, 145);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(76, 28);
            this.label_level.TabIndex = 4;
            this.label_level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 403);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.label_show_level);
            this.Controls.Add(this.label_frags);
            this.Controls.Add(this.label_info_frags);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бойовий літачок";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pict_ball_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_ship)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pict_fire;
        private System.Windows.Forms.PictureBox pict_ball;
        private System.Windows.Forms.PictureBox pict_ship;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_info_frags;
        private System.Windows.Forms.Label label_frags;
        private System.Windows.Forms.PictureBox pict_ball_1;
        private System.Windows.Forms.Label label_show_level;
        private System.Windows.Forms.Label label_level;
    }
}

