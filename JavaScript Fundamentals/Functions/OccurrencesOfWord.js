// Problem 3. Occurrences of word

// Write a function that finds all the occurrences of word in a text.
// The search can be case sensitive or case insensitive.
// Use function overloading.

function countOccurrence(word, text, isCaseSensitive) {
	var pattern = '\\b' + word + '\\b',
		flag = isCaseSensitive ? 'g' : 'gi',
		regex = new RegExp(pattern, flag);

	return text.match(regex).length;
}

var text = 'Telerik Academy telerik TeLeRiK telerik tElErIk TELERIK telerik telerik';
console.log(countOccurrence('telerik', text, true));
console.log(countOccurrence('telerik', text, false));