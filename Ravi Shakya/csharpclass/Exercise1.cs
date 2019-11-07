public class Exercise1
{
    public void ByteArrays()
        {
            byte[] bytes = { 1, 5, 9, 10, 14, 15, 17, 20, 24, 25, 30, 35, 40, 43, 45, 50, 51, 55, 60};
            foreach (var x in bytes)
        {
            if(x % 5==0)
            System.Console.WriteLine(x);
        }
        }
}