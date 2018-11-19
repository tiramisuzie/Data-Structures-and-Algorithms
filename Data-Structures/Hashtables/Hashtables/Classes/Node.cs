namespace Hashtables.Classes
{
    public class Node
    {
        public string Key { get; set; }

        public object Value { get; set; }
        
        public Node(string key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
