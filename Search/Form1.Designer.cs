namespace Search
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Clear = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Transform = new System.Windows.Forms.Button();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.Dorm = new System.Windows.Forms.CheckBox();
            this.Floor = new System.Windows.Forms.CheckBox();
            this.Room = new System.Windows.Forms.CheckBox();
            this.Surname = new System.Windows.Forms.CheckBox();
            this.NameCheck = new System.Windows.Forms.CheckBox();
            this.PhoneNumber = new System.Windows.Forms.CheckBox();
            this.DormBox = new System.Windows.Forms.ComboBox();
            this.FloorBox = new System.Windows.Forms.ComboBox();
            this.RoomBox = new System.Windows.Forms.ComboBox();
            this.SurnameBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.PhoneBox = new System.Windows.Forms.ComboBox();
            this.transfor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.хелпToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear.Location = new System.Drawing.Point(11, 498);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(152, 21);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Очистити";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(11, 122);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(893, 346);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Transform
            // 
            this.Transform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Transform.Location = new System.Drawing.Point(750, 511);
            this.Transform.Margin = new System.Windows.Forms.Padding(2);
            this.Transform.Name = "Transform";
            this.Transform.Size = new System.Drawing.Size(154, 33);
            this.Transform.TabIndex = 2;
            this.Transform.Text = "Пошук";
            this.Transform.UseVisualStyleBackColor = true;
            this.Transform.Click += new System.EventHandler(this.Search_Click);
            // 
            // LINQ
            // 
            this.LINQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(854, 490);
            this.LINQ.Margin = new System.Windows.Forms.Padding(2);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(50, 17);
            this.LINQ.TabIndex = 3;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            // 
            // SAX
            // 
            this.SAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(804, 490);
            this.SAX.Margin = new System.Windows.Forms.Padding(2);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(46, 17);
            this.SAX.TabIndex = 4;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // DOM
            // 
            this.DOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(750, 490);
            this.DOM.Margin = new System.Windows.Forms.Padding(2);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(50, 17);
            this.DOM.TabIndex = 5;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // Dorm
            // 
            this.Dorm.AutoSize = true;
            this.Dorm.Location = new System.Drawing.Point(11, 38);
            this.Dorm.Margin = new System.Windows.Forms.Padding(2);
            this.Dorm.Name = "Dorm";
            this.Dorm.Size = new System.Drawing.Size(85, 17);
            this.Dorm.TabIndex = 6;
            this.Dorm.Text = "Гуртожиток";
            this.Dorm.UseVisualStyleBackColor = true;
            // 
            // Floor
            // 
            this.Floor.AutoSize = true;
            this.Floor.Location = new System.Drawing.Point(11, 60);
            this.Floor.Margin = new System.Windows.Forms.Padding(2);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(63, 17);
            this.Floor.TabIndex = 7;
            this.Floor.Text = "Поверх";
            this.Floor.UseVisualStyleBackColor = true;
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Location = new System.Drawing.Point(11, 83);
            this.Room.Margin = new System.Windows.Forms.Padding(2);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(66, 17);
            this.Room.TabIndex = 8;
            this.Room.Text = "Кімната";
            this.Room.UseVisualStyleBackColor = true;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(298, 36);
            this.Surname.Margin = new System.Windows.Forms.Padding(2);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(75, 17);
            this.Surname.TabIndex = 9;
            this.Surname.Text = "Прізвище";
            this.Surname.UseVisualStyleBackColor = true;
            // 
            // NameCheck
            // 
            this.NameCheck.AutoSize = true;
            this.NameCheck.Location = new System.Drawing.Point(298, 58);
            this.NameCheck.Margin = new System.Windows.Forms.Padding(2);
            this.NameCheck.Name = "NameCheck";
            this.NameCheck.Size = new System.Drawing.Size(45, 17);
            this.NameCheck.TabIndex = 10;
            this.NameCheck.Text = "Ім\'я";
            this.NameCheck.UseVisualStyleBackColor = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(298, 81);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(71, 17);
            this.PhoneNumber.TabIndex = 11;
            this.PhoneNumber.Text = "Телефон";
            this.PhoneNumber.UseVisualStyleBackColor = true;
            // 
            // DormBox
            // 
            this.DormBox.FormattingEnabled = true;
            this.DormBox.Location = new System.Drawing.Point(108, 34);
            this.DormBox.Margin = new System.Windows.Forms.Padding(2);
            this.DormBox.Name = "DormBox";
            this.DormBox.Size = new System.Drawing.Size(166, 21);
            this.DormBox.TabIndex = 12;
            // 
            // FloorBox
            // 
            this.FloorBox.FormattingEnabled = true;
            this.FloorBox.Location = new System.Drawing.Point(108, 58);
            this.FloorBox.Margin = new System.Windows.Forms.Padding(2);
            this.FloorBox.Name = "FloorBox";
            this.FloorBox.Size = new System.Drawing.Size(166, 21);
            this.FloorBox.TabIndex = 13;
            // 
            // RoomBox
            // 
            this.RoomBox.FormattingEnabled = true;
            this.RoomBox.Location = new System.Drawing.Point(108, 81);
            this.RoomBox.Margin = new System.Windows.Forms.Padding(2);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(166, 21);
            this.RoomBox.TabIndex = 14;
            // 
            // SurnameBox
            // 
            this.SurnameBox.FormattingEnabled = true;
            this.SurnameBox.Location = new System.Drawing.Point(395, 33);
            this.SurnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(166, 21);
            this.SurnameBox.TabIndex = 15;
            // 
            // NameBox
            // 
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(395, 55);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(166, 21);
            this.NameBox.TabIndex = 16;
            // 
            // PhoneBox
            // 
            this.PhoneBox.FormattingEnabled = true;
            this.PhoneBox.Location = new System.Drawing.Point(395, 80);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(166, 21);
            this.PhoneBox.TabIndex = 17;
            this.PhoneBox.SelectedIndexChanged += new System.EventHandler(this.PhoneBox_SelectedIndexChanged);
            // 
            // transfor
            // 
            this.transfor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.transfor.Location = new System.Drawing.Point(11, 523);
            this.transfor.Margin = new System.Windows.Forms.Padding(2);
            this.transfor.Name = "transfor";
            this.transfor.Size = new System.Drawing.Size(152, 21);
            this.transfor.TabIndex = 18;
            this.transfor.Text = "Трансформувати в HTML";
            this.transfor.UseVisualStyleBackColor = true;
            this.transfor.Click += new System.EventHandler(this.Transfor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хелпToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // хелпToolStripMenuItem
            // 
            this.хелпToolStripMenuItem.Name = "хелпToolStripMenuItem";
            this.хелпToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.хелпToolStripMenuItem.Text = "Допомога";
            this.хелпToolStripMenuItem.Click += new System.EventHandler(this.хелпToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 555);
            this.Controls.Add(this.transfor);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.FloorBox);
            this.Controls.Add(this.DormBox);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.NameCheck);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.Dorm);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.Transform);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Лаба 2 @ Савчук";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Transform;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.CheckBox Dorm;
        private System.Windows.Forms.CheckBox Floor;
        private System.Windows.Forms.CheckBox Room;
        private System.Windows.Forms.CheckBox Surname;
        private System.Windows.Forms.CheckBox NameCheck;
        private System.Windows.Forms.CheckBox PhoneNumber;
        private System.Windows.Forms.ComboBox DormBox;
        private System.Windows.Forms.ComboBox FloorBox;
        private System.Windows.Forms.ComboBox RoomBox;
        private System.Windows.Forms.ComboBox SurnameBox;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.ComboBox PhoneBox;
        private System.Windows.Forms.Button transfor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem хелпToolStripMenuItem;
    }
}

