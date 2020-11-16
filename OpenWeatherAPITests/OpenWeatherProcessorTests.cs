using OpenWeatherAPI;
using System;
using System.Threading.Tasks;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {
        OpenWeatherProcessor _sut = OpenWeatherProcessor.Instance;



        [Fact]
        public async Task GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            ApiHelper.InitializeClient();

            _sut.ApiKey = null;

            await Assert.ThrowsAsync<ArgumentException>(() => _sut.GetOneCallAsync());

        }
        [Fact]
        public async Task GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            ApiHelper.InitializeClient();

            _sut.ApiKey = null;

            await Assert.ThrowsAsync<ArgumentException>(() => _sut.GetCurrentWeatherAsync());

        }
        [Fact]
        public async Task GetOneCallAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            ApiHelper.ApiClient = null;

            _sut.ApiKey = "test";

            await Assert.ThrowsAsync<ArgumentException>(() => _sut.GetOneCallAsync());

        }
        [Fact]
        public async Task GetCurrentWeatherAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            ApiHelper.ApiClient = null;

            _sut.ApiKey = "test";

            await Assert.ThrowsAsync<ArgumentException>(() => _sut.GetCurrentWeatherAsync());

        }


    }
}
