using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FinalAssignment.Test
{
    [TestFixture]
    class ValidateUserTestScript
    {
        private ValidateUser validator;

        [SetUp]
        public void Setup()
        {
            validator = new ValidateUser();
        }

        [Test]
        public void ValidateUser_ValidCredentials()
        {
            // Arrange
            string username = "hammy79826";
            string password = "hammad@220704";

            // Act
            bool result = validator.validateUser(username, password);

            //result = true;
            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidateUser_InvalidUsername()
        {
            // Arrange
            string username = "invalidUser";
            string password = "hammad@220704";

            // Act
            bool result = validator.validateUser(username, password);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateUser_InvalidPassword()
        {
            // Arrange
            string username = "hammy79826";
            string password = "invalidPassword";

            // Act
            bool result = validator.validateUser(username, password);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateAnswer_ValidAnswer()
        {
            // Arrange
            string username = "hammy79826";
            string answer = "Kiara";

            // Act
            bool result = validator.validateAnswer(answer, username);

            //result = true;
            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidateAnswer_InvalidAnswer()
        {
            // Arrange
            string username = "hammy79826";
            string answer = "Friday";

            // Act
            bool result = validator.validateAnswer(answer, username);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
