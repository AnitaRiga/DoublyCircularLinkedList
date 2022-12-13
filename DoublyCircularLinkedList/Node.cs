namespace DoublyCircularLinkedList
{
    //Node structure.
    public class Node
    {
        public Node prev;   //Stores the link to the next node.
        public string student; //Stores the value of the element.
        public Node next;   //Stores the link to the previous node.

        // Constructor to create a new node
        // next and prev is by default initialized as null
        public Node(string s) 
        {
            this.student = s;
        }
    };
}