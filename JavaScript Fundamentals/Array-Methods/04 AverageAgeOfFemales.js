// Problem 4. Average age of females

// Write a function that calculates the average age 
// of all females, extracted from an array of persons
// Use Array#filter
// Use only array methods and no regular loops (for, while)

function createPerson(firstname, lastname, age, gender) {
	return {
		firstname: firstname,
		lastname: lastname,
		age: age,
		gender: gender
	};	
}

function calculateAvgFemaleAge(people) {
	var females = people.filter(function(person) {
		return person.gender === true;
	});
	var avgFemaleAge = females.reduce(function(sum, female) {
		return sum + female.age;
	}, 0) / females.length;

	return avgFemaleAge;
}

var people = [
	createPerson('Ivan', 'Ivanov', 12, false),
	createPerson('Todor', 'Todorov', 24, false),
	createPerson('Maria', 'Kirilova', 18, true), 
	createPerson('Stoyan', 'Georgiev', 17, false),
	createPerson('Vesela', 'Petrova', 15, true),
	createPerson('Gergana', 'Pavlova', 22, true),
	createPerson('Georgi', 'Hristov', 21, false)
];

console.log(calculateAvgFemaleAge(people));