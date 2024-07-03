using Ejercicio_Parcial;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<string> amigos1 = new List<string> { "lauty", "juli", "cande" };
                Class1 obj1 = new Class1("magui", 19, amigos1);

                List<string> amigos2 = new List<string> { "maite", "facu", "tomy" };
                Class1 obj2 = new Class1("valen", 20, amigos2);

                string path = "datos.txt";

                if (Class1.EscribirArchivo(obj1, path))
                {
                    Console.WriteLine("Datos de obj1 guardados correctamente.");
                }
                else
                {
                    Console.WriteLine("Error al guardar los datos de obj1.");
                }

                if (Class1.EscribirArchivo(obj2, path))
                {
                    Console.WriteLine("Datos de obj2 guardados correctamente.");
                }
                else
                {
                    Console.WriteLine("Error al guardar los datos de obj2.");
                }
            }
        }
    }
}