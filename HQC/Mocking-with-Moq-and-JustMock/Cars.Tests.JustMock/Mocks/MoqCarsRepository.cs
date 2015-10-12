namespace Cars.Tests.JustMock.Mocks
{
    using Cars.Contracts;
    using Cars.Models;
    using Moq;
    using System.Linq;

    public class MoqCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();
            mockedCarsRepository.Setup(r => r.Add(It.IsAny<Car>())).Verifiable();
            mockedCarsRepository.Setup(r => r.Remove(It.IsAny<Car>())).Verifiable();
            mockedCarsRepository.Setup(r => r.All()).Returns(this.FakeCarCollection);
            mockedCarsRepository.Setup(r => r.Search(It.IsAny<string>()))
                .Returns(this.FakeCarCollection.ToList());
            mockedCarsRepository.Setup(r => r.Search(It.IsNotNull<string>()))
                .Returns((string search) => this.FakeCarCollection
                    .Where(c => c.Make.ToLower() == search.ToLower() || c.Model.ToLower() == search.ToLower()).ToList());
            mockedCarsRepository.Setup(r => r.GetById(It.IsInRange(0, this.FakeCarCollection.Count, Range.Exclusive)))
                .Returns((int id) => this.FakeCarCollection.Where(c => c.Id == id).First());
            mockedCarsRepository.Setup(r => r.GetById(It.IsInRange(int.MinValue, 0, Range.Inclusive)))
                .Verifiable();
            mockedCarsRepository.Setup(r => r.GetById(It.IsInRange(this.FakeCarCollection.Count, int.MaxValue, Range.Inclusive)))
                .Verifiable();
            mockedCarsRepository.Setup(r => r.SortedByMake()).Returns(this.FakeCarCollection.OrderBy(c => c.Make).ToList());
            mockedCarsRepository.Setup(r => r.SortedByYear()).Returns(this.FakeCarCollection.OrderByDescending(c => c.Year).ToList());
            this.CarsData = mockedCarsRepository.Object;
        }
    }
}
