bool condition = true;

while (condition)
{
    Console.WriteLine($@"
    Choose an Option:
    1. Add Book
    2. Add Magazine
    3. Show All Items
    4. Borrow Item
    5. Return Item
    6. Exit
");

    int Option = Convert.ToInt32(Console.ReadLine());
}