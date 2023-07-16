using Problems;

#region TwoSum

var twoSum = new TwoSumSolution();
var twoSumResponse = twoSum.TwoSum2(twoSum.nums2, 6);

ResponseOutput.WriteIEnumerable(twoSumResponse);

#endregion
#region PalindromeNumber

var inPalindrome = new Problems.PalindromeNumber.Solution();
var inPalindromeResponse = inPalindrome.IsPalindrome4(inPalindrome.x);
//Problems.PalindromeNumber.ResponseOutput.Write(inPalindromeResponse);

#endregion
#region RomanToInteger

var romanToInteger = new Problems.RomanToInteger.Solution();
var romanToIntegerResponse = romanToInteger.RomanToInt(romanToInteger.s3);
//Problems.RomanToInteger.ResponseOutput.Write(romanToIntegerResponse);
#endregion
#region LongestCommonPrefix

var longestCommonPrefix = new Problems.LongestCommonPrefix.Solution();
var longestCommonPrefixResponse = longestCommonPrefix.LongestCommonPrefix(longestCommonPrefix.strs2);
//Problems.LongestCommonPrefix.ResponseOutput.Write(longestCommonPrefixResponse);

#endregion
#region ValidParentheses

var validParentheses = new Problems.ValidParentheses.Solution();
var validParenthesesResponse = validParentheses.IsValid(validParentheses.s4);
//Problems.ValidParentheses.ResponseOutput.Write(validParenthesesResponse);

#endregion


