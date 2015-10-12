// Problem 6. Group people

// Write a function that groups an array of persons by first letter of first name 
// and returns the groups as a JavaScript Object
// Use Array#reduce
// Use only array methods and no regular loops (for, while)

function createPerson(firstname, lastname, age, gender) {
	return {
		firstname: firstname,
		lastname: lastname,
		age: age,
		gender: gender
	};	
}

function groupPeople(people) {
	var groups = people.reduce(function(gr, person) {
		var letter = person.firstname[0];
	
		if (gr[letter]) {
			gr[letter].push(person);
		}
		else {
			gr[letter] = [person];
		}
	
		return gr;
	}, {});
	
	return groups;
}

var people = [
	createPerson('Martin', 'Ivanov', 20, false),
	createPerson('Todor', 'Todorov', 24, false),
	createPerson('Maria', 'Kirilova', 18, true), 
	createPerson('Milen', 'Georgiev', 17, false),
	createPerson('Teodora', 'Petrova', 15, true),
	createPerson('Gergana', 'Pavlova', 22, true),
	createPerson('Georgi', 'Hristov', 21, false)
];

console.log(groupPeople(people));