using Backend_P.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend_P.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        private readonly List<Student> _storage;

        public StudentRepository(){
            _storage = new List<Student>();
        }

        void IStudentRepository.Add(Student student){
            _storage.Add(student);
        }

        void IStudentRepository.ChangeData(Student student){
            var index = _storage.FindIndex(0,1,x=> x.Id == student.Id);
            _storage[index] = student;
        }

        //EU PAREI AQUI <<<<<<<<<<<<<<<<<<<<<<<<-------- IMPLEMENTAR A INTERFACE
        
        IEnumerable<Student> IStudentRepository.List(){
            return _storage;
        }

        Student IStudentRepository.ById(int id){
            return _storage.FirstOrDefault(x=> x.Id == id);
        }

        void IStudentRepository.Remove(Student student){
            _storage.Remove(student);
        }
    }
}