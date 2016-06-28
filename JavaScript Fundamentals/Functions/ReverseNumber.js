// Problem 2. Reverse number

// Write a function that reverses the digits of given decimal number.

function reverseNumber(number) {
	number = +number;
	var isNegative = number < 0,
		number = number.toString().replace('-', '').split(''),
		reversedNumber = [];

	if (isNegative) {
		reversedNumber.push('-');
	}

	Array.prototype.push.apply(reversedNumber, number.reverse());
	return +(reversedNumber.join(''));
}

console.log(reverseNumber(256));
console.log(reverseNumber(123.45));
console.log(reverseNumber(-3178));