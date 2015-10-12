// Problem 4. Sort 3 numbers

// Sort 3 real values in descending order.
// Use nested if statements.

var a = 5,
	b = 1,
	c = 2;

if (a > b) {
	if (a > c) {
		if (b > c) {
			console.log(a + ' ' + b + ' ' + c);
		}
		else{
			console.log(a + ' ' + c + ' ' + b);
		}
	}
	else {
		console.log(c + ' ' + a + ' ' + b);
	}
}
else {
	if (b > c) {
		if (a > c) {
			console.log(b + ' ' + a + ' ' + c);
		}
		else {
			console.log(b + ' ' + c + ' ' + a);
		}
	}
	else {
		console.log(c + ' ' + b + ' ' + a);
	}
}