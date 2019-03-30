/*
 * @lc app=leetcode.cn id=42 lang=csharp
 *
 * [42] 接雨水
 *
 * https://leetcode-cn.com/problems/trapping-rain-water/description/
 *
 * algorithms
 * Hard (42.79%)
 * Total Accepted:    11.1K
 * Total Submissions: 25.8K
 * Testcase Example:  '[0,1,0,2,1,0,1,3,2,1,2,1]'
 *
 * 给定 n 个非负整数表示每个宽度为 1 的柱子的高度图，计算按此排列的柱子，下雨之后能接多少雨水。
 * 
 * 
 * 
 * 上面是由数组 [0,1,0,2,1,0,1,3,2,1,2,1] 表示的高度图，在这种情况下，可以接 6 个单位的雨水（蓝色部分表示雨水）。 感谢
 * Marcos 贡献此图。
 * 
 * 示例:
 * 
 * 输入: [0,1,0,2,1,0,1,3,2,1,2,1]
 * 输出: 6
 * 
 */
using System.Collections;
public class Solution {
    public int Trap (int[] height) {
        int volumn=0;
        if(height.Length<2)
        {
            return 0;
        }
        //求出最高点
       (int,int) _maxHeight=(0,0);
       for(int i=0;i<height.Length;i++)
       {
          if(height[i]>_maxHeight.Item2)
          {
              _maxHeight=(i,height[i]);
          }
       }
       //遇到下降节点；一定有雨水 ，如果
       //临时左边最大值
       int temp=height[0];
       for(int i=1;i<_maxHeight.Item1;i++)
       {
         if(height[i]>temp)
         {
             temp=height[i];
         }
         else{
             volumn+=temp-height[i];
         }
       }
       int right_tmep=height[height.Length-1];
       for(int i=height.Length-2;i>_maxHeight.Item1;i--)
       {
         if(height[i]>right_tmep)
         {
             right_tmep=height[i];
         }
         else{
             volumn+=right_tmep-height[i];
         }
       }
        return volumn;
    }
}