using Microsoft.EntityFrameworkCore;

namespace Persona.Models
{
    public class PersonaDBContext:DbContext
    {
        public PersonaDBContext(DbContextOptions options): base(options)
        { 
        
        }
        public DbSet<Persona> Personas { get; set; }
    }
}
