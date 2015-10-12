// Problem 2. Correct brackets

// Write a JavaScript function to check if in a 
// given expression the brackets are put correctly.

function isCorrectExpression(expression) {
	var countOpenBracket = 0,
		countCloseBracket = 0,
		isCorrect;

	for (var index = 0; index < expression.length; index += 1) {
		if (expression[index] === '(') {
			countOpenBracket++;
		} else if (expression[index] === ')') {
			countCloseBracket++;
		}
	}

	isCorrect = (countOpenBracket === countCloseBracket);
	return isCorrect;
}

console.log(isCorrectExpression(')(a+b))'));
console.log(isCorrectExpression('((a+b)/5-d)'));