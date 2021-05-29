using KluCareer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.Entities.Concrate.Models
{
    public class News:BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Type { get; set; }
        public int? ShowCount { get; set; }
    }
}
