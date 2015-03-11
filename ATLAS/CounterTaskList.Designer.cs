namespace ATLAS
{
    partial class CounterTaskList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterTaskList));
            this.listBox = new System.Windows.Forms.ListBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_teritory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_thema = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 23;
            this.listBox.Location = new System.Drawing.Point(12, 91);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(279, 372);
            this.listBox.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(12, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(449, 65);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Список об\'єктів, які необхідно позначити на контурній карті:";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_teritory
            // 
            this.label_teritory.BackColor = System.Drawing.Color.White;
            this.label_teritory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_teritory.Location = new System.Drawing.Point(319, 91);
            this.label_teritory.Name = "label_teritory";
            this.label_teritory.Size = new System.Drawing.Size(115, 38);
            this.label_teritory.TabIndex = 2;
            this.label_teritory.Text = "Територія:";
            this.label_teritory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(300, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Територія:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_thema
            // 
            this.label_thema.BackColor = System.Drawing.Color.White;
            this.label_thema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_thema.Location = new System.Drawing.Point(319, 284);
            this.label_thema.Name = "label_thema";
            this.label_thema.Size = new System.Drawing.Size(115, 38);
            this.label_thema.TabIndex = 5;
            this.label_thema.Text = "Тема:";
            this.label_thema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(297, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 65);
            this.label2.TabIndex = 6;
            this.label2.Text = "Територія:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CounterTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(473, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_thema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_teritory);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.listBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "CounterTaskList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список об\'єктів";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_teritory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_thema;
        private System.Windows.Forms.Label label2;
    }
}