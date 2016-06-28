// Problem 5. Larger than neighbours

// Write a method that checks if the element at given position in given array of integers is 
// larger than its two neighbours (when such exist). 
// Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

function solve(args) {
	var n = +args[0];
	var array = args[1].split(' ').map(function(num) {
		return +num;
	});

	var pos,
		isBigger,
		counter = 0;

	for (pos = 1; pos < n - 1; pos += 1) {
		// isBigger = isBiggerThanNeighbours(array, pos);

		// if (isBigger) {
		// 	counter += 1;
		// }

		isBigger = false;

		if (array[pos - 1] < array[pos] && array[pos + 1] < array[pos]) {
			isBigger = true;
			counter += 1;
		}
	}

	return counter;
}

function isBiggerThanNeighbours(array, pos) {
	if (array[pos - 1] < array[pos] && array[pos + 1] < array[pos]) {
		return true;
	}

	return false;
}

console.log(solve(['6', '-26 -25 -28 31 2 27']));