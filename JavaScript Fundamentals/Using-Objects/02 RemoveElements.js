// Problem 2. Remove elements

// Write a function that removes all elements with a given value.
// Attach it to the array type.

Array.prototype.remove = function(element) {
	for (var index = 0; index < this.length; index += 1) {
		if (this[index] === element) {
			this.splice(index, 1);
		}
	}
};

var array = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
console.log(array);
array.remove(1);
console.log(array);