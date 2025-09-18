
    namespace Data_structure_demo
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                //List Example
                List<Student> students = new List<Student>();

                // Add Student objects to the list
                Student first = new Student(1, "Alice", 10);
                Student second = new Student(2, "Bob", 90);
                Student third = new Student(3, "Charlie", 78);
                students.Add(first);
                students.Add(second);
                students.Add(third);


                // Access and display each student using foreach
                Console.WriteLine("Student List:");
                foreach (Student s in students)
                {
                    Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
                }

                // Access a specific object by index
                Console.WriteLine($"\nSecond student is: {students[1].name}");


                //Dictionay Example
                Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
                students_dict.Add("firstStudent", first);
                students_dict.Add("seondStudent", second);
                students_dict.Add("thirdStudent", third);


                foreach (KeyValuePair<string, Student> student in students_dict)
                {
                    Console.WriteLine($"ID: {student.Value.id}, Name: {student.Value.name}, Marks: {student.Value.marks}");
                }


                //Hashset Example
                Console.WriteLine("Hashset demo");
                HashSet<Student> students_hashset = new HashSet<Student>();
                students_hashset.Add(first);
                students_hashset.Add(second);
                students_hashset.Add(first);
                students_hashset.Add(third);

                foreach (Student s in students)
                {
                    Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
                }


                //StackDemo


                Stack<Student> students_stack = new Stack<Student>();
                students_stack.Push(first);
                students_stack.Push(second);
                students_stack.Push(third);

                Student pop_stack = students_stack.Pop();
                
                Console.WriteLine($"ID: {pop_stack.id}, Name: {pop_stack.name}, Marks: {pop_stack.marks}");


                //Queue demo
                Console.WriteLine("Queue demo");
                Queue<Student> students_queue = new Queue<Student>();
                students_queue.Enqueue(first);
                students_queue.Enqueue(second);
                students_queue.Enqueue(third);

                Console.WriteLine($"ID: {students_queue.Dequeue().id}, Name: {students_queue.Dequeue().name}, Marks: {students_queue.Dequeue().marks}");



            //LinkedList Demo

            Console.WriteLine("\nLinked List demo");
                LinkedList<Student> students_ll = new LinkedList<Student>();
                students_ll.AddLast(first);
                students_ll.AddLast(second);
                students_ll.AddLast(third);

                Console.WriteLine("Student List:");
                foreach (Student s in students_ll)
                {
                    Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
                }

                //Tuple Demo

                Console.WriteLine("\nTuple List demo");
                //Tuple<Student> students_tuple = new Tuple<Student>(first);
                var students_tuple = Tuple.Create(first, second, third);



                Console.WriteLine("Student 1 Data:");
                Console.WriteLine($"ID: {students_tuple.Item1.id}, Name: {students_tuple.Item1.name}, Marks: {students_tuple.Item1.marks}");
                Console.WriteLine($"ID: {students_tuple.Item2.id}, Name: {students_tuple.Item2.name}, Marks: {students_tuple.Item2.marks}");
                Console.WriteLine($"ID: {students_tuple.Item3.id}, Name: {students_tuple.Item3.name}, Marks: {students_tuple.Item3.marks}");

            }
        }
    }
