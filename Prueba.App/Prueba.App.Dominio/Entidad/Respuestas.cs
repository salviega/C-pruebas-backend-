using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.App.Dominio;

namespace Prueba.App.Dominio
{
    public class Respuestas
    {
        public List<String> RespuestaGeografia {get;set;}
        public List<String> RespuestaEntretenimiento {get;set;}
        public List<String> RespuestaHistoria {get;set;}
        public List<String> RespuestaDeportes {get;set;}
        public List<String> RespuestaCiencia {get;set;}
        public Respuestas()
        {
            List<String> RespuestaGeografia = new List<string>() {"Alemán","Ecuador","Rin","Leman","Jakarta"};
            this.RespuestaGeografia = RespuestaGeografia;

            List<String> RespuestaEntretenimiento = new List<string>() {"Yogui","Clint Eastwood","Federico Fellini","Rosalia","Mudito"};
            this.RespuestaEntretenimiento = RespuestaEntretenimiento;

            List<String> RespuestaHistoria = new List<string>() {"Catalina de Aragón","Francia","Waterloo","Venecia","Tiberio"};
            this.RespuestaHistoria = RespuestaHistoria;

            List<String> RespuestaDeportes = new List<string>() {"Caballo","Judokas","Baloncesto","Veintiuno","Sangría"};
            this.RespuestaDeportes = RespuestaDeportes;

            List<String> RespuestaCiencia = new List<string>() {"Neuronas","Pila","Paloma","Diciembre","Espalda"};
            this.RespuestaCiencia = RespuestaCiencia;
        }
    }
}