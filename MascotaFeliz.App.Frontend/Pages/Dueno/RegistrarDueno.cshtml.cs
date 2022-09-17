using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class RegistrarDuenoModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;
        public Dueno duenoExiste {get;set;}

        [BindProperty]
        public string id { get; set; }

        [BindProperty]
        public string identificacion { get; set; }

        [BindProperty]
        public string nombres { get; set; }

        [BindProperty]
        public string apellidos { get; set; }

        [BindProperty]
        public string direccion { get; set; }

        [BindProperty]
        public string telefono { get; set; }

        [BindProperty]
        public string correo { get; set; }

        public RegistrarDuenoModel(){
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        }

        public IActionResult OnPost()
        {
            Console.WriteLine(identificacion);
            duenoExiste = _repoDueno.GetDuenoPorIdentificacion(identificacion);
            if(duenoExiste == null){
                Dueno nuevoDueno = new Dueno();
                nuevoDueno.Identificacion = identificacion;
                nuevoDueno.Nombres = nombres;
                nuevoDueno.Apellidos = apellidos;
                nuevoDueno.Direccion = direccion;
                nuevoDueno.Telefono = telefono;
                nuevoDueno.Correo = correo;
                _repoDueno.AddDueno(nuevoDueno);
                return RedirectToPage("ListarDueno");
            }else{
                return RedirectToPage("./UsuarioExiste");
            }
        }
    }
}
