namespace LongestSubarrayAfterDeletingOneElement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LongestSubarrayAfterDeletingOneElement longestSubarrayAfterDeletingOneElement = new();
            Console.WriteLine(longestSubarrayAfterDeletingOneElement.LongestSubarray(new int[] { 1, 1, 0, 1 }));
			Console.WriteLine(longestSubarrayAfterDeletingOneElement.LongestSubarray(new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }));
			Console.WriteLine(longestSubarrayAfterDeletingOneElement.LongestSubarray(new int[] { 1, 1, 1 }));
		}
	}
}