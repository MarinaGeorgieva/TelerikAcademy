// Problem 5. nbsp

// Write a function that replaces non breaking white-spaces 
// in a text with &nbsp

function replaceNBSP(text) {
	var regex = new RegExp(' ', 'gi');
	return text.replace(regex, '&nbsp');
}

var text = 'Telerik    Academy       Telerik   Academy';
text = replaceNBSP(text);
console.log(text);