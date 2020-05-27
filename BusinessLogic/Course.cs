using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        public Course(string courseName)
        {
            CourseName = courseName;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; } = "STAFF";

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName { 
            get 
            { 
                return CourseName; 
            } 
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    CourseName = value;
                }
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get
            {
                return NumberOfCredits;
            }
            set
            {
                if (value > 30)
                {
                    throw new ArgumentException();
                }
                else NumberOfCredits = value;
            }
        }

    }
}
