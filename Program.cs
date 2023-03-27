Console.WriteLine("Enter a number to check if it is a Prime or Composite number >>>");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0 || number == 1)
{
    Console.WriteLine(number + " is a Composite number.");
    
}
else
{
    for(int i = 2; i <= number / 2; i++)
    {
        if(number % i == 0)
        {
            Console.WriteLine(number + " is a Composite Number.");
            return;
        }
    }
    Console.WriteLine(number + " is a Prime number");
    Console.ReadLine();
}
