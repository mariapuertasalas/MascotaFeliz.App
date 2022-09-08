/*using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
       /// <summary>
        /// Referencia al contexto de Historia
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        } 

        public Historia AddHistoria(Historia historia)
        {
        var historiaAdicionada = _appContext.Historias.Add(historia);
        _appContext.SaveChanges();
        return historiaAdicionada.Entity; 
        }


         public void DeleteHistoria(int idHistoria)
         {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(h=> h.Id == idHistoria);
            if (historiaEncontrada == null)
              return;
            _appContext.Historias.Remove(historiaEncontrada);
            _appContext.SaveChanges();

         }
         public IEnumerable<Historia> GetAllHistorias()
         {
            return GetAllHistorias_();
         }

        public IEnumerable<Historia> GetHistoriasPorFiltro(DateTime filtro)
        {
            var historias = GetAllHistorias(); // Obtiene todos los saludos
            if (historias != null)  //Si se tienen saludos
            {
                if (!DateTime.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    historias = historias.Where(h => h.FechaInicial.Contains(filtro));
                }
            }
            return historias;
        }
        public IEnumerable<Historia> GetAllHistorias_()
        {
            return _appContext.Historias;
        }

        public Historia GetHistoria(int idHistoria)
        {
            return _appContext.Historias.FirstOrDefault(d => d.Id == idHistoria);
        }

        public Historia UpdateHistoria(Historia historia)
        {
            var historiaEncontrada= _appContext.Historias.FirstOrDefault(d => d.Id == historia.Id);
            if (historiaEncontrada != null)
            {
                historiaEncontrada.FechaInicial = historia.FechaInicial;
                historiaEncontrada.VisitasPyP = historia.VisitasPyP;
            
                _appContext.SaveChanges();
            }
            return historiaEncontrada;
        }     





    }
}*/

