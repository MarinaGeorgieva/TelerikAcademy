// Problem 11. String format

// Write a function that formats a string using placeholders.
// The function should work with up to 30 placeholders and all types

function stringFormat() {
	var args = arguments,
		str = args[0],
		placeholder;

	for (var i = 1; i < args.length; i += 1) {
		placeholder = '{' + (i - 1) + '}';

		while (str.indexOf(placeholder) > -1) {
			str = str.replace(placeholder, args[i]);
		}
	}

	return str;
}

var str1 = stringFormat('Hello {0}!', 'Peter');
console.log(str1);
//str = 'Hello Peter!';

var frmt = '{0}, {1}, {0} text {2}';
var str2 = stringFormat(frmt, 1, 'Pesho', 'Gosho');
console.log(str2);
//str = '1, Pesho, 1 text Gosho'