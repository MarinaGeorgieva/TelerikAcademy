// Problem 6.

// Write a function that groups an array of people by age, first or last name.
// The function must return an associative array, 
// with keys - the groups, and values - arrays with people in this groups
// Use function overloading (i.e. just one function)

function buildPerson(fname, lname, age) {
	return {
		firstname: fname,
		lastname: lname,
		age: age
	};
}

function group(array, prop) {
	var group = [];

	for (var index in array) {
		var curProp = array[index][prop];
		group[curProp] = group[curProp] || [];
		group[curProp].push(array[index]);
	}

	return group;
}

var personIvan1 = buildPerson('Ivan', 'Ivanov', 24),
	personIvan2 = buildPerson('Ivan', 'Georgiev', 26),
	personIvan3 = buildPerson('Ivan', 'Petrov', 24),
	personGeorgi1 = buildPerson('Georgi', 'Georgiev', 26),
	personGeorgi2 = buildPerson('Georgi', 'Petrov', 23),
	personGeorgi3 = buildPerson('Georgi', 'Ivanov', 25),
	personPeter1 = buildPerson('Peter', 'Petrov', 25),	
	personPeter2 = buildPerson('Peter', 'Georgiev', 23),
	personPeter3 = buildPerson('Peter', 'Ivanov', 26);

var people = [
	personIvan1,
	personIvan2,
	personIvan3,
	personGeorgi1,
	personGeorgi2,
	personGeorgi3,
	personPeter1,
	personPeter2,
	personPeter3
];

var groupedByFname = group(people, 'firstname'),
	groupedByLname = group(people, 'lastname'),
	groupedByAge = group(people, 'age');

console.log('Grouped by firstname:');
console.log(groupedByFname);
console.log('Grouped by lastname:');
console.log(groupedByLname);
console.log('Grouped by age:');
console.log(groupedByAge);