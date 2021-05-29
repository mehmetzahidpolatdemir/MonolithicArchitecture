using KluCareer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.Entities.Concrate.Models
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Password { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
    }
}
