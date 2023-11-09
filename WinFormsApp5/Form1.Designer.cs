namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            вычислитьToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            textBox_Result1 = new TextBox();
            label3 = new Label();
            btn_Close1 = new Button();
            groupBox2 = new GroupBox();
            textBox_Date1 = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_Math1 = new Button();
            tabControl1 = new TabControl();
            toolTip1 = new ToolTip(components);
            toolStripMenuItem1 = new ToolStripSeparator();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            программаРасчетыToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(617, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вычислитьToolStripMenuItem, toolStripMenuItem1, очиститьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // вычислитьToolStripMenuItem
            // 
            вычислитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { программаРасчетыToolStripMenuItem });
            вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            вычислитьToolStripMenuItem.Size = new Size(224, 26);
            вычислитьToolStripMenuItem.Text = "Вычислить";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(btn_Close1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btn_Math1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(609, 434);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Расчеты";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox_Result1);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(347, 197);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(254, 153);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Результат:";
            // 
            // textBox_Result1
            // 
            textBox_Result1.Location = new Point(62, 72);
            textBox_Result1.Name = "textBox_Result1";
            textBox_Result1.ReadOnly = true;
            textBox_Result1.Size = new Size(156, 27);
            textBox_Result1.TabIndex = 5;
            textBox_Result1.TextChanged += textBox_Result1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(21, 75);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 3;
            label3.Text = "Y = ";
            label3.Click += label3_Click;
            // 
            // btn_Close1
            // 
            btn_Close1.Location = new Point(409, 375);
            btn_Close1.Margin = new Padding(3, 4, 3, 4);
            btn_Close1.Name = "btn_Close1";
            btn_Close1.Size = new Size(86, 31);
            btn_Close1.TabIndex = 4;
            btn_Close1.Text = "Выход";
            btn_Close1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_Date1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(8, 197);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(254, 153);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Исходные данные:";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox_Date1
            // 
            textBox_Date1.Location = new Point(57, 72);
            textBox_Date1.Name = "textBox_Date1";
            textBox_Date1.Size = new Size(156, 27);
            textBox_Date1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 3;
            label2.Text = "x =";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(593, 181);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задание:";
            groupBox1.Enter += groupBox4_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(183, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 24);
            label1.Name = "label1";
            label1.Size = new Size(400, 20);
            label1.TabIndex = 0;
            label1.Text = "Рассчитать значение выражения при исходных данных:";
            label1.Click += label1_Click;
            // 
            // btn_Math1
            // 
            btn_Math1.Location = new Point(65, 375);
            btn_Math1.Margin = new Padding(3, 4, 3, 4);
            btn_Math1.Name = "btn_Math1";
            btn_Math1.Size = new Size(100, 31);
            btn_Math1.TabIndex = 3;
            btn_Math1.Text = "Вычислить";
            btn_Math1.UseVisualStyleBackColor = true;
            btn_Math1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 36);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(617, 467);
            tabControl1.TabIndex = 2;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(224, 26);
            очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(224, 26);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // программаРасчетыToolStripMenuItem
            // 
            программаРасчетыToolStripMenuItem.Name = "программаРасчетыToolStripMenuItem";
            программаРасчетыToolStripMenuItem.Size = new Size(246, 26);
            программаРасчетыToolStripMenuItem.Text = "Программа \"Расчеты\"";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(224, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 505);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Моё приложение";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private Button btn_Close1;
        private Button btn_Math1;
        private GroupBox groupBox3;
        private TextBox textBox_Result1;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox textBox_Date1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private ToolStripMenuItem вычислитьToolStripMenuItem;
        private ToolStripMenuItem программаРасчетыToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}