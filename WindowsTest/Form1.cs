using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "文本文件|*.txt";
            openFileDialog.Multiselect = false;
            DialogResult dialogResult =openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string extension =Path.GetExtension(openFileDialog.FileName);
                if (extension.Equals(".txt"))
                {
                    string txtConent =File.ReadAllText(openFileDialog.FileName,Encoding.Default);
                    richTextBoxContent.Text = txtConent;
                }
                else
                {
                    MessageBox.Show("请选择txt文件", "打开提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
