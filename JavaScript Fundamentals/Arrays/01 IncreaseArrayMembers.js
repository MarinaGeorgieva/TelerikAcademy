// Problem 1. Increase numbers members

// Write a program that allocates numbers of N integers, 
// initializes each element by its index multiplied by 5 
// and then prints the obtained numbers on the console.

function solve(args) {
	var n = +args[0];

	var numbers = [],
		i,
		len = n;

	for (i = 0; i < len; i += 1) {
		numbers.push(i * 5);
		console.log(numbers[i]);
	}
}