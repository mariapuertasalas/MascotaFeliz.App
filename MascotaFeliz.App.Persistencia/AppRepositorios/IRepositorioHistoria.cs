using System.Runtime.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        public IEnumerable<Historia> GetAllHistorias();
        public Historia AddHistoria(Historia historia);
        public Historia UpdateHistoria(Historia historia);
        public void DeleteHistoria(int idHistoria);
        public Historia GetHistoria(int idHistoria);
        public IEnumerable<Historia> GetHistoriasPorFiltro(DateTimeFormat filtro);
    }
}