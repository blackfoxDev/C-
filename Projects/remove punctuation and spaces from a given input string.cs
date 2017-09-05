// Method-1# using Regular Expression
 private string GetValidStringUsingRegex(string originalString)
 {
 string validString = string.Empty;
 validString = System.Text.RegularExpressions.Regex.Replace
           (originalString, @"[^\w]", string.Empty);
 return validString;
 }

 // Method-2# using Lambda Expression
 private string GetValidStringUsingLambda(string originalString)
 {
 var result = new String(originalString.Where
       (ch => !Char.IsPunctuation(ch) && !Char.IsWhiteSpace(ch)).ToArray());
 return result;
 }
