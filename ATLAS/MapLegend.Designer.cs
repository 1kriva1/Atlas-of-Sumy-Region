﻿namespace ATLAS
{
    partial class MapLegend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapLegend));
            this.pictureBox_MapLegend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MapLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_MapLegend
            // 
            this.pictureBox_MapLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_MapLegend.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_MapLegend.Name = "pictureBox_MapLegend";
            this.pictureBox_MapLegend.Size = new System.Drawing.Size(500, 512);
            this.pictureBox_MapLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_MapLegend.TabIndex = 0;
            this.pictureBox_MapLegend.TabStop = false;
            // 
            // MapLegend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 512);
            this.Controls.Add(this.pictureBox_MapLegend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MapLegend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Легенда карти";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapLegend_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MapLegend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_MapLegend;
    }
}