// Problem 7. Is prime

// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

function solve(args) {
	var number = +args[0];

	if (number < 2) {
		return false;
	}

	for (var i = 2; i <= Math.sqrt(number); i++) {
		if (number % i === 0) {
			return false;
		}
	}

	return true;
}

console.log(solve(["1"]));
console.log(solve(["2"]));
console.log(solve(["3"]));
console.log(solve(["4"]));
console.log(solve(["9"]));
console.log(solve(["37"]));
console.log(solve(["97"]));
console.log(solve(["51"]));
console.log(solve(["-3"]));
console.log(solve(["0"]));