using System.Collections.Generic;
using DataAccessLayer.Models;
using System.Linq;
using CommonLayer.Models;

namespace DataAccessLayer
{
    public class Repository
    {
        //public List<Register> get()
        //{
        //    int id = 1;
        //    dotnetEntities DBContext = new dotnetEntities();
        //    List<Register> l = DBContext.Registers.ToList<Register>();
        //        return l;
        //        }
        public void SaveRegisteredUsers(CommonLayer.Models.Register RegisteredUsers)
        {
            dotnetEntities DBContext = new dotnetEntities();
            DBContext.Registers.Add(RegisteredUsers);
            DBContext.SaveChanges();

        }

        public void VerifyLogin(CommonLayer.Models.Register re)
        {
           
            dotnetEntities DBContext = new dotnetEntities();
            var tempUser = DBContext.Registers.FirstOrDefault(u => u.Username == re.Username && u.Password == re.Password);

            var result = DBContext.Test(re.Username, re.Password).FirstOrDefault(); 



        }
    }

    
}
