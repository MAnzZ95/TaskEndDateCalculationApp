using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Common;
using TaskApp.IService;

namespace TaskAppTest
{
    public class CommonValidateTest
    {
        private readonly IValidate _validate;

        public CommonValidateTest()
        {
            _validate = new Validate();
        }

        [Theory]
        [InlineData("2022-12-12")]
        [InlineData("2022-2-28")]        
        public void shoud_valid_Date(string value)
        {
         
            //Act
            var isvalidDate = _validate.IsValidDate(value);

            //Assert
            Assert.True(isvalidDate);

        }

        // [Fact]
        [Theory]
        [InlineData("2022-13-12")]
        [InlineData("2022-1-32")]
        [InlineData("2022-13-42")]
        [InlineData("2022-2-29")]
        public void shoud_not_valid_Date(string value)
        {

            //Act
            var isvalidDate = _validate.IsValidDate(value);

            //Assert
            Assert.False(isvalidDate);

        }

        [Theory]
        [InlineData("5")]
        [InlineData("30")]
        public void shoud_valid_NumberOfDate(string value)
        {

            //Act
            var isvalidNoofDate = _validate.IsValidNumberofDays(value);

            //Assert
            Assert.True(isvalidNoofDate);

        }

        [Theory]
        [InlineData("-5")]
        [InlineData("31")]
        public void shoud_not_valid_NumberOfDate(string value)
        {

            //Act
            var isvalidNoofDate = _validate.IsValidNumberofDays(value);

            //Assert
            Assert.False(isvalidNoofDate);

        }

    }
}
