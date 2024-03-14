namespace AppTestAlanAzeim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TreeNode treeNode1 = new TreeNode("1");
            TreeNode treeNode2 = new TreeNode("2");
            TreeNode treeNode3 = new TreeNode("Nodo2");
            button1 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            leabelButon = new Label();
            LeabelCheck = new Label();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            maskedTextBox1 = new MaskedTextBox();
            monthCalendar1 = new MonthCalendar();
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            RadioYes = new RadioButton();
            RadioNot = new RadioButton();
            ButIncrement = new Button();
            radioLeable = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            treeView1 = new TreeView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Push";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(21, 85);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(46, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "one";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(21, 122);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(46, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "two";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // leabelButon
            // 
            leabelButon.AutoSize = true;
            leabelButon.Location = new Point(125, 34);
            leabelButon.Name = "leabelButon";
            leabelButon.Size = new Size(90, 15);
            leabelButon.TabIndex = 3;
            leabelButon.Text = "me, I am a label";
            // 
            // LeabelCheck
            // 
            LeabelCheck.AutoSize = true;
            LeabelCheck.Location = new Point(110, 108);
            LeabelCheck.Name = "LeabelCheck";
            LeabelCheck.Size = new Size(131, 15);
            LeabelCheck.TabIndex = 3;
            LeabelCheck.Text = "me, I am another leable";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.IntegralHeight = false;
            checkedListBox1.Items.AddRange(new object[] { "Hello", "hola", "Hallo", "Salut" });
            checkedListBox1.Location = new Point(336, 26);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 76);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBox1.Location = new Point(509, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(333, 129);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Github";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "claro", "porsupuesto", "siempre", "confirmo" });
            listBox1.Location = new Point(664, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 232);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 292);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(245, 174);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(664, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(304, 425);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 13;
            // 
            // RadioYes
            // 
            RadioYes.AutoSize = true;
            RadioYes.Location = new Point(294, 222);
            RadioYes.Name = "RadioYes";
            RadioYes.Size = new Size(42, 19);
            RadioYes.TabIndex = 14;
            RadioYes.TabStop = true;
            RadioYes.Text = "yes";
            RadioYes.UseVisualStyleBackColor = true;
            RadioYes.CheckedChanged += RadioYes_CheckedChanged;
            // 
            // RadioNot
            // 
            RadioNot.AutoSize = true;
            RadioNot.Location = new Point(293, 247);
            RadioNot.Name = "RadioNot";
            RadioNot.Size = new Size(43, 19);
            RadioNot.TabIndex = 15;
            RadioNot.TabStop = true;
            RadioNot.Text = "not";
            RadioNot.UseVisualStyleBackColor = true;
            RadioNot.CheckedChanged += RadioNot_CheckedChanged;
            // 
            // ButIncrement
            // 
            ButIncrement.Location = new Point(317, 388);
            ButIncrement.Name = "ButIncrement";
            ButIncrement.Size = new Size(75, 23);
            ButIncrement.TabIndex = 16;
            ButIncrement.Text = "increment";
            ButIncrement.UseVisualStyleBackColor = true;
            ButIncrement.Click += ButIncrement_Click;
            // 
            // radioLeable
            // 
            radioLeable.AutoSize = true;
            radioLeable.Location = new Point(366, 232);
            radioLeable.Name = "radioLeable";
            radioLeable.Size = new Size(131, 15);
            radioLeable.TabIndex = 17;
            radioLeable.Text = "me, I am another leable";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(609, 350);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(156, 123);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(516, 332);
            label1.Name = "label1";
            label1.Size = new Size(353, 15);
            label1.TabIndex = 19;
            label1.Text = "can be used as a notepad, change font and size and paste images.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(466, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 156);
            label2.Name = "label2";
            label2.Size = new Size(229, 15);
            label2.TabIndex = 21;
            label2.Text = "you can enter any type of data in text type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(445, 388);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "1";
            treeNode2.Name = "Nodo1";
            treeNode2.Text = "2";
            treeNode3.Name = "Nodo2";
            treeNode3.Text = "Nodo2";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            treeView1.Size = new Size(121, 97);
            treeView1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 488);
            label3.Name = "label3";
            label3.Size = new Size(310, 15);
            label3.TabIndex = 23;
            label3.Text = "Allows data to be displayed in a hierarchical tree structure";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(881, 505);
            Controls.Add(label3);
            Controls.Add(treeView1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(radioLeable);
            Controls.Add(ButIncrement);
            Controls.Add(RadioNot);
            Controls.Add(RadioYes);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(monthCalendar1);
            Controls.Add(maskedTextBox1);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(LeabelCheck);
            Controls.Add(leabelButon);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NotifyIcon notifyIcon1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label leabelButon;
        private Label LeabelCheck;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private MaskedTextBox maskedTextBox1;
        private MonthCalendar monthCalendar1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private RadioButton RadioYes;
        private RadioButton RadioNot;
        private Button ButIncrement;
        private Label radioLeable;
        private RichTextBox richTextBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ToolTip toolTip1;
        private TreeView treeView1;
        private Label label3;
    }
}
