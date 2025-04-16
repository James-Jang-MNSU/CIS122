public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> aStack = new Stack<int>();
        foreach(string s in operations)
        {
            if(s == "+")
            {
                int temp1 = aStack.Pop();
                int temp2 = aStack.Peek();
                aStack.Push(temp1);
                aStack.Push(temp1 + temp2);
            }
            else if(s == "D")
            {
                aStack.Push(aStack.Peek()*2);
            }
            else if(s == "C")
            {
                aStack.Pop();
            }
            else
            {
                aStack.Push(Int32.Parse(s));
            }
        }
        int sum = 0;
        while(aStack.Count>0)
        {
            sum += aStack.Pop();
        }
        return sum;
    }
}