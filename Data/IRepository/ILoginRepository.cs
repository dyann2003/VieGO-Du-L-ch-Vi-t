using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
  public interface ILoginRepository
  {
    User? GetUserByEmail(string email);
  }
}
