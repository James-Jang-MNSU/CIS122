public class Solution {
    public bool JudgeCircle(string moves) {
        if(moves.Length % 2 == 1)
        {
            return false;
        }
        else
        {
            int vertical = 0;
            int horizontal = 0;
            foreach(char letter in moves)
            {
                if(letter == 'U') vertical++;
                else if(letter == 'D') vertical--;
                else if(letter == 'R') horizontal++;
                else if(letter == 'L') horizontal--;
            }
            if (vertical != 0)
            {
                return false;
            }
            if (horizontal != 0)
            {
                return false;
            }
            return true;
        }
    }
}