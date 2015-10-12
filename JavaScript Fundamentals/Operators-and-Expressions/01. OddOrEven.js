// Problem 1. Odd or Even

// Write an expression that checks if given integer is odd or even.

function isEven(number) {
	if (number % 2 == 0) {
		return true;
	}
	else {
		return false;
	}
}

console.log(isEven(7));
console.log(isEven(10));
