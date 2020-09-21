using System;
using System.Collections.Generic;
using System.Text;

namespace HW26
{
    public class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime? DeletedDate { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
