// Problem 8. Number as words

// Write a script that converts a number in the range [0…999] to words, 
// corresponding to its English pronunciation.

function getNumberName(number) {
	number = +number;
	var hundreds = Math.floor(number / 100);
	var tens = Math.floor(number % 100 / 10);
	var ones = Math.floor(number % 100 % 10);
	var result = '';

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
				result += 'Twenty ';
				break;
			case 3:
				result += 'Thirty ';
				break;
			case 4:
				result += 'Fourty ';
				break;
			case 5:
				result += 'Fifty ';
				break;
			case 6:
				result += 'Sixty ';
				break;
			case 7:
				result += 'Seventy ';
				break;
			case 8:
				result += 'Eighty ';
				break;
			case 9:
				result += 'Ninety ';
				break;
		}
	} else if (tens == 1) {
		switch (ones) {
			case 0:
				result += 'Ten';
				break;
			case 1:
				result += 'Eleven ';
				break;
			case 2:
				result += 'Twelve ';
				break;
			case 3:
				result += 'Thirteen ';
				break;
			case 4:
				result += 'Fourteen ';
				break;
			case 5:
				result += 'Fifteen ';
				break;
			case 6:
				result += 'Sixteen ';
				break;
			case 7:
				result += 'Seventeen ';
				break;
			case 8:
				result += 'Eighteen ';
				break;
			case 9:
				result += 'Nineteen ';
				break;
		}
	}
	if (tens != 1) {
		switch (ones) {
			case 1:
				result += 'One';
				break;
			case 2:
				result += 'Two';
				break;
			case 3:
				result += 'Three';
				break;
			case 4:
				result += 'Four';
				break;
			case 5:
				result += 'Five';
				break;
			case 6:
				result += 'Six';
				break;
			case 7:
				result += 'Seven';
				break;
			case 8:
				result += 'Eight';
				break;
			case 9:
				result += 'Nine';
				break;
		}
	}

	console.log(result);

	if (hundreds == 0 && tens == 0 && ones == 0) {
		console.log('Zero');
	}

	
}

getNumberName(0);
getNumberName(9);
getNumberName(10);
getNumberName(12);
getNumberName(19);
getNumberName(25);
getNumberName(98);
getNumberName(273);
getNumberName(400);
getNumberName(501);
getNumberName(617);
getNumberName(711);
getNumberName(999);