using MyApplication.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication.NetFramework.Formularios
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            var clientes = getClientes();

            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.Nombre);
            }
        }

        //Create function return a list of clientes for http get request
        public List<Cliente> getClientes()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:7078/api/clientes").Result;
            if (response.IsSuccessStatusCode)
            {
                string responseBody = response.Content.ReadAsStringAsync().Result;
                List<Cliente> result = JsonConvert.DeserializeObject<List<Cliente>>(responseBody);
                return result;
            }

            return null;
        }
    }
}
