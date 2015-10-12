// Problem 12. Generate list

// Write a function that creates a HTML <ul> using a 
// template for every HTML <li>.
// The source of the list should be an array of elements.
// Replace all placeholders marked with –{…}– with the value of the 
// corresponding property of the object.

function generateList(people, template) {
	var result = '',
		placeholder;

	result += '<ul>';

	for (var i = 0; i < people.length; i += 1) {
		result += '<li>';

		var curLi = template.replace('-{name}-', people[i].name);
		curLi = curLi.replace('-{age}-', people[i].age);

		result += curLi;
		result += '</li>';
	}

	result += '</ul>';
	return result;
}

var result = document.getElementById('result'),
	template = document.getElementById('list-item').innerHTML,
	people = [{
		name: 'Pesho',
		age: 20
	}, {
		name: 'Gosho',
		age: 23
	}, {
		name: 'Ivan',
		age: 17
	}];
var peopleList = generateList(people, template);

result.innerHTML = peopleList;
console.log(peopleList);