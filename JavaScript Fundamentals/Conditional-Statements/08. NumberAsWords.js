// Problem 8. Number as words

// Write a script that converts a number in the range [0…999] to words, 
// corresponding to its English pronunciation.

function solve(args) {
	var number = +args[0],
		hundreds = Math.floor(number / 100),
		tens = Math.floor(number % 100 / 10),
		ones = Math.floor(number % 100 % 10),
		result = '';

	if (hundreds > 0) {
		switch (hundreds) {
			case 1:
				result += 'One hundred ';
				break;
			case 2:
				result += 'Two hundred ';
				break;
			case 3:
				result += 'Three hundred ';
				break;
			case 4:
				result += 'Four hundred ';
				break;
			case 5:
				result += 'Five hundred ';
				break;
			case 6:
				result += 'Six hundred ';
				break;
			case 7:
				result += 'Seven hundred ';
				break;
			case 8:
				result += 'Eight hundred ';
				break;
			case 9:
				result += 'Nine hundred ';
				break;
		}
		if ((tens != 0) || (tens == 0 && ones != 0)) {
			result += 'and ';
		}
	}

	if (tens > 1) {
		switch (tens) {
			case 2:
				result += 'twenty ';
				break;
			case 3:
				result += 'thirty ';
				break;
			case 4:
				result += 'fourty ';
				break;
			case 5:
				result += 'fifty ';
				break;
			case 6:
				result += 'sixty ';
				break;
			case 7:
				result += 'seventy ';
				break;
			case 8:
				result += 'eighty ';
				break;
			case 9:
				result += 'ninety ';
				break;
		}
	} else if (tens == 1) {
		switch (ones) {
			case 0:
				result += 'ten';
				break;
			case 1:
				result += 'eleven ';
				break;
			case 2:
				result += 'twelve ';
				break;
			case 3:
				result += 'thirteen ';
				break;
			case 4:
				result += 'fourteen ';
				break;
			case 5:
				result += 'fifteen ';
				break;
			case 6:
				result += 'sixteen ';
				break;
			case 7:
				result += 'seventeen ';
				break;
			case 8:
				result += 'eighteen ';
				break;
			case 9:
				result += 'nineteen ';
				break;
		}
	}
	if (tens != 1) {
		switch (ones) {
			case 1:
				result += 'one';
				break;
			case 2:
				result += 'two';
				break;
			case 3:
				result += 'three';
				break;
			case 4:
				result += 'four';
				break;
			case 5:
				result += 'five';
				break;
			case 6:
				result += 'six';
				break;
			case 7:
				result += 'seven';
				break;
			case 8:
				result += 'eight';
				break;
			case 9:
				result += 'nine';
				break;
		}
	}

	if (hundreds == 0 && tens == 0 && ones == 0) {
		return 'Zero';
	}

	result = result.trim();
	return result.charAt(0).toUpperCase() + result.slice(1);
}