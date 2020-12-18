using KluCareer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KluCareer.Entities.Concrate.Models
{
    public class Cv:BaseEntity
    {
        public DateTime BirthDate { get; set; }
        public DateTime DrivingLicance { get; set; }
        public Guid BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
