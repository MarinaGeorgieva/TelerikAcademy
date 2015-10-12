// Problem 3. Min/Max of sequence

// Write a script that finds the max and min number from a sequence of numbers.

var numbers = [2, 6, 10, 17, 3, 1, 7, 4, 8];
var min = numbers[0], 
	max = numbers[0];

for (var index in numbers) {
	if (min > numbers[index]) {
		min = numbers[index];
	}
	if (max < numbers[index]) {
		max = numbers[index];
	}
}

console.log('Max: ' + max);
console.log('Min: ' + min);