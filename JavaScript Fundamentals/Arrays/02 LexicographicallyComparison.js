// Problem 2. Lexicographically comparison

// Write a script that compares two char arrays lexicographically (letter by letter).

function compare(first, second) {
	for (var i = 0; i < Math.min(first.length, second.length); i += 1) {
		if (second[i] !== first[i]) {
			return first[i] < second[i] ? -1 : 1;
		}
	}

	if (first.length != second.length) {
		first.length < second.length ? -1 : 1;
	}

	return 0;
}

console.log(compare(['k', 'r', 's', 'e'], ['k', 'g', 's', 'z']));
console.log(compare(['k', 'r', 's', 'e'], ['k', 'r', 's', 'e']));
console.log(compare(['a', 'b', 'c', 'd'], ['a', 'd', 'b', 'a']));
