/*
 * @lc app=leetcode.cn id=922 lang=csharp
 *
 * [922] 可能的二分法
 */
public class Solution {
    public int[] SortArrayByParityII(int[] A) {
         int len = A.Length;

            int j = 1;

            // 从左为 基数时候，从
            for (int i = 0; i < len - 1; i= i + 2)
            {
                //当需要换位数
                if (( A[i] & 1)!= 0)
                {
                        //查找换位数，找到立刻返回
                        while ((A[j] & 1) != 0)
                        {
                            j += 2;
                        }
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;

                  }
               
            }
            return A;
    }
}

