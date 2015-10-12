// Problem 5. Appearance count

// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.

function countAppearance(array, number) {
	number = +number;
	var counter = 0,
		index,
		len;

	for (index = 0, len = array.length; index < len; index += 1) {
		if (number === array[index]) {
			counter++;
		}
	}

	return counter;
}

function test(array, number, result) {
	result = +result;

	return countAppearance(array, number) === result;
}

var array = [2, 1, 8, 10, 7, 2, 5, 2, 2, 3, 6, 2];

console.log('Result: ' + countAppearance(array, 2));
console.log('Tested result: ' + test(array, 2, 5));