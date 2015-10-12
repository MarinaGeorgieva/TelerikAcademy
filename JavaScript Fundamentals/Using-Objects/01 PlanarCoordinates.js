// Problem 1. Planar coordinates

// Write functions for working with shapes in standard Planar coordinate system.
// Points are represented by coordinates P(X, Y)
// Lines are represented by two points, 
// marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
// Calculate the distance between two points.
// Check if three segment lines can form a triangle.

function createPoint(x, y) {
	if (isNaN(x) || isNaN(y)) {
		return null;
	}

	return {
		x: parseFloat(x),
		y: parseFloat(y),
		toString: function() {
			return '(' + this.x + ', ' + this.y + ')';
		}
	};
}

function createLine(first, second) {
	return {
		p1: first,
		p2: second,
		toString: function() {
			return '(P1' + first.toString() + ', P2' + second.toString() + ')';
		}
	};
}

function calculateDistance(firstPoint, secondPoint) {
	var distX = secondPoint.x - firstPoint.x,
		distY = secondPoint.y - firstPoint.y;

	return Math.sqrt(distX * distX + distY * distY);
}

function canFormTriangle(a, b, c) {
	if (isNaN(a) || isNaN(b) || isNaN(c)) {
		return false;
	}

	if ((a + b > c) && (a + c > b) && (b + c > a)) {
		return true;
	}

	return false;
}

var a = createPoint(2, 3),
 	b = createPoint(4, 5),
 	c = createPoint(3.5, 6),
 	ab = createLine(a, b),
 	ac = createLine(a, c),
 	bc = createLine(b, c),
 	distAB = calculateDistance(ab.p1, ab.p2),
 	distAC = calculateDistance(ac.p1, ac.p2),
 	distBC = calculateDistance(bc.p1, bc.p2);

console.log(a.toString());
console.log(b.toString());
console.log(c.toString());
console.log(ab.toString());
console.log(ac.toString());
console.log(bc.toString());
console.log(distAB);
console.log(distAC);
console.log(distBC);
console.log(canFormTriangle(distAB, distAC, distBC));
