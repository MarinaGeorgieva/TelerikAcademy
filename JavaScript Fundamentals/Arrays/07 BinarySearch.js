// Problem 7. Binary search

// Write a script that finds the index of given element in a 
// sorted array of integers by using the binary search algorithm.

function binarySearch(array, element) {
	var minIndex = 0,
		maxIndex = array.length - 1;

	while (minIndex <= maxIndex) {
		var midIndex = ((minIndex + maxIndex) / 2) | 0;
		if (array[midIndex] === element) {
			return midIndex; // element found
		}
		else if (array[midIndex] < element) {
			minIndex = midIndex + 1;
		}
		else {
			maxIndex = midIndex - 1;
		}
	}

	return -1; // element not found
}

console.log(binarySearch([1, 2, 3, 4, 5, 6, 7, 8, 10, 16, 27], 6));
console.log(binarySearch([1, 2, 3, 4, 5, 6, 7, 8, 10, 16, 27], 27));
console.log(binarySearch([1, 2, 3, 4, 5, 6, 7, 8, 10, 16, 27], 15));
console.log(binarySearch([1, 2, 3, 4, 5, 6, 7, 8, 10, 16, 27], 0));