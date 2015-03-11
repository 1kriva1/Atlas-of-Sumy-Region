namespace MindCounts
{
    partial class FormMindCounter
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
            this.label_question = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multy = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBox_level = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_question.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_question.Location = new System.Drawing.Point(12, 19);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(533, 149);
            this.label_question.TabIndex = 0;
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_answer
            // 
            this.textBox_answer.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_answer.Location = new System.Drawing.Point(551, 32);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(219, 124);
            this.textBox_answer.TabIndex = 1;
            this.textBox_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_answer_KeyDown);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(12, 238);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(166, 46);
            this.button_plus.TabIndex = 2;
            this.button_plus.Text = "Сума";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(195, 238);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(166, 46);
            this.button_minus.TabIndex = 3;
            this.button_minus.Text = "Різниця";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_multy
            // 
            this.button_multy.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multy.Location = new System.Drawing.Point(379, 238);
            this.button_multy.Name = "button_multy";
            this.button_multy.Size = new System.Drawing.Size(166, 46);
            this.button_multy.TabIndex = 4;
            this.button_multy.Text = "Множення";
            this.button_multy.UseVisualStyleBackColor = true;
            this.button_multy.Click += new System.EventHandler(this.button_multy_Click);
            // 
            // button_divide
            // 
            this.button_divide.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_divide.Location = new System.Drawing.Point(566, 238);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(166, 46);
            this.button_divide.TabIndex = 5;
            this.button_divide.Text = "Ділення";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 181);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(642, 33);
            this.progressBar.TabIndex = 6;
            // 
            // textBox_level
            // 
            this.textBox_level.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_level.Location = new System.Drawing.Point(673, 181);
            this.textBox_level.Name = "textBox_level";
            this.textBox_level.Size = new System.Drawing.Size(97, 32);
            this.textBox_level.TabIndex = 7;
            this.textBox_level.Text = "10";
            this.textBox_level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_1
            // 
            this.label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_1.Location = new System.Drawing.Point(807, 19);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(183, 104);
            this.label_1.TabIndex = 8;
            this.label_1.Text = "Залишилось часу:";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_time
            // 
            this.label_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_time.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time.Location = new System.Drawing.Point(807, 157);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(183, 127);
            this.label_time.TabIndex = 9;
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clock
            // 
            this.clock.Interval = 2000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // FormMindCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 297);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.textBox_level);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_multy);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMindCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Усний рахунок";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multy;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBox_level;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer clock;
    }
}

