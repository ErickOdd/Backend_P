using Backend_P.Models;
using System;
using System.Collections.Generic;

namespace Backend_P.Repositories
{
    public interface IStudentRepository
    {


        void Add(Student student);

        void ChangeData(Student student);
        
        IEnumerable<Student> List();

        Student ById(int id);

        void Remove(Student student);
    }
}