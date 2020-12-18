using KluCareer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.Entities.Concrate.Models
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Cv> Cvs { get; set; }
    }
}
