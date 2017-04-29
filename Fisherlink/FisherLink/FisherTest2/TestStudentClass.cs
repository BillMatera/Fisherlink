using FisherLink.Models;
using System;
using Xunit;

namespace FisherTest2
{
    public class TestStudentClass
    {
        [Fact]
        public void Test1()
        {
            //Define a new student, add data, then test data exists in Student object.

            //Arrange
            var Student = new Student
            {
                ID = 1,
                LastName = "Matera",
                FirstMidName = "Bill"
            };

            //Assert
            Assert.NotNull(Student);   //Does Student exist?
            Assert.Equal("Matera", Student.LastName);  //Is last name correct?
            Assert.Equal("Bill", Student.FirstMidName);  //Is first name correct?
        }
    }
}