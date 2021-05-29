using KluCareer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KluCareer.Entities.Concrate.Models
{
    public class DevirDaimDurum:BaseEntity
    {
        public Guid DevirDaimId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
