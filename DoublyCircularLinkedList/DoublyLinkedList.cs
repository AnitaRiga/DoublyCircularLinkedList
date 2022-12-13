namespace DoublyCircularLinkedList
{
    public class DoublyLinkedList
    {
        public Node head;
        public Node tail;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }
        public void Insert(string newStudent)
        {
            Node newNode = new Node(newStudent);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
            }
            tail = newNode;
        }

        // Adding a node at the beginning of the list.
        public void AddFirst(string newStudent)
        {
            // Allocate node and put in the data.
            Node newNode = new Node(newStudent);

            // Make next of new node as head and previous as NULL.
            newNode.next = head;
            newNode.prev = null;

            // Change prev of head node to new node.
            if (head != null)
            {
                head.prev = newNode;

                // Move the head to point to the new node.
                head = newNode;
            }
        }

        // Inserting a new node after a given node.
        public void InsertAfter(string prevStudent, string newStudent)
        {
            Node newNode = new Node(newStudent);

            // Find a node having value 'prevStudent' and next node of it.
            Node prevNode = head;

            while (prevNode.student != prevStudent)
            {
                prevNode = prevNode.next;
            }
            Node next = prevNode.next;

            // Insert newNode between prevNode and the next one.
            prevNode.next = newNode;
            newNode.prev = prevNode;
            newNode.next = next;
            next.prev = newNode;
        }

        // Deleting the first node.
        public void DeleteTheFirstElement()
        {
            if (head == null)
            {
                Console.WriteLine("The List is empty." + "\r\n");
            }
            else
            {
                head = head.next;
                tail.prev = head;
            }
        }

        //  Deleting an element in the list.
        public void DeleteAfter(string prevStudent)
        {
            Node prevNode = head;
            while (prevNode.student != prevStudent)
            {
                prevNode = prevNode.next;
            }
            prevNode.next = prevNode.next.next;
            prevNode.next.prev = prevNode;
        }

        // Deleting the last node.
        public void DeleteTheLastElement()
        {
            if (tail == null)
            {
                Console.WriteLine("The List is empty." + "\r\n");
            }
            else
            {
                tail = tail.prev;
                head.prev = tail;
            }
        }

        // Searching for an element.
        public void SearchForTheElement(string studentName)
        {
            // Create a current node pointing to head.
            Node current = new Node(studentName);
            current = head;

            // Create two variables: found - to track search, i - to track current index.
            int found = 0;
            int i = 0;

            /* if the current node is not null, check the node value with studentName.
            If found, update variables and break the loop, 
            else continue searching till current node is not null */
            if (current != null)
            {
                while (current != null)
                {
                    i++;
                    if (current.student == studentName)
                    {
                        found++;
                        break;
                    }
                    current = current.next;
                }

                if (found == 1)
                {
                    Console.WriteLine("'{0}' is found at position {1} / index {2}." + "\r\n", studentName, i, i - 1);
                }
                else Console.WriteLine("'{0}' is NOT found." + "\r\n", studentName);
            }

            // If the current node is null at the start, the list is empty.
            else
            {
                Console.WriteLine("The List is empty." + "\r\n");
            }
        }

        // Checking whetner the list is empty.
        public void CheckWhetherListIsEmpty()
        {
            string message;

            if (head == null)
            {
                message = "The List is Empty.";
            }
            else
            {
                message = "The List is NOT Empty.";
            }

            Console.WriteLine(message);
        }

        // Printing the elements.
        public void Display()
        {
            Node node = head;
            while (node != tail.next)
            {
                Console.Write(node.student + " -> ");
                node = node.next;
            }

            Console.WriteLine("HEAD" + "\r\n");
        }
    }
}