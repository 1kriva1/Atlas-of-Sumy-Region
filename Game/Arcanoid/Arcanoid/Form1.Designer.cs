namespace Arcanoid
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.super = new System.Windows.Forms.Label();
            this.label_super1 = new System.Windows.Forms.Label();
            this.label_super2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.RadioButton();
            this.rocket = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_show_life = new System.Windows.Forms.Label();
            this.label_life = new System.Windows.Forms.Label();
            this.label_show_level = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.timer_bonus = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.super);
            this.panel1.Controls.Add(this.label_super1);
            this.panel1.Controls.Add(this.label_super2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ball);
            this.panel1.Controls.Add(this.rocket);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 457);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(125, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 35);
            this.label5.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(352, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 35);
            this.label4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(225, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 35);
            this.label3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(296, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 35);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(157, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 35);
            this.label1.TabIndex = 13;
            // 
            // super
            // 
            this.super.BackColor = System.Drawing.Color.Red;
            this.super.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.super.Location = new System.Drawing.Point(193, 267);
            this.super.Name = "super";
            this.super.Size = new System.Drawing.Size(85, 70);
            this.super.TabIndex = 12;
            this.super.Text = "Bonus";
            this.super.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.super.Visible = false;
            // 
            // label_super1
            // 
            this.label_super1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_super1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_super1.Location = new System.Drawing.Point(39, 147);
            this.label_super1.Name = "label_super1";
            this.label_super1.Size = new System.Drawing.Size(68, 52);
            this.label_super1.TabIndex = 11;
            this.label_super1.Text = "Extra Box";
            this.label_super1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_super1.Visible = false;
            // 
            // label_super2
            // 
            this.label_super2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_super2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_super2.Location = new System.Drawing.Point(390, 138);
            this.label_super2.Name = "label_super2";
            this.label_super2.Size = new System.Drawing.Size(68, 52);
            this.label_super2.TabIndex = 10;
            this.label_super2.Text = "Extra Box";
            this.label_super2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_super2.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(410, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 35);
            this.label7.TabIndex = 9;
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.Checked = true;
            this.ball.Enabled = false;
            this.ball.Location = new System.Drawing.Point(244, 417);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 13);
            this.ball.TabIndex = 8;
            this.ball.TabStop = true;
            this.ball.UseVisualStyleBackColor = true;
            // 
            // rocket
            // 
            this.rocket.Enabled = false;
            this.rocket.Location = new System.Drawing.Point(193, 429);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(114, 28);
            this.rocket.TabIndex = 7;
            this.rocket.Text = "- - - - -";
            this.rocket.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(27, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 35);
            this.label6.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_show_life
            // 
            this.label_show_life.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_show_life.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_show_life.Location = new System.Drawing.Point(515, 12);
            this.label_show_life.Name = "label_show_life";
            this.label_show_life.Size = new System.Drawing.Size(143, 23);
            this.label_show_life.TabIndex = 1;
            this.label_show_life.Text = "Кількість життів:";
            this.label_show_life.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_life
            // 
            this.label_life.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_life.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_life.Location = new System.Drawing.Point(555, 45);
            this.label_life.Name = "label_life";
            this.label_life.Size = new System.Drawing.Size(67, 39);
            this.label_life.TabIndex = 2;
            this.label_life.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_show_level
            // 
            this.label_show_level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_show_level.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_show_level.Location = new System.Drawing.Point(515, 110);
            this.label_show_level.Name = "label_show_level";
            this.label_show_level.Size = new System.Drawing.Size(143, 23);
            this.label_show_level.TabIndex = 3;
            this.label_show_level.Text = "Рівень:";
            this.label_show_level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_level
            // 
            this.label_level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_level.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_level.Location = new System.Drawing.Point(555, 150);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(67, 39);
            this.label_level.TabIndex = 4;
            this.label_level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_bonus
            // 
            this.timer_bonus.Interval = 120;
            this.timer_bonus.Tick += new System.EventHandler(this.timer_bonus_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 481);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.label_show_level);
            this.Controls.Add(this.label_life);
            this.Controls.Add(this.label_show_life);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Арканоїд";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rocket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton ball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_show_life;
        private System.Windows.Forms.Label label_life;
        private System.Windows.Forms.Label label_show_level;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_super1;
        private System.Windows.Forms.Label label_super2;
        private System.Windows.Forms.Label super;
        private System.Windows.Forms.Timer timer_bonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

