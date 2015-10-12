// Problem 4. Third digit

// Write an expression that checks for given integer if its third digit 
// (right-to-left) is 7.

function isSeven(number) {
	if (Math.floor(number / 100 % 10) == 7) {
		return true;
	}
	else {
		return false;
	}
}

console.log(isSeven(701));
console.log(isSeven(5));
console.log(isSeven(1732));
console.log(isSeven(9703));
console.log(isSeven(877));
console.log(isSeven(777877));
console.log(isSeven(9999799));