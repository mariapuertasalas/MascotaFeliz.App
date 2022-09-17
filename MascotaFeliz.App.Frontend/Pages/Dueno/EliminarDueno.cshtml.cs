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
    public class EliminarDuenoModel : PageModel
    {

        private readonly IRepositorioDueno _repoDueno;
        public Dueno dueno {get;set;}

        [BindProperty]
        public string id { get; set; }

        public EliminarDuenoModel(){
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

        public IActionResult OnPostDelete()
        {
            _repoDueno.DeleteDueno(int.Parse(id));
            return RedirectToPage("ListarDueno");
        }

    }
}
