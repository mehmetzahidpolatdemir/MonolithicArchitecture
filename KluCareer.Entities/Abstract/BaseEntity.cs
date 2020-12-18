using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.Entities.Abstract
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
