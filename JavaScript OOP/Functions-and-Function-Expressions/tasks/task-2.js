/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(start, end) {
	var divisor,
		maxDivisor,
		n,
		isPrime,
		primes = [];

	if (typeof(start) == 'undefined' || typeof(end) === 'undefined') {
		throw new Error();
	}

	start = +start;
	end = +end;

	for (n = start; n <= end; n += 1) {
		maxDivisor = Math.sqrt(n);
		isPrime = true;

		for (divisor = 2; divisor <= maxDivisor; divisor += 1) {
			if (!(n % divisor)) {
				isPrime = false;
				break;
			}
		}

		if (isPrime && n > 1) {
			primes.push(n);
		}
	}

	return primes;
}

module.exports = findPrimes;