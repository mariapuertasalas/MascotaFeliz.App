using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        public IEnumerable<Mascota> GetAllMascota();
        public Mascota AddMascota(Mascota mascota);
        public Mascota UpdateMascota(Mascota mascota);
        public void DeleteMascota(int idMascota);
        public Mascota GetMascota(int idMascota);
        public IEnumerable<Mascota> GetMascotaPorFiltro(string filtro);
    }
}