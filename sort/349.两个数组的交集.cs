/*
 * @lc app=leetcode.cn id=349 lang=csharp
 *
 * [349] 两个数组的交集
 */
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
         int len1 = nums1.Length;
            int len2 = nums2.Length;
            if (len1 == 0 || len2 == 0)
                return new int[] { };
            List<int> ls = new List<int>();
           
             for (int i = 0; i < len1; i++)
               {
                    for(int j=0;j<len2;j++)
                    { 
                       if(nums1[i]==nums2[j])
                        {
                            ls.Add(nums1[i]);
                            continue;
                        }
                    }
               }
           
            var result = ls.Distinct().ToArray();
            return result;
    }

}

