/*
 * @lc app=leetcode.cn id=1030 lang=csharp
 *
 * [1030] 距离顺序排列矩阵单元格
 */
public class Solution {
    public int[][] AllCellsDistOrder(int R, int C, int r0, int c0) {
        int dis1 = r0>(R-1)/2?r0:(R-r0-1);
            int dis2 = c0>(C-1)/2?c0:(C-c0-1);
            int max_dis = dis1 + dis2;
            int dis = 0;
            Dictionary<int, List<int[]>> dic = new Dictionary<int, List<int[]>>();
            int[][] result = new int[R*C][];
            for(int i=0;i<R;i++)
            { 
               for(int j = 0; j < C; j++) {

                   dis = Math.Abs(r0  - i)+Math.Abs(c0-j);
                    var item = dic.GetValueOrDefault(dis);
                    if(item==null)
                    {
                        var ls = new List<int[]>();
                        ls.Add(new int[] { i, j });
                        dic.Add(dis, ls);          
                    }
                    else{
                       
                        item.Add(new int[] { i, j });
                        //dic.Add(dis, item);
                    }

               }
            
            }
            int index = 0;
            for(int i=0;i<=max_dis;i++)
            {
                var ay = dic.GetValueOrDefault(i).ToArray();
                ay.CopyTo(result, index);
                index += ay.Count();
            }

            return result;
    }
}

