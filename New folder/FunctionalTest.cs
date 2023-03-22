using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FindingACourse
{
    //Add required NUnit test attribute
    
    class FunctionalTest
    {
        Program p =new Program();
        //Add required test methods
        [Test]
        public void Fun1()
        {
            Assert.AreEqual("Invalid" ,p.ValidateNoOfCourse(0));
            Assert.AreEqual("Invalid" ,p.ValidateNoOfCourse(21));
            Assert.AreEqual("Valid" ,p.ValidateNoOfCourse(20));
        }
        [Test]
        public void Fun2()
        {
            String[] course=new String[3]{"CSE","ME","AGR"};
            Assert.AreEqual("Available" ,p.SearchCourse(course,"ME"));
            Assert.AreEqual("Not Available" ,p.SearchCourse(course,""));
        }
        
    }
}
