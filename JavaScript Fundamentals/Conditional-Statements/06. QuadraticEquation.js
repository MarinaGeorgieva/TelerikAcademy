// Problem 6. Quadratic equation

// Write a script that reads the coefficients a, b and c of a quadratic 
// equation ax^2 + bx + c = 0 and solves it (prints its real roots).
// Calculates and prints its real roots.

function solve(args) {
	var a = +args[0],
		b = +args[1],
		c = +args[2],
		x1,
		x2,
		result;

	var discriminant = b * b - 4 * a * c;

	if (a == 0) {
		if (b == 0) {
			result = 'no real roots';
		} else {
			x1 = -c / b;
			result = 'x1=' + x1.toFixed(2);
		}
	} else {
		if (discriminant > 0) {
			var x1 = (-b - Math.sqrt(discriminant)) / (2 * a),
				x2 = (-b + Math.sqrt(discriminant)) / (2 * a);

			if (x1 > x2) {
				var temp = x1;
				x1 = x2;
				x2 = temp;
			}

			result = 'x1=' + x1.toFixed(2) + '; ' + 'x2=' + x2.toFixed(2);
		} else if (discriminant == 0) {
			x1 = (-b / (2 * a));
			result = 'x1=x2=' + x1.toFixed(2);
		} else {
			result = 'no real roots';
		}
	}

	return result;
}