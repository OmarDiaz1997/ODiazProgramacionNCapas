using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        static public void Add()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese los datos del ususario al sistema");
            Console.WriteLine("Ingrese el nomnre del ususario: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido paterno del ususario: ");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido materno del ususario: ");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el grado del ususario: ");
            usuario.Grado = byte.Parse(Console.ReadLine());

            BL.Usuario.Add(usuario);
        }



        static public void Update()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Ingrese los datos a actualizar");
            Console.WriteLine("Ingrese el ID del usuario: ");
            usuario.IdUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo nombre de usuario: ");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo nomnre del usuario: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo apellido paterno del usuario: ");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo apellido materno del usuario: ");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo Email: ");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva password: ");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva fecha de nacimiento: ");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo sexo: ");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo telefono: ");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo celular: ");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo CURP: ");
            usuario.CURP = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo grado del ususario: ");
            usuario.Grado = byte.Parse(Console.ReadLine());

            BL.Usuario.UdateSP(usuario);
        }




        static public void DeleteSP()
        {

            Console.WriteLine("Eliminar ususario del sistema");
            Console.WriteLine("Ingrese el ID del ususario: ");
            int IdUsuario = int.Parse(Console.ReadLine());

            BL.Usuario.DeleteSP(IdUsuario);
        }



        static public void GetAll() 
        {
            ML.Result result = BL.Usuario.GetAllSP();

            foreach (ML.Usuario usuario in result.Objects) 
            {
                Console.WriteLine("El ID del usuario es: " + usuario.IdUsuario);
                Console.WriteLine("El nombre de usuario es: " + usuario.UserName);
                Console.WriteLine("El nombre del usuario es: " + usuario.Nombre);
                Console.WriteLine("El apellido paterno del usuario es: " + usuario.ApellidoPaterno);
                Console.WriteLine("El apellido materno del usuario es: " + usuario.ApellidoMaterno);
                Console.WriteLine("El Email es: " + usuario.Email);
                Console.WriteLine("El password es: " + usuario.Password);
                Console.WriteLine("El fecha de nacimiento es: " + usuario.FechaNacimiento);
                Console.WriteLine("El sexo es: " + usuario.Sexo);
                Console.WriteLine("El Telefono es: " + usuario.Telefono);
                Console.WriteLine("El Telefono celular es: " + usuario.Celular);
                Console.WriteLine("El CURP es: " + usuario.CURP);
                Console.WriteLine("El grado del usuario es: " + usuario.Grado);
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }




        static public void GetByIdSP()
        {
            Console.WriteLine("Buscar Usuario por ID");
            Console.WriteLine("Ingrese el ID del ususario: ");
            int IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.GetByIdSP(IdUsuario);

            if (result.Correct)
            {
                ML.Usuario usuario = (ML.Usuario)result.Object;  //Unboxing
                Console.WriteLine("El ID del usuario es: " + usuario.IdUsuario);
                Console.WriteLine("El nombre del usuario es: " + usuario.Nombre);
                Console.WriteLine("El apellido paterno del usuario es: " + usuario.ApellidoPaterno);
                Console.WriteLine("El apellido materno del usuario es: " + usuario.ApellidoMaterno);
                Console.WriteLine("El grado del usuario es: " + usuario.Grado);
                Console.WriteLine("--------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Ocurrio un error " + result.ErrorMessage);
            }
        }



        static public void AddSP()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese los datos del ususario al sistema");
            Console.WriteLine("Ingrese el nombre de ususario: ");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido paterno: ");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido materno: ");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingrese su Email: ");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese su password: ");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento: ");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese su Sexo: ");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono: ");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese su celular: ");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingrese su CURP: ");
            usuario.CURP = Console.ReadLine();
            Console.WriteLine("Ingrese su grado: ");
            usuario.Grado = byte.Parse(Console.ReadLine());

            BL.Usuario.AddSP(usuario);
        }
    }
}
