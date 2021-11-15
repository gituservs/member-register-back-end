using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberRegister.Models
{
    public class MemberDetailContext:DbContext
    {
        public MemberDetailContext(DbContextOptions<MemberDetailContext> options):base(options)
        {

        }

        public DbSet<MemberDetail> MemberDetail { get; set; }
    }
}
