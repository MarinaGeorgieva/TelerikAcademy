// Problem 5. Selection sort

// Sorting an array means to arrange its elements in increasing order.
// Write a script to sort an array.
// Use the selection sort algorithm: Find the smallest element, 
// move it at the first position, find the smallest from the rest, 
// move it at the second position, etc.

function selectionSort(array) {
	for (var i = 0; i < array.length - 1; i += 1) {
		var currentMin = i;
		for (j = i + 1; j < array.length; j += 1) {
			if (array[j] < array[currentMin]) {
				currentMin = j;
			}
		}

		if (currentMin !== i) {
			var temp = array[i];
			array[i] = array[currentMin];
			array[currentMin] = temp;
		}
	}

	console.log(array);
}

selectionSort([4, 1, 7, 30, 9, 26, 13, 8, 5, 3, 27, 10]);