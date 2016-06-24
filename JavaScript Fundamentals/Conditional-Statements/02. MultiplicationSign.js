// Problem 2. Multiplication Sign

// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

function solve(args) {
	var a = +args[0],
		b = +args[1],
		c = +args[2];

	if (a > 0 && b > 0 && c > 0) {
		return '+';
	} else if (a > 0 && b > 0 && c < 0) {
		return '-';
	} else if (a > 0 && b < 0 && c > 0) {
		return '-';
	} else if (a > 0 && b < 0 && c < 0) {
		return '+';
	} else if (a < 0 && b > 0 && c > 0) {
		return '-';
	} else if (a < 0 && b > 0 && c < 0) {
		return '+';
	} else if (a < 0 && b < 0 && c > 0) {
		return '+';
	} else if (a < 0 && b < 0 && c < 0) {
		return '-';
	} else {
		return '0';
	}
}