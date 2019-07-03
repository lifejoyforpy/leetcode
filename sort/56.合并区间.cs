/*
 * @lc app=leetcode.cn id=56 lang=csharp
 *
 * [56] 合并区间
 */
public class Solution {
    public int[][] Merge(int[][] intervals) {
         var len = intervals.Length;
            if (len == 0)
                return new int[][] { };
            // 排序数组
            var temp = intervals[0];
            var a = 0;
            var b = 0;
            for (int i = 0; i < len; i++)
            {
                var min = intervals[i];
                for (int j = i + 1; j < len; j++)
                {
                    if (min[0] > intervals[j][0])
                        min = intervals[j];

                }
                // 交换位置
                a = intervals[i][0];
                b = intervals[i][1];
                intervals[i][0] = min[0];
                intervals[i][1] = min[1];
                min[0] = a;
                min[1] = b;

            }


            var array = new List<int[]>();
            var index = 0;

            foreach (var item in intervals)
            {
                if (index == 0)
                {
                    array.Add(item);
                    index++;
                }
                else
                {
                    //两元素有交集 则 合并
                    // 一种是包含关系（1，4）（2，3）则不需要操作，放弃元素（2，3）
                    //一种交集（1，4）（2，5）合并
                    //一种 没交集（1，4）（5，6）则两 元素 
                    if (array[index - 1][0] <= item[0] && item[0] <= array[index - 1][1] && item[1] >= array[index - 1][1])
                    {
                        array[index - 1][1] = item[1];
                    }

                    else if (item[0] > array[index - 1][1])
                    {
                        array.Add(item);
                        index++;
                    }
                }

            }
            
            return array.ToArray();
    }
}

