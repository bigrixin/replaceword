namespace AutoRunApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_check_network_try_times = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_check_network_delay_time = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_minutes_delay = new System.Windows.Forms.Label();
            this.label_try_run_times = new System.Windows.Forms.Label();
            this.cB_launch_app_try_times = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cB_launch_app_delay_time = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_check_sql_try_times = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cB_check_sql_delay_time = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cB_check_network_try_times);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cB_check_network_delay_time);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cB_check_network_try_times
            // 
            this.cB_check_network_try_times.FormattingEnabled = true;
            this.cB_check_network_try_times.Items.AddRange(new object[] {
            resources.GetString("cB_check_network_try_times.Items"),
            resources.GetString("cB_check_network_try_times.Items1"),
            resources.GetString("cB_check_network_try_times.Items2"),
            resources.GetString("cB_check_network_try_times.Items3"),
            resources.GetString("cB_check_network_try_times.Items4")});
            resources.ApplyResources(this.cB_check_network_try_times, "cB_check_network_try_times");
            this.cB_check_network_try_times.Name = "cB_check_network_try_times";
            this.cB_check_network_try_times.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::AutoRunApp.Properties.Resources.timer_16;
            this.label3.Name = "label3";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // cB_check_network_delay_time
            // 
            this.cB_check_network_delay_time.FormattingEnabled = true;
            this.cB_check_network_delay_time.Items.AddRange(new object[] {
            resources.GetString("cB_check_network_delay_time.Items"),
            resources.GetString("cB_check_network_delay_time.Items1"),
            resources.GetString("cB_check_network_delay_time.Items2"),
            resources.GetString("cB_check_network_delay_time.Items3"),
            resources.GetString("cB_check_network_delay_time.Items4"),
            resources.GetString("cB_check_network_delay_time.Items5"),
            resources.GetString("cB_check_network_delay_time.Items6"),
            resources.GetString("cB_check_network_delay_time.Items7"),
            resources.GetString("cB_check_network_delay_time.Items8")});
            resources.ApplyResources(this.cB_check_network_delay_time, "cB_check_network_delay_time");
            this.cB_check_network_delay_time.Name = "cB_check_network_delay_time";
            this.cB_check_network_delay_time.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_minutes_delay);
            this.groupBox2.Controls.Add(this.label_try_run_times);
            this.groupBox2.Controls.Add(this.cB_launch_app_try_times);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cB_launch_app_delay_time);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label_minutes_delay
            // 
            resources.ApplyResources(this.label_minutes_delay, "label_minutes_delay");
            this.label_minutes_delay.Name = "label_minutes_delay";
            // 
            // label_try_run_times
            // 
            resources.ApplyResources(this.label_try_run_times, "label_try_run_times");
            this.label_try_run_times.Name = "label_try_run_times";
            // 
            // cB_launch_app_try_times
            // 
            this.cB_launch_app_try_times.FormattingEnabled = true;
            this.cB_launch_app_try_times.Items.AddRange(new object[] {
            resources.GetString("cB_launch_app_try_times.Items"),
            resources.GetString("cB_launch_app_try_times.Items1"),
            resources.GetString("cB_launch_app_try_times.Items2"),
            resources.GetString("cB_launch_app_try_times.Items3"),
            resources.GetString("cB_launch_app_try_times.Items4")});
            resources.ApplyResources(this.cB_launch_app_try_times, "cB_launch_app_try_times");
            this.cB_launch_app_try_times.Name = "cB_launch_app_try_times";
            this.cB_launch_app_try_times.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::AutoRunApp.Properties.Resources.timer_16;
            this.label4.Name = "label4";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // cB_launch_app_delay_time
            // 
            this.cB_launch_app_delay_time.FormattingEnabled = true;
            this.cB_launch_app_delay_time.Items.AddRange(new object[] {
            resources.GetString("cB_launch_app_delay_time.Items"),
            resources.GetString("cB_launch_app_delay_time.Items1"),
            resources.GetString("cB_launch_app_delay_time.Items2"),
            resources.GetString("cB_launch_app_delay_time.Items3"),
            resources.GetString("cB_launch_app_delay_time.Items4"),
            resources.GetString("cB_launch_app_delay_time.Items5"),
            resources.GetString("cB_launch_app_delay_time.Items6"),
            resources.GetString("cB_launch_app_delay_time.Items7"),
            resources.GetString("cB_launch_app_delay_time.Items8")});
            resources.ApplyResources(this.cB_launch_app_delay_time, "cB_launch_app_delay_time");
            this.cB_launch_app_delay_time.Name = "cB_launch_app_delay_time";
            this.cB_launch_app_delay_time.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cB_check_sql_try_times);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cB_check_sql_delay_time);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cB_check_sql_try_times
            // 
            this.cB_check_sql_try_times.FormattingEnabled = true;
            this.cB_check_sql_try_times.Items.AddRange(new object[] {
            resources.GetString("cB_check_sql_try_times.Items"),
            resources.GetString("cB_check_sql_try_times.Items1"),
            resources.GetString("cB_check_sql_try_times.Items2"),
            resources.GetString("cB_check_sql_try_times.Items3"),
            resources.GetString("cB_check_sql_try_times.Items4")});
            resources.ApplyResources(this.cB_check_sql_try_times, "cB_check_sql_try_times");
            this.cB_check_sql_try_times.Name = "cB_check_sql_try_times";
            this.cB_check_sql_try_times.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Image = global::AutoRunApp.Properties.Resources.timer_16;
            this.label7.Name = "label7";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // cB_check_sql_delay_time
            // 
            this.cB_check_sql_delay_time.FormattingEnabled = true;
            this.cB_check_sql_delay_time.Items.AddRange(new object[] {
            resources.GetString("cB_check_sql_delay_time.Items"),
            resources.GetString("cB_check_sql_delay_time.Items1"),
            resources.GetString("cB_check_sql_delay_time.Items2"),
            resources.GetString("cB_check_sql_delay_time.Items3"),
            resources.GetString("cB_check_sql_delay_time.Items4"),
            resources.GetString("cB_check_sql_delay_time.Items5"),
            resources.GetString("cB_check_sql_delay_time.Items6"),
            resources.GetString("cB_check_sql_delay_time.Items7"),
            resources.GetString("cB_check_sql_delay_time.Items8")});
            resources.ApplyResources(this.cB_check_sql_delay_time, "cB_check_sql_delay_time");
            this.cB_check_sql_delay_time.Name = "cB_check_sql_delay_time";
            this.cB_check_sql_delay_time.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button_save
            // 
            resources.ApplyResources(this.button_save, "button_save");
            this.button_save.Name = "button_save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.btnOK);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_minutes_delay;
        private System.Windows.Forms.Label label_try_run_times;
        private System.Windows.Forms.ComboBox cB_launch_app_try_times;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cB_launch_app_delay_time;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_check_network_try_times;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_check_network_delay_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cB_check_sql_try_times;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cB_check_sql_delay_time;
    }
}