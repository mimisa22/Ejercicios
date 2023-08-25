using Techsoft.MyApplication.Aplicacion.Servicios;

namespace MyApplication.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Guardar Cliente

            var clienteService = new ClienteService();


            try
            {
                clienteService.Guardar("Wendy", "Castro", "8095555555", "Santo Domingo", 30);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}