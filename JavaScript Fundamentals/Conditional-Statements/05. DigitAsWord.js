// Problem 5. Digit as word

// Write a script that asks for a digit (0-9), and depending on the input, 
// shows the digit as a word (in English).
// Print “not a digit” in case of invalid input.
// Use a switch statement.

function getDigitName(digit) {
	switch (digit) {
		case 0: console.log('zero');
				break;
		case 1: console.log('one');
				break;
		case 2: console.log('two');
				break;
		case 3: console.log('three');
				break;
		case 4: console.log('four');
				break;
		case 5: console.log('five');
				break;
		case 6: console.log('six');
				break;
		case 7: console.log('seven');
				break;
		case 8: console.log('eight');
				break;
		case 9: console.log('nine');
				break;
		default: console.log('not a digit');
				break;
	}
}

getDigitName(2);
getDigitName(1);
getDigitName(0);
getDigitName(5);
getDigitName(-0.1);
getDigitName('hi');
getDigitName(9);
getDigitName(10);