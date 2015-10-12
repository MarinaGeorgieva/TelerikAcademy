// Problem 6. Quadratic equation

// Write a script that reads the coefficients a, b and c of a quadratic 
// equation ax^2 + bx + c = 0 and solves it (prints its real roots).
// Calculates and prints its real roots.

function solve(a, b, c) {
	var discriminant = b * b - 4 * a * c;

	if (a == 0) {
		if (b == 0) {
			console.log('no solution');
		}
		else {
			console.log('x = ' + -c / b);
		}
	}
	else {
		if (discriminant > 0) {
			console.log('x1 = ' + (-b + Math.sqrt(discriminant)) / (2 * a) + '; ' + 
				'x2 = ' + (-b - Math.sqrt(discriminant)) / (2 * a));
		}
		else if (discriminant == 0) {
			console.log('x1 = x2 = ' + (-b / (2 * a)));
		}
		else {
			console.log('no real roots');
		}
	}
}

solve(2, 5, -3);
solve(-1, 3, 0);
solve(-0.5, 4, -8);
solve(5, 2, 8);