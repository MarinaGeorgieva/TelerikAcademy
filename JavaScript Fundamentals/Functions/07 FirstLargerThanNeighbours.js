// Problem 7. First larger than neighbours

// Write a function that returns the index of the first element 
// in array that is larger than its neighbours or -1, if there’s no such element.
// Use the function from the previous exercise.

function getFirstLargerThanNeighbours(array) {
	var found = false,
		index,
		len;

	for (index = 0, len = array.length; index < len; index += 1) {
		if (array[index - 1] < array[index] && array[index] > array[index + 1]) {
			found = true;
			return index;
		}
	}

	if (!found) {
		return -1;
	}
}

console.log(getFirstLargerThanNeighbours([1, 4, 5, 7, 16, 3, 8, 6, 2, 27, 9]));