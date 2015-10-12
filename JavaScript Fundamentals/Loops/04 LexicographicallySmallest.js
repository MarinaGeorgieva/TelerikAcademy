// Problem 4. Lexicographically smallest

// Write a script that finds the lexicographically smallest and largest property in document, 
// window and navigator objects.

function getMinProperty(obj) {
	var min = 0;

	for (var prop in obj) {
		if (!min) {
			min = prop;
		}

		if (prop < min) {
			min = prop;
		}
	}

	console.log('Min property: ' + min);
}

function getMaxProperty(obj) {
	var max = 0;

	for (var prop in obj) {
		if (!max) {
			max = prop;
		}

		if (prop > max) {
			max = prop;
		}
	}

	console.log('Max property: ' + max);
}

console.log('document');
getMinProperty(document);
getMaxProperty(document);

console.log('window');
getMinProperty(window);
getMaxProperty(window);

console.log('navigator');
getMinProperty(navigator);
getMaxProperty(navigator);

