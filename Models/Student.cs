using System;

namespace Backend_P.Models{
    public class Student{
        public Student()
        {
            status = Status.Engaged;
        }
        
        public int Id { get; set; }

        public int card {get; set;}

        public string name { get; set; }

        public int age { get; set; }

        public string email {get;set;}

        public string classRoom { get; set; }

        public DateTime[][] record { get; set; }

        public Status status;
        public enum Status { Engaged, Vacation, Locked, Graduated}
    }
}