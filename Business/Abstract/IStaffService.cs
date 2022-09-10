using Business.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStaffService
    //The service operations that will be used in the business layer were declared in this interface.
    //Our own result types have been created to indicate whether the transactions were successful or to indicate why they failed if they failed.
    //This allows us to write readable and standardized codes.
    {
        IDataResult<List<Staff>> GetAll();
        IDataResult<Staff> GetById(int id);
        IResult Delete(Staff staff);
        IResult Update(Staff staff);
        IResult Add(Staff staff);

    }
}
