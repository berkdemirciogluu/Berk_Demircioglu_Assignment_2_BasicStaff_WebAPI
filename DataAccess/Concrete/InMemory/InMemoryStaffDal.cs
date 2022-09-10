using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryStaffDal : IStaffDal 
    {
        List<Staff> _staffList; // It is a global variable that will act as our database.

        public InMemoryStaffDal()
        {
            //This step simulates that this list will behave as our database.
            _staffList = new List<Staff>()
            {
                new Staff{Id=1, Name="Berk", LastName="Demircioglu",DateOfBirth=DateTime.Now,Email="berk@yahoo.com",PhoneNumber="+905068442627",Salary=5000},
                new Staff{Id=2, Name="Beste", LastName="Bilen",DateOfBirth=DateTime.Now,Email="beste@yahoo.com",PhoneNumber="+905068442627",Salary=5000},
                new Staff{Id=3, Name="Oktay", LastName="Domuz",DateOfBirth=DateTime.Now,Email="emre@yahoo.com",PhoneNumber="+905068442627",Salary=5000},
                new Staff{Id=4, Name="Hilal", LastName="Aslan",DateOfBirth=DateTime.Now,Email="alin@yahoo.com",PhoneNumber="+905068442627",Salary=5000},
                new Staff{Id=5, Name="Zuhal", LastName="Kaplan",DateOfBirth=DateTime.Now,Email="veli@yahoo.com",PhoneNumber="+905068442627",Salary=5000},
                new Staff{Id=6, Name="Semra", LastName="Kedi",DateOfBirth=DateTime.Now,Email="mehmet@yahoo.com",PhoneNumber="+905068442627",Salary=5000}
            };
        }
        public void Add(Staff staff) //This method of adding the instance to the list.
        {
            _staffList.Add(staff);
        }

        public void Delete(Staff staff) //The method for deleting an element from the list.
        {
            Staff staffToDelete = _staffList.SingleOrDefault(s => s.Id == staff.Id); //The instance was found in the list.
            _staffList.Remove(staffToDelete); //The found instance was deleted.
        }

        public Staff GetById(int id) //The method of bringing the element according to the id of the element.
        {
            return _staffList.SingleOrDefault(s=>s.Id==id); //The instance was found in the list.
        }

        public List<Staff> GetAll() //The method of bringing the all the elements in the list.
        {
            return _staffList.OrderBy(x=>x.Id).ToList<Staff>(); //The elements also was ordered.
        }


        public void Update(Staff staff) //The method for updating the information of a list element. 
        {
            Staff staffToUpdate = _staffList.SingleOrDefault(s => s.Id == staff.Id); //The element that will be updated was found.

            //The following if queries were made for control of non-value areas.
            //In fact, the current validations already cover the following situations.
            //However, in case of any changes in validations in the future, the following checks were performed.

            staffToUpdate.Name = staff.Name != default ? staff.Name : staffToUpdate.Name;
            staffToUpdate.LastName = staff.LastName != default ? staff.LastName : staffToUpdate.LastName;
            staffToUpdate.DateOfBirth = staff.DateOfBirth != default ? staff.DateOfBirth : staffToUpdate.DateOfBirth;
            staffToUpdate.PhoneNumber = staff.PhoneNumber != default ? staff.PhoneNumber : staffToUpdate.PhoneNumber;
            staffToUpdate.Email =staff.Email != default ? staff.Email : staffToUpdate.Email;
            staffToUpdate.Salary = staff.Salary != default ? staff.Salary : staffToUpdate.Salary;
        }
    }
}
