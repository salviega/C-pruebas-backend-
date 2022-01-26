using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.App.Dominio;

namespace Prueba.App.Persistencia
{
    public interface IRepositorioParticipante
    {
        IEnumerable<Participante> GetAllParticipantes();
        void AddParticipante(Participante participante);
        Participante UpdateParticipante(int Document);
        void DeleteParticipante(int Document);
        Participante GetParticipante(int Document);
    }
}