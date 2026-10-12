internal class Bai1
{
    private static void Main(string[] args)
    {
        //Bai1
        Console.WriteLine("Nhap 3 so nguyen a, b, c: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        long a = long.Parse(parts[0]);
        long b = long.Parse(parts[1]);
        long c = long.Parse(parts[2]);
        long max = a;
        if (b>max)
        {
            max = c;
        }
        if (c > max)
        {
            max = c;
        }
        long min = a;
        if (b < min)
        {
            min = b;
        }
        if (c < min)
        {
            min = c;
        }
        long tong = a + b + c;
        double tbc = (double)tong/3;
        Console.WriteLine($"So lon nhat: {max}; so nho nhat: {min}");
        Console.WriteLine($"Tong: {tong}; trung binh cong 3 so: {tbc}");
    }
}