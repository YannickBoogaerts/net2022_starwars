// See https://aka.ms/new-console-template for more information


internal class VaisseauHeritage : Icommand
{
    public string Name => "Héritage de Vaisseau";

    public void Execute()
    {
        VaisseauAncetre v1 = new Millenium("Luc");
        Console.WriteLine(v1.ToString());

        Millenium v2 = new Millenium("Yann");
        v2.decoller();
        v2.atterrir();
        v2.AfficheNom();

        Xwing v3 = new Xwing("Biggs");
        v3.decoller();
        v3.atterrir();
        v3.AfficheNom();
    }
}