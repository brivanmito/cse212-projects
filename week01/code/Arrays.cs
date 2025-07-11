public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Create an array to hold the multiples.
        // The size of the array will be equal to the 'length' parameter.
        var multiples = new double[length];

        // Step 2: Use a loop to calculate each multiple.
        // Since array indexes start at 0, we loop from 0 to length - 1.
        // For each index i, store the (i + 1) * number in the array.

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return the array of multiples.
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        int n = data.Count;
        // Create a list depending the quantity of the initial list
        List<int> rotated = new List<int>(new int[n]);

        // Place each element in its new rotated position
        for (int i = 0; i < n; i++)
        {
            int newIndex = (i + amount) % n;
            rotated[newIndex] = data[i];
        }

        // Copy the rotated elements back to the original list
        for (int i = 0; i < n; i++)
        {
            data[i] = rotated[i];
        }


    }
}
