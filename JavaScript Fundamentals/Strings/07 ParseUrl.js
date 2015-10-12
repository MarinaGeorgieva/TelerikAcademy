// Problem 7. Parse URL

// Write a script that parses an URL address given in the format: 
// [protocol]://[server]/[resource] and extracts from it the 
// [protocol], [server] and [resource] elements.
// Return the elements in a JSON object.

function extractFromUrl(url) {
	var index,
		splittedUrl,
		protocol,
		server,
		resource,
		parsedUrl;

	index = url.indexOf('//');
	protocol = url.substring(0, index - 1);
	url = url.split("//").pop();
	splittedUrl = url.split('/');
	server = splittedUrl[0];
	resource = url.replace(server, '');

	parsedUrl = {
		protocol: protocol,
		server: server,
		resource: resource
	};

	return parsedUrl;
}

var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

console.log(extractFromUrl(url));