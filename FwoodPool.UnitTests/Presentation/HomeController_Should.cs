using FwoodPool.Presentation.Controllers;
using NUnit.Framework;
using System.Web.Mvc;

namespace FwoodPool.UnitTests.Presentation
{
    [TestFixture]
    public class HomeController_Should
    {
        private HomeController _sut;

        [SetUp]
        public void Init()
        {
            _sut = new HomeController();
        }

        [Test]
        public void Index_ReturnTheCorrectView()
        {
            var viewResult = _sut.Index() as ViewResult;

            Assert.AreEqual(string.Empty, viewResult.ViewName);
        }

        [Test]
        public void Rules_ReturnTheCorrectView()
        {
            var viewResult = _sut.Rules() as ViewResult;

            Assert.AreEqual(string.Empty, viewResult.ViewName);
        }

        [Test]
        public void Constitution_ReturnTheCorrectView()
        {
            var viewResult = _sut.Constitution() as ViewResult;

            Assert.AreEqual(string.Empty, viewResult.ViewName);
        }

        [Test]
        public void About_ReturnTheCorrectView()
        {
            var viewResult = _sut.About() as ViewResult;

            Assert.AreEqual(string.Empty, viewResult.ViewName);
        }

        [Test]
        public void Contact_ReturnTheCorrectView()
        {
            var viewResult = _sut.Contact() as ViewResult;

            Assert.AreEqual(string.Empty, viewResult.ViewName);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
