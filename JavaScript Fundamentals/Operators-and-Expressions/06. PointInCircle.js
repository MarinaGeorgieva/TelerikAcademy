// Problem 6. Point in Circle

// Write an expression that checks if given point P(x, y) is within a circle 
// K({0,0}, 5). //{0,0} is the centre and 5 is the radius

function isInCircle(x, y) {
	var inCircle = ((x - 0) * (x - 0) + (y - 0) * (y - 0) <= 5 * 5);
	if (inCircle) {
		return true;
	}
	else {
		return false;
	}
}

console.log(isInCircle(0, 1));
console.log(isInCircle(-5, 0));
console.log(isInCircle(-4, 5));
console.log(isInCircle(1.5, -3));
console.log(isInCircle(0, 0));