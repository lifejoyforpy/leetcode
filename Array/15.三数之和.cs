/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 *
 * https://leetcode-cn.com/problems/3sum/description/
 *
 * algorithms
 * Medium (21.54%)
 * Total Accepted:    42.9K
 * Total Submissions: 198.9K
 * Testcase Example:  '[-1,0,1,2,-1,-4]'
 *
 * 给定一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0
 * ？找出所有满足条件且不重复的三元组。
 * 
 * 注意：答案中不可以包含重复的三元组。
 * 
 * 例如, 给定数组 nums = [-1, 0, 1, 2, -1, -4]，
 * 
 * 满足要求的三元组集合为：
 * [
 * ⁠ [-1, 0, 1],
 * ⁠ [-1, -1, 2]
 * ]
 * 
 * 
 */
using System;
using System.Collections;
using System.linq;
public class Solution {
    public IList<IList<int>> ThreeSum (int[] nums) {

        IList<IList<int>> triplet_list = new List<IList<int>> ();
        int len = nums.Length;
        if (len < 2) {

            return triplet_list;
        }
        Array.Sort (nums);
        for (int i = 0; i < len - 2; i++) {
            if (nums[i] > 0)
                break;
            int j = i + 1;
            int k = len-1;
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            while (j < k) {
                 if (nums[i] + nums[j] + nums[k] == 0) {
                    IList<int> triplet = new List<int> ();
                    triplet.Add (nums[i]);
                    triplet.Add (nums[j]);
                    triplet.Add (nums[k]);
                    triplet_list.Add (triplet);                                                         j++;
                    while (j<k && nums[j]==nums[j-1])
                    {
                        j++;
                    }
                }
                if (nums[i] + nums[j] + nums[k] < 0) {
                    j++;
                    while (j<k && nums[j]==nums[j-1])
                    {
                        j++;
                    }
                }
                if (nums[i] + nums[j] + nums[k] > 0) {
                    k--;
                    while(k>j && nums[k]==nums[k+1])
                    {
                        k--;
                    }
                }
                
                
            }

        }
        return triplet_list;
    }
}