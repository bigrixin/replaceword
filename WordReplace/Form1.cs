namespace WordReplace
{
    public partial class WordReplace : Form
    {

        public WordReplace()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    label1.Text = filePath;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    richTextBox1.Text = fileContent;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sourceFileContent = richTextBox1.Text;
                string sourceStr = textBox1.Text;
                string replaceStr = textBox2.Text;
                string matchCaseRreplaceContent = sourceFileContent.Replace(sourceStr, replaceStr);

                if (checkBox2.Checked)
                {
                    //The first letter is automatically case replaced
                    if (sourceStr.Any(char.IsUpper))
                    {
                        sourceStr = char.ToLower(sourceStr[0]) + sourceStr.Substring(1);
                        replaceStr = char.ToLower(replaceStr[0]) + replaceStr.Substring(1);
                    }

                    else
                    {
                        sourceStr = char.ToUpper(sourceStr[0]) + sourceStr.Substring(1);
                        replaceStr = char.ToUpper(replaceStr[0]) + replaceStr.Substring(1);
                    }

                    string autoMatchCaseRreplaceContent = matchCaseRreplaceContent.Replace(sourceStr, replaceStr);
                    richTextBox2.Text = autoMatchCaseRreplaceContent;
                }
                else if (checkBox1.Checked)
                {
                    // Match case

                    richTextBox2.Text = matchCaseRreplaceContent;
                }
                else
                {
                    if (sourceStr.Any(char.IsUpper))
                        sourceStr = char.ToLower(sourceStr[0]) + sourceStr.Substring(1);
                    else
                        sourceStr = char.ToUpper(sourceStr[0]) + sourceStr.Substring(1);

                    string replaceContent = matchCaseRreplaceContent.Replace(sourceStr, replaceStr);
                    richTextBox2.Text = replaceContent;
                }

                label1.ForeColor = Color.Red;
                label1.Text = "Successfully replace";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                checkBox1.Visible = false;
            else
                checkBox1.Visible = true;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && richTextBox1.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}