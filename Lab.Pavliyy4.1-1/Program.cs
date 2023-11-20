// сред 4.1
Random rand = new Random();
const int n = 17;
int[] a = new int[n];
int sum = 0, sum1 = 0, n1, n2;

for (int i = 0; i < n; i++)
{
    a[i] = rand.Next(10, 100);
    Console.Write(a[i] + " ");
}
Console.WriteLine("\n\n");
for (int i = 0; i < n; i++)
{
    n1 = a[i] / 10; n2 = a[i] % 10;
    sum1 += n1 + n2;

    Console.WriteLine(i + 1 + ": " + sum1);
    sum += sum1;
    sum1 = 0;
}

Console.WriteLine("\n\n" + sum);
Console.ReadLine();