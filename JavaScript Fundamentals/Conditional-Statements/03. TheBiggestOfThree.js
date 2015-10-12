// Problem 3. The biggest of Three

// Write a script that finds the biggest of three numbers.
// Use nested if statements.

var a = -0.1,
	b = -0.5,
	c = -1.1;

if (a > b) {
	if (a > c) {
		console.log(a);
	}
	else {
		console.log(c);
	}
}
else {
	if (b > c) {
		console.log(b);
	}
	else {
		console.log(c);
	}
}