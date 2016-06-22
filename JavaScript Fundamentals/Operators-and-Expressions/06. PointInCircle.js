// Problem 6. Point in Circle

// Write an expression that checks if given point P(x, y) is within a circle 
// K({0,0}, 2). //{0,0} is the centre and 2 is the radius

function solve(args) {
	var x = +args[0];
	var y = +args[1];

	var distance = Math.sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0)),
		inCircle = distance <= 2;
	if (inCircle) {
		return "yes " + distance.toFixed(2);
	} else {
		return "no " + distance.toFixed(2);
	}
}

console.log(solve(["0", "1"]));
console.log(solve(["-2", "0"]));
console.log(solve(["-1", "2"]));
console.log(solve(["1.5", "-1"]));
console.log(solve(["0", "0"]));