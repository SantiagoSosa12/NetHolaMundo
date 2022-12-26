using Microsoft.EntityFrameworkCore;
using holaMundo.Models.DataModels;

namespace holaMundo.DataAccess
{  
   public class UniversityBDContext: DbContext
   {  
        public UniversityBDContext(DbContextOptions<UniversityBDContext> options): base(options)
        {

        }

        public DbSet<Curso>? Users {get; set;}
   }  
}