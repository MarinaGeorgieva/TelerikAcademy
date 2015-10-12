// Problem 3. Deep copy

// Write a function that makes a deep copy of an object.
// The function should work for both primitive and reference types.

function deepCopy(obj) {
	if (typeof obj !== 'object') {
		return obj;
	}

	var objClone = {};
	for (var prop in obj) {
		objClone[prop] = deepCopy(obj[prop]);
	}

	return objClone;
}

console.log(deepCopy('string'));
console.log(deepCopy(7));
console.log(deepCopy(true));
console.log(deepCopy({ firstName: 'Ivan', lastName: 'Ivanov'}));