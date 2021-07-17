using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    public class Student:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Sex { get; set; }
        public DateTime BronDate { get; set; }
        public string Phone { get; set; }
        public string QQ { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        /// <summary>
        /// 外键（班级Id）刚来的时候没有班级
        /// </summary>
        [ForeignKey(nameof(Class))]
        
        public Guid? ClassId { get; set; }
        public Class Class { get; set; }
    }
}
