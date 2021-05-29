using KluCareer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KluCareer.Entities.Concrate.Models
{
    public class DevirDaim:BaseEntity
    {
        public bool Status { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public List<DevirDaimDurum> DevirDaimDurum { get; set; }
    }
}
