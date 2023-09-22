namespace WordReplace
{
    partial class WordReplace
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
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            button3 = new Button();
            Browse = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            checkBox2 = new CheckBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            upperCaseToolStripMenuItem1 = new ToolStripMenuItem();
            upperCaseToolStripMenuItem = new ToolStripMenuItem();
            lowerCaseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            copyToToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            clearToolStripMenuItem = new ToolStripMenuItem();
            richTextBox2 = new RichTextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            firstLetterUpperCaseToolStripMenuItem = new ToolStripMenuItem();
            upperCaseAllToolStripMenuItem = new ToolStripMenuItem();
            lowerCaseAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            clearToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            copyToClipboardToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(Browse);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 38);
            panel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(1096, 7);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "AutoStart";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Browse
            // 
            Browse.Location = new Point(13, 7);
            Browse.Name = "Browse";
            Browse.Size = new Size(75, 23);
            Browse.TabIndex = 4;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 11);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(1177, 39);
            panel2.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(1096, 9);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Clear all";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.ForeColor = Color.IndianRed;
            checkBox2.Location = new Point(734, 13);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(261, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "The first letter is automatically case replaced.";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(1015, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Replace";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(564, 13);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Match case";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientInactiveCaption;
            textBox2.Location = new Point(345, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += richTextBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(92, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 13);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Replace to";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "Source word";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 77);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(richTextBox2);
            splitContainer1.Size = new Size(1177, 526);
            splitContainer1.SplitterDistance = 538;
            splitContainer1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.PeachPuff;
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(538, 526);
            richTextBox1.TabIndex = 9;
            richTextBox1.Tag = "";
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.DoubleClick += richTextBox1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.Wheat;
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { upperCaseToolStripMenuItem1, upperCaseToolStripMenuItem, lowerCaseToolStripMenuItem, toolStripSeparator1, copyToToolStripMenuItem, toolStripSeparator2, clearToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(196, 148);
            // 
            // upperCaseToolStripMenuItem1
            // 
            upperCaseToolStripMenuItem1.Name = "upperCaseToolStripMenuItem1";
            upperCaseToolStripMenuItem1.Size = new Size(195, 22);
            upperCaseToolStripMenuItem1.Text = "First Letter Upper Case ";
            upperCaseToolStripMenuItem1.Click += upperCaseToolStripMenuItem1_Click;
            // 
            // upperCaseToolStripMenuItem
            // 
            upperCaseToolStripMenuItem.Name = "upperCaseToolStripMenuItem";
            upperCaseToolStripMenuItem.Size = new Size(195, 22);
            upperCaseToolStripMenuItem.Text = "Upper Case for All";
            upperCaseToolStripMenuItem.Click += upperCaseToolStripMenuItem_Click;
            // 
            // lowerCaseToolStripMenuItem
            // 
            lowerCaseToolStripMenuItem.Name = "lowerCaseToolStripMenuItem";
            lowerCaseToolStripMenuItem.Size = new Size(195, 22);
            lowerCaseToolStripMenuItem.Text = "Lower Case for All";
            lowerCaseToolStripMenuItem.Click += lowerCaseToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(192, 6);
            // 
            // copyToToolStripMenuItem
            // 
            copyToToolStripMenuItem.Name = "copyToToolStripMenuItem";
            copyToToolStripMenuItem.Size = new Size(195, 22);
            copyToToolStripMenuItem.Text = "Copy to Clipboard";
            copyToToolStripMenuItem.Click += copyToToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(192, 6);
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(195, 22);
            clearToolStripMenuItem.Text = "Clear Current Area";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(192, 255, 192);
            richTextBox2.ContextMenuStrip = contextMenuStrip2;
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(0, 0);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(635, 526);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.BackColor = Color.LightGreen;
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { firstLetterUpperCaseToolStripMenuItem, upperCaseAllToolStripMenuItem, lowerCaseAllToolStripMenuItem, toolStripSeparator4, clearToolStripMenuItem1, toolStripSeparator3, copyToClipboardToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(193, 126);
            // 
            // firstLetterUpperCaseToolStripMenuItem
            // 
            firstLetterUpperCaseToolStripMenuItem.Name = "firstLetterUpperCaseToolStripMenuItem";
            firstLetterUpperCaseToolStripMenuItem.Size = new Size(192, 22);
            firstLetterUpperCaseToolStripMenuItem.Text = "First Letter Upper Case";
            firstLetterUpperCaseToolStripMenuItem.Click += firstLetterUpperCaseToolStripMenuItem_Click;
            // 
            // upperCaseAllToolStripMenuItem
            // 
            upperCaseAllToolStripMenuItem.Name = "upperCaseAllToolStripMenuItem";
            upperCaseAllToolStripMenuItem.Size = new Size(192, 22);
            upperCaseAllToolStripMenuItem.Text = "Upper Case All";
            upperCaseAllToolStripMenuItem.Click += upperCaseAllToolStripMenuItem_Click;
            // 
            // lowerCaseAllToolStripMenuItem
            // 
            lowerCaseAllToolStripMenuItem.Name = "lowerCaseAllToolStripMenuItem";
            lowerCaseAllToolStripMenuItem.Size = new Size(192, 22);
            lowerCaseAllToolStripMenuItem.Text = "Lower Case All";
            lowerCaseAllToolStripMenuItem.Click += lowerCaseAllToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(189, 6);
            // 
            // clearToolStripMenuItem1
            // 
            clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            clearToolStripMenuItem1.Size = new Size(192, 22);
            clearToolStripMenuItem1.Text = "Clear Current Area";
            clearToolStripMenuItem1.Click += clearToolStripMenuItem1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(189, 6);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            copyToClipboardToolStripMenuItem.Size = new Size(192, 22);
            copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            copyToClipboardToolStripMenuItem.Click += copyToClipboardToolStripMenuItem_Click;
            // 
            // WordReplace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 603);
            Controls.Add(splitContainer1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WordReplace";
            Text = "WordReplace";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Button Browse;
        private Label label1;
        private Panel panel2;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private SplitContainer splitContainer1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private CheckBox checkBox2;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem upperCaseToolStripMenuItem;
        private ToolStripMenuItem lowerCaseToolStripMenuItem;
        private ToolStripMenuItem copyToToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem upperCaseToolStripMenuItem1;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem firstLetterUpperCaseToolStripMenuItem;
        private ToolStripMenuItem upperCaseAllToolStripMenuItem;
        private ToolStripMenuItem lowerCaseAllToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private Button button3;
    }
}