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
    public class ActualizarDuenoModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;
        public Dueno dueno {get;set;}

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

        public ActualizarDuenoModel(){
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        }

        public IActionResult OnGet(int Id)
        {
            dueno = _repoDueno.GetDueno(Id);
            if(dueno != null){
                return Page();
            }else{
                return RedirectToPage("./NotFound");
            }
        }

        public IActionResult OnPost()
        {
            dueno = _repoDueno.GetDueno(int.Parse(id));
            if(dueno != null){
                dueno.Identificacion = identificacion;
                dueno.Nombres = nombres;
                dueno.Apellidos = apellidos;
                dueno.Direccion = direccion;
                dueno.Telefono = telefono;
                dueno.Correo = correo;
                _repoDueno.UpdateDueno(dueno);
                return Page();
            }else{
                return RedirectToPage("./NotFound");
            }
        }
    }
}
