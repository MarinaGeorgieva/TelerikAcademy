// Problem 1. Reverse string

// Write a JavaScript function that reverses a string and returns it.

function reverse(str) {
	var reversed = [];

	for (var index = str.length - 1; index >= 0; index -= 1) {
		reversed.push(str[index]);
	}

	return reversed.join('');
}

console.log(reverse('sample'));