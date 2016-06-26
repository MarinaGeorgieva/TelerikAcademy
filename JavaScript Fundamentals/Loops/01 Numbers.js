// Problem 1. Numbers

// Write a script that prints all the numbers from 1 to N.

function solve(args) {
	var n = +args[0],
		result = '';

	for (var i = 1; i <= n; i++) {
		result += i + ' ';
	}

	return result;
}