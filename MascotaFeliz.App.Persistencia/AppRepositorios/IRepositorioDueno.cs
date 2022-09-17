using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioDueno
    {
        IEnumerable<Dueno> GetAllDuenos();
        Dueno AddDueno(Dueno nuevoDueno);
        Dueno UpdateDueno(Dueno dueno);
        void DeleteDueno(int id);
        Dueno GetDueno(int id);
        Dueno GetDuenoPorIdentificacion(String Identificacion);
        IEnumerable<Dueno> GetDuenosPorFiltro(string filtro);
    }
}