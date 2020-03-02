using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        @base @base = new @base("");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            @base.smena_zaprosa("insert into tbl(dat, kl_vo) values(CONVERT(date, '" + dateTimePicker1.Value + "', 104), " + numericUpDown1.Value + ")");
            @base.zapis_v_bd();
            MessageBox.Show("зАПИСЬ ДОБАВЛЕНа");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            @base.smena_zaprosa("delete from tbl");
            @base.zapis_v_bd();
            MessageBox.Show("вСЕ ЗАПИСИ УДАЛЕНы");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
