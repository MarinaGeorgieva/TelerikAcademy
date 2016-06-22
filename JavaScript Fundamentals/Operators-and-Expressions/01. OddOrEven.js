// Problem 1. Odd or Even

// Write an expression that checks if given integer is odd or even.

function solve(args) {
	var number = parseInt(args[0]);

	if (number % 2) {
		return "odd " + number;
	} else {
		return "even " + number;
	}
}

console.log(solve(["7"]));
console.log(solve(["10"]));