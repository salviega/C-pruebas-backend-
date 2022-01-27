using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        public Participante categorias(int nivel, Participante Participante)
        {
            Dictionary<int, int> valor = new Dictionary<int, int>()
            {
                {1, 1000000},
                {2, 2000000},
                {3, 4000000},
                {4, 8000000},
                {5, 16000000},
            };

            BolsaPreguntas Preguntas = new BolsaPreguntas();
            BolsaRepuestas Respuestas = new BolsaRepuestas();
            Respuestas Respuesta = new Respuestas();

            String _Pregunta = "";
            String Correcta = "";

            Random rd = new Random();

            int i = rd.Next(1, 5);

            List<String> _Respuesta;
            List<String> _OrdenRespuesta;

            String _Answer;
            int _Answer_;
            bool x = true;

            switch (nivel)
            {
                case 1:

                    foreach (var Pregunta in Preguntas.Geografia)
                    {
                        if (i == Pregunta.Key)
                        {
                            _Pregunta = Pregunta.Value;
                            Correcta = Respuesta.RespuestaGeografia[i - 1];
                        }
                    }
                    _Respuesta = Respuestas.OpcionesRespuestasGeografia[i - 1];                
                    _OrdenRespuesta = _Respuesta.OrderBy(item => rd.Next()).ToList();

                    Console.WriteLine(_Pregunta + " \n");
                    Console.WriteLine("A. " + _OrdenRespuesta[0] + "     B." + _OrdenRespuesta[1]);
                    Console.WriteLine("C. " + _OrdenRespuesta[2] + "     D." + _OrdenRespuesta[3] + " \n");

                    _Answer = GetStringFromUser("Por favor, digite la letra que corresponda a su respuesta: ");
                    _Answer_ = 0;

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
                                Console.WriteLine("¡Muy bien! Acabas de ganar {0:C} \n", valor[nivel]);
                                if (Participante.Money == 0)
                                {
                                    Participante.Money = valor[nivel];
                                    Participante.Answer = nivel;
                                    return Participante;
                                }
                                else
                                {
                                    if (valor.FirstOrDefault(x => x.Value == valor[nivel]).Key == nivel)
                                    {
                                        Participante.Money = valor[nivel] + Participante.Money;
                                        Participante.Answer = nivel;
                                        return Participante;
                                    }  
                                }
                            }
                            else
                            {
                                Participante.Money = 0;
                                Participante.Answer = nivel;
                                Thread.Sleep(1000);
                                Console.WriteLine("Ah tu respuesta ha sido incorrecta, que mal acabas de perder la opotunidad de tu vida \n");
                                Console.WriteLine("«Game Over» \n");
                                return Participante;
                            }
                        }
                    }

                    return null;

                case 2:

                    foreach (var Pregunta in Preguntas.Entretenimiento)
                    {
                        if (i == Pregunta.Key)
                        {
                            _Pregunta = Pregunta.Value;
                            Correcta = Respuesta.RespuestaEntretenimiento[i - 1];
                        }
                    }
                    _Respuesta = Respuestas.OpcionesRespuestasEntretenimiento[i - 1];                
                    _OrdenRespuesta = _Respuesta.OrderBy(item => rd.Next()).ToList();

                    Console.WriteLine(_Pregunta + " \n");
                    Console.WriteLine("A. " + _OrdenRespuesta[0] + "     B." + _OrdenRespuesta[1]);
                    Console.WriteLine("C. " + _OrdenRespuesta[2] + "     D." + _OrdenRespuesta[3] + " \n");

                    _Answer = GetStringFromUser("Por favor, digite la letra que corresponda a su respuesta: ");
                    _Answer_ = 0;

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
                                Console.WriteLine("¡Muy bien! Acabas de ganar {0:C} \n", valor[nivel]);
                                if (Participante.Money == 0)
                                {
                                    Participante.Money = valor[nivel];
                                    Participante.Answer = nivel;
                                    return Participante;
                                }
                                else
                                {
                                    if (valor.FirstOrDefault(x => x.Value == valor[nivel]).Key == nivel)
                                    {
                                        Participante.Money = valor[nivel] + Participante.Money;
                                        Participante.Answer = nivel;
                                        return Participante;
                                    }  
                                }
                            }
                            else
                            {
                                Participante.Money = 0;
                                Participante.Answer = nivel;
                                Thread.Sleep(1000);
                                Console.WriteLine("Ah tu respuesta ha sido incorrecta, que mal acabas de perder la opotunidad de tu vida \n");
                                Console.WriteLine("«Game Over» \n");
                                return Participante;
                            }
                        }
                    }

                    return null;
                    
                default:
    
                    return null;
            }
        }
    }
}