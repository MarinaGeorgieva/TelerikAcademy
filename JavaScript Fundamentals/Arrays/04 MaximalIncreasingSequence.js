// Problem 4. Maximal increasing sequence

// Write a script that finds the maximal increasing sequence in an array.

var array = [3, 2, 3, 4, 2, 2, 4],
	len = 1,
	maxLen = 1, 
	end,
	maxEnd,
	result = [];

for (var i = 0; i < array.length - 1; i += 1) {
	if (array[i] < array[i + 1]) {
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