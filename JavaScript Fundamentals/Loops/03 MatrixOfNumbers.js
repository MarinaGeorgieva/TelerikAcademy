// Problem 3. Matrix of numbers

// Write a javascript function that prints a matrix like in the examples below by a given integer N. 
// Use two nested loops.
// 1 2 3 4
// 2 3 4 5
// 3 4 5 6
// 4 5 6 7

function solve(args) {
	var n = +args[0];

	var result = '';

	for (var i = 0; i < n; i++) {
		for (var j = 0; j < n; j++) {
			result += i + j + 1 + ' ';
			if (j === n - 1) {
				result = result.trim();
			}
		}

		result += '\n';
	}

	return result;
}

console.log(solve(['2']));
console.log(solve(['3']));
console.log(solve(['4']));