using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CPAT1.Models;

namespace CPAT1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult AdvisorView()
        {
            var students = new Student[]
            {
                new Student
                {
                    FirstName = "Ana",
                    MiddleInitial = 'S',
                    LastName = "Smith",
                    N_Number = "N00000001",
                    MajorID = 1
                },
                new Student
                {
                    FirstName = "Banana",
                    LastName = "Spots",
                    N_Number = "N00000002",
                    MajorID = 2
                }
            };

            ViewBag.currentStudent = students[0];

            var courses = new Course[]
            {
                new Course
                {
                    CourseID = 99,
                    CourseName = "PreCalculus",
                    CreditHours = 3,
                    Description = "Topics will include linear and quadratic functions and their applications; " +
                    "systems of equations; inequalities, polynomials, exponentials, logarithms, trigonometric " +
                    "functions and their inverses and their graphs; trigonometric identities, and complex numbers.",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {

                    },
                    CoRequisites = new int[]
                    {

                    }

                },

                new Course
                {
                    CourseID = 100,
                    CourseName = "Intro to Visual & Procedural Programming",
                    CreditHours = 3,
                    Description = "This course provides an introduction to the fundamentals of visual programming as " +
                    "well as procedural language structure and capabilities. Students learn about visual programming " +
                    "development, including problem definition, problem solving and algorithms, procedures, controls, " +
                    "arrays, structures, coding, visual interface design, testing, and debugging. ",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {

                    },
                    CoRequisites = new int[]
                    {

                    }
                },

                new Course
                {
                    CourseID = 101,
                    CourseName = "Intro to Object Oriented Programming",
                    CreditHours = 3,
                    Description = "This course introduces the principles and practices of Object Oriented (OO) programming. " +
                    "Topics include user interface and problem data classes; class versus instance properties and " +
                    "methods; abstraction; encapsulation; inheritance and multiple inheritance; polymorphism; " +
                    "software design techniques; and problem solving. The concepts are utilized in numerous programming projects. ",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {
                        100
                    },
                    CoRequisites = new int[]
                    {

                    }
                },

                new Course
                {
                    CourseID = 200,
                    CourseName = "Computational Structures",
                    CreditHours = 3,
                    Description = "This course covers the applications of finite mathematics to CIS. Topics include sets, " +
                    "relations, functions, and number theory; algebraic and combinatorial structures; applications of graphs; " +
                    "Boolean algebra and switching theory, and logic.",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {
                        99
                    },
                    CoRequisites = new int[]
                    {

                    }
                },

                new Course
                {
                    CourseID = 201,
                    CourseName = "Web Systems Development",
                    CreditHours = 3,
                    Description = "Students learn about the influence of E-Business, local and global transaction processing, " +
                    "Internet, web design and development, and Electronic Data Interchange on information systems. After an " +
                    "introduction to the basic concepts of relational database systems, students will practice connectivity to a " +
                    "database to retrieve information. The course includes a design and implementation project involving a database " +
                    "in the Web environment.",
                    Major = "Computer Science",
                    PreRequisites = new int[]
                    {
                        100, 101
                    },
                    CoRequisites = new int[]
                    {
                        200
                    }
                }
            };

            double sumHours = 0;

            foreach (Course c in courses)
            {
                sumHours += c.CreditHours;
            }
            ViewBag.TotalHours = sumHours;

            return View(courses);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
