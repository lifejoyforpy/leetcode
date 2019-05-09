/*
 * @lc app=leetcode.cn id=350 lang=csharp
 *
 * [350] 两个数组的交集 II
 */
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
         Dictionary<int,int> dic1=new Dictionary<int, int>();
           var result = new List<int>();
           for(var i = 0; i < nums1.Length; i++)
           {
               var value = dic1.GetValueOrDefault(nums1[i]);
               if (value== default)
               {
                   value = 1;
                   dic1.Add(nums1[i],value);
               }
               else
               {
                   value++;  
                    dic1.Remove(nums1[i]);
                   dic1.Add(nums1[i],value);
               }
           }
           for (int j = 0; j < nums2.Length; j++)
           {
               var value = dic1.GetValueOrDefault(nums2[j]);
               if (value != default )
               { 
   
                    value--;
                    dic1.Remove(nums2[j]);
                    dic1.Add(nums2[j], value);
                    result.Add(nums2[j]);
               } 
           }
           return result.ToArray();
    }
}

