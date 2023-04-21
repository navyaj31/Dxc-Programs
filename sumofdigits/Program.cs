int i, sum = 0, j;
Console.WriteLine("Enter a five digit number:");
i = Convert.ToInt32(Console.ReadLine());
while(i > 0)
{
    j = i % 10;
    sum = sum + j;
    i = i / 10;
}
Console.WriteLine("Sum is=" + sum);


