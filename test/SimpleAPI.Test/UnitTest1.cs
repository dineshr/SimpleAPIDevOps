using Xunit;
using SchoolApp.Controllers;
using SchoolApp.Services;
using SimpleAPI.Controllers;
using Microsoft.AspNetCore.Mvc.Core;




namespace SimpleAPI.Test
{

    public class UnitTest1
    {
        // EnvironmentVariableTarget repoMock = new Mock<ClassroomService>();

        private readonly static IClassroomService _classroomService = null;
        ClassRoomController controller = new ClassRoomController(_classroomService);


        [Fact]
        public void GetReturnsSomethingString_ShouldReturnValue()
        {
            //Arrange

            var returnValue = controller.Get(3);
            Assert.Equal("Something goes here with id: 3", returnValue.Value);

        }




    }
}
