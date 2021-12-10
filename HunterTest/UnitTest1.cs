using HunterMovies.Interfaces;
using HunterMovies.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HunterTest
{
    [TestClass]
    public class UnitTest1
    {
        private IMovie movieServices;

        public UnitTest1(IMovie _movieServices)
        {
            movieServices = _movieServices;
        }
        [TestMethod]
        public void GetMovies()
        {
            var response = movieServices.getMovies();
            Assert.IsNotNull(response);
        }
    }
}
