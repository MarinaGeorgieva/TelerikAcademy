// Problem 5. Hex to Decimal

// Using loops implement a javascript function that converts a hex number number to its decimal representation.

function solve(args) {
	var hexNumber = args[0];

	var i,
		len = hexNumber.length,
		decimalNumber = 0;

	for (i = 0; i < len; i++) {
		var digitAsString = hexNumber[len - i - 1],
			digit;

		switch (digitAsString) {
			case 'A':
				digit = 10;
				break;
			case 'B':
				digit = 11;
				break;
			case 'C':
				digit = 12;
				break;
			case 'D':
				digit = 13;
				break;
			case 'E':
				digit = 14;
				break;
			case 'F':
				digit = 15;
				break;
			default:
				digit = +digitAsString;
				break;
		}

		decimalNumber += digit * Math.pow(16, i);
	}

	return decimalNumber;
}

console.log(solve(['FE']));
console.log(solve(['1AE3']));
console.log(solve(['4ED528CBB4']));