using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    //In this class, messages that can be used continuously in different parts of the project.
    {
        public static string StaffAdded = "Staff Added";
        public static string StaffsListed = "Staff Listed";
        public static string StaffBrought = "Staff Brought";
        public static string StaffNameInvalid = "Staff Name Invalid";
        public static string StaffLastNameInvalid = "Invalid Last Name";
        public static string StaffPhoneNumberInvalid = "Invalid Phone Number";
        public static string StaffDateOfBirthInvalid = "Invalid Date of Birth";
        public static string StaffEmailInvalid = "Invalid Email Address";
        public static string StaffUpdated = "Staff Updated";
        public static string StaffDeleted = "Staff Deleted";
        public static string InvalidStaff = "Staff Not In The List";
        public static string StaffExisted = "Staff Already In The List";
    }
}
