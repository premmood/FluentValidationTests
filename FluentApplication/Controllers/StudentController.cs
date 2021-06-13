using FluentApplication.Models;
using FluentApplication.Validator;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student stud)// public IActionResult Index([CustomizeValidator(Properties = "Name,EmailId")]Student stud)
        {
            //var validator = new StudentValidator();

            //if (true)
            //{
            //var results = validator.Validate(stud, options => options.IncludeRuleSets("MyRule"));
            //var results = validator.Validate(stud, options => options.IncludeProperties("Name", "EmailId"));
            //results.AddToModelState(ModelState, null);
            //}
            ////else 
            //{
            //    var resultss = validator.Validate(stud);
            //    //resultss.IsValid
            //    //resultss.Errors
            //    resultss.AddToModelState(ModelState, null);
            //}

            if (!ModelState.IsValid)
            { 
            
            }

            return View();
        }


    }
}
