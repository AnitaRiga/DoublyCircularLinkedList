/*
Implement a doubly circularly linked list in C#. Create these separate functions:
1.addNode() / insert() – to add a new element at:   
o   the beginning of the list,                          DONE
o	some position in the list,                            DONE
o	the end of the list,                                  DONE
2.	deleteNode() – to delete an element at:  
o   the beginning of the list,                          DONE
o	some position in the list,                            DONE
o	the end of the list,                                  DONE
3.	search() – to find an element in the list,          DONE
4.	isEmpty() – to check whether a list is empty,       DONE
5.	display() – to print a list.                        DONE
*/

using DoublyCircularLinkedList;

DoublyLinkedList studentsList = new DoublyLinkedList();

studentsList.Insert("Anna Red");
studentsList.Insert("Alex Green");
studentsList.Insert("Tom Grey");
studentsList.Insert("Ella Yellow");
studentsList.Insert("John Orange");
studentsList.Insert("Peter Blue");
studentsList.Insert("Eric Black");

studentsList.Display();

studentsList.DeleteTheLastElement();
studentsList.Display();

studentsList.DeleteTheFirstElement();
studentsList.Display();

studentsList.AddFirst("Mary White");
studentsList.Insert("Bob Purple");
studentsList.Display();

studentsList.DeleteAfter("John Orange");
studentsList.Display();

studentsList.InsertAfter("Ella Yellow", "Leo Pink");
studentsList.Display();

studentsList.SearchForTheElement("Ella Yellow");
studentsList.SearchForTheElement("XXX");

studentsList.CheckWhetherListIsEmpty();
