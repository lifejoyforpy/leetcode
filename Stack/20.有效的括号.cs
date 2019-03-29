/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 *
 * https://leetcode-cn.com/problems/valid-parentheses/description/
 *
 * algorithms
 * Easy (37.08%)
 * Total Accepted:    58.3K
 * Total Submissions: 157.1K
 * Testcase Example:  '"()"'
 *
 * 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。
 * 
 * 有效字符串需满足：
 * 
 * 
 * 左括号必须用相同类型的右括号闭合。
 * 左括号必须以正确的顺序闭合。
 * 
 * 
 * 注意空字符串可被认为是有效字符串。
 * 
 * 示例 1:
 * 
 * 输入: "()"
 * 输出: true
 * 
 * 
 * 示例 2:
 * 
 * 输入: "()[]{}"

 * 输出: true
 * 
 * 
 * 示例 3:
 * 
 * 输入: "(]"
 * 输出: false
 * 
 * 
 * 示例 4:
 * 
 * 输入: "([)]"
 * 输出: false
 * 
 * 
 * 示例 5:
 * 
 * 输入: "{[]}"
 * 输出: true
 * 
 */
using System.Collections;
using system;
public class Solution {
    public bool IsValid (string s) {
        Stack<char> _stack = new Stack<char> ();
        foreach (var c in s) {
            if (c == '(' || c == '{' || c == '[') {
                _stack.Push (c);
            } else {
                if (_stack.Count == 0)
                    return false;
                var element = _stack.Pop ();
                if (element == '(' && c != ')') {
                    return false;
                }
                if (element == '{' && c != '}') {
                    return false;
                }
                if (element == '[' && c != ']') {
                    return false;
                }
            }
        }
        if (_stack.Count > 0)
            return false;
        return true;
    }
}