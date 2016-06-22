// Problem 2. Divisible by 7 and 5

// Write a boolean expression that checks for given integer if it can be divided 
// (without remainder) by 7 and 5 in the same time.

function solve(args) {
	var number = +args[0];

	if (number % 7 === 0 && number % 5 === 0) {
		return "true " + number;
	} else {
		return "false " + number;
	}
}

console.log(solve(["35"]));
console.log(solve(["5"]));
console.log(solve(["7"]));
console.log(solve(["0"]));