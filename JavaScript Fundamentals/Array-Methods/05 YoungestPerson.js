// Problem 5. Youngest person

// Write a function that finds the youngest male person 
// in a given array of people and prints his full name
// Use only array methods and no regular loops (for, while)
// Use Array#find

function createPerson(firstname, lastname, age, gender) {
	return {
		firstname: firstname,
		lastname: lastname,
		age: age,
		gender: gender
	};	
}

// polyfill
if (!Array.prototype.find) {
	Array.prototype.find = function(callback) {
		var i,
			len;

		for (i = 0, len = this.length; i < len; i += 1) {
			if (callback(this[i], i, this)) {
				return this[i];
			}
		}

		return undefined;
	};
}

var people = [
	createPerson('Ivan', 'Ivanov', 20, false),
	createPerson('Todor', 'Todorov', 24, false),
	createPerson('Maria', 'Kirilova', 18, true), 
	createPerson('Stoyan', 'Georgiev', 17, false),
	createPerson('Vesela', 'Petrova', 15, true),
	createPerson('Gergana', 'Pavlova', 22, true),
	createPerson('Georgi', 'Hristov', 21, false)
];

function getYoungestMaleName(people) {
	var youngestMale = people.sort(function(first, second) {
		return first.age - second.age;
	}).find(function(person) {
		return !person.gender;
	});

	return youngestMale.firstname + ' ' + youngestMale.lastname;
}

console.log(getYoungestMaleName(people));