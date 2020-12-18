using KluCareer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.Entities.Concrate.Models
{
    public class Fakulte:BaseEntity
    {
        public string Name { get; set; }

        public List<Fakulte> Fakulteler { get; set; }
    }
}
