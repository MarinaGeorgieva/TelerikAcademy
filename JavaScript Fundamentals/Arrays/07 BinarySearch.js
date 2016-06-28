// Problem 7. Binary search

// Write a program that finds the index of given element X 
// in a sorted array of N integers by using the Binary search algorithm.

function solve(args) {
	var array = args[0].split('\n').map(function(num) {
		return +num;
	});

	var n = array.shift(),
		x = array.pop();

	var minIndex = 0,
		maxIndex = n - 1;

	while (minIndex <= maxIndex) {
		var midIndex = ((minIndex + maxIndex) / 2) | 0;
		if (array[midIndex] === x) {
			return midIndex;
		} else if (array[midIndex] < x) {
			minIndex = midIndex + 1;
		} else {
			maxIndex = midIndex - 1;
		}
	}

	return -1;
}

// function binarySearch(array, element) {
// 	var minIndex = 0,
// 		maxIndex = array.length - 1;

// 	while (minIndex <= maxIndex) {
// 		var midIndex = ((minIndex + maxIndex) / 2) | 0;
// 		if (array[midIndex] === element) {
// 			return midIndex; // element found
// 		} else if (array[midIndex] < element) {
// 			minIndex = midIndex + 1;
// 		} else {
// 			maxIndex = midIndex - 1;
// 		}
// 	}

// 	return -1; // element not found
// }

// console.log(binarySearch([1, 2, 3, 4, 5, 6, 7, 8, 10, 16, 27], 6));
// console.log(binarySearch([1, 2, 3, 4, 5, 6, 7, 8, 10, 16, 27], 27));
// console.log(binarySearch([1, 2, 3, 4, 5, 6, 7, 8, 10, 16, 27], 15));
// console.log(binarySearch([1, 2, 3, 4, 5, 6, 7, 8, 10, 16, 27], 0));