using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.App.Persistencia
{
    public class AppContext
    {
        public MongoClient Client = new MongoClient("mongodb+srv://QQSM:qqsm@qqsm.8zhje.mongodb.net/qqms_csharp?retryWrites=true&w=majority");
    }
}
