// Problem 5. Third bit

// Write a boolean expression for finding if the bit #3 (counting from 0) 
// of a given integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

function getThirdBit(number) {
	var position = 3;
	var mask = 1 << position;
	var nAndMask = number & mask;
	var bit = nAndMask >> position;
	return bit;
}

console.log(getThirdBit(5));
console.log(getThirdBit(8));
console.log(getThirdBit(0));
console.log(getThirdBit(15));
console.log(getThirdBit(5343));
console.log(getThirdBit(62241));