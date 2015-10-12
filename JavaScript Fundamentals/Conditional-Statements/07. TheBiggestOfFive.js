// Problem 7. The biggest of five numbers

// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.

var a = 5,
	b = 2,
	c = 2,
	d = 4,
	e = 1;

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

console.log(greatest);