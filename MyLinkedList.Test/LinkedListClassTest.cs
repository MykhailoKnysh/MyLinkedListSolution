using NUnit.Framework;

namespace MyLinkedList.Test
{
    public class LinkedListClassTest : MyListBase
    {
        [Test]
        public override void AddByIndex_WhenInpuIsNotValid_ShouldThrowIndexOutOfRangeException(int index, int value, int[] result)
        {
            throw new System.NotImplementedException();
        }

        public override void AddByIndex_WhenInputIsValid_ShouldAddItToCollection(int index, int valueToInsert, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void AddRangeByIndex_WhenInpuISValued_ShouldThrowArgumentException(int index, int[] insertCollection, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void AddRangeByIndex_WhenInputIsValued_ShouldAddItToCollection(int index, int[] collectionToInsert, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void AddRangeStart_WhenInputIsValued_ShouldAddItToCollection(int[] collectionToInsert, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void AddRange_WhenInputIsValued_ShouldAddItToCollection(int[] collectionToInsert, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void Add_WhenInputIsValid_ShouldAddItToCollection(int valueToInsert, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void FindIndexByValue_WhenValidIndexPassed_ShouldReturnIndex(int valueToInsert, int expectedIndex, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMaxIndex_WhenInputIsNotValid_ShouldThrowInvalidOperationExeption(int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMaxIndex_WhenInputIsNotValid_ShouldThrowNullReferenceExeption(int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMaxIndex_WhenInputIsValued_ShouldFindIndexMaxElement(int expectedIndex, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMax_WhenInputIsValued_ShouldFindMaxElement(int expectedMax, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMinIndex_WhenInputIsNotValid_ShouldThrowInvalidOperationInvalidOperationExeption(int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMinIndex_WhenInputIsNotValid_ShouldThrowNullReferenceExeption(int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMinIndex_WhenInputIsValid_ShouldFindIndexMinElement(int expectedIndex, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void GetMin_WhenInputIsValued_ShouldFindMaxElement(int expectedMin, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void HalfReverse_WhenValidListPassed_ShouldReverseListByHalves(int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void HalfReverse_WhenValidListPassed_ShouldReverseListByHalves(int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveByIndex_WhenIndexOutOfRange_ShouldThrowArgumentOutOfRangeException(int index, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveByIndex_WhenIndexOutOfRange_ShouldThrowIndexOutOfRangeException(int index, int quantity, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveByIndex_WhenIndexOutOfRange_ShouldThrowInvalidOperationException(int index, int quantity, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveByIndex_WhenIndexOutOfRange_ShouldThrowInvalidOperationException(int quantity, int[] inputArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveByIndex_WhenValidIndexPassed_ShouldDeleteElementByPosition(int index, int expectedValueToRemove, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveByValueAll_WhenValidIndexPassed_ShouldRemoveFirstValue(int valueToRemove, int expectedCounter, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveByValueFirst_WhenValidIndexPassed_ShouldRemoveFirstValue(int valueToRemove, int expectedIndex, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveRangeByIndex_WhenValidIndexPassed_ShouldRemoveRangeByIndex(int index, int quantity, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveRangeStart_WhenValidIndexPassed_ShouldRemoveRangeStart(int quantity, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveStart_WhenIndexOutOfRange_ShouldThrowArgumentOutOfRangeException()
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveStart_WhenValidIndexPassed_ShouldDeleteFirstElement(int expectedValueToRemove, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void Remove_WhenIndexOutOfRange_ShouldThrowArgumentOutOfRangeException()
        {
            throw new System.NotImplementedException();
        }

        public override void Remove_WhenValidIndexPassed_ShouldDeleteLastElement(int expectedValueToRemove, int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void Reverse_WhenValidListPassed_ShouldReverseList(int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void SortDesc_WhenCollectionIsUnsorted_ShouldSortCollectionInDescendingOrder(int[] inputArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        public override void Sort_WhenCollectionIsUnsorted_ShouldSortCollectionInAscendingOrder(int[] inpuatArray, int[] expectedArray)
        {
            throw new System.NotImplementedException();
        }

        [TestCase(new int[] { 6, 7, 2, 1, 5, 3, 4, 10, 8, 9 }, "6 7 2 1 5 3 4 10 8 9")]
        public override void ToString_WhenCollectionIsValued_ShouldConvertCollectionToString(
          int[] inputArray, string expectedString)
        {
            LinkedListClass<int> actualList = new LinkedListClass<int>(inputArray);

            string actualString = actualList.ToString();

            Assert.AreEqual(expectedString, actualString);
        }
    }
}