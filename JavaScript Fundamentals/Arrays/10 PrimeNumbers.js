// Problem 10. Prime Numbers

// Write a program that finds all prime numbers in the range [1 ... N]. 
// Use the Sieve of Eratosthenes algorithm. 
// The program should print the biggest prime number which is <= N.

function solve(args) {
	var n = +args[0],
		i, j,
		isPrime;

	for (i = n; i >= 0; i -= 1) {
		isPrime = true;

		for (j = 2; j <= Math.sqrt(i); j += 1) {
			if (i % j === 0) {
				isPrime = false;
				break;
			}
		}

		if (isPrime === true) {
			return i;
		}
	}
}

// Sieve of Eratosthenes algorithm

// function solve(args) {
// 	var n = +args[0],
// 		array = [],
// 		i, j,
// 		currentPrime,
// 		maxPrime = 2;

// 	for (i = 0; i < n + 1; i += 1) {
// 		array.push(true);
// 	}

// 	for (i = 2; i <= Math.sqrt(n); i += 1) {
// 		if (array[i]) {
// 			for (j = i * i; j < n + 1; j += i) {
// 				array[j] = false;
// 			}
// 		}
// 	}

// 	for (i = 2; i < n + 1; i += 1) {
// 		if (array[i]) {
// 			currentPrime = i;
// 			if (maxPrime < currentPrime) {
// 				maxPrime = currentPrime;
// 			}
// 		}
// 	}

// 	console.log(maxPrime);
// }

// solve(['13']);