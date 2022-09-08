using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;


namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        //private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
       
        //*private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             //ListarDuenosFiltro();      
           //AddDueno();
           //BuscarDueno(1);
            //ListarVeterinariosFiltro();
            //AddVeterinario();
            //BuscarVeterinario(1);
            //AddHistoria();
            //AddMascota();
            //BuscarMascota(1);
            ListarMascota();
        }
            private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Leonardo",
                Apellidos = "Rodriguez", 
                Direccion = "Calle 120",
                Telefono = "111258258",
                Correo = "Batman@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "La Chilindrina",
                Apellidos = "No se sabe", 
                Direccion = "Transversal 5 # 17A-155",
                Telefono = "2222222222",
                TarjetaProfesional = "TP0001"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

           /* private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(1990, 04, 12)
                
            };
            _repoHistoria.AddHistoria(historia);
        }


        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos+" "+dueno.Direccion+" "+dueno.Telefono+" "+dueno.Correo);
        }

            private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void ListarDuenosFiltro()
        {
            var duenosM = _repoDueno.GetDuenosPorFiltro("nar");
            foreach (Dueno p in duenosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }

        private static void ListarVeterinariosFiltro()
        {
            var veterinarios = _repoVeterinario.GetVeterinariosPorFiltro("e");
            foreach (Veterinario p in veterinariosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }*/
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Camelia",
                Color= "Blanco", 
                Especie = "Gato",
                Raza = "Esfinge",
            };
            _repoMascota.AddMascota(mascota);
        }
        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Raza+" "+mascota.Color+" "+mascota.Especie);
        }
        private static void ListarMascota()
        {
        var mascotas = _repoMascota.GetAllMascota();
        foreach (Mascota m in mascotas)
        {
           Console.WriteLine(m.Nombre +" "+m.Especie+" "+m.Raza+" "+m.Color); 
        }
        
        }

    }
    
}
