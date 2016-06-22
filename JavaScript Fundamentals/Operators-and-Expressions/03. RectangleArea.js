// Problem 3. Rectangle area

// Write an expression that calculates rectangle’s area and perimeter by given width and height.

function solve(args) {
	var width = +args[0];
	var height = +args[1];

	var area = width * height;
	var perimeter = 2 * (width + height);
	return area.toFixed(2) + " " + perimeter.toFixed(2);
}

console.log(solve([3, 4]));
console.log(solve([2.5, 3]));
console.log(solve([5, 5]));