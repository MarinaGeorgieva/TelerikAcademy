// Problem 5. Selection sort

// Sorting an array means to arrange its elements in increasing order. 
// Write a program to sort an array. 
// Use the Selection sort algorithm: Find the smallest element, 
// move it at the first position, find the smallest from the rest, 
// move it at the second position, etc.

function solve(args) {
	var array = args[0].split('\n').map(function(num) {
		return +num;
	});

	var n = array.shift(),
		i, j;

	for (i = 0; i < n - 1; i += 1) {
		var currentMin = i;
		for (j = i + 1; j < n; j += 1) {
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

	return array.join('\n')
}

console.log(solve(['6\n3\n4\n1\n5\n2\n6']))

// function selectionSort(array) {
// 	for (var i = 0; i < array.length - 1; i += 1) {
// 		var currentMin = i;
// 		for (j = i + 1; j < array.length; j += 1) {
// 			if (array[j] < array[currentMin]) {
// 				currentMin = j;
// 			}
// 		}

// 		if (currentMin !== i) {
// 			var temp = array[i];
// 			array[i] = array[currentMin];
// 			array[currentMin] = temp;
// 		}
// 	}

// 	console.log(array);
// }

// selectionSort([4, 1, 7, 30, 9, 26, 13, 8, 5, 3, 27, 10]);