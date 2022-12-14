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
    public class ConsultarDuenoModel : PageModel
    {
        
        private readonly IRepositorioDueno _repoDueno;
        public Dueno dueno {get;set;}

        public ConsultarDuenoModel(){
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
    }
}
