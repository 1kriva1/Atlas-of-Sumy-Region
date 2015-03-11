namespace Viselka
{
    partial class FormViselka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViselka));
            this.picture_error = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label_word = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_error)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_error
            // 
            this.picture_error.BackColor = System.Drawing.Color.White;
            this.picture_error.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_error.Location = new System.Drawing.Point(12, 12);
            this.picture_error.Name = "picture_error";
            this.picture_error.Size = new System.Drawing.Size(300, 350);
            this.picture_error.TabIndex = 0;
            this.picture_error.TabStop = false;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(334, 134);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(549, 228);
            this.panel.TabIndex = 1;
            // 
            // label_word
            // 
            this.label_word.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_word.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_word.Location = new System.Drawing.Point(399, 12);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(424, 105);
            this.label_word.TabIndex = 2;
            this.label_word.Text = "******";
            this.label_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reset.Location = new System.Drawing.Point(12, 368);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(300, 43);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Оновити";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // FormViselka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 413);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label_word);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.picture_error);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormViselka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра Виселка";
            this.Load += new System.EventHandler(this.FormViselka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_error;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.Button button_reset;
    }
}

