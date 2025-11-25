using Inlämningsuppgift_1.Data.Interfaces;
using Inlämningsuppgift_1.Services;
using Moq;

namespace Inlämningsuppgift_1.Tests.Services
{
    public class UserServiceTests
    {
        [Fact]
        public void Register_AddsUser_WhenUsernameNotTaken()
        {
            // Arrange
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(uow => uow.Users.GetAllUsers()).Returns(new List<User>());

            var service = new UserService(mockRepo.Object);

            // Act
            var result = service.Register("newuser", "pass", "email@example.com");

            // Assert
            Assert.True(result);
            mockRepo.Verify(uow => uow.Users.AddUser(It.Is<User>(u => u.Username == "newuser" && u.Email == "email@example.com")), Times.Once);
        }

        [Fact]
        public void Register_ReturnsFalse_WhenUsernameAlreadyExists()
        {
            // Arrange

            var existing = new User { Id = 1, Username = "Alice", Password = "p", Email = "a@e" };
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(Uow => Uow.Users.GetAllUsers()).Returns(new List<User> { existing });

            var service = new UserService(mockRepo.Object);

            // Act
            var result = service.Register("alice", "x", "e@e");

            // Assert
            Assert.False(result);
            mockRepo.Verify(Uow => Uow.Users.AddUser(It.IsAny<User>()), Times.Never);
        }

        [Fact]
        public void Login_ReturnsTokenAndSaves_WhenCredentialsValid()
        {
            // Arrange
            var user = new User { Id = 2, Username = "bob", Password = "pwd", Email = "b@e" };
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(uow => uow.Users.GetAllUsers()).Returns(new List<User> { user });

            var service = new UserService(mockRepo.Object);

            // Act
            var token = service.Login("bob", "pwd");

            // Assert
            Assert.False(string.IsNullOrWhiteSpace(token));
            Assert.StartsWith("token-", token);
            mockRepo.Verify(uow => uow.Users.SaveToken(token, user.Id), Times.Once);
        }

        [Fact]
        public void Login_ReturnsNull_WhenInvalidCredentials()
        {
            // Arrange
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(uow => uow.Users.GetAllUsers()).Returns(new List<User>());

            var service = new UserService(mockRepo.Object);

            // Act
            var token = service.Login("no", "user");

            // Assert
            Assert.Null(token);
            mockRepo.Verify(uow => uow.Users.SaveToken(It.IsAny<string>(), It.IsAny<int>()), Times.Never);
        }

        [Fact]
        public void GetUserByToken_DelegatesToRepository()
        {
            // Arrange
            var user = new User { Id = 3, Username = "u", Email = "u@e" };
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(uow => uow.Users.GetUserByToken("t")).Returns(user);

            var service = new UserService(mockRepo.Object);

            // Act
            var result = service.GetUserByToken("t");

            // Assert
            Assert.Equal(user, result);
        }

        [Fact]
        public void GetById_DelegatesToRepository()
        {
            // Arrange
            var user = new User { Id = 4, Username = "iduser", Email = "x@x" };
            var mockRepo = new Mock<IUnitOfWork>();
            mockRepo.Setup(uow => uow.Users.GetById(4)).Returns(user);

            var service = new UserService(mockRepo.Object);

            // Act
            var result = service.GetById(4);

            // Assert
            Assert.Equal(user, result);
        }
    }
}
