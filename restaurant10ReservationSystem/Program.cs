using System;
/*
 1. Validar si el usuario existe o si se debe registrar y generar un registro o login
 2. Debe darle la bienvenida a los ususarios existentes
 3. El programa debe repetirse hasta registar 10 usuarios
 */
namespace restaurant10ReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombreUsuarios = new string[10]
                {"Pedro", "Robert", "Joan", "Selena", "Mike", "Dani", "Paul", "Joel", "Celis", "" };
            int arrayCurrenciIndex = 9;
            bool userType;

            Console.WriteLine("Bienvenido al mejor restaurante 5 estrellas del Mundo!");
            while(arrayCurrenciIndex < 10)
            {
                //if(arrayCurrenciIndex == 10)
                //{
                //    Console.WriteLine("El restaurante esta lleno, prueba de nuevo el proximo año");
                //    Environment.Exit(0);
                //}
                Console.WriteLine("\n \nEstas registrado? Escribe True o False para registrarte");
                userType = Convert.ToBoolean(Console.ReadLine());
                if (userType == true)
                {
                    Console.WriteLine("Hola tu estas registrado? Por favor ingrese su nombre");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The usuario a buscar es: {0}", userToSearch);
                    int index = Array.IndexOf(nombreUsuarios, userToSearch);
                    if (index == 1)
                    {
                        Console.WriteLine("No se encontro el usuario, intenta de nuevo o registrate");
                    }
                    else
                    {
                        Console.WriteLine("Welcome {0}, es un placer servirte", nombreUsuarios[index]);
                    }
                }
                else if (userType == false)
                {
                   Console.WriteLine("Por favor escriba y recuerde su nombre de usuario");
                   nombreUsuarios[arrayCurrenciIndex] = Console.ReadLine();
                   Console.WriteLine("Su usuario fue registrado exitosamente \n +" +
                     "Tu nombre de usuario es: {0}", nombreUsuarios[arrayCurrenciIndex]);
                   arrayCurrenciIndex++;
                }
            }
            Console.WriteLine("El restaurante esta lleno, prubea de nuevo el proximo año \n , Estos son los clientes");
            int auxIndex = 0;
            foreach (string element in nombreUsuarios)
            {
                Console.WriteLine("Numero de cliente: {0} y nombre usuarios: {0}", auxIndex+1, nombreUsuarios[auxIndex]);
            }
            Environment.Exit(0);

        }
    }
}

