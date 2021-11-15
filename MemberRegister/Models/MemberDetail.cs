using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MemberRegister.Models
{
    public class MemberDetail
    {
        [Key]
        public int Id { get; set; }
        
        [Column(TypeName ="nvarchar(100)")]
        public string MemberName { get; set; }

        [Column(TypeName = "nvarchar(50)")] 
        public string MemberMail { get; set; }
        
        [Column(TypeName = "nvarchar(10)")] 
        public string MemberPhone { get; set; }
    }
}
