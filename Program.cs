Console.Title = "Aplikasi Calculator";

Console.Write("Pilih menu calculator: ");
Console.WriteLine();
Console.WriteLine("1. Penjumlahan");
Console.WriteLine("2. Pengurangan");
Console.WriteLine("3. Perkalian");
Console.WriteLine("4. Pembagian");
Console.WriteLine();
Console.Write("Input nomor menu [1..4]: ");
int pilihan = int.Parse(Console.ReadLine());
Console.WriteLine();
switch (pilihan)
{
    case 1:
        Console.Write("Inputkan nilai a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Inputkan nilai b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hasil penambahan " + a + " + " + b + " = " + Penambahan(a, b));
        break;
    case 2:
        Console.Write("Inputkan nilai a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Inputkan nilai b = ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
        break;
    case 3:
        Console.Write("Inputkan nilai a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Inputkan nilai b = ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
        break;
    case 4:
        Console.Write("Inputkan nilai a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Inputkan nilai b = ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
        break;
    default:
        Console.WriteLine("Maaf menu yang Anda pilih tidak tersedia");
        break;
}
Console.WriteLine();
Console.WriteLine("Tekan sembarang key untuk keluar");
Console.ReadKey();

static int Penambahan(int a, int b)
{
    return a + b;
}
static int pengurangan(int a, int b)
{
    return a - b;
}
static int Perkalian(int a, int b)
{
    return a * b;
}
static int Pembagian(int a, int b)
{
    return a / b;
}