using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Linq;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {

        private readonly AppContext _appContext;

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Veterinario> GetAllVeterinario(){
            return _appContext.Veterinarios;
        }

        public Veterinario AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        public Veterinario UpdateVeterinario(Veterinario veterinario){
                return null;
        }

        public void DeleteVeterinario (int idVeterinario){
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(d => d.Id == idVeterinario);
            if (veterinarioEncontrado == null)
                return;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }

        public Veterinario GetVeterinario(int idVeterianrio){
             return _appContext.Veterinarios.FirstOrDefault(m => m.Id == idVeterianrio);
        }
    }
    

}