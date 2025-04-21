public class Solution {
    public bool IsHappy(int n) {
        List<int> previous = new List<int>();
        while(n != 1 && previous.Contains(n) == false)
        {
            previous.Add(n);
            string numString = n.ToString();
            int newNum = 0;
            foreach(char c in numString)
            {
                newNum += (int)Math.Pow((c-'0'), 2);
            }
            n = newNum;
        }
        return n == 1;
    }
}