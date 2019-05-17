using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DataModel
{
    public class UserAbility:BaseEntity
    {
        public string UserId { get; set; }
        public string AbilityId { get; set; }
        public byte Score { get; set; }
        public string Description { get; set; }
    }
}
