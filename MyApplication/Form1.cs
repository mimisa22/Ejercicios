using MyApplication.Contexto;
using MyApplication.Entidades;
using MyApplication.Fabricas;
using static MyApplication.Fabricas.RepositorioFabrik;

namespace MyApplication
{
    public partial class Form1 : Form
    {


        private readonly DBOptions DbOptions;

        public Form1()
        {
            InitializeComponent();

            DbOptions = Configuracion.Instancia(DBOptions.SQLServer).DbOption;


            
        }




        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                var cliente = new Cliente(
                       txtNombre.Text, txtApellido.Text, txtTelefono.Text,
                       txtDireccion.Text, int.Parse(txtEdad.Text));

                RepositorioFabrik
                    .CrearRepositorio(DbOptions)
                    .Guardar<Cliente>(cliente);
            }

            catch (ArgumentException ar)
            {
                MessageBox.Show($"Datos Inválidos: {ar.Message}");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al guardar.");
            }



        }

    }
}