using Microsoft.EntityFrameworkCore;
using MyApplication.Contexto;
using MyApplication.Entidades;
using MyApplication.Fabricas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyApplication.Fabricas.RepositorioFabrik;

namespace MyApplication
{
    public partial class FrmDoctores : Form
    {
        private DBOptions dbOptions;

        public FrmDoctores()
        {
            InitializeComponent();
            dbOptions = DBOptions.Txt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var doctor = new Doctor(
                   txtNombre.Text, txtApellido.Text, txtTelefono.Text,
                   txtCedula.Text, int.Parse(txtEdad.Text));

            RepositorioFabrik
                .CrearRepositorio(dbOptions)
                .Guardar(doctor);



 

        }



    }
}
