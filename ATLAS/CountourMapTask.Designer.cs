namespace ATLAS
{
    partial class CountourMapTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountourMapTask));
            this.button_start = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_thema = new System.Windows.Forms.ComboBox();
            this.comboBox_teritory = new System.Windows.Forms.ComboBox();
            this.label_thema = new System.Windows.Forms.Label();
            this.label_teritory = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_stat_teritory = new System.Windows.Forms.Label();
            this.label_stat_thema = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl_instrument = new System.Windows.Forms.TabControl();
            this.tabPage_main = new System.Windows.Forms.TabPage();
            this.button_fill_rectangle = new System.Windows.Forms.Button();
            this.button_fill_ellipse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_reverse = new System.Windows.Forms.Label();
            this.button_color = new System.Windows.Forms.Button();
            this.comboBox_spill = new System.Windows.Forms.ComboBox();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_mapRefresh = new System.Windows.Forms.Button();
            this.button_shrift = new System.Windows.Forms.Button();
            this.button_text = new System.Windows.Forms.Button();
            this.button_Elipse = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
            this.button_pen = new System.Windows.Forms.Button();
            this.tabPage_view = new System.Windows.Forms.TabPage();
            this.button_countour_back = new System.Windows.Forms.Button();
            this.button_show_list = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.pictureBox_map = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_X = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Y = new System.Windows.Forms.ToolStripStatusLabel();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog_counterMap = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.tabControl_instrument.SuspendLayout();
            this.tabPage_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
            this.tabPage_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_map)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(459, 683);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(191, 71);
            this.button_start.TabIndex = 15;
            this.button_start.Text = "Приступити до завдання";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Visible = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_refresh.Location = new System.Drawing.Point(12, 722);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(191, 32);
            this.button_refresh.TabIndex = 14;
            this.button_refresh.Text = "Оновити";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Visible = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_thema
            // 
            this.comboBox_thema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_thema.Enabled = false;
            this.comboBox_thema.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_thema.FormattingEnabled = true;
            this.comboBox_thema.Items.AddRange(new object[] {
            "Населенні пункти",
            "Річки",
            "Корисні копалини"});
            this.comboBox_thema.Location = new System.Drawing.Point(666, 373);
            this.comboBox_thema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_thema.Name = "comboBox_thema";
            this.comboBox_thema.Size = new System.Drawing.Size(343, 35);
            this.comboBox_thema.TabIndex = 13;
            this.comboBox_thema.SelectedIndexChanged += new System.EventHandler(this.comboBox_thema_SelectedIndexChanged);
            // 
            // comboBox_teritory
            // 
            this.comboBox_teritory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_teritory.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_teritory.FormattingEnabled = true;
            this.comboBox_teritory.Items.AddRange(new object[] {
            "Конотопський район",
            "Сумський район"});
            this.comboBox_teritory.Location = new System.Drawing.Point(54, 373);
            this.comboBox_teritory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_teritory.Name = "comboBox_teritory";
            this.comboBox_teritory.Size = new System.Drawing.Size(343, 35);
            this.comboBox_teritory.TabIndex = 12;
            this.comboBox_teritory.SelectedIndexChanged += new System.EventHandler(this.comboBox_teritory_SelectedIndexChanged);
            // 
            // label_thema
            // 
            this.label_thema.BackColor = System.Drawing.Color.Transparent;
            this.label_thema.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_thema.Location = new System.Drawing.Point(642, 226);
            this.label_thema.Name = "label_thema";
            this.label_thema.Size = new System.Drawing.Size(394, 53);
            this.label_thema.TabIndex = 11;
            this.label_thema.Text = "Виберіть тему завдання:";
            this.label_thema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_teritory
            // 
            this.label_teritory.BackColor = System.Drawing.Color.Transparent;
            this.label_teritory.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_teritory.Location = new System.Drawing.Point(35, 226);
            this.label_teritory.Name = "label_teritory";
            this.label_teritory.Size = new System.Drawing.Size(394, 53);
            this.label_teritory.TabIndex = 10;
            this.label_teritory.Text = "Виберіть територію:";
            this.label_teritory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_title
            // 
            this.label_title.BackColor = System.Drawing.Color.White;
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_title.Location = new System.Drawing.Point(14, 49);
            this.label_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(1056, 56);
            this.label_title.TabIndex = 9;
            this.label_title.Text = "Виберіть режим для завдань на контурних картах";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_stat_teritory
            // 
            this.label_stat_teritory.BackColor = System.Drawing.Color.White;
            this.label_stat_teritory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_stat_teritory.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_stat_teritory.Location = new System.Drawing.Point(87, 513);
            this.label_stat_teritory.Name = "label_stat_teritory";
            this.label_stat_teritory.Size = new System.Drawing.Size(218, 49);
            this.label_stat_teritory.TabIndex = 16;
            this.label_stat_teritory.Text = "Територія:";
            this.label_stat_teritory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_stat_thema
            // 
            this.label_stat_thema.BackColor = System.Drawing.Color.White;
            this.label_stat_thema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_stat_thema.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_stat_thema.Location = new System.Drawing.Point(729, 513);
            this.label_stat_thema.Name = "label_stat_thema";
            this.label_stat_thema.Size = new System.Drawing.Size(218, 49);
            this.label_stat_thema.TabIndex = 17;
            this.label_stat_thema.Text = "Тема:";
            this.label_stat_thema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 90);
            this.label1.TabIndex = 18;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(715, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 90);
            this.label2.TabIndex = 19;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl_instrument
            // 
            this.tabControl_instrument.Controls.Add(this.tabPage_main);
            this.tabControl_instrument.Controls.Add(this.tabPage_view);
            this.tabControl_instrument.Location = new System.Drawing.Point(0, 0);
            this.tabControl_instrument.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl_instrument.Name = "tabControl_instrument";
            this.tabControl_instrument.SelectedIndex = 0;
            this.tabControl_instrument.Size = new System.Drawing.Size(1085, 105);
            this.tabControl_instrument.TabIndex = 20;
            this.tabControl_instrument.Visible = false;
            // 
            // tabPage_main
            // 
            this.tabPage_main.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage_main.Controls.Add(this.button_fill_rectangle);
            this.tabPage_main.Controls.Add(this.button_fill_ellipse);
            this.tabPage_main.Controls.Add(this.label3);
            this.tabPage_main.Controls.Add(this.label_reverse);
            this.tabPage_main.Controls.Add(this.button_color);
            this.tabPage_main.Controls.Add(this.comboBox_spill);
            this.tabPage_main.Controls.Add(this.button_clean);
            this.tabPage_main.Controls.Add(this.button_next);
            this.tabPage_main.Controls.Add(this.button_back);
            this.tabPage_main.Controls.Add(this.button_mapRefresh);
            this.tabPage_main.Controls.Add(this.button_shrift);
            this.tabPage_main.Controls.Add(this.button_text);
            this.tabPage_main.Controls.Add(this.button_Elipse);
            this.tabPage_main.Controls.Add(this.button_rectangle);
            this.tabPage_main.Controls.Add(this.button_line);
            this.tabPage_main.Controls.Add(this.numericUpDown_width);
            this.tabPage_main.Controls.Add(this.button_pen);
            this.tabPage_main.Location = new System.Drawing.Point(4, 25);
            this.tabPage_main.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage_main.Name = "tabPage_main";
            this.tabPage_main.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage_main.Size = new System.Drawing.Size(1077, 76);
            this.tabPage_main.TabIndex = 0;
            this.tabPage_main.Text = "Головна";
            // 
            // button_fill_rectangle
            // 
            this.button_fill_rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_fill_rectangle.BackgroundImage")));
            this.button_fill_rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fill_rectangle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_fill_rectangle.Location = new System.Drawing.Point(328, 15);
            this.button_fill_rectangle.Name = "button_fill_rectangle";
            this.button_fill_rectangle.Size = new System.Drawing.Size(57, 49);
            this.button_fill_rectangle.TabIndex = 30;
            this.button_fill_rectangle.Text = "Еліпс";
            this.button_fill_rectangle.UseVisualStyleBackColor = true;
            this.button_fill_rectangle.Click += new System.EventHandler(this.Change_Tools_Click);
            // 
            // button_fill_ellipse
            // 
            this.button_fill_ellipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_fill_ellipse.BackgroundImage")));
            this.button_fill_ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fill_ellipse.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_fill_ellipse.Location = new System.Drawing.Point(387, 15);
            this.button_fill_ellipse.Name = "button_fill_ellipse";
            this.button_fill_ellipse.Size = new System.Drawing.Size(58, 49);
            this.button_fill_ellipse.TabIndex = 29;
            this.button_fill_ellipse.Text = "Еліпс";
            this.button_fill_ellipse.UseVisualStyleBackColor = true;
            this.button_fill_ellipse.Click += new System.EventHandler(this.Change_Tools_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(632, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Товщина";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_reverse
            // 
            this.label_reverse.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_reverse.Location = new System.Drawing.Point(785, 12);
            this.label_reverse.Name = "label_reverse";
            this.label_reverse.Size = new System.Drawing.Size(79, 24);
            this.label_reverse.TabIndex = 23;
            this.label_reverse.Text = "Повернути";
            this.label_reverse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_color
            // 
            this.button_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_color.BackgroundImage")));
            this.button_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_color.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_color.Location = new System.Drawing.Point(991, 15);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(79, 47);
            this.button_color.TabIndex = 27;
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // comboBox_spill
            // 
            this.comboBox_spill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_spill.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_spill.FormattingEnabled = true;
            this.comboBox_spill.Items.AddRange(new object[] {
            "Повернути на 90 градусів направо",
            "Повернути на 90 градусів вліво",
            "Повернтути на 180 градусів"});
            this.comboBox_spill.Location = new System.Drawing.Point(742, 43);
            this.comboBox_spill.Name = "comboBox_spill";
            this.comboBox_spill.Size = new System.Drawing.Size(161, 21);
            this.comboBox_spill.TabIndex = 26;
            this.comboBox_spill.SelectedIndexChanged += new System.EventHandler(this.comboBox_spill_SelectedIndexChanged);
            // 
            // button_clean
            // 
            this.button_clean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_clean.BackgroundImage")));
            this.button_clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_clean.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clean.Location = new System.Drawing.Point(911, 15);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(72, 47);
            this.button_clean.TabIndex = 25;
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.Change_Tools_Click);
            // 
            // button_next
            // 
            this.button_next.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next.Location = new System.Drawing.Point(56, 12);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(48, 21);
            this.button_next.TabIndex = 24;
            this.button_next.Text = "Вперед";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(3, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(46, 20);
            this.button_back.TabIndex = 23;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_mapRefresh
            // 
            this.button_mapRefresh.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mapRefresh.Location = new System.Drawing.Point(16, 43);
            this.button_mapRefresh.Name = "button_mapRefresh";
            this.button_mapRefresh.Size = new System.Drawing.Size(75, 22);
            this.button_mapRefresh.TabIndex = 22;
            this.button_mapRefresh.Text = "Очистити";
            this.button_mapRefresh.UseVisualStyleBackColor = true;
            this.button_mapRefresh.Click += new System.EventHandler(this.button_mapRefresh_Click);
            // 
            // button_shrift
            // 
            this.button_shrift.Location = new System.Drawing.Point(112, 43);
            this.button_shrift.Name = "button_shrift";
            this.button_shrift.Size = new System.Drawing.Size(57, 29);
            this.button_shrift.TabIndex = 21;
            this.button_shrift.Text = "ШРИФТ";
            this.button_shrift.UseVisualStyleBackColor = true;
            this.button_shrift.Click += new System.EventHandler(this.button_shrift_Click);
            // 
            // button_text
            // 
            this.button_text.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_text.BackgroundImage")));
            this.button_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_text.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_text.Location = new System.Drawing.Point(110, 8);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(60, 33);
            this.button_text.TabIndex = 17;
            this.button_text.UseVisualStyleBackColor = true;
            this.button_text.Click += new System.EventHandler(this.Change_Tools_Click);
            // 
            // button_Elipse
            // 
            this.button_Elipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Elipse.BackgroundImage")));
            this.button_Elipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Elipse.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Elipse.Location = new System.Drawing.Point(259, 15);
            this.button_Elipse.Name = "button_Elipse";
            this.button_Elipse.Size = new System.Drawing.Size(67, 49);
            this.button_Elipse.TabIndex = 16;
            this.button_Elipse.Text = "Еліпс";
            this.button_Elipse.UseVisualStyleBackColor = true;
            this.button_Elipse.Click += new System.EventHandler(this.Change_Tools_Click);
            // 
            // button_rectangle
            // 
            this.button_rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_rectangle.BackgroundImage")));
            this.button_rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_rectangle.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_rectangle.Location = new System.Drawing.Point(177, 15);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(81, 50);
            this.button_rectangle.TabIndex = 15;
            this.button_rectangle.Text = "Прямокутник";
            this.button_rectangle.UseVisualStyleBackColor = true;
            this.button_rectangle.Click += new System.EventHandler(this.Change_Tools_Click);
            // 
            // button_line
            // 
            this.button_line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_line.BackgroundImage")));
            this.button_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_line.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_line.Location = new System.Drawing.Point(446, 15);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(60, 50);
            this.button_line.TabIndex = 13;
            this.button_line.Text = "Лінія";
            this.button_line.UseVisualStyleBackColor = true;
            this.button_line.Click += new System.EventHandler(this.Change_Tools_Click);
            // 
            // numericUpDown_width
            // 
            this.numericUpDown_width.Location = new System.Drawing.Point(618, 41);
            this.numericUpDown_width.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_width.Name = "numericUpDown_width";
            this.numericUpDown_width.ReadOnly = true;
            this.numericUpDown_width.Size = new System.Drawing.Size(109, 23);
            this.numericUpDown_width.TabIndex = 12;
            this.numericUpDown_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_pen
            // 
            this.button_pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_pen.BackgroundImage")));
            this.button_pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_pen.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_pen.Location = new System.Drawing.Point(506, 15);
            this.button_pen.Name = "button_pen";
            this.button_pen.Size = new System.Drawing.Size(60, 50);
            this.button_pen.TabIndex = 0;
            this.button_pen.UseVisualStyleBackColor = true;
            this.button_pen.Click += new System.EventHandler(this.Change_Tools_Click);
            // 
            // tabPage_view
            // 
            this.tabPage_view.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage_view.Controls.Add(this.button_countour_back);
            this.tabPage_view.Controls.Add(this.button_show_list);
            this.tabPage_view.Controls.Add(this.button_open);
            this.tabPage_view.Controls.Add(this.button_print);
            this.tabPage_view.Controls.Add(this.button_save);
            this.tabPage_view.Location = new System.Drawing.Point(4, 25);
            this.tabPage_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage_view.Name = "tabPage_view";
            this.tabPage_view.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage_view.Size = new System.Drawing.Size(1077, 76);
            this.tabPage_view.TabIndex = 1;
            this.tabPage_view.Text = "Вид";
            // 
            // button_countour_back
            // 
            this.button_countour_back.Location = new System.Drawing.Point(8, 25);
            this.button_countour_back.Name = "button_countour_back";
            this.button_countour_back.Size = new System.Drawing.Size(100, 35);
            this.button_countour_back.TabIndex = 26;
            this.button_countour_back.Text = "Назад ";
            this.button_countour_back.UseVisualStyleBackColor = true;
            this.button_countour_back.Click += new System.EventHandler(this.button_countour_back_Click);
            // 
            // button_show_list
            // 
            this.button_show_list.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_show_list.BackgroundImage")));
            this.button_show_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_show_list.Location = new System.Drawing.Point(547, 6);
            this.button_show_list.Name = "button_show_list";
            this.button_show_list.Size = new System.Drawing.Size(78, 64);
            this.button_show_list.TabIndex = 25;
            this.button_show_list.UseVisualStyleBackColor = true;
            this.button_show_list.Click += new System.EventHandler(this.button_show_list_Click);
            // 
            // button_open
            // 
            this.button_open.BackColor = System.Drawing.Color.Transparent;
            this.button_open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_open.BackgroundImage")));
            this.button_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_open.Location = new System.Drawing.Point(177, 6);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(100, 64);
            this.button_open.TabIndex = 23;
            this.button_open.UseVisualStyleBackColor = false;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_print
            // 
            this.button_print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_print.BackgroundImage")));
            this.button_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_print.Location = new System.Drawing.Point(418, 6);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(100, 64);
            this.button_print.TabIndex = 22;
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_save
            // 
            this.button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_save.BackgroundImage")));
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.Location = new System.Drawing.Point(295, 6);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 64);
            this.button_save.TabIndex = 21;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // pictureBox_map
            // 
            this.pictureBox_map.Location = new System.Drawing.Point(0, 105);
            this.pictureBox_map.Name = "pictureBox_map";
            this.pictureBox_map.Size = new System.Drawing.Size(1085, 635);
            this.pictureBox_map.TabIndex = 21;
            this.pictureBox_map.TabStop = false;
            this.pictureBox_map.Visible = false;
            this.pictureBox_map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_map_MouseDown);
            this.pictureBox_map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_map_MouseMove);
            this.pictureBox_map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_map_MouseUp);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_X,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel_Y});
            this.statusStrip.Location = new System.Drawing.Point(0, 740);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel1.Text = "X:";
            // 
            // toolStripStatusLabel_X
            // 
            this.toolStripStatusLabel_X.Name = "toolStripStatusLabel_X";
            this.toolStripStatusLabel_X.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel_X.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel3.Text = "Y:";
            // 
            // toolStripStatusLabel_Y
            // 
            this.toolStripStatusLabel_Y.Name = "toolStripStatusLabel_Y";
            this.toolStripStatusLabel_Y.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel_Y.Text = "-";
            // 
            // saveFileDialog_counterMap
            // 
            this.saveFileDialog_counterMap.DefaultExt = "tif";
            this.saveFileDialog_counterMap.RestoreDirectory = true;
            this.saveFileDialog_counterMap.ValidateNames = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog_counterMap";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // CountourMapTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 762);
            this.Controls.Add(this.pictureBox_map);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl_instrument);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_stat_thema);
            this.Controls.Add(this.label_stat_teritory);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.comboBox_thema);
            this.Controls.Add(this.comboBox_teritory);
            this.Controls.Add(this.label_thema);
            this.Controls.Add(this.label_teritory);
            this.Controls.Add(this.button_refresh);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CountourMapTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контурні карти";
            this.tabControl_instrument.ResumeLayout(false);
            this.tabPage_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
            this.tabPage_view.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_map)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_thema;
        private System.Windows.Forms.ComboBox comboBox_teritory;
        private System.Windows.Forms.Label label_thema;
        private System.Windows.Forms.Label label_teritory;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_stat_teritory;
        private System.Windows.Forms.Label label_stat_thema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl_instrument;
        private System.Windows.Forms.TabPage tabPage_main;
        private System.Windows.Forms.ComboBox comboBox_spill;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_mapRefresh;
        private System.Windows.Forms.Button button_shrift;
        private System.Windows.Forms.Button button_text;
        private System.Windows.Forms.Button button_Elipse;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.NumericUpDown numericUpDown_width;
        private System.Windows.Forms.Button button_pen;
        private System.Windows.Forms.TabPage tabPage_view;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_X;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Y;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label_reverse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_counterMap;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button button_countour_back;
        private System.Windows.Forms.Button button_show_list;
        private System.Windows.Forms.Button button_fill_rectangle;
        private System.Windows.Forms.Button button_fill_ellipse;
        public System.Windows.Forms.PictureBox pictureBox_map;
    }
}