using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioDueno
    {
        public IEnumerable<Dueno> GetAllDuenos();
        public Dueno AddDueno(Dueno dueno);
        public Dueno UpdateDueno(Dueno dueno);
        public void DeleteDueno(int idDueno);
        public Dueno GetDueno(int idDueno);
        public IEnumerable<Dueno> GetDuenosPorFiltro(string filtro);
    }
}