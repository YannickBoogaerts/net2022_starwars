// See https://aka.ms/new-console-template for more information


internal class VaisseauPropriete : Icommand
{
    public string Name => "gestion des propriétés" ;

    public void Execute()
    {
        VaisseauSercurise v1 = new VaisseauSercurise();
        //v1.nbMissile = 5;
        v1.Add(10);

        Console.WriteLine("Le vaisseau v1 à comme pilote {0} et à {1} missiles",
        v1.Pilote, v1.GetNbMissile());
        v1.Pilote = "Luc";
        v1.Pilote = "Lea";
        v1.Add(-10);

        Console.WriteLine("Le vaisseau v1 à comme pilote {0} et à {1} missiles",
        v1.Pilote, v1.GetNbMissile());

        Console.WriteLine("Nombre maximum de missiles "
            +VaisseauSercurise.MAX_MISSILES);

        v1.Tirer();
        v1.Tirer(11);

    }
}