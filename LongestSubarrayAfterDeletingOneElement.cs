namespace LongestSubarrayAfterDeletingOneElement
{
	internal class LongestSubarrayAfterDeletingOneElement
	{
		public int LongestSubarray(int[] nums)
		{
			int zeroCount = 0;
			int leftBound = 0;
			int longestSubarray = 0;
			int n = nums.Length;
			for (int rightBound = 0; rightBound < n; ++rightBound)
			{
				zeroCount += (nums[rightBound] == 0) ? 1 : 0;
				while(zeroCount > 1)
				{
					zeroCount -= (nums[leftBound] == 0) ? 1 : 0;
					++leftBound;
				}
				longestSubarray = Math.Max(longestSubarray, rightBound - leftBound);
			}
			return longestSubarray;
		}
	}
}
