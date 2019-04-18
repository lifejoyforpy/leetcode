/*
 * @lc app=leetcode.cn id=976 lang=csharp
 *
 * [976] 最小面积矩形
 *
 * https://leetcode-cn.com/problems/largest-perimeter-triangle/description/
 *
 * algorithms
 * Easy (56.86%)
 * Total Accepted:    3.3K
 * Total Submissions: 6K
 * Testcase Example:  '[2,1,2]'
 *
 * 给定由一些正数（代表长度）组成的数组 A，返回由其中三个长度组成的、面积不为零的三角形的最大周长。
 * 
 * 如果不能形成任何面积不为零的三角形，返回 0。
 * 
 * 
 * 
 * 
 * 
 * 
 * 示例 1：
 * 
 * 输入：[2,1,2]
 * 输出：5
 * 
 * 
 * 示例 2：
 * 
 * 输入：[1,2,1]
 * 输出：0
 * 
 * 
 * 示例 3：
 * 
 * 输入：[3,2,3,4]
 * 输出：10
 * 
 * 
 * 示例 4：
 * 
 * 输入：[3,6,2,3]
 * 输出：8
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 3 <= A.length <= 10000
 * 1 <= A[i] <= 10^6
 * 
 * 
 */
public class Solution {
    public int LargestPerimeter(int[] A) {
          int result = 0;
            // 三个数 任意两个数之和大于第三个才可以构成三角形
            if (A.Length < 3 || A.Length>10000)
                return 0;
            var  b= A.OrderByDescending(x => x).ToArray();
            //从小到大排序
            // 如果存在最大的为，i,j ,k
            //则i+2=j+1=k
            // 如果不是因为a[i]+a[j]>a[k]
            //如果ijk之间存在一个l
            //a[l]+a[k]>a[k],
            for(int i=0;i<b.Length-2;i++)
            { 
                if(b[i]<(b[i+1]+b[i+2])){
                    return (b[i] + b[i + 1] + b[i +2]);
                }
            }
            return result;
    }
}

