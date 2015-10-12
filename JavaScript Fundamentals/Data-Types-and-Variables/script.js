// Problem 1. JavaScript literals

// Assign all the possible JavaScript literals to different variables.

var intLiteral = 5,
	floatLiteral = 5.123,
	stringLiteral = 'pesho',
	boolLiteral = true,
	array = [1, 2, 3, 4, 5],
	object = { name: 'Pesho', age: 19},
	func = function() { return 100;};

// Problem 2. Quoted text

// Create a string variable with quoted text in it.
// For example: `'How you doin'?', Joey said'.

var quotedText = '\'How you doin\'?\', Joey said.';
console.log(quotedText);

// Problem 3. Typeof variables

// Try typeof on all variables you created.

var variables = [intLiteral, floatLiteral, stringLiteral, boolLiteral, array, object, func];

for (var i = 0; i < variables.length; i++) {
	console.log('Type of ' + variables[i] + ' is ' + typeof(variables[i]));
}

// Problem 4. Typeof null

// Create null, undefined variables and try typeof on them.

var nullLiteral = null,
	undefinedLiteral;

console.log('Type of ' + nullLiteral + ' is ' + typeof(nullLiteral));
console.log('Type of ' + undefinedLiteral + ' is ' + typeof(undefinedLiteral));