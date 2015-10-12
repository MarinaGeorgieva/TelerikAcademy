// Problem 3. Maximal sequence

// Write a script that finds the maximal sequence of equal elements in an array.

var array = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
	len = 1,
	maxLen = 1, 
	end,
	maxEnd,
	result = [];

for (var i = 0; i < array.length - 1; i += 1) {
	if (array[i] === array[i + 1]) {
		len += 1;
		end = i + 1;
		if (maxLen < len) {
			maxLen = len;
			maxEnd = end;
		}
	}
	else {
		len = 1;
	}
}

for (var i = maxEnd - maxLen + 1; i <= maxEnd; i++) {
	result.push(array[i]);
}

console.log(result);