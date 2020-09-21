using System;
using System.Collections.Generic;
using System.Text;

namespace HW26
{
    public class Profile
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Address { get; set; }
        public User User { get; set; }

        public Guid UserId { get; set; }
    }
}
