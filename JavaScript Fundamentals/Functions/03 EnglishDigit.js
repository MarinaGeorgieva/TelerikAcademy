// Problem 3. English digit

// Write a method that returns the last digit of given integer as an English word. 
// Write a program that reads a number and prints the result of the method.

function solve(args) {
	number = +args[0];
	var lastDigit = number % 10;
	switch (lastDigit) {
		case 0:
			return 'zero';
		case 1:
			return 'one';
		case 2:
			return 'two';
		case 3:
			return 'three';
		case 4:
			return 'four';
		case 5:
			return 'five';
		case 6:
			return 'six';
		case 7:
			return 'seven';
		case 8:
			return 'eight';
		case 9:
			return 'nine';
		default:
			return 'not a number';
	}
}