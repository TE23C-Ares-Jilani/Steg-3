static void Square()
{
    int number = 0;
    string pnum = Console.ReadLine();
    bool success = int.TryParse(pnum, out number);
    
    Console.ReadLine();
}
Square();

