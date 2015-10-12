// Problem 3. Underage people

// Write a function that prints all underaged persons of an array of person
// Use Array#filter and Array#forEach
// Use only array methods and no regular loops (for, while)

function createPerson(firstname, lastname, age) {
	return {
		firstname: firstname,
		lastname: lastname,
		age: age
	};	
}

function getUnderagedPeople(people) {
	var underagedPeople = people.filter(function(person) {
		return person.age < 18;
	}).forEach(function(person) {
		console.log(person);
	});
}

var people = [
	createPerson('Ivan', 'Ivanov', 12),
	createPerson('Todor', 'Todorov', 24),
	createPerson('Maria', 'Kirilova', 18), 
	createPerson('Stoyan', 'Georgiev', 17),
	createPerson('Vesela', 'Petrova', 15),
	createPerson('Georgi', 'Hristov', 21)
];

getUnderagedPeople(people);