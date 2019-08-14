using System.Collections.Generic;

namespace BlazorToucanTesting.Domain.Entities
{
    public class Suite : TenantEntity
    {
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
    }
}
