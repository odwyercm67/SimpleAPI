using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController forecastController = new WeatherForecastController(null);

        [Fact]
        public void GetForecastCountTest()
        {
            List<WeatherForecast> forecasts = forecastController.Get().ToList();

            Assert.Equal(5, forecasts.Count);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
