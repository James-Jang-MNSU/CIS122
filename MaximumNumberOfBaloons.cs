public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int aCount = 0;
        int bCount = 0;
        int lCount = 0;
        int oCount = 0;
        int nCount = 0;
        int balloonCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            // check if amount of remaining characters is enough for 
            // at least one more "balloon"
            int missingLetters = 0;
            if(bCount < 1) { missingLetters++; }
            if(aCount < 1) { missingLetters++; }
            if(lCount < 1)
            {
                missingLetters++;
                missingLetters++;
            }
            else if(lCount < 2) { missingLetters++; }
            if(oCount < 1)
            {
                missingLetters++;
                missingLetters++;
            }
            else if(oCount < 2) { missingLetters++; }
            if(nCount < 1) { missingLetters++; }
            if(missingLetters > text.Length-i) { break; }

            // check for letter b/a/l/o/n
            if(text[i] == 'b')
            {
                bCount++;
            }
            else if(text[i] == 'a')
            {
                aCount++;                
            }
            else if(text[i] == 'l')
            {
                lCount++;
            }
            else if(text[i] == 'o')
            {
                oCount++;
            }
            else if(text[i] == 'n')
            {
                nCount++;
            }
            // if letters for one instance of balloon are counted,
            // increment the count for number of balloons
            // and subtract letter counts
            if(bCount>=1 && aCount>=1 && lCount>=2 && oCount>=2 && nCount>=1)
            {
                bCount = bCount - 1;
                aCount = aCount - 1;
                lCount = lCount - 2;
                oCount = oCount - 2;
                nCount = nCount - 1;
                balloonCount++;
            }
        }
        return balloonCount;
    }
}