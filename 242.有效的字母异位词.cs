/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */
public class Solution {

    //实际判断两字符串自字符是否相等，排序后的字符串是否相等
    public bool IsAnagram(string s, string t) {
        
         int[] array = new int[26];
            var sc = s.ToCharArray();
            var tc = t.ToCharArray();
            if (sc.Count() != tc.Count())
                return false;
            for(int i=0;i<sc.Count();i++)
            { 
               array[sc[i]-'a']++;
            }
            for(int j=0;j<tc.Count();j++)
            {

                if (array[tc[j] - 'a'] == 0) return false;
                array[tc[j] - 'a']--;
            }
            return true;
    }
    //粗略方法
    //   var sc = s.ToCharArray();
    //         var tc = t.ToCharArray();
    //         if (sc.Count() != t.Count())
    //             return false;
    //         Array.Sort(sc);
    //         Array.Sort(tc);
    //     if (string.Concat<char>(tc) == string.Concat<char>(sc))

    //             return true;
    //         return false;
}

