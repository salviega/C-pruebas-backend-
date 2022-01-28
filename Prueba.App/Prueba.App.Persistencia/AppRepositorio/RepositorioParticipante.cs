using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.App.Dominio;

namespace Prueba.App.Persistencia
{
    public class RepositorioParticipante : IRepositorioParticipante
    {
        private readonly AppContext _AppContext;
        public RepositorioParticipante(AppContext _AppContext)
        {
            this._AppContext = _AppContext;
        }
        public static String GetStringFromUser(String prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        void IRepositorioParticipante.AddParticipante(Participante Participante)
        {
            var Database = _AppContext.Client.GetDatabase("qqsm_csharp");
            var Collection = Database.GetCollection<Participante>("participantes");
            Collection.InsertOne(Participante);
            
        }
        IEnumerable<Participante> IRepositorioParticipante.GetAllParticipantes()
        {
            var Database = _AppContext.Client.GetDatabase("qqsm_csharp");
            var Collection = Database.GetCollection<Participante>("participantes");
            List<Participante> Participantes = Collection.Find(d => true).ToList();
            foreach (var Participante in Participantes)
            {
                Console.WriteLine(Participante.Name + " " + Participante.LastName + " \n");
            }
            return Participantes;
        }
        Participante IRepositorioParticipante.UpdateParticipante(int Document)
        {
            var Database = _AppContext.Client.GetDatabase("qqsm_csharp");
            var Collection = Database.GetCollection<Participante>("participantes");
            var ParticipanteBuscado = Collection.Find(d => d.Document == Document).ToList();
            
            if (ParticipanteBuscado != null)
            {

                var ParticipanteEncontrado = new Participante();
                foreach (var _Participante in ParticipanteBuscado)
                {
                    
                    ParticipanteEncontrado = _Participante;
                }
                
                Participante Participante = new Participante();

                bool i = true;
                while (i)
                {
                    try
                    {
                        Console.WriteLine("Participante encontrado. Actualice los datos \n");
                        var Name = GetStringFromUser("Nombre: ");
                        var LastName = GetStringFromUser("Apellido: ");
                        Console.WriteLine(" \n");

                        Participante.Id = ParticipanteEncontrado.Id;
                        Participante.Name = Name;
                        Participante.LastName = LastName;
                        Participante.Document = ParticipanteEncontrado.Document;
                        Participante.Answer = ParticipanteEncontrado.Answer;
                        Participante.Money = ParticipanteEncontrado.Money;
                
                        i = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(" \n");
                        Console.WriteLine("¡Ups! Ocurrió un error, por favor vuelva a ingresar tus datos \n");
                    }
                }
                
                Console.WriteLine("Datos actualizados \n");
                Collection.ReplaceOne(d => d.Id == Participante.Id, Participante);
                return Participante;
            }
            else
            {
                Console.WriteLine("No se encontró participante \n");
                return null;
            }
        }
        void IRepositorioParticipante.DeleteParticipante(int Document)
        {
            var Database = _AppContext.Client.GetDatabase("qqsm_csharp");
            var Collection = Database.GetCollection<Participante>("participantes");
            var ParticipanteBuscado = Collection.Find(d => d.Document == Document).ToList();
            
            if (ParticipanteBuscado != null)
            {
                var ParticipanteEncontrado = new Participante();
                foreach (var _Participante in ParticipanteBuscado)
                {
                    ParticipanteEncontrado = _Participante;
                }
                Console.WriteLine("participante eliminado \n");
                Console.WriteLine(ParticipanteEncontrado.Name + " " + ParticipanteEncontrado.LastName + " \n");
                Collection.DeleteOne(d => d.Document == Document);
                
            }
            else
            {
                Console.WriteLine("No se encontró participante \n");
            }
        }
        Participante IRepositorioParticipante.GetParticipante(int Document)
        {
            var Database = _AppContext.Client.GetDatabase("qqsm_csharp");
            var Collection = Database.GetCollection<Participante>("participantes");
            var ParticipanteBuscado = Collection.Find(d => d.Document == Document).ToList();
            if (ParticipanteBuscado != null)
            {
                var ParticipanteEncontrado = new Participante();
                foreach (var _Participante in ParticipanteBuscado)
                {
                    ParticipanteEncontrado = _Participante;
                }

                return ParticipanteEncontrado;
            }
            else
            {
        
                Console.WriteLine("El participante no fue encontrado \n");
                return null;
            }
        }
    }
}