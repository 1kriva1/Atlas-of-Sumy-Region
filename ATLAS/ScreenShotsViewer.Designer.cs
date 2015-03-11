namespace ATLAS
{
    partial class ScreenShotsViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenShotsViewer));
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.listBox_screenshots = new System.Windows.Forms.ListBox();
            this.pictureBox_screenshot = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_screenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.button_delete);
            this.panel_main.Controls.Add(this.label_title);
            this.panel_main.Controls.Add(this.listBox_screenshots);
            this.panel_main.Controls.Add(this.pictureBox_screenshot);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(763, 410);
            this.panel_main.TabIndex = 1;
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(105, 373);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(81, 28);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Видалити";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(53, 19);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(188, 29);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Список скріншотів:";
            // 
            // listBox_screenshots
            // 
            this.listBox_screenshots.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_screenshots.FormattingEnabled = true;
            this.listBox_screenshots.ItemHeight = 27;
            this.listBox_screenshots.Location = new System.Drawing.Point(3, 60);
            this.listBox_screenshots.Name = "listBox_screenshots";
            this.listBox_screenshots.Size = new System.Drawing.Size(299, 301);
            this.listBox_screenshots.TabIndex = 1;
            this.listBox_screenshots.SelectedIndexChanged += new System.EventHandler(this.listBox_screenshots_SelectedIndexChanged);
            // 
            // pictureBox_screenshot
            // 
            this.pictureBox_screenshot.BackColor = System.Drawing.Color.Teal;
            this.pictureBox_screenshot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_screenshot.Location = new System.Drawing.Point(307, 5);
            this.pictureBox_screenshot.Name = "pictureBox_screenshot";
            this.pictureBox_screenshot.Size = new System.Drawing.Size(452, 401);
            this.pictureBox_screenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_screenshot.TabIndex = 0;
            this.pictureBox_screenshot.TabStop = false;
            // 
            // ScreenShotsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 410);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreenShotsViewer";
            this.Text = "ScreenShots";
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_screenshot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ListBox listBox_screenshots;
        private System.Windows.Forms.PictureBox pictureBox_screenshot;
    }
}