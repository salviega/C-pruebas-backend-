using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.App.Dominio
{
    public abstract class Persona
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public abstract string Id {get;set;}
        [BsonElement("nombre")]
        public abstract string Name {get;set;}
        [BsonElement("apellido")]
        public abstract string LastName {get;set;}
        [BsonElement("documento")]
        public abstract int Document {get;set;}

    }
}