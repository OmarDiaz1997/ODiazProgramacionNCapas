using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch
            int opcion = 0;
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Menu");
            Console.WriteLine("1.-Agregar usuario");
            Console.WriteLine("2.-Actualizar usuario");
            Console.WriteLine("3.-Eliminar usuario del sistema");
            Console.WriteLine("4.-Consultar lista de todos los usuarios");
            Console.WriteLine("5.-Consultar usuario por ID");
            Console.WriteLine("Seleccionar una opción");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //PL.Usuario.Add();
                    PL.Usuario.AddSP();
                    break;
                case 2:
                    PL.Usuario.Update();
                    break;
                case 3:
                    PL.Usuario.DeleteSP();
                    break;
                case 4:
                    PL.Usuario.GetAll();
                    break;
                case 5:
                    PL.Usuario.GetByIdSP();
                    break;
            }
        }
    }
}