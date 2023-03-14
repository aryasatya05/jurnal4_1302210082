// See https://aka.ms/new-console-template for more information
public class kodeBuah
{
    public enum Buah {Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }
    public static string getKodeBuah(Buah fruit)
    {
        String[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return kodeBuah[(int)fruit];
    }
    
}

public class posisiKarakterGame
{
    enum state { berdiri, tengkurap};
    public static void Main()
    {

        string getKodeBuah = kodeBuah.getKodeBuah(kodeBuah.Buah.Kelapa);
        Console.WriteLine(getKodeBuah);
        Console.WriteLine();

        state state1 = state.berdiri;
        String[] kondisi = { "Posisi Stand By", "Posisi Istirahat" };
        while (state1 != null)
        {
            Console.WriteLine(kondisi[(int)state1]);
            Console.WriteLine();
            Console.WriteLine("Masukkan Perintah!");

            String Perintah = Console.ReadLine();
            switch(state1)
            {
                case state.tengkurap:
                    if(Perintah == "Berdiri")
                    {
                        state1 = state.berdiri;
                    }
                    else
                    {
                        state1 = state.tengkurap;
                        Console.WriteLine("Perintah Salah");
                    }
                    break;

                case state.berdiri:
                    if(Perintah == "Tengkurap")
                    {
                        state1 = state.tengkurap;

                    } else
                    {
                        state1 = state.berdiri;
                        Console.WriteLine("Perintah Salah");
                    }
                    break;
            }
        }

    }
}

