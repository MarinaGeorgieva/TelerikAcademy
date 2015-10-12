// Problem 9. Point in Circle and outside Rectangle

// Write an expression that checks for given point P(x, y) 
// if it is within the circle K( (1,1), 3) and out of the 
// rectangle R(top=1, left=-1, width=6, height=2).

function isInCircleAndOutsideRect(x, y) {
	var isInCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 3 * 3);
	var isOutsideRect = !((x >= -1 && x <= 5) && (y <= 1 && y >= -1));
	return isInCircle && isOutsideRect;
}

console.log(isInCircleAndOutsideRect(1, 2));
console.log(isInCircleAndOutsideRect(2.5, 2));
console.log(isInCircleAndOutsideRect(0, 1));
console.log(isInCircleAndOutsideRect(2.5, 1));
console.log(isInCircleAndOutsideRect(2, 0));
console.log(isInCircleAndOutsideRect(2, 1.5));