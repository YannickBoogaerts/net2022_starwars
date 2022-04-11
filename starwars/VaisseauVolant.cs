// See https://aka.ms/new-console-template for more information


internal class VaisseauVolant
{

    // variable de classe
    public const int MAX_MISSILES = 30;

    // variable d'instance
    private string? pilote;
    private int nbMissile;
    private bool enVol = false;

    //Propriété
    public string? Pilote
    {
        get
        {
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
    public static int CptEnVol { get; private set; }

    // constructeur
    public VaisseauVolant(string pilote)
    {
        this.pilote = pilote;
    }

    public VaisseauVolant(string pilote, int nbMisille)
    {
        this.pilote = pilote;
        this.Add(nbMisille);
    }

    internal void decoller()
    {
        if(! enVol)
        {
            Console.WriteLine("Le Vaisseau de {0} décolle",pilote);
            enVol = true;
            CptEnVol++;
        }
        else
        {
            Console.WriteLine("Le Vaisseau de {0} est déjà en vol", pilote);
        }
    }

    internal void atterrir()
    {
        if (enVol)
        {
            Console.WriteLine("Le Vaisseau de {0} atterri", pilote);
            enVol = false;
            CptEnVol--;
        }
        else
        {
            Console.WriteLine("Le Vaisseau de {0} est déjà au sol", pilote);
        }
     }

    public int GetNbMissile()
    {
        return nbMissile;
    }

    public void Add(int missiles)
    {
        if (missiles > 0)
        {
            if (this.nbMissile + missiles <= VaisseauSercurise.MAX_MISSILES)
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
        if (nbMissile > 0)
        {
            Console.WriteLine("PAN");
            nbMissile--;
        }
        else
        {
            Console.WriteLine("POUF");
        }
    }

    internal void Tirer(int nb)
    {
        for (int i = 0; i < nb; i++)
        {
            Tirer();
        }
    }
}
