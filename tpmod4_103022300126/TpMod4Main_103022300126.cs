using tpmod4_103022300126;
using tpmod4_1030223300126;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("1. program kode pos");
        Console.WriteLine("2. program Door Machine");
        Console.WriteLine("0. exit");
        Console.WriteLine("nasukkan pilihan : ");

        string masuk = Console.ReadLine();

        while (masuk != "0")
        {
            if (masuk == "1")
            {
                KodePos Kode = new KodePos();
                Console.WriteLine("masukkan nama kelurahan (kembali untuk ke menu utama) : ");
                string kelurahan = Console.ReadLine() ?? "";

                if (kelurahan != "kembali")
                {
                    string kode = KodePos.getKodePos(kelurahan);
                    Console.WriteLine($"kode pos {kelurahan} : {kode}");
                }
                else
                {
                    Main();
                }

            }
            else if (masuk == "2")
            {
                DoorMachine door = new DoorMachine();
                door.door();
            }
            else if (masuk == "0")
            {
                break;
            }
        }
    }
}