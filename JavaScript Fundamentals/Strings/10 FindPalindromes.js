// Problem 10. Find palindromes

// Write a program that extracts from a given 
// text all palindromes, e.g. "ABBA", "lamal", "exe"

function findPalindromes(text) {
	var i,
		len,
		palindromes = [],
		words = text.match(/\b\w+\b/g);

	for (i = 0, len = words.length; i < len; i += 1) {
		if (isPlaindrome(words[i])) {
			palindromes.push(words[i]);
		}
	}

	return palindromes;
}

function isPlaindrome(word) {
	var i,
		len,
		isPlaindrome = true;

	for (i = 0, len = word.length; i < len / 2; i += 1) {
		if (word[i] !== word[len - i - 1]) {
			isPlaindrome = false;
		}
	}
	return isPlaindrome;
}

var text = 'abba exe something 1221 12321 anything refer AbbA smthng telerik';

console.log(findPalindromes(text));