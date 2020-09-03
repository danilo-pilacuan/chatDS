using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace chatDS.DAL
{
    public class GestorContexto : DbContext
    {
        public DbSet<Mensaje> listaMensajes { get; set; }
        public DbSet<Contacto> listaContactos { get; set; }
        public DbSet<Usuario> listaUsuarios { get; set; }
    }
}