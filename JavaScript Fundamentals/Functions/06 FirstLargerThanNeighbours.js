// Problem 6. First larger than neighbours

// Write a method that returns the index of the first element in array 
// that is larger than its neighbours, or -1, if there is no such element.
// Use the function from the previous task.

function solve(args) {
	var n = +args[0];
	var array = args[1].split(' ').map(function(num) {
		return +num;
	});

	var index,
		found = false;

	for (index = 1; index < n - 1; index += 1) {
		if (array[index - 1] < array[index] && array[index + 1] < array[index]) {
			found = true;
			return index;
		}
	}

	if (!found) {
		return -1;
	}
}