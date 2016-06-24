// Problem 4. Sort 3 numbers

// Sort 3 real values in descending order.
// Use nested if statements.

function solve(args) {
	var a = +args[0],
		b = +args[1],
		c = +args[2];

	if (a > b) {
		if (a > c) {
			if (b > c) {
				return a + ' ' + b + ' ' + c;
			} else {
				return a + ' ' + c + ' ' + b;
			}
		} else {
			return c + ' ' + a + ' ' + b;
		}
	} else {
		if (b > c) {
			if (a > c) {
				return b + ' ' + a + ' ' + c;
			} else {
				return b + ' ' + c + ' ' + a;
			}
		} else {
			return c + ' ' + b + ' ' + a;
		}
	}
}