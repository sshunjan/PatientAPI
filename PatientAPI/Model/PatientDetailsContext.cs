using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Model
{
    public class PatientDetailsContext:DbContext
    {
        public PatientDetailsContext(DbContextOptions<PatientDetailsContext> options):base(options)
        {

        }

        public DbSet<PatientDetails> PatientDetails { get; set; }
    }
}
