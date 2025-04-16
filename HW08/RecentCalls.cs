public class RecentCounter {
    private List<int> requests = new List<int>();

    public List<int> Requests
    {
        get { return this.requests; }
        set { this.requests = value; }
    }

    public RecentCounter() {
        this.Requests = new List<int>();
    }
    
    public int Ping(int t) {
        this.Requests.Add(t);

        int inRangeReq = 0;
        for(int i = 0; i<this.Requests.Count; i++)
        {
            if(this.Requests[i] >= t-3000) inRangeReq++;
        }
        return inRangeReq;
    }
}