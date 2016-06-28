// Problem 6. Most frequent number

// Write a program that finds the most frequent number in an array of N elements.

function solve(args) {
	var array = args[0].split('\n').map(function(num) {
		return +num;
	});

	var n = array.shift(),
		i,
		occurrences = {},
		maxCount = 1,
		maxNumber;

	for (i = 0; i < n; i += 1) {
		occurrences[array[i]] = (occurrences[array[i]] || 0) + 1;

		if (maxCount < occurrences[array[i]]) {
			maxCount = occurrences[array[i]];
			maxNumber = array[i];
		}
	}

	return maxNumber + ' (' + maxCount + ' times)';
}