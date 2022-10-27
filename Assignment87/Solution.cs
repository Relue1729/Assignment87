namespace Assignment87
{
    internal class Solution
    {
        public static long PrettyNumberCount()
        {
            var lengthToCompare = 6;
            var numBase = 13;
            var possibleSums = (numBase - 1) * lengthToCompare + 1;

            long[] sums = Enumerable.Repeat<long>(0, possibleSums).ToArray();

            for (int i = 0; i < Math.Pow(numBase, lengthToCompare); i++)
            {
                int sum = 0;

                for (int y = i; y >= 1; y /= numBase)
                    sum += y % numBase;

                sums[sum]++;
            }

            long count = 0;
            for (int i = 0; i < possibleSums; i++)
            {
                count += sums[i] * sums[i];
            }

            return count * 13; //accounts for the middle number
        }
    }
}