// See https://aka.ms/new-console-template for more information


public class VaisseauSercurise
{
    // variable de classe
    public const int MAX_MISSILES = 30;

    // variable d'instance
    private string? pilote;
    private int nbMissile;

    //Propriété
    public string? Pilote
    {
        get {
            Console.WriteLine("lecture du pilote");
            return this.pilote; 
        }
        set
        {
            Console.WriteLine("Modification du pilote");
            if (this.pilote == null)
            {
                this.pilote = value;
            }
        }
    }

    public int GetNbMissile()
    {
        return nbMissile;
    }

    public void Add(int missiles)
    {
        if(missiles > 0) 
        {
            if(this.nbMissile+ missiles <= VaisseauSercurise.MAX_MISSILES)
            {
                this.nbMissile += missiles;
            }
            else
            {
                nbMissile = MAX_MISSILES;
            }
        }
    }

    internal void Tirer()
    {
        if(nbMissile > 0)
        {
            Console.WriteLine("PAN");
            nbMissile--;
        }else
        {
            Console.WriteLine("POUF");
        }
    }

    internal void Tirer(int nb)
    {
        for (int i = 0; i < nb; i++){
            Tirer();
        }
    }
}