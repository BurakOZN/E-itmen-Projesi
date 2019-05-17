using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DataModel
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }//email
        public string Password { get; set; }
        public string PictureURL { get; set; }
        public DateTime Birth { get; set; }
    }
}
