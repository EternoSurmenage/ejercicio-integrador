using System;
using Xunit;
using ArticlesAPI.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using ArticlesAPI.Contracts;
using ArticlesTests.ClassData;
using ArticlesAPI.Exceptions;

namespace ArticlesTests
{
    public class IsDateInputValidTest
    {
        private readonly ValidatorService validatorService;
        string start = "2010-06-01";
        string end = "2016-08-01";

        public IsDateInputValidTest()
        {
            validatorService = new ValidatorService();
        }

        [Fact]
        public void WhenProperlyCalledReturnsWithoutExceptions()
        {
            // Arrange
            DateTime? startDate = new DateTime(2017, 1, 18);
            DateTime? endDate = DateTime.Now;

            // Action
            var exception = Record.Exception(() =>
                {
                    this.validatorService.IsDateInputValid(startDate, endDate);
                });

            //Assert   
            Assert.Null(exception);
        }

        [Theory, ClassData(typeof(EmptyDateInputClassData))]
        public void WhenDatesAreEmptyReturnsException(DateTime? firstDate, DateTime? endDate)
        {
            // Arrange

            // Action

            // Assert 
            Assert.Throws<BadRequestException>(() => validatorService.IsDateInputValid(firstDate, endDate));
        }

        [Theory, ClassData(typeof(InvalidDateRangeClassData))]
        public void WhenInvalidDateRangeReturnsException(DateTime? firstDate, DateTime? endDate)
        {
            // Arrange

            // Action

            // Assert 
            Assert.Throws<BadRequestException>(() => validatorService.IsDateInputValid(firstDate, endDate));
        }

        [Theory, ClassData(typeof(FutureDateClassData))]
        public void WhenDatesAreFutureReturnsException(DateTime? firstDate, DateTime? endDate)
        {
            // Arrange

            // Action

            // Assert 
            Assert.Throws<BadRequestException>(() => validatorService.IsDateInputValid(firstDate, endDate));
        }
    }


}

