// Problem 3. Maximal sequence

// Write a program that finds the length of the maximal sequence 
// of equal elements in an array of N integers.

function solve(args) {
	var newArgs = args[0].split('\n');

	var array = newArgs.map(function(num) {
		return +num;
	});
	array.shift();

	var n = +newArgs[0],
		i,
		len = 1,
		maxLen = 1;
	// end,
	// maxEnd,
	// result = [];

	for (i = 0; i < n - 1; i += 1) {
		if (array[i] === array[i + 1]) {
			len += 1;
			// end = i + 1;
			if (maxLen < len) {
				maxLen = len;
				// maxEnd = end;
			}
		} else {
			len = 1;
		}
	}

	// for (i = maxEnd - maxLen + 1; i <= maxEnd; i++) {
	// 	result.push(array[i]);
	// }

	// console.log(result);
	console.log(maxLen);
}

solve(['10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1']);