public class Exercise1
{
    public void ByteArrays()
        {
            byte[] bytes = { 3, 10, 8, 25 ,40,100};
            foreach (var x in bytes)
        {
            if(x % 5==0)
            System.Console.WriteLine(x);
        }
        }
}