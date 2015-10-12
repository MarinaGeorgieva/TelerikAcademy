namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    
    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
         // : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void DetailsShouldWorkCorrectlyWithValidId()
        {
            var model = (Car)this.GetModel(() => this.controller.Details(1));

            Assert.IsNotNull(model);
            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DetailsShouldThrowArgumentNullExceptionWithIdOutsideLeftBoundary()
        {
            var model = (Car)this.GetModel(() => this.controller.Details(0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DetailsShouldThrowArgumentNullExceptionWithIdOutsideRightBoundary()
        {
            var model = (Car)this.GetModel(() => this.controller.Details(8));
        }

        [TestMethod]
        public void SearchingCarsByMakeShouldWorkCorrectly()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Search("Bmw"));

            Assert.IsNotNull(model);
            Assert.AreEqual(2, model.Count);

            Assert.AreEqual("BMW", model[0].Make);
            Assert.AreEqual("BMW", model[1].Make);
        }

        [TestMethod]
        public void SearchingCarsByModelShouldWorkCorrectly()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Search("Astra"));

            Assert.IsNotNull(model);
            Assert.AreEqual(1, model.Count);
            Assert.AreEqual("Astra", model[0].Model);
        }

        [TestMethod]
        public void SearchingCarsShouldReturnNothingIfWrongSearchCondition()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Search("Toyota"));

            Assert.IsNotNull(model);
            Assert.AreEqual(0, model.Count);
        }

        [TestMethod]
        public void SearchingCarsShouldReturnAllCarsIfSearchConditionIsNull()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Search(null));

            Assert.IsNotNull(model);
            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        public void SearchingCarsShouldReturnAllCarsIfSearchConditionIsEmpty()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Search(""));

            Assert.IsNotNull(model);
            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortingCarsShouldThrowArgumentExceptionIfParameterIsNull()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Sort(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortingCarsShouldThrowArgumentExceptionIfParameterIsEmpty()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Sort(""));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortingCarsShouldThrowArgumentExceptionIfParameterIsInvalid()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Sort("model"));
        }

        [TestMethod]
        public void SortingCarsByMakeShouldWorkCorrectly()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.IsNotNull(model);
            Assert.AreEqual(4, model.Count);

            Assert.AreEqual("Audi", model[0].Make);
            Assert.AreEqual("BMW", model[1].Make);
            Assert.AreEqual("BMW", model[2].Make);
            Assert.AreEqual("Opel", model[3].Make);
        }

        [TestMethod]
        public void SortingCarsByYearShouldWorkCorrectly()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.IsNotNull(model);
            Assert.AreEqual(4, model.Count);

            Assert.AreEqual(2010, model[0].Year);
            Assert.AreEqual(2008, model[1].Year);
            Assert.AreEqual(2007, model[2].Year);
            Assert.AreEqual(2005, model[3].Year);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
