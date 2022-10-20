using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Controller;
using TaskApp.IService;
using TaskApp.Service;

namespace TaskAppTest
{
    public class TaskControllerTest
    {
        //In this Controller test only calculate the end date.
        //So I validate the what is the given in put in console level,
        //therefore I dont include the input type and length validation test in this controller

        private readonly TimeCalculationController _controller;
        private readonly IHolydayService_22 _service;

        public TaskControllerTest()
        {
            _service = new HolydayService_22();
            _controller = new TimeCalculationController(_service);
        }
        [Fact]
        public void Should_Return_Request_EndDate()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("2022-09-11");
            //Act
            var endDate = _controller.CalculateEndDate(date, "5");

            //Assert
            Assert.Equal("2022-9-16", endDate);

        }
        [Fact]
        public void Should_Return_Incremented_Month()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("2022-09-29");
            //Act
            var endDate = _controller.CalculateEndDate(date, "5");

            //Assert
            Assert.Equal("2022-10-6", endDate);

        }
        [Fact]
        public void Should_Return_Incremented_Year()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("2022-12-29");
            //Act
            var endDate = _controller.CalculateEndDate(date, "5");

            //Assert
            Assert.Equal("2023-1-5", endDate);

        }

        [Fact]

        public void check_if_date_is_null_then_calculate_end_date()
        {
            //Arrange
            DateTime defaultDate = new DateTime();

            //Act
            var endDate = _controller.CalculateEndDate(defaultDate, "5");

            //Assert
            //Expected value is must change, because if date empty I consider act as today date
            Assert.Equal("2022-11-1", endDate);

        }

    }
}
