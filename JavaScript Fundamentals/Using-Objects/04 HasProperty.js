// Problem 4. Has property

// Write a function that checks if a given object contains a given property.

function hasProperty(obj, property) {
	var hasProp = false;

	for (var prop in obj) {
		if (property === prop) {
			hasProp = true;
		}
	}

	return hasProp;
}

var personIvan = {
	firstName: 'Ivan',
	lastName: 'Ivanov',
	age: 19 
};

var hasProp = hasProperty(personIvan, 'age');
console.log(hasProp);