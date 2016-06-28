// Problem 7. Sorting array

// Write a method that returns the maximal element in a portion of array of integers starting at given index. 
// Using it write another method that sorts an array in ascending / descending order. 
// Write a program that sorts a given array.

function solve(args) {
	var n = +args[0];
	var array = args[1].split(' ').map(function(num) {
		return +num;
	});

	var sortedArray = sortDescending(array);
	return sortedArray.reverse().join(' ');

	function getMaxElement(array, start) {
		var maxElement = array[start];
		for (var i = start; i < n; i += 1) {
			if (maxElement < array[i]) {
				maxElement = array[i];
			}
		}

		return maxElement;
	}

	function sortDescending(array) {
		var i,
			currentMaxElement,
			currentMaxElementIndex,
			temp;

		for (i = 0; i < n; i += 1) {
			currentMaxElement = getMaxElement(array, i);
			currentMaxElementIndex = array.indexOf(currentMaxElement, i);
			temp = array[currentMaxElementIndex];
			array[currentMaxElementIndex] = array[i];
			array[i] = temp;
		}

		return array;
	}
}

console.log(solve(['6', '3 4 1 5 2 6']));