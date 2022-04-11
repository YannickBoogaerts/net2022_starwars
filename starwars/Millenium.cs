// See https://aka.ms/new-console-template for more information


internal class Millenium : VaisseauAncetre
{


    public Millenium(string nomDuPilote):base(nomDuPilote,10)
    { }

    public override void AfficheNom()
    {
        Console.WriteLine("Millenium"); ;
    }
}