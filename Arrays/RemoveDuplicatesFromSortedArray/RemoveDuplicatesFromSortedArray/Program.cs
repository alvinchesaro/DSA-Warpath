public class Solution{

    public static void Main() 
    {
        int[] arrayWithDuplicates = {1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5};

        int arrayCount = RemoveDuplicates(arrayWithDuplicates);

        Console.WriteLine($"Number of Unique Elements: {arrayCount}");
        Console.WriteLine("Modified Array: ");

        for (int i = 0; i < arrayCount; i++){
            Console.WriteLine(arrayWithDuplicates[i]);
        }

    }
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        // Pointer to keep track of our unique Index
        int uniqueIndex = 1;

        // Begin forloop at 1 to check whether the next number is a duplicate
        for (int i = 1; i < nums.Length; i++){
            if(nums[i] != nums[i-1]){
                nums[uniqueIndex] = nums[i];
                uniqueIndex++;
            }
        }

        return uniqueIndex;

    }

}
