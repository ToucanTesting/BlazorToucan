using System.Collections.Generic;

namespace BlazorToucanTesting.Domain.Entities
{
    public class Tenant : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<UserBase> Users { get; set; }
        public virtual ICollection<Suite> Suites { get; set; }
    }
}
