public class DynamicArray {

    private int capacity;
    private int length;
    private int[] arr;
    
    public DynamicArray(int capacity) {
        this.capacity = capacity;
        this.length = 0;
        this.arr = new int[capacity];
    }

    public int Get(int i) {
        return arr[i];
    }

    public void Set(int i, int n) {
        arr[i] = n;
    }

    public void PushBack(int n) {
        if(capacity == length)
        {
            this.Resize();
        }

        arr[length] = n;
        length++;
    }

    public int PopBack() {
        length--;
        return arr[length];
    }

    private void Resize() {
        capacity = capacity * 2;

        int[] newArray = new int[capacity];

        for(int i = 0; i < length; i++)
        {
            newArray[i] = arr[i];
        }
        arr = newArray;
    }

    public int GetSize() {
        return length;
    }

    public int GetCapacity() {
        return arr.Length;
    }
}
