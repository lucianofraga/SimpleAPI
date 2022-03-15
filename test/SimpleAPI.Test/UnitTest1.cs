using System;
using System.Linq;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        private WeatherForecastController _weatherForecastCtrl = new WeatherForecastController(null);

        [Fact]
        public void GetAllWeatherForecast()
        {
            var result = _weatherForecastCtrl.Get();
            Assert.Equal(result.Any(), true);
        }
    }
}
