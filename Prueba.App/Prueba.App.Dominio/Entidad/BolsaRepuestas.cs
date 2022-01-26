using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.App.Dominio;

namespace Prueba.App.Dominio
{
    public class BolsaRepuestas
    {
        public List<List<String>> OpcionesRespuestasGeografia {get;set;}
        public List<List<String>> OpcionesRespuestasEntretenimiento {get;set;}
        public List<List<String>> OpcionesRespuestasHistoria {get;set;}
        public List<List<String>> OpcionesRespuestasDeportes {get;set;}
        public List<List<String>> OpcionesRespuestasCiencia {get;set;}
        public BolsaRepuestas()
        {
            List<List<String>> OpcionesRespuestasGeografia = new List<List<String>>();
            OpcionesRespuestasGeografia.Add(new List<String> {"Alemán","Español","Inglés","Filandés"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Venezuela","Bolivia","Argentina","Ecuador"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Nilo","Danubio","Rin","Volga"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Leman", "Bolsena", "Iseo","Trasimeno"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Laos","Viena","Torino","Jakarta"});
            this.OpcionesRespuestasGeografia = OpcionesRespuestasGeografia;

            List<List<String>> OpcionesRespuestasEntretenimiento = new List<List<String>>();
            OpcionesRespuestasGeografia.Add(new List<String> {"Mogui","Winnie pooh","Barney","Yogui"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Brad Pitt","Clint Eastwood","Leonardo Dicaprio","Jason Momoa"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Gabriel Marquez","Luchino Visconti","Federico Fellini","Pier Pasolini"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Rosalia","Shakira","Becky G","Paulina Rubio"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Guillo", "Bolsena", "Mudito","Gruñon"});
            this.OpcionesRespuestasEntretenimiento = OpcionesRespuestasEntretenimiento;

            List<List<String>> OpcionesRespuestasHistoria = new List<List<String>>();
            OpcionesRespuestasGeografia.Add(new List<String> {"Catalina de Aragón","Catalina la grande","Julieta","Cleopatra"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Francia","Italia","Inglaterra","España"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Té","Opio","Waterloo","Boston"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Venecia","Torino","Bologña","Turin"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Julio Cesar", "Alejandro", "Artemio","Tiberio"});
            this.OpcionesRespuestasHistoria = OpcionesRespuestasHistoria;

            List<List<String>> OpcionesRespuestasDeportes = new List<List<String>>();
            OpcionesRespuestasGeografia.Add(new List<String> {"Torre","Peón","Alfíl","Caballo"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Judistas","Judokas","Judenses","judos"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Baloncesto","Fútbol","Americano","Ciclismo"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Veintiuno","Ventidos","Veinte","Dicinueve"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Cubalibre", "Sangría", "Verano","Cabeza de jabalí"});
            this.OpcionesRespuestasDeportes = OpcionesRespuestasDeportes;

            List<List<String>> OpcionesRespuestasCiencia = new List<List<String>>();
            OpcionesRespuestasGeografia.Add(new List<String> {"Sinapticas","Neuronas","Axiomas","Espermatozoide"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Pila","Bombilla","Bateria","Electricidad"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Albatros","Paloma","Grulla","Monje"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Julio","Diciembre","Agosto","Septiembre"});
            OpcionesRespuestasGeografia.Add(new List<String> {"Codos", "Planta del pie", "Espalda","Cara"});
            this.OpcionesRespuestasCiencia = OpcionesRespuestasCiencia;
        }
    }
}