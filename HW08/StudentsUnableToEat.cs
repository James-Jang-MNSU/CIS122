public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Dictionary<int, int> aDict = new Dictionary<int, int>();
        aDict.Add(0, 0);
        aDict.Add(1, 0);
        foreach(int st in students)
        {
            aDict[st]++;
        }

        foreach(int sw in sandwiches)
        {
            if(aDict[sw] > 0)
            {
                aDict[sw]--;
            }
            else
            {
                return aDict[0] + aDict[1];
            }
        }
        return 0;

        /*
        Stack<int> aStack = new Stack<int>();
        Queue<int> aQueue = new Queue<int>();
        for(int i = 0; i<students.Length; i++)
        {
            aStack.Push(sandwiches[students.Length-i-1]);
            aQueue.Enqueue(students[i]);
        }

        int rotation = 0;
        while(aQueue.Count > 0)
        {
            if(aQueue.Peek() == aStack.Peek())
            {
                aQueue.Dequeue();
                aStack.Pop();
                rotation = 0;
            }
            else
            {
                if(rotation == aQueue.Count)
                {
                    return rotation;
                }
                else
                {
                    aQueue.Enqueue(aQueue.Dequeue());
                    rotation++;   
                }
            }
        }
        return aQueue.Count;
        */
    }
}