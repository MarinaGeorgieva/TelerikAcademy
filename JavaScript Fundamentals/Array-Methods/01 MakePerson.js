// Problem 1. Make person

// Write a function for creating persons.
// Each person must have firstname, lastname, 
// age and gender (true is female, false is male)
// Generate an array with ten person with different names, ages and genders

function createPerson(firstname, lastname, age, gender) {
	return {
		firstname: firstname,
		lastname: lastname,
		age: age,
		gender: gender
	};	
}

var fnames = ['Ivan', 'Peter', 'Georgi', 'Nikolay', 'Martin', 'Todor', 'Ivo', 'Simeon', 'Maria', 'Zornitsa'],
	lnames = ['Georgiev', 'Hristov', 'Kostov', 'Ivanov', 'Hristov', 'Zhelev', 'Petrov', 'Nikolov', 'Dimitrova', 'Angelova'],
	ages = [23, 21, 26, 29, 24, 25, 20, 31, 27, 24];

var people = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1].map(function(_, index) {
	if (index <= 7) {
		return createPerson(fnames[index], lnames[index], ages[index], false);
	} 
	else {
		return createPerson(fnames[index], lnames[index], ages[index], true);
	}
});

console.log(people);