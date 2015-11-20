namespace SortingHomework.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LinearSearchTests
    {
        [TestMethod]
        public void LinearSearchShouldWorkCorrectlyWithEmptyCollection()
        {
            var collection = new SortableCollection<int>();
            collection.Sort(new MergeSorter<int>());
            var found = collection.LinearSearch(21);

            Assert.IsFalse(found, "Element is found in empty collection!");
        }

        [TestMethod]
        public void LinearSearchShouldWorkCorrectlyWhenSearchedElementIsFound()
        {
            var collection = new SortableCollection<int>(new int[] { 6, 1, 4, 2, 3, 21, -5, 8});
            collection.Sort(new MergeSorter<int>());
            var found = collection.LinearSearch(21);

            Assert.IsTrue(found, "Element is not found in collection!");
        }

        [TestMethod]
        public void LinearSearchShouldWorkCorrectlyWhenSearchedElementIsNotFound()
        {
            var collection = new SortableCollection<int>(new int[] { 6, 1, 4, 2, 3, -5, 8 });
            collection.Sort(new MergeSorter<int>());
            var found = collection.LinearSearch(21);

            Assert.IsFalse(found, "Element is found in collection!");
        }
    }
}
