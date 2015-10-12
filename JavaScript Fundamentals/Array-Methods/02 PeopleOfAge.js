// Problem 2. People of age

// Write a function that checks if an array of person contains 
// only people of age (with age 18 or greater)
// Use only array methods and no regular loops (for, while)

function createPerson(firstname, lastname, age) {
	return {
		firstname: firstname,
		lastname: lastname,
		age: age
	};	
}

function onlyAdults(peopleArr) {
	var onlyAdults = peopleArr.every(function(person) {
		return person.age >= 18;
	});
	
	return onlyAdults;
}

var people = [
	createPerson('Ivan', 'Ivanov', 20),
	createPerson('Todor', 'Todorov', 24),
	createPerson('Maria', 'Kirilova', 18), 
	createPerson('Stoyan', 'Georgiev', 17),
	createPerson('Vesela', 'Petrova', 15),
	createPerson('Georgi', 'Hristov', 21)
];

var otherPeople = [
	createPerson('Ivan', 'Ivanov', 20),
	createPerson('Todor', 'Todorov', 24),
	createPerson('Maria', 'Kirilova', 18), 
	createPerson('Stoyan', 'Georgiev', 27),
	createPerson('Vesela', 'Petrova', 25),
	createPerson('Georgi', 'Hristov', 21)
];

console.log(onlyAdults(people));
console.log(onlyAdults(otherPeople));