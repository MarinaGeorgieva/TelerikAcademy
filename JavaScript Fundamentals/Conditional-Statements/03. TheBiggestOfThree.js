// Problem 3. The biggest of Three

// Write a script that finds the biggest of three numbers.
// Use nested if statements.

function solve(args) {
	var a = +args[0],
		b = +args[1],
		c = +args[2];

	if (a > b) {
		if (a > c) {
			return a;
		} else {
			return c;
		}
	} else {
		if (b > c) {
			return b;
		} else {
			return c;
		}
	}
}