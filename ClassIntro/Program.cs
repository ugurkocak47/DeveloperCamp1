// See https://aka.ms/new-console-template for more information



Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Kerem Varış";
kurs2.IzlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Berkay Bilgin";
kurs3.IzlenmeOrani = 80;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "C++";
kurs4.Egitmen = "Murat Kurtboğan";
kurs4.IzlenmeOrani = 100;

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi +"      " + kurs.Egitmen + "       " + "Izlenme Orani:" + kurs.IzlenmeOrani);
}
class Kurs
{
    //prop snippet
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}
