using System;
using System.Collections.Generic;
using Backend_P.Models;
using Backend_P.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend_P.Controllers
{
    public class StudentController: Controller
    {

        private readonly IStudentRepository _repositorio;

        public StudentController(IStudentRepository repositorio){
            _repositorio = repositorio;
        }

        [HttpGet("v1/student")]
        public IActionResult ListStudents(){
            return Ok(_repositorio.List());
        }
   
        [HttpPost("v1/student/")]
        public IActionResult AddStudent([FromBody] Student student){
            _repositorio.Add(student);
            return Ok();
        }

        [HttpGet("v1/student/{id}")]
        public IActionResult StudentById(int id, [FromBody] Student student){
            var studentAntigo = _repositorio.ById(id);
            if (studentAntigo == null){
                return NotFound();
            }
            return Ok(studentAntigo);
        }

        [HttpPut("v1/student/{id}")]
        public IActionResult ChangeStudentData(int id, [FromBody] Student student){
            var studentAntigo = _repositorio.ById(id);
            if (studentAntigo == null){
                return NotFound();
            }

            studentAntigo.age = student.age;
            studentAntigo.card = student.card;
            studentAntigo.classRoom = student.classRoom;
            studentAntigo.email = student.email;
            //Rever a necessidade do SET no ID
            studentAntigo.Id = student.Id;
            studentAntigo.name = student.name;
            studentAntigo.record = student.record;
            studentAntigo.status = student.status;

            _repositorio.ChangeData(studentAntigo);
            return Ok();
        }

        [HttpDelete("v1/student/{id}")]
        public IActionResult RemoveStudent(int id,[FromBody]Student student){
            var studentAntigo = _repositorio.ById(id);
            if (studentAntigo == null){
                return NotFound();
            }
            _repositorio.Remove(student);
            return Ok();
        }
    }
}