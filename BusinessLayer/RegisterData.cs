using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;

namespace BusinessLayer
{
   public class RegisterData
    {
        public List<Register> GetUsers()
        {
            var DA = new Repository();
            List<Register> r = DA.GetRegiUsers();
            return r;
        }
        
    }
}
