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
            OpcionesRespuestasEntretenimiento.Add(new List<String> {"Mogui","Winnie pooh","Barney","Yogui"});
            OpcionesRespuestasEntretenimiento.Add(new List<String> {"Brad Pitt","Clint Eastwood","Leonardo Dicaprio","Jason Momoa"});
            OpcionesRespuestasEntretenimiento.Add(new List<String> {"Gabriel Marquez","Luchino Visconti","Federico Fellini","Pier Pasolini"});
            OpcionesRespuestasEntretenimiento.Add(new List<String> {"Rosalia","Shakira","Becky G","Paulina Rubio"});
            OpcionesRespuestasEntretenimiento.Add(new List<String> {"Guillo", "Bolsena", "Mudito","Gruñon"});
            this.OpcionesRespuestasEntretenimiento = OpcionesRespuestasEntretenimiento;

            List<List<String>> OpcionesRespuestasHistoria = new List<List<String>>();
            OpcionesRespuestasHistoria.Add(new List<String> {"Catalina de Aragón","Catalina la grande","Julieta","Cleopatra"});
            OpcionesRespuestasHistoria.Add(new List<String> {"Francia","Italia","Inglaterra","España"});
            OpcionesRespuestasHistoria.Add(new List<String> {"Té","Opio","Waterloo","Boston"});
            OpcionesRespuestasHistoria.Add(new List<String> {"Venecia","Torino","Bologña","Turin"});
            OpcionesRespuestasHistoria.Add(new List<String> {"Julio Cesar", "Alejandro", "Artemio","Tiberio"});
            this.OpcionesRespuestasHistoria = OpcionesRespuestasHistoria;

            List<List<String>> OpcionesRespuestasDeportes = new List<List<String>>();
            OpcionesRespuestasDeportes.Add(new List<String> {"Torre","Peón","Alfíl","Caballo"});
            OpcionesRespuestasDeportes.Add(new List<String> {"Judistas","Judokas","Judenses","judos"});
            OpcionesRespuestasDeportes.Add(new List<String> {"Baloncesto","Fútbol","Americano","Ciclismo"});
            OpcionesRespuestasDeportes.Add(new List<String> {"Veintiuno","Ventidos","Veinte","Dicinueve"});
            OpcionesRespuestasDeportes.Add(new List<String> {"Cubalibre", "Sangría", "Verano","Cabeza de jabalí"});
            this.OpcionesRespuestasDeportes = OpcionesRespuestasDeportes;

            List<List<String>> OpcionesRespuestasCiencia = new List<List<String>>();
            OpcionesRespuestasCiencia.Add(new List<String> {"Sinapticas","Neuronas","Axiomas","Espermatozoide"});
            OpcionesRespuestasCiencia.Add(new List<String> {"Pila","Bombilla","Bateria","Electricidad"});
            OpcionesRespuestasCiencia.Add(new List<String> {"Albatros","Paloma","Grulla","Monje"});
            OpcionesRespuestasCiencia.Add(new List<String> {"Julio","Diciembre","Agosto","Septiembre"});
            OpcionesRespuestasCiencia.Add(new List<String> {"Codos", "Planta del pie", "Espalda","Cara"});
            this.OpcionesRespuestasCiencia = OpcionesRespuestasCiencia;
        }
    }
}