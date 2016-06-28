// Problem 2. Lexicographically comparison

// Write a program that compares two char arrays lexicographically (letter by letter).


function solve(args) {
	var arraysAsStr = args[0].split('\n');
	var firstArray = arraysAsStr[0].split(''),
		secondArray = arraysAsStr[1].split('');

	var i,
		len = Math.min(firstArray.length, secondArray.length);

	for (i = 0; i < len; i += 1) {
		if (secondArray[i] !== firstArray[i]) {
			return firstArray[i] < secondArray[i] ? '<' : '>';
		}
	}

	if (firstArray.length != secondArray.length) {
		return firstArray.length < secondArray.length ? '<' : '>';
	}

	return '=';
}

console.log(solve(['krse\nkgsz']));
console.log(solve(['krse\nkrse']));
console.log(solve(['abcd\nadba']));
console.log(solve(['hello\nhalo']));
console.log(solve(['food\nfood']));