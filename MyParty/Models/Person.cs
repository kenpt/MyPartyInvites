using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyParty.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="姓名不能为空！")]
        public string Name { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage ="必须选择是否参加！")]
        public bool? Attend { get; set; }

    }
}