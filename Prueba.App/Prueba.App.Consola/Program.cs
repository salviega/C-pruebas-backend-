using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Prueba.App.Dominio;
using Prueba.App.Persistencia; 

namespace Prueba.App.Consola
{
    class Program
    {
        public static String GetStringFromUser(String prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            // Comentarios en c#
            Console.WriteLine("Prueba para Summit");
         
            Comentarios en párrafo
         
            /Clases para números
            int numero = 0; // integer
            decimal x = 0.0m; // decimal
            float f = 0.0f; // float
            double d = 0.0D; // doble
            
            //Definir cadenas
            String cadena = "Hola mundo";

            //Definir boolean
            bool bandera = false;

            //Clase tiempo
            DateTime fecha = DateTime.MinValue;

            Console.WriteLine("El valor de i es: {0}", numero);
            Console.WriteLine("El valor de x es: {0:C}", x); // :C pone formato moneda
            Console.WriteLine("El valor de f es: {0:F2}", f); // :C formato decimal
            Console.WriteLine("El valor de d es: {0:F2}", d); 
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortTimeString());

            // Conversion de tipo

            int i = 0, d = 0;
            i = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            
        
            i = (int) d; //Casteo conversion implicita de una unidad menor a mayor
            i = Convert.ToInt32(d); //Conversion, alternativa
            i = Convert.ToInt32(cadena); // true es 1, false es 0  
            */
            
            /*
            Console.WriteLine(" \n");
            Console.WriteLine("¡Bienvenido! \n");
            Thread.Sleep(1000); // 1000 milisegundos = 1 segundos
            Console.WriteLine("Vamos a jugar «quien quiere ser millonario» \n");
            Console.WriteLine("Por favor ingresa tus datos personales \n");
            Thread.Sleep(1000);

            Participante Participante = new Participante();

            bool i = true;
            while (i)
            {
                try
                {
                    String Name = GetStringFromUser("Nombre: ");
                    String LastName = GetStringFromUser("Apellido: ");
                    int Document = Convert.ToInt32(GetStringFromUser("Documento: "));
                    Console.WriteLine(" \n");

                    Participante.Name = Name;
                    Participante.LastName = LastName;
                    Participante.Document = Document;
                    Participante.Answer = 0;
                    Participante.Money = 0;
                    
                    i = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(" \n");
                    Console.WriteLine("¡Ups! Ocurrió un error, por favor vuelva a ingresar tus datos \n");
                }
            }

            RepositorioParticipante Almacenamiento = new RepositorioParticipante(new Persistencia.AppContext());
            Participante ParticipanteValido = ((IRepositorioParticipante)Almacenamiento).GetParticipante(Participante.Document);
            if (ParticipanteValido.Document == Participante.Document)
            {
                Console.WriteLine("Usted se encuentra registrado. No puede volver a jugar \n");
                Console.WriteLine(ParticipanteValido.Name + " " + ParticipanteValido.LastName);
                Thread.Sleep(1000);
                System.Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("¡Perfecto! " + Participante.Name + " " + Participante.LastName + " es hora de jugar \n");
                ((IRepositorioParticipante)Almacenamiento).AddParticipante(Participante);
            }
            */
            
            // CRUD en MongoDB atlas
            
            /*
            ((IRepositorioParticipante)Almacenamiento).AddParticipante(Participante);
            ((IRepositorioParticipante)Almacenamiento).GetAllParticipantes();
            int Documento = Convert.ToInt32(Console.ReadLine());
            ((IRepositorioParticipante)Almacenamiento).UpdateParticipante(Documento);
            Documento = Convert.ToInt32(Console.ReadLine());
            ((IRepositorioParticipante)Almacenamiento).DeleteParticipante(Documento);
            Documento = Convert.ToInt32(Console.ReadLine());
            ((IRepositorioParticipante)Almacenamiento).GetParticipante(Documento);
            */

            /*
            BolsaPreguntas Bolsa = new BolsaPreguntas();
            Participante = Bolsa.categorias(1, Participante);
            Console.WriteLine("Nivel alcanzado: " + Participante.Answer);
            Console.WriteLine("Dinero actual: {0:C}", Participante.Money);
            //Participante = Bolsa.categorias(2, Participante);
            //Participante = Bolsa.categorias(3, Participante);
            //Participante = Bolsa.categorias(4, Participante);
            //Participante = Bolsa.categorias(5, Participante);
            */
            
            // SQL PostgreSQL

            AppContext2 conn = new AppContext2();
            NpgsqlConnection bd = conn.Connection();
            
            /* Create table
            NpgsqlCommand cmd = new NpgsqlCommand("CREATE TABLE Persons(" +
            "PersonID int," +
            "Name varchar(255)," +
            "LastName varchar(255)," +
            "Document int);", bd); 
            cmd.ExecuteNonQuery();
            bd.Close();
            */

            /* RENAME COLUMN
            NpgsqlCommand cmd = new NpgsqlCommand("ALTER TABLE Persons \n" +
            "RENAME COLUMN personIDD TO personID", bd); 
            cmd.ExecuteNonQuery();
            bd.Close();
            */

            NpgsqlCommand cmd = new NpgsqlCommand("ALTER TABLE Persons \n" +
            "ADD PRIMARY KEY (personid)", bd); 
            cmd.ExecuteNonQuery();
            bd.Close();


        }
    }
}