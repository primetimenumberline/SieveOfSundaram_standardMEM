long n = 101;
bool[] b = new bool[n];
for(long i = 1; i*2 < n; i++)
{
    for (long j = 1; (i+j+2*i*j)*2 < n; j++)
    {
        b[i+j+2*i*j] = true;
    }
}
Console.WriteLine("2");
for (long i = 1; i*2 < n; i++)
{
    if (!b[i])
        Console.WriteLine("{0}", 2*i+1);
}