internal class Exercise1
{
    public void ByteArrays()
    {
        byte[] bytes= {12, 34, 23, 25, 55}; 
        foreach (var i in bytes)
        {
            if (i % 5 == 0)
            System.Console.WriteLine(i);
        }
    }
}
