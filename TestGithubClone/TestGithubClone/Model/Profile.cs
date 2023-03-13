using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestGithubClone.Model
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Rank { get; set; }

        public Profile(int Id, string Name, string Description, string Rank) 
        {
            this.Id = 0;
            this.Name = Name;
            this.Description = Description;
            this.Rank = Rank;
        }

        public void createId()
        {
             

        }



    }   


}
