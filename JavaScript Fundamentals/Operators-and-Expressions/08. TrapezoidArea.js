// Problem 8. Trapezoid area

// Write an expression that calculates trapezoid's area by given sides 
// a and b and height h.

function calculateArea(a, b, h) {
	return (a + b) * h / 2;
}

console.log(calculateArea(5, 7, 12));
console.log(calculateArea(2, 1, 33));
console.log(calculateArea(8.5, 4.3, 2.7));
console.log(calculateArea(100, 200, 300));
console.log(calculateArea(0.222, 0.333, 0.555));