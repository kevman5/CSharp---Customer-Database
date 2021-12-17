using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customer_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveClientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String textFile = "c://clientinfo.csv";
            String path = @"C://clientinfo.csv";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("File Created");
                }
            }
            String clientinfo1;
            clientinfo1 = tb_client1.Text;
            
            clientinfo1 = clientinfo1 + ", " + tb_jobname1 .Text;
            clientinfo1 = clientinfo1 + ", " + tb_start1.Text;
            clientinfo1 = clientinfo1 + ", " + tb_end1.Text;
            clientinfo1 = clientinfo1 + ", " + tb_price1.Text;
            clientinfo1 = clientinfo1 + ", " + tb_script1.Text;
            clientinfo1 = clientinfo1 + ", " + tb_phone1.Text;
            clientinfo1 = clientinfo1 + ", " + tb_email1.Text;

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(clientinfo1);
            }

            tb_email1.Clear();
            tb_phone1.Clear();
            tb_end1.Clear();
            tb_start1.Clear();
            tb_script1.Clear();
            tb_price1.Clear();
            tb_jobname1.Clear();
            tb_client1.Clear();
        }

        private void loadClientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String path = @"C:\\clientinfo.csv";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                listBox1.Items.Clear();
                while ((s = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(s);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int whichone;
            whichone = listBox1.SelectedIndex;
            String s;
            s = listBox1.Items[whichone].ToString();
            int posc1, posc2, posc3, posc4, posc5, posc6, posc7;
            posc1 = s.IndexOf(',');
            posc2 = s.IndexOf(',', posc1 + 1);
            posc3 = s.IndexOf(',', posc2 + 1);
            posc4 = s.IndexOf(',', posc3 + 1);
            posc5 = s.IndexOf(',', posc4 + 1);
            posc6 = s.IndexOf(',', posc5 + 1);
            posc7 = s.IndexOf(',', posc6 + 1);
            tb_client1.Text = s.Substring(0,posc1);
            tb_jobname1.Text = s.Substring(posc1 + 1, posc2 - posc1 -1);
            tb_start1.Text = s.Substring(posc2 + 1, posc3 - posc2 -1);
            tb_end1.Text = s.Substring(posc3 + 1, posc4 - posc3 -1);
            tb_price1.Text = s.Substring(posc4 + 1, posc5 - posc4 - 1);
            tb_script1.Text = s.Substring(posc5 + 1, posc6 - posc5 - 1);
            tb_phone1.Text = s.Substring(posc6 + 1, posc7 - posc6 - 1);
            tb_email1.Text = s.Substring(posc7 + 1, s.Length - posc7 - 1);
            tabPage1.Show();
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_client1.Clear();
            tb_jobname1.Clear();
            tb_start1.Clear();
            tb_end1.Clear();
            tb_price1.Clear();
            tb_script1.Clear();
            tb_phone1.Clear();
            tb_email1.Clear();


        }
    }
}
