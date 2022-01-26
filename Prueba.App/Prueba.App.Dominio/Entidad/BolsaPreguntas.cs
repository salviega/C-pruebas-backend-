using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.App.Dominio;

namespace Prueba.App.Dominio
{
    public class BolsaPreguntas
    {
        public Dictionary<int, String> Geografia { get; set; }
        public Dictionary<int, String> Entretenimiento { get; set; }
        public Dictionary<int, String> Historia { get; set; }
        public Dictionary<int, String> Deportes { get; set; }
        public Dictionary<int, String> Ciencia { get; set; }
        public BolsaPreguntas(Dictionary<int, String> Geografia, Dictionary<int, String> Entretenimiento, Dictionary<int, String> Historia, Dictionary<int, String> Deportes, Dictionary<int, String> Ciencia)
        {
            this.Geografia = Geografia;
            this.Entretenimiento = Entretenimiento;
            this.Historia = Historia;
            this.Deportes = Deportes;
            this.Ciencia = Ciencia;
        }
        public BolsaPreguntas()
        {
            Preguntas Categoria = new Preguntas();
            this.Geografia = Categoria.Geografia;
            this.Entretenimiento = Categoria.Entretenimiento;
            this.Historia = Categoria.Historia;
            this.Deportes = Categoria.Deportes;
            this.Ciencia = Categoria.Ciencia;
        }

        public static String GetStringFromUser(String prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public Participante categorias(int nivel, Participante participante)
        {
            Dictionary<int, int> valor = new Dictionary<int, int>()
            {
                {1, 1000000},
                {2, 2000000},
                {3, 4000000},
                {4, 8000000},
                {5, 16000000},
            };

            switch (nivel)
            {
                case 1:

                    BolsaPreguntas Preguntas = new BolsaPreguntas();
                    BolsaRepuestas Respuestas = new BolsaRepuestas();
                    Respuestas Respuesta = new Respuestas();

                    String _Pregunta = "";
                    String Correcta = "";

                    Random rd = new Random();
                    int i = rd.Next(1, 5);

                    foreach (var Pregunta in Preguntas.Geografia)
                    {
                        if (i == Pregunta.Key)
                        {
                            _Pregunta = Pregunta.Value;
                            Correcta = Respuesta.RespuestaGeografia[i - 1];
                        }
                    }
                    var _Respuesta = Respuestas.OpcionesRespuestasGeografia[i - 1];                
                    var _OrdenRespuesta = _Respuesta.OrderBy(item => rd.Next()).ToList();

                    Console.WriteLine(_Pregunta + " \n");
                    Console.WriteLine("A. " + _OrdenRespuesta[0] + "     B." + _OrdenRespuesta[1]);
                    Console.WriteLine("C. " + _OrdenRespuesta[2] + "     D." + _OrdenRespuesta[3] + " \n");

                    String _Answer = GetStringFromUser("Por favor, digite la letra que corresponda a su respuesta: \n");
                    int _Answer_ = 0;

                    bool x = true;
                    while(x)
                    {
                        switch (_Answer)
                        {
                            case ("a"):
                                _Answer_ = 0;
                                x = false;
                                break;
                            case ("A"):
                                _Answer_ = 0;
                                x = false;
                                break;    
                            case ("b"):
                                _Answer_ = 1;
                                x = false;
                                break;
                            case ("B"):
                                _Answer_ = 1;
                                x = false;
                                break;
                            case ("c"):
                                _Answer_ = 2;
                                x = false;
                                break;
                            case ("C"):
                                _Answer_ = 2;
                                x = false;
                                break;
                            case ("d"):
                                _Answer_ = 3;
                                x = false;
                                break;
                            case ("D"):
                                _Answer_ = 3;
                                x = false;
                                break;
                            default:
                                _Answer = GetStringFromUser("Hubo un error, ingresa nuevamente la letra que corresponda a tu respuesta: ");
                                break;
                        }
                    }

                    foreach (var ans in _OrdenRespuesta)
                    {
                        if( String.Equals(ans, _OrdenRespuesta[_Answer_]))
                        {
                            if(String.Equals(_OrdenRespuesta[_Answer_], Correcta))
                            {
                                Console.WriteLine("¡Muy bien! Acabas de ganar " + valor[nivel] + " \n");
                                participante.Money = valor[nivel];
                            }
                        }
                    }

                    break;

                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}