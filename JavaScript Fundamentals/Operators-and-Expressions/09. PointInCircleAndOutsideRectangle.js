// Problem 9. Point, Circle, Rectangle

// Write an expression that checks for given point P(x, y) 
// if it is within the circle K( (1,1), 1.5) and out of the 
// rectangle R(top=1, left=-1, width=6, height=2).

function solve(args) {
	var x = +args[0],
		y = +args[1];
	var result = "";
	var isInCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5),
		isOutsideRect = !((x >= -1 && x <= 5) && (y <= 1 && y >= -1));

	if (isInCircle) {
		result += "inside circle";
	} else {
		result += "outside circle";
	}

	if (isOutsideRect) {
		result += " outside rectangle";
	} else {
		result += " inside rectangle";
	}

	return result;
}

console.log(solve(["1", "2"]));
console.log(solve(["2.5", "2"]));
console.log(solve(["0", "1"]));
console.log(solve(["2.5", "1"]));
console.log(solve(["2", "0"]));
console.log(solve(["2", "1.5"]));