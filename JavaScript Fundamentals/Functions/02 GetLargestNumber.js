// Problem 2. Get largest number

// Write a method GetMax() with two parameters that returns the larger of two integers. 
// Write a program that reads 3 integers from the console 
// and prints the largest of them using the method GetMax().

function solve(args) {
	var input = args[0].split(' ');
	var firstNumber = +input[0],
		secondNumber = +input[1],
		thirdNumber = +input[2];

	return getMax(firstNumber, getMax(secondNumber, thirdNumber));

	function getMax(firstNumber, secondNumber) {
		if (firstNumber > secondNumber) {
			return firstNumber;
		}

		return secondNumber;
	}
}