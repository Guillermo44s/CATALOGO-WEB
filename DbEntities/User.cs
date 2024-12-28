using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbEntities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UrlImagePerfil { get; set; }
        public bool IsAdmin { get; set; }
    }
}
