// Problem 6. Most frequent number

// Write a script that finds the most frequent number in an array.

var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
	counter = 1,
	maxCounter = 1,
	number,
	maxNumber;

for (var index = 0; index < array.length - 1; index += 1) {
	number = array[index];
	for (var j = index + 1; j < array.length; j += 1) {
		if (number === array[j]) {
			counter += 1;
		}
	}

	if (counter > maxCounter) {
		maxCounter = counter;
		maxNumber = number;
	}
	counter = 1;
}

console.log('Most frequent number is ' + maxNumber + ' (' + maxCounter + ' times)');