public class DynamicArray
{
    private int[] _items;
    private int _count;
    private int _capacity;

    public DynamicArray(int capacity)
    {
        _capacity = capacity > 0 ? capacity : 0;
        _items = new int[_capacity];
        _count = 0;
    }

    public int Get(int i)
    {
        return _items[i];
    }

    public void Set(int i, int n)
    {
        _items[i] = n;
    }

    public void PushBack(int n)
    {
        if (_count == _capacity)
        {
            Resize();
        }

        _items[_count] = n;
        _count++;
    }

    public int PopBack()
    {
        _count--;
        return _items[_count];
    }

    private void Resize()
    {
        _capacity *= 2;
        var newArr = new int[_capacity];

        for (int i = 0; i < _count; i++)
        {
            newArr[i] = _items[i];
        }

        _items = newArr;
    }

    public int GetSize()
    {
        return _count;
    }

    public int GetCapacity()
    {
        return _capacity;
    }
}