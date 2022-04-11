// See https://aka.ms/new-console-template for more information


internal class VaisseauChampPartage : Icommand
{
    public string Name => "Champ partagé";

    public void Execute()
    {
        VaisseauVolant v1 = new VaisseauVolant("Luc");
        VaisseauVolant v2 = new VaisseauVolant("Lea",5);

        v1.decoller();
        v1.decoller();
        v2.decoller();
        v1.atterrir();
        v1.atterrir();
        Console.WriteLine("Nombre de vaisseau en vol : {0}", VaisseauVolant.CptEnVol);
    }
}