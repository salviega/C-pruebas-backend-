using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.App.Dominio;

namespace Prueba.App.Dominio
{
    public class Preguntas
    {
        
        public Dictionary<int, String> Geografia {get;set;}
        public Dictionary<int, String> Entretenimiento {get;set;}
        public Dictionary<int, String> Historia {get;set;}
        public Dictionary<int, String> Deportes {get;set;}
        public Dictionary<int, String> Ciencia {get;set;}
        public Preguntas()
        {
            this.Geografia = new Dictionary<int, string>()
            {
            {1,"¿Cuál es el idioma más hablado en Suiza?"},
            {2,"¿Qué país está entre Perú y Colombia?"},
            {3,"Cuál es el río más largo de Europa Occidental?"},
            {4,"¿Qué lago baña la ciudad de Ginebra?"},
            {5,"¿Cuál es la capital de Indonesia?"}
            };

            this.Entretenimiento = new Dictionary<int, string>()
            {
            {1,"¿Cuál es el oso más famoso del parque nacional de Yellowstone?"},
            {2,"¿Qué actor, que no era el feo ni el malo, era el bueno?"},
            {3,"¿Con qué director de cine italiano se casó la actriz Giulietta Masina?"},
            {4,"¿Quién fue la gran ganadora de los Grammy Latinos 2018?"},
            {5,"¿Cuál de los Siete Enanitos no tenía barba?"}
            };

            this.Historia = new Dictionary<int, string>()
            {
            {1,"¿Qué reina británica era hija de los Reyes Católicos?"},
            {2,"¿Qué país fue llamado la Galia por los romanos?"},
            {3,"¿Qué batalla crucial tuvo lugar en 1815?"},
            {4,"¿Cuál era la ciudad hogar de Marco Polo?"},
            {5,"¿Quién era el emperador de Roma cuando murió Jesús?"}
            };

            this.Deportes = new Dictionary<int, string>()
            {
            {1,"¿Qué pieza de ajedrez puede hacer un movimiento en forma de L?"},
            {2,"¿Cómo se llaman los deportistas que practican el judo?"},
            {3,"Qué deporte practican los Harlem Globetrotters?"},
            {4,"¿A cuántos puntos se disputa un set en el tenis de mesa?"},
            {5,"¿Qué obtienes si añades fruta fresca al vino tinto?"}            
            };

            this.Ciencia = new Dictionary<int, string>()
            {
            {1,"¿Cómo se llaman las células nerviosas?"},
            {2,"¿Qué fabricó Alessandro Volta, por primera vez, en 1800?"},
            {3,"¿Cuál es el pájaro símbolo de la paz?"},
            {4,"¿En qué mes el sol está más cerca de la Tierra?"},
            {5,"¿En qué parte del cuerpo se encuentra la piel más gruesa?"}
            };
        }
    }
}