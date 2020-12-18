using KluCareer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.Entities.Concrate.Models
{
    public class Bolum:BaseEntity
    {
        public string Name { get; set; }
        public Guid FakulteId { get; set; }
        public Fakulte Fakulte { get; set; }
        public List<Cv> Cvs { get; set; }
    }
}
