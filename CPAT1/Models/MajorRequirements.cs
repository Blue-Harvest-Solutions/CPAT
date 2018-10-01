using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPAT1.Models
{
    public class MajorRequirements
    {
        public MajorRequirements()
        {
            var ReqClasses = new[]
            {
                new Course
                {
                    CourseID = 99,
                    CourseName = "PreCalculus",
                    CreditHours = 3,
                    Description = "Topics will include linear and quadratic functions and their applications; " +
                    "systems of equations; inequalities, polynomials, exponentials, logarithms, trigonometric " +
                    "functions and their inverses and their graphs; trigonometric identities, and complex numbers."
                    
                },

                new Course
                {
                    CourseID = 100,
                    CourseName = "Intro to Visual & Procedural Programming",
                    CreditHours = 3,
                    Description = "This course provides an introduction to the fundamentals of visual programming as " +
                    "well as procedural language structure and capabilities. Students learn about visual programming " +
                    "development, including problem definition, problem solving and algorithms, procedures, controls, " +
                    "arrays, structures, coding, visual interface design, testing, and debugging. "
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
                    PreRequisites = new int[]
                    {
                        100
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
                    PreRequisites = new int[]
                    {
                        99
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
        }
    }
}
