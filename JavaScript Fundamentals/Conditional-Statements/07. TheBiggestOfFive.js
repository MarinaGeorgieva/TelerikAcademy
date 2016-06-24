// Problem 7. The biggest of five numbers

// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.

function solve(args) {
	var a = +args[0],
		b = +args[1],
		c = +args[2],
		d = +args[3],
		e = +args[4];

	var greatest = a;

	if (greatest < b) {
		greatest = b;
	}

	if (greatest < c) {
		greatest = c;
	}

	if (greatest < d) {
		greatest = d;
	}

	if (greatest < e) {
		greatest = e;
	}

	return greatest;
}