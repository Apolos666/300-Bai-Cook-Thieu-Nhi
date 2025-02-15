var intervals = new int[][] {
    [1,2],[3,5],[6,7],[8,10],[12,16]
};

var newInterval = new int[] {4,8};

var result = Insert(intervals, newInterval);

foreach (var item in result)
{
    Console.WriteLine($"[{item[0]},{item[1]}]");
}

int[][] Insert(int[][] intervals, int[] newInterval)
{
    var result = new List<int[]>();
        
    var i = 0;
    while (i < intervals.Length && intervals[i][1] < newInterval[0]) {
        result.Add(intervals[i]);
        i++;
    } 
        
    while (i < intervals.Length && intervals[i][0] <= newInterval[1]) {
        newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
        newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
        i++;
    }
        
    result.Add(newInterval);
        
    while (i < intervals.Length) {
        result.Add(intervals[i]);
        i++;
    }
        
    return result.ToArray();
}