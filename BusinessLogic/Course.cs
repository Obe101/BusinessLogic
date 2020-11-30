using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private byte numberOfCredits;
        private string instructorName;
        private string courseName;
        const string DefaultInstructor = "STAFF";

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = instructorName;
            
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName
        {
            get => instructorName;
            set
            {
                if (value == null)
                {
                    value = DefaultInstructor;
                }

                instructorName = value;
            }

        }


        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName { get => courseName;
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(courseName)} cannot be null");
                }
                courseName = value; }
            }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get => numberOfCredits;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException($"{nameof(numberOfCredits)} should be more than 0");
                }

                if (value > 29)
                {
                    throw new ArgumentException($"{nameof(numberOfCredits)} should not be more than 30");
                }
                
                numberOfCredits = value;
            }
        }

    }
}
