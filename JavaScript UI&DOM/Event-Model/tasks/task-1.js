/* globals $ */

/* 
Create a function that takes an id or DOM element and:
  
*/

function solve() {
	var CONSTANTS = {
		class: {
			button: 'button',
				content: 'content'
		},
		display: {
			hidden: 'none',
			visible: ''
		},
		buttonInnerHTML: {
			onHidden: 'show',
			onVisible: 'hide'
		}
	};

	var validator = {
		validateInput: function(input) {
			if (typeof input !== 'string' && !(input instanceof HTMLElement)) {
				throw new Error('Invalid input');
			}
		},
		getElement: function(element) {
			var result = element;

			if (typeof element === 'string') {
				result = document.getElementById(element);

				if (result === null) {
					throw new Error('Invalid id');
				}
			}

			return result;
		}
	};

	function getChildrenWithClass(element, className) {
		var result = [],
			children = element.children,
			i,
			len,
			currentChild;

		for (i = 0, len = children.length; i < len; i += 1) {
			currentChild = children[i];

			if (currentChild.className === className) {
				result.push(currentChild);
			}
		}

		return result;
	}

	function buttonEvent(event) {
		var clicked = event.target,
			canToggleVisibility,
			contentElement,
			nextElement = clicked.nextElementSibling;

		while (nextElement) {
			if (nextElement.className == CONSTANTS.class.content) {
				contentElement = nextElement;

				while (nextElement) {
					if (nextElement.className == CONSTANTS.class.button) {
						canToggleVisibility = true;
						break;
					}

					nextElement = nextElement.nextElementSibling;
				}

				break;
			} else {
				nextElement = nextElement.nextElementSibling;
			}
		}

		if (canToggleVisibility) {
			if (contentElement.style.display == CONSTANTS.display.hidden) {
				contentElement.style.display = CONSTANTS.display.visible;
				clicked.innerHTML = CONSTANTS.buttonInnerHTML.onVisible;
			} else {
				contentElement.style.display = CONSTANTS.display.hidden;
				clicked.innerHTML = CONSTANTS.buttonInnerHTML.onHidden;
			}
		}
	}

	return function(selector) {
		var element, buttons;

		validator.validateInput(selector);
		element = validator.getElement(selector);

		var buttons = getChildrenWithClass(element, CONSTANTS.class.button)
			.map(function(button) {
				button.innerHTML = CONSTANTS.buttonInnerHTML.onVisible;
				button.addEventListener('click', buttonEvent);
			});
	};
}

module.exports = solve;