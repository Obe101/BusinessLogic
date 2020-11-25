using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicTests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void InstantiateCourse_DefaultConstructor_AssignsDefaultInstructor()
        {
            //YOU MUST MODIFY THE COURSE CLASS TO GET THIS TO WORK
            //DO NOT MODIFY THIS TEST CODE
            Course c = new Course("CPW 215");

            const string DefaultInstructor = "STAFF";

            Assert.AreEqual(DefaultInstructor, c.InstructorName);
        }

        [TestMethod]
        [DataRow((byte)0)]
        [DataRow((byte)30)] //no more than 30 credits allowed
        [DataRow((byte)31)]
        [DataRow((byte)35)]
        public void SetCreditsProperty_InvalidCredits_ThrowsArgumentException(byte numCredits)
        {
            //DO NOT MODIFY THIS TEST CODE. THE COURSE CLASS MUST BE MODIFIED TO GET THE TEST TO PASS
            Course c = new Course("CPW 215");

            Assert.ThrowsException<ArgumentException>(() => c.NumberOfCredits = numCredits);
        }

        [TestMethod]
        [DataRow((byte)5)]
        public void SetCreditsProperty_ValidCredits_SetsValue(byte numCredits)
        {
            //DO NOT MODIFY THIS TEST CODE. THE COURSE CLASS MAY NEED TO BE MODIFIED TO GET THE TEST TO PASS
            Course c = new Course("CPW 215");
            c.NumberOfCredits = numCredits;
            Assert.AreEqual(c.NumberOfCredits, numCredits);
        }

        [TestMethod]
        public void SetCourseNameProperty_ToNull_ThrowsArgumentNullException()
        {
            //DO NOT MODIFY THIS TEST CODE. THE COURSE CLASS MUST BE MODIFIED TO GET THE TEST TO PASS
            Course c = new Course("CPW 215");
            Assert.ThrowsException<ArgumentNullException>(() => c.CourseName = null);
        }

        [TestMethod]
        [DataRow("CPW 219")]
        public void SetCourseNameProperty_ValidString_SetsCourseName(string courseName)
        {
            //DO NOT MODIFY THIS TEST CODE. THE COURSE CLASS MAY NEED TO BE MODIFIED TO GET THE TEST TO PASS
            Course c = new Course("CPW 215");
            c.CourseName = "CPW 219";
            Assert.AreEqual(c.CourseName, courseName);
        }
    }
}
