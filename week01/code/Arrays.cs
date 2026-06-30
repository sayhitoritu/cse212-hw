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
        // Step 1: Create a new array with the required length.
        // Step 2: Loop through each index in the array.
        // Step 3: Calculate the multiple by multiplying the starting number
        //         by (index + 1).
        // Step 4: Store the calculated value in the array.
        // Step 5: Return the completed array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Find the starting index of the elements that will move
        //         to the front of the list.
        // Step 2: Copy those elements into a temporary list.
        // Step 3: Remove those elements from the end of the original list.
        // Step 4: Insert the copied elements at the beginning of the list.

        int startIndex = data.Count - amount;

        List<int> temp = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, temp);
    }
}
