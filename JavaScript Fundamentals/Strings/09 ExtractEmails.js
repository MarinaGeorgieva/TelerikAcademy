// Problem 9. Extract e-mails

// Write a function for extracting all email addresses from given text.
// All sub-strings that match the format @… should be recognized as emails.
// Return the emails as array of strings.

function extractEmails(text) {
	return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}

var text = 'pesho123@abv.bg dfnfs "fdjhsfdsdf" hjdsbhfgdb@gmail.com' +
	' "asadsada@abv.bg" fjhdsdh sadsdfs.fghhgs@abv.bg';

console.log(extractEmails(text));