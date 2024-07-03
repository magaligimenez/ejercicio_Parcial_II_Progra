namespace Ejercicio_Parcial
{
    /*
    Desarrollar una clase que incluya como atributos un string, un entero, una lista (del tipo que desee).  
    Ademas deberán crear un método estático en dicha clase, que escriba en un archivo de texto  los datos de un objeto. 
    El método ,ademas, debe recibir la ruta (path) del archivo. 
    Si se pueden guardar los datos en el archivo, el método debe retornar true; de lo contrario, debe retornar false. 
    Probar en el main la funcionalidad.
     */
    public class Class1
    {
        string nombre;
        int edad;
        List<string> amigos;

        public Class1(string nombre, int edad, List<string> amigos)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.amigos = amigos;
        }

        public static bool EscribirArchivo(Class1 obj, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine($"Nombre: {obj.nombre}");
                    sw.WriteLine($"Edad: {obj.edad}");
                    sw.WriteLine("Amigos: " + string.Join(", ", obj.amigos));
                    sw.WriteLine();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}