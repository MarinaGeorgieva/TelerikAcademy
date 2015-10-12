// Problem 3. Sub-string in text

// Write a JavaScript function that finds how many times a substring 
// is contained in a given text (perform case insensitive search).

function countSubstrings(text, substr) {
	var regex = new RegExp(substr, 'gi');
	return text.match(regex).length;
}

var text = 'The text is as follows: We are living in an yellow submarine. We don\'t have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';

console.log(countSubstrings(text, 'in'));