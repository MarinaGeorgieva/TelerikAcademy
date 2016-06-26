// Problem 2. MMSA

// Implement a javascript function that accepts an array of floating-point numbers as strings 
// and returns the minimal, the maximal number, 
// the sum and the average of all numbers (displayed with 2 digits after the decimal point).

function solve(args) {
	var numbers = args.map(function(number) {
		return +number;
	});

	var i,
		len = numbers.length,
		min = numbers[0],
		max = numbers[0],
		sum = 0,
		average;

	var result = '';

	for (i = 0; i < len; i++) {
		if (numbers[i] < min) {
			min = numbers[i];
		}

		if (numbers[i] > max) {
			max = numbers[i];
		}

		sum += numbers[i];
	}

	average = sum / len;

	result += 'min=' + min.toFixed(2) + '\n';
	result += 'max=' + max.toFixed(2) + '\n';
	result += 'sum=' + sum.toFixed(2) + '\n';
	result += 'avg=' + average.toFixed(2);
	return result;
}

console.log(solve(['2', '5', '1']));
console.log(solve(['2', '-1', '4']));