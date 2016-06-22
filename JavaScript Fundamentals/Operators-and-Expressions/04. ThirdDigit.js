// Problem 4. Third digit

// Write an expression that checks for given integer if its third digit 
// (right-to-left) is 7.

function solve(args) {
	var number = +args[0];

	var thirdDigit = Math.floor(number / 100 % 10);
	if (thirdDigit == 7) {
		return "true";
	} else {
		return "false " + thirdDigit;
	}
}

console.log(solve(["701"]));
console.log(solve(["5"]));
console.log(solve(["1732"]));
console.log(solve(["9703"]));
console.log(solve(["877"]));
console.log(solve(["777877"]));
console.log(solve(["9999799"]));