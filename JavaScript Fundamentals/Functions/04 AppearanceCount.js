// Problem 4. Appearance count

// Write a method that counts how many times given number appears in a given array. 
// Write a test program to check if the method is working correctly.

function solve(args) {
	var n = +args[0],
		x = +args[2],
		array = args[1].split(' ').map(function(num) {
			return +num;
		});

	var counter = 0,
		index;

	for (index = 0; index < n; index += 1) {
		if (x === array[index]) {
			counter += 1;
		}
	}

	return counter;
}

// function countAppearance(array, number) {
// 	number = +number;
// 	var counter = 0,
// 		index,
// 		len;

// 	for (index = 0, len = array.length; index < len; index += 1) {
// 		if (number === array[index]) {
// 			counter++;
// 		}
// 	}

// 	return counter;
// }

// function test(array, number, result) {
// 	result = +result;

// 	return countAppearance(array, number) === result;
// }

// var array = [2, 1, 8, 10, 7, 2, 5, 2, 2, 3, 6, 2];

// console.log('Result: ' + countAppearance(array, 2));
// console.log('Tested result: ' + test(array, 2, 5));