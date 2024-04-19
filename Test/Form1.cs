using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAvailableAssemblies();

            //comboBox1.Text = comboBox1.Items[0].ToString();
            //this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
        }

        void LoadAvailableAssemblies()
        {
            //название файла сборки текущего приложения
            string except = new FileInfo(Application.ExecutablePath).Name;
            //получаем название файла без расширения
            except = except.Substring(0, except.IndexOf("."));
            //получаем все *.exe файлы из домашней директории
            string[] files = Directory.GetFiles(Application.StartupPath, "*.exe");
            foreach (var file in files)
            {
                //получаем имя файла
                string fileName = new FileInfo(file).Name;
                /*если имя афйла не содержит имени исполняемого файла проекта,
                *то оно добавляется в список*/
                if (fileName.IndexOf(except) == -1)
                    AvailableAssemblies.Items.Add(fileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(AvailableAssemblies.SelectedItem != null)
            {
                Process.Start(AvailableAssemblies.SelectedItem.ToString());
            }
        }



        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    string mess = "";
        //    if (cbLangEn.Checked)
        //        mess += cbLangEn.Text + " ";
        //    if (cbLangFr.Checked)
        //        mess += cbLangFr.Text;
        //    MessageBox.Show(mess, "WinForm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //}

        //private void cbLangEn_CheckedChanged(object sender, EventArgs e)
        //{
        //    cbLangFr.Enabled = cbLangEn.Checked;
        //    if (!cbLangEn.Checked)
        //        cbLangFr.Checked = false;

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show((sender as ComboBox).SelectedItem.ToString());
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (textBox1.Text != "")
        //    {
        //        comboBox1.Items.Add(textBox1.Text);
        //        textBox1.Text = "";
        //    }


        //}

        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{


        //}

        //private void Form1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    this.Text = $"X - {e.X}, Y - {e.Y}";
        //}
    }
}
