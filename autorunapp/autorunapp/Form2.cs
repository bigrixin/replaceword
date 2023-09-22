using System;
using System.IO;
using System.Windows.Forms;

namespace AutoRunApp
{
    public partial class Form2 : Form
    {
        private readonly Form1 form1;

        public Form2(Form frm1)
        {
            InitializeComponent();
            this.form1 = (Form1)frm1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            read_from_setting_ini();
            button_save.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            save_to_setting_ini();
            form1.save_to_setting_ini();
            button_save.Enabled = false;
        }

        private void read_from_setting_ini()
        {
            string settingFile = form1.Setting_ini_file;

            if (File.Exists(settingFile))
            {
                cB_check_network_delay_time.Text = form1.ReadINI(form1.Setting_Section_Name, form1.Setting_key_delay_check_network_seconds, settingFile);
                cB_check_network_try_times.Text = form1.ReadINI(form1.Setting_Section_Name, form1.Setting_key_try_check_network_times, settingFile);

                cB_check_sql_delay_time.Text = form1.ReadINI(form1.Setting_Section_Name, form1.Setting_key_delay_check_sql_seconds, settingFile);
                cB_check_sql_try_times.Text = form1.ReadINI(form1.Setting_Section_Name, form1.Setting_key_try_check_sql_times, settingFile);

                cB_launch_app_delay_time.Text = form1.ReadINI(form1.Setting_Section_Name, form1.Setting_key_delay_launch_app_seconds, settingFile);
                cB_launch_app_try_times.Text = form1.ReadINI(form1.Setting_Section_Name, form1.Setting_key_try_launch_app_times, settingFile);
            }

        }

        private void save_to_setting_ini()
        {
            string settingFile = form1.Setting_ini_file;
            // delay check network seconds
            form1.WriteINI(form1.Setting_Section_Name, form1.Setting_key_delay_check_network_seconds, cB_check_network_delay_time.Text, settingFile);

            // try check network times
            form1.WriteINI(form1.Setting_Section_Name, form1.Setting_key_try_check_network_times, cB_check_network_try_times.Text, settingFile);

            // delay check sql seconds
            form1.WriteINI(form1.Setting_Section_Name, form1.Setting_key_delay_check_sql_seconds, cB_check_sql_delay_time.Text, settingFile);

            // try check sql times
            form1.WriteINI(form1.Setting_Section_Name, form1.Setting_key_try_check_sql_times, cB_check_sql_try_times.Text, settingFile);

            // delay launch app seconds
            form1.WriteINI(form1.Setting_Section_Name, form1.Setting_key_delay_launch_app_seconds, cB_launch_app_delay_time.Text, settingFile);

            // try launch app times
            form1.WriteINI(form1.Setting_Section_Name, form1.Setting_key_try_launch_app_times, cB_launch_app_try_times.Text, settingFile);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_save.Enabled = true;
        }

    }
}
