// See https://aka.ms/new-console-template for more information


internal class VaisseauDeBase : Icommand
{
    public string Name
    {
        get { return "Classe = Structure"; }
    }

    public void Execute()
    {
        VaisseauBase v1 = new VaisseauBase();
        VaisseauBase v2 = new VaisseauBase();
        v1.pilote = "Luc";
        v2.pilote = "Lea";
        v1.nbMissile = 3;
        v2.nbMissile = 5;

        Console.WriteLine("Le vaisseau v1 à comme pilote {0} et à {1} missiles",
            v1.pilote, v1.nbMissile);

        Console.WriteLine("Le vaisseau v2 à comme pilote {0} et à {1} missiles",
            v2.pilote, v2.nbMissile);

        v2.nbMissile = -5;

        Console.WriteLine("Le vaisseau v2 à comme pilote {0} et à {1} missiles",
            v2.pilote, v2.nbMissile);

    }
}