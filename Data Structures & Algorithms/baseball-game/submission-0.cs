public class Solution {
    public int CalPoints(string[] operations) {
        int n = operations.Length;
        List<int> record = new List<int>();

        for(int i = 0; i < n; i++)
        {
            // 1. If it's a number, parse and add it
            if(int.TryParse(operations[i], out int score)) {
                record.Add(score);
            }
            // 2. If it's "+"
            else if(operations[i] == "+") {
                int sum = record[record.Count - 1] + record[record.Count - 2];
                record.Add(sum);
            }
            // 3. If it's "C"
            else if(operations[i] == "C") {
                record.RemoveAt(record.Count - 1);
            }
            // 4. If it's "D" (Double)
            else if(operations[i] == "D") {
                int doubleScore = record[record.Count - 1] * 2;
                record.Add(doubleScore);
            }
        }
        
        // Return the sum of all elements in the record list
        int totalSum = 0;
        foreach(int num in record) {
            totalSum += num;
        }
        return totalSum;
    }
}