// Problem 5. Youngest person

// Write a function that finds the youngest person 
// in a given array of people and prints his/hers full name
// Each person has properties firstname, lastname and age.

function buildPerson(fname, lname, age) {
	return {
		firstname: fname,
		lastname: lname,
		age: age
	};
}

function findYoungestPerson(peopleArray) {
	var minAge = peopleArray[0].age,
		minAgeIndex;

	for (var i = 1; i < peopleArray.length; i += 1) {
		if (peopleArray[i].age < minAge) {
			minAge = peopleArray[i].age;
			minAgeIndex = i;
		}
	}

	return peopleArray[minAgeIndex];
}

var personGosho = buildPerson('Gosho', 'Petrov', 32),
	personKiro = buildPerson('Kiro', 'Kirov', 23),
	personIvan = buildPerson('Bay', 'Ivan', 81),
	personPesho = buildPerson('Pesho', 'Georgiev', 26);

var people = [
	personGosho,
	personKiro,
	personIvan,
	personPesho
];

console.log(findYoungestPerson(people));