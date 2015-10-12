// Problem 6. Larger than neighbours

// Write a function that checks if the element at given position 
// in given array of integers is bigger than its two neighbours (when such exist).

function isBiggerThanNeighbours(array, pos) {
	var isBigger = false;

	if (pos <= 0 || pos >= array.length - 1) {
		return 'Invalid position!';
	}
	else {
		if (array[pos - 1] < array[pos] && array[pos + 1] < array[pos]) {
			isBigger = true;
		}
	}

	return isBigger;
}

console.log(isBiggerThanNeighbours([5, 7, 2], 1));
console.log(isBiggerThanNeighbours([1, 2, 3, 4], 2));
console.log(isBiggerThanNeighbours([8, 17, 6], 0));