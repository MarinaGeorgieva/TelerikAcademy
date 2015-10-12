/* globals $ */

/* 
Create a function that takes an id or DOM element and an array of contents
* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function() {

	function validateIfNullOrUndefined(name, parameter) {
		if (parameter === undefined || parameter === null) {
			throw new Error(name + ' cannot be null or undefined');
		}
	}

	function validateContentsParameter(parameter) {
		if (typeof parameter !== 'string' && typeof parameter !== 'number') {
			throw new Error('Contents parameters must be string or number');
		}
	}

	function validateContents(contents) {
		var i,
			len;

		if (!Array.isArray(contents)) {
			throw new Error('Contents must be an array');
		}

		for (i = 0, len = contents.length; i < len; i += 1) {
			validateContentsParameter(contents[i]);
		}
	}

	function getElement(element) {
		if (typeof element === 'string') {
			element = document.getElementById(element);
		}

		if (!(element instanceof HTMLElement)) {
			throw new Error('Invalid element passed');
		}

		return element;
	}

	function appendDivsToElement(element, contents) {
		var div,
			fragment,
			i,
			len,
			divToBeAdded;

		element.innerHTML = '';
		div = document.createElement('div');
		fragment = document.createDocumentFragment();

		for (i = 0, len = contents.length; i < len; i += 1) {
			divToBeAdded = div.cloneNode(true);
			divToBeAdded.innerHTML = contents[i];
			fragment.appendChild(divToBeAdded);
		}

		element.appendChild(fragment);
	}

	return function(element, contents) {
		validateIfNullOrUndefined('Element', element);
		validateIfNullOrUndefined('Contents', contents);
		validateContents(contents);

		element = getElement(element);
		appendDivsToElement(element, contents);
	};
};