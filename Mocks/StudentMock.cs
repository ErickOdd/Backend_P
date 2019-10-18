using System;

namespace Backend_P.Models{
    public class StudentMock: Student
    {
        StudentMock(){
            Id = 666666;
            card = 666;
            name = "Lucifer de Jesus Costa ";
            age = 6;
            email = "capetinha666@hotmail.com";
            classRoom = "6H";
            var dateString = "5/1/2008 8:30:52 AM";
            DateTime date1 = DateTime.Parse(dateString,
                          System.Globalization.CultureInfo.InvariantCulture);
            status = Status.Engaged;

        }
    }
}