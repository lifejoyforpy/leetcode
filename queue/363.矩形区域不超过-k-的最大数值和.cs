/*
 * @lc app=leetcode.cn id=363 lang=csharp
 *
 * [363] 矩形区域不超过 K 的最大数值和
 *
 * https://leetcode-cn.com/problems/max-sum-of-rectangle-no-larger-than-k/description/
 *
 * algorithms
 * Hard (32.44%)
 * Total Accepted:    387
 * Total Submissions: 1.2K
 * Testcase Example:  '[[1,0,1],[0,-2,3]]\n2'
 *
 * 给定一个非空二维矩阵 matrix 和一个整数 k，找到这个矩阵内部不大于 k 的最大矩形和。
 * 
 * 示例:
 * 
 * 输入: matrix = [[1,0,1],[0,-2,3]], k = 2
 * 输出: 2 
 * 解释: 矩形区域 [[0, 1], [-2, 3]] 的数值和是 2，且 2 是不超过 k 的最大数字（k = 2）。
 * 
 * 
 * 说明：
 * 
 * 
 * 矩阵内的矩形区域面积必须大于 0。
 * 如果行数远大于列数，你将如何解答呢？
 * 
 * 
 */
using System.Collections;
// 积分图算法
// f(x,y)=f(x-1,y)+f(x,y-1)+v(x,y)- f(x--1,y-1)
//x=0 y>0   f(x,y)=f(x,y-1)+v(x,y)
// y-0,x>0  f(x,y)=f(x-1,y)+v(x,y)
//x=0;y=0 f(x,y)=v(x,y)
using System.Linq;
public class Solution {
    public int MaxSumSubmatrix (int[][] matrix, int k) {
      int rows = matrix.Length;
            if (rows == 0)
                return 0;
            int cols = matrix[0].Length;
            if (cols == 0)
                return 0;
            int result = int.MinValue;
            if (rows == 0 || cols == 0)
                return 0;
            int[] matrix_sum = new int[rows];
            // 起始列l ，终止列r ，
            // l递增后，matrix_sum 至0重新计算。
            for (int l = 0; l < cols; l++)
            {
                for (int m = 0; m < rows; m++)
                {
                    matrix_sum[m] = 0;
                }
                for (int r = l; r < cols; r++)
                {
                    int? target = null;
                    for (int i = 0; i < rows; i++)
                    {
                        matrix_sum[i] += matrix[i][r];
                    }
                    //求出matrix_sum 里最接近k的组合。
                    int sum = 0;
                    int max_value = int.MinValue;
                    SortedSet<int?> list = new SortedSet<int?>();
                    list.Add(0);
                    for (int j = 0; j < rows; j++)
                    {
                        sum += matrix_sum[j];
                        target = list.FirstOrDefault(x => x >= (sum - k));
                        if (target != null)
                            max_value = Math.Max(sum - target.Value, max_value);
                        list.Add(sum);
                    }
                    result = Math.Max(result, max_value);
                    if (result == k)
                        return k;
                }

            }
            return result;

   }
   // 暴力解法+积分图算法 leetcode 不通过超时
   //{
// int rows = matrix.Length;
//         if (rows == 0)
//             return 0;
//         int cols = matrix[0].Length;
//         if (cols == 0)
//             return 0;
//         //sum[i,j] 是i行j列的数之和，即元素积分图
//         int[, ] matrix_sum = new int[rows, cols];
//         int result = int.MinValue;
//         if (rows == 0 || cols == 0)
//             return 0;
//         for (int i = 0; i < rows; i++) {
//             for (int j = 0; j < cols; j++) {
//                 if (i == 0 && j == 0) {
//                        matrix_sum[i, j] = matrix[0][0];
//                 }
//                 if (i == 0 && j > 0) {
//                        matrix_sum[i, j] = matrix_sum[0, j - 1] + matrix[0][j];
//                 }
//                 if (i > 0 && j == 0) {

//                        matrix_sum[i, j] = matrix_sum[i - 1, 0] + matrix[i][0];
//                 }
//                 if (i > 0 && j > 0) {
//                        matrix_sum[i, j] = matrix_sum[i - 1, j] + matrix_sum[i, j - 1] - matrix_sum[i - 1, j - 1] + matrix[i][j];
//                 }        
//                 for(int m=0;m<=i;m++)
//                 {
//                  for(int n=0;n<=j;n++)
//                  { 
//                      var value =matrix_sum[i,j];;       
//                     if (m>0)
//                     {
//                         value-=matrix_sum[m-1,j];
//                     }
//                     if(n>0)
//                     {
//                       value-=matrix_sum[i,n-1];
//                     }
//                     if(m>0 && n>0)
//                     {
//                        value+=matrix_sum[m-1,n-1];
//                     }
//                     if(value==k)
//                       return k;
//                     else if(value<k)
//                     {
//                       result=Math.Max(result,value);
//                     }
//                  }
//                 }  
//             }
//         }
//         return result;

  // }

}
