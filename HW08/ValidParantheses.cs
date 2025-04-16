public class Solution {
    public bool IsValid(string s) {
        Stack<int> aStack = new Stack<int>();
        foreach(char c in s)
        {
            if(c == '[') aStack.Push(3);
            else if(c == '{') aStack.Push(2);
            else if(c == '(') aStack.Push(1);
            else 
            {
                if(aStack.Count < 1) return false;
                if(c == ']')
                {
                    if(aStack.Pop() != 3) return false;
                } 
                if(c == '}')
                {
                    if(aStack.Pop() != 2) return false;
                } 
                if(c == ')')
                {
                    if(aStack.Pop() != 1) return false;
                } 
            }
        }
        if(aStack.Count != 0) return false;
        return true;
    }
}