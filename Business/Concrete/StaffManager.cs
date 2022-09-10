using Business.Abstract;
using Business.Constants;
using Business.Utilities.Results;
using Business.Utilities.Validation.FluentValidation;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    //To see relevant messages, check Business.Utilities.Constants.Messages.cs
    public class StaffManager : IStaffService
    {
        //Considering the possibility of using a different database in the future, injection was made with an interface. 
        IStaffDal _staffDal; 

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public IResult Add(Staff staff)
        {
            //It is checked whether the element that will be added is already in the list or not.
            if (_staffDal.GetById(staff.Id) == null) 
            {
                try
                {
                    ValidationTool.Validate(new StaffValidator(), staff); //Validation was handled.
                    _staffDal.Add(staff); //The element was added.
                    return new SuccessResult(Messages.StaffAdded); //The result was returned with a relevant message.
                                                                  //To see relevant messages, check Business.Utilities.Constants.Messages.cs
                }
                catch (Exception ex)
                {
                    return new ErrorResult(ex.Message); //If something goes wrong, error messages are returned.
                }
            }
            return new ErrorResult(Messages.StaffExisted); //If the element is already in the list, it gives a result with the message that says so.
                                                           //To see relevant messages, check Business.Utilities.Constants.Messages.cs
        }

        public IResult Delete(Staff staff)
        {
            //It is checked whether the element that will be added is already in the list or not.
            if (_staffDal.GetById(staff.Id) != null)
            {
                _staffDal.Delete(staff);//The element was deleted.
                return new SuccessResult(Messages.StaffDeleted);//The result was returned with a relevant message.
                //To see relevant messages, check Business.Utilities.Constants.Messages.cs
            }
            return new ErrorResult(Messages.InvalidStaff);//The result was returned with a relevant message.
            //To see relevant messages, check Business.Utilities.Constants.Messages.cs
        }

        public IDataResult<List<Staff>> GetAll()
        {
            //All the elements in the list were introduced  with a relevant message.
            //To see relevant messages, check Business.Utilities.Constants.Messages.cs
            return new SuccessDataResult<List<Staff>>(_staffDal.GetAll(),Messages.StaffsListed);
        }

        public IDataResult<Staff> GetById(int id)
        {
            //It is checked whether the element that will be added is already in the list or not.
            if (_staffDal.GetById(id) != null)
            {
                //The element was brought in according to the id of the element with a relevant message.
                //To see relevant messages, check Business.Utilities.Constants.Messages.cs
                return new SuccessDataResult<Staff>(_staffDal.GetById(id),Messages.StaffBrought);
            }
            //If there is no element with a given id, the result is returned with a relevant message.
            return new ErrorDataResult<Staff>(Messages.InvalidStaff);  
        }

        public IResult Update(Staff staff)
        {
            //It is checked whether the element that will be added is already in the list or not.
            if (_staffDal.GetById(staff.Id) != null)
            {
                try
                {
                    ValidationTool.Validate(new StaffValidator(), staff); //Validation was handled.
                    _staffDal.Update(staff); //The given element was updated.
                    return new SuccessResult(Messages.StaffUpdated);//The result was returned with a relevant message.
                                                                    //To see relevant messages, check Business.Utilities.Constants.Messages.cs
                }
                catch (Exception ex)
                {
                    return new ErrorResult(ex.Message); //If something goes wrong, error messages are returned.
                }
            }
            return new ErrorResult(Messages.InvalidStaff);//If there is no element with a given id, the result is returned with a relevant message.
                                                          //To see relevant messages, check Business.Utilities.Constants.Messages.cs
        }

    }
}
