using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_Praktikum_1
{
    public partial class Form1 : Form
    {
        public Form1(object lBoxName)
        {
            this.LBoxName = lBoxName;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void lBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = LBoxName.ToString();
            label2.Text = LBoxName.ToString();
            label3.Text = LBoxName.ToString();
        }
        public DataTable dataMahasiswa = new DataTable();

        public object LBoxName { get; }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataMahasiswa.Columns.Add("Nama");
            dataMahasiswa.Columns.Add("Alamat");
            dataMahasiswa.Columns.Add("Telp");
        }
            private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataMahasiswa.Columns.Add("Nama");
            dataMahasiswa.Columns.Add("Alamat");
            dataMahasiswa.Columns.Add("Telp");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Form1 form &&
                   EqualityComparer<object>.Default.Equals(LBoxName, form.LBoxName);
        }

        public override int GetHashCode()
        {
            return -1760279793 + EqualityComparer<object>.Default.GetHashCode(LBoxName);
        }
    }
}
