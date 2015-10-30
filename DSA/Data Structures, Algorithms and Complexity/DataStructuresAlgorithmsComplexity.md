**Task 1.** What is the expected running time of the following C# code?

Explain why using Markdown.
Assume the array's size is n.

    long Compute(int[] arr)
    {
    	long count = 0;
    	for (int i=0; i<arr.Length; i++)
    	{
    		int start = 0, end = arr.Length-1;
    		while (start < end)
    			if (arr[start] < arr[end])
    				{ start++; count++; }
    			else 
    				end--;
    	}
    	return count;
    }

Runs in **O(n ^ 2)** because each of the n iterations of the for loop leads to n iterations of the while loop. The other operations run in constant time.


**Task 2.** What is the expected running time of the following C# code?

Explain why using Markdown.
Assume the input matrix has size of n * m.

    long CalcCount(int[,] matrix)
    {
    	long count = 0;
    	for (int row=0; row<matrix.GetLength(0); row++)
    		if (matrix[row, 0] % 2 == 0)
    			for (int col=0; col<matrix.GetLength(1); col++)
    				if (matrix[row,col] > 0)
    					count++;
    	return count;
    }

Runs in quadratic time **O(n * m)** because for each of the n iterations of the outer loop the inner loop will have m iterations when the element of the matrix is even.
If all elements of the matrix are odd, the code runs in linear time **O(n)**. 


**Task 3.** What is the expected running time of the following C# code?

Explain why using Markdown.
Assume the input matrix has size of n * m.

    long CalcSum(int[,] matrix, int row)
    {
    	long sum = 0;
    	for (int col = 0; col < matrix.GetLength(0); col++) 
    		sum += matrix[row, col];
    	if (row + 1 < matrix.GetLength(1)) 
    		sum += CalcSum(matrix, row + 1);
    	return sum;
    }
    
    Console.WriteLine(CalcSum(matrix, 0));

Runs in **O(n * m)** because the for loop has n iterations and the method CalcSum is called m times. The other operations run in constant time.