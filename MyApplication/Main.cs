using MyApplication.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyApplication.Fabricas.RepositorioFabrik;

namespace MyApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();


            Configuracion.Instancia(DBOptions.SQLServer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FrmDoctores();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();    
        }
    }
}
