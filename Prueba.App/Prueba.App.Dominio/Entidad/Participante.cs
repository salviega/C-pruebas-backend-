using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.App.Dominio;

namespace Prueba.App.Dominio
{
    public class Participante: Persona
    {
        public override string Id {get;set;}

        public override string Name {get;set;}

        public override string LastName {get;set;}
        public override int Document {get;set;}
        [BsonElement("respuesta")]
        public int Answer {get;set;}
        [BsonElement("dinero")]
        public int Money {get;set;}
        public Participante()
        {

        }
    }
}