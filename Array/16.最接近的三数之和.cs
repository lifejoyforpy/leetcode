/*
 * @lc app=leetcode.cn id=16 lang=csharp
 *
 * [16] 最接近的三数之和
 *
 * https://leetcode-cn.com/problems/3sum-closest/description/
 *
 * algorithms
 * Medium (39.50%)
 * Total Accepted:    19.8K
 * Total Submissions: 50.1K
 * Testcase Example:  '[-1,2,1,-4]\n1'
 *
 * 给定一个包括 n 个整数的数组 nums 和 一个目标值 target。找出 nums 中的三个整数，使得它们的和与 target
 * 最接近。返回这三个数的和。假定每组输入只存在唯一答案。
 * 
 * 例如，给定数组 nums = [-1，2，1，-4], 和 target = 1.
 * 
 * 与 target 最接近的三个数的和为 2. (-1 + 2 + 1 = 2).
 * 
 * 
 */
public class Solution {
    public int ThreeSumClosest (int[] nums, int target) {
        Array.Sort (nums);
        int len = nums.Length;
        if (len <= 2) {
            return 0;
        }
        int result = int.MaxValue;
        int value = 0;
        int divd_value = 0;
        int min_divdvalue = int.MaxValue;
        for (int i = 0; i < len; i++) {
            int j = i + 1;
            int k = len - 1;
            while (j < k) {
                value = nums[i] + nums[j] + nums[k];
                divd_value = (value - target) < 0 ? (value - target) * -1 : (value - target);
                if (divd_value == 0)
                    return value;
                if (divd_value < min_divdvalue) {
                    min_divdvalue = divd_value;
                    result = value;
                }
                if (value < target) {
                    j++;
                } else {
                    k--;
                }

            }

        }
        return result;
    }
   
}
