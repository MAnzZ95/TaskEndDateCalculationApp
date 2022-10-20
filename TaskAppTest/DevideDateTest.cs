using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Common;

namespace TaskAppTest
{
    public class DevideDateTest
    {
        /// <summary>
        /// In this case in programe.cs class check first date is valid format and verify it validity
        /// If date is valid only, we can access on this class therefor I don't check in this case string date is 
        /// not valid or not
        /// </summary>
        private readonly IDevideDate _devideDate;

        public DevideDateTest()
        {
            _devideDate = new DevideDate();
        }
        [Fact]
        public void return_value_is_correct_Day()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("2022-10-29");
            //Act
            int expectData=_devideDate.getDayfromDate(date);
            //Assert
            Assert.Equal(29, expectData);  
        }
        [Fact]
        public void return_value_is_not_correct_Day()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("2022-10-29");
            //Act
            int expectData = _devideDate.getDayfromDate(date);
            //Assert
            Assert.NotEqual(30, expectData);
        }

        [Fact]
        public void return_value_is_correct_Month()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("2022-10-29");
            //Act
            int expectData = _devideDate.getMonthfromDate(date);
            //Assert
            Assert.Equal(10, expectData);
        }

        [Fact]
        public void return_value_is_not_correct_Month()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("2022-10-29");
            //Act
            int expectData = _devideDate.getMonthfromDate(date);
            //Assert
            Assert.NotEqual(12, expectData);
        }

        [Fact]
        public void return_value_is_correct_Year()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("2022-10-29");
            //Act
            int expectData = _devideDate.getYearfromDate(date);
            //Assert
            Assert.Equal(2022, expectData);
        }

        [Fact]
        public void return_value_is_not_correct_Year()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("2022-10-29");
            //Act
            int expectData = _devideDate.getYearfromDate(date);
            //Assert
            Assert.NotEqual(2023, expectData);
        }

    }
}
