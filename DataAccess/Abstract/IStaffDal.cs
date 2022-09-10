using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IStaffDal : IEntityRepository<Staff>
    //This is a interface of the Staff object.
    //This includes operations related to Staff Class in the database.
    //This interface receives inheritance methods from the IEntityRepository for the Staff Class.
    {


    }
}
