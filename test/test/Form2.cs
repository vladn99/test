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
    public partial class Form2 : Form
    {
        const int kol = 60;
        public Form2()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath.Replace(@"\bin\Debug", ""));
        }

        private void tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            ost();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.tbl". При необходимости она может быть перемещена или удалена.
            this.tblTableAdapter.Fill(this.database1DataSet.tbl);
            ost();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void ost() 
        {
            label1.Text = "";
            label2.Text = "";
            @base @base = new @base("select kl_vo from tbl");
            label2.Text = "Осталось:" + (kol - @base.proverka_znachenei_v_bd()).ToString();
            label1.Text = "Потраченно:" + @base.proverka_znachenei_v_bd();
        }
    }
}
