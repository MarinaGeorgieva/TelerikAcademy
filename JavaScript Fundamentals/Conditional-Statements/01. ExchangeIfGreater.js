// Problem 1. Exchange if greater

// Write an if statement that takes two double variables a and b 
// and exchanges their values if the first one is greater than the second.
// As a result print the values a and b, separated by a space.


function solve(args) {
	var a = +args[0],
		b = +args[1];

	if (a >= b) {
		var temp = a;
		a = b;
		b = temp;
	}

	return a + ' ' + b;
}