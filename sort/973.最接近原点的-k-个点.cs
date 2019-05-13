/*
 * @lc app=leetcode.cn id=973 lang=csharp
 *
 * [973] 最接近原点的 K 个点
 */
public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        List<int[]> result=new List<int[]>(); 
            if (points.Length < K)
            {
                throw  new Exception($"参数异常");
            }
            Dictionary<int,List<int[]>> dic=new Dictionary<int, List<int[]>>();
            for (int i = 0; i < points.Length; i++)
            {            
                int key = 0;
                for (int j = 0; j < points[i].Length; j++)
                {
                    key += Math.Abs( points[i][j])*Math.Abs( points[i][j]);
                }
                var value = dic.GetValueOrDefault(key);
                
                // add 
                if (value == default)
                {
                    List<int[]> ls =new List<int[]>();            
                    ls.Add(points[i]);
                    dic.Add(key,ls);
                }
                else
                {
                    value.Add(points[i]);
                }
            }

            var dic1 = dic.OrderBy(x => x.Key);
            int nums = K;
        
            foreach (var keyparis in dic1)
            {
                int count= keyparis.Value.Count;
                var value = keyparis.Value.ToArray();
                if (nums <= count)
                {         
                    result.AddRange(value.Take(nums).ToArray());
                    break;
                }
                else
                {
                    result.AddRange(value);
                }
                nums-=count;                
            }
            return result.ToArray();
    }
}

