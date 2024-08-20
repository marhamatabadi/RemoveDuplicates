namespace Solution
{
    public static class Main
    {
        public static int RemoveDuplicates(ref int[] nums)
        {

            int writeIndex = 1;
            for (int readIndex = 1; readIndex < nums.Length; readIndex++)
            {
                if (nums[readIndex] != nums[writeIndex - 1])
                {
                    writeIndex++;
                    nums[writeIndex - 1] = nums[readIndex];

                }
            }
            nums = nums[0..writeIndex];
            return writeIndex;

        }

    }
}
