public class LRUCache {

  
    private readonly Dictionary<int, LinkedListNode<(int Key, int Value)>> _data = new();
    private readonly LinkedList<(int Key, int Value)> _order = new();
    private readonly int _capacity;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
    }

    public int Get(int key)
    {
        if (!_data.TryGetValue(key, out var node))
        {
            return -1;
        }

        _order.Remove(node);
        _order.AddFirst(node);

        return node.Value.Value;
    }

    public void Put(int key, int value)
    {
        if (_data.TryGetValue(key, out var node))
        {
            Update(node, value);
            return;
        }

        if (_order.Count < _capacity)
        {
            Add(key, value);
        }
        else
        {
            Pop();
            Add(key, value);
            
        }
    }

    private void Add(int key, int value)
    {
        var node = new LinkedListNode<(int, int)>((key, value));
        _order.AddFirst(node);
        _data.Add(key, node);
    }

    private void Update(LinkedListNode<(int Key, int Value)> node, int value)
    {
        _order.Remove(node);
        _order.AddFirst(node);
        node.Value = (node.Value.Key, value);
    }

    private LinkedListNode<(int Key, int Value)> Pop()
    {
        var node = _order.Last;
        _order.RemoveLast();
        _data.Remove(node!.Value.Key);

        return node;
    }
}
