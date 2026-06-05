wizard wizardA = new wizard("Harry Potter", 20);
wizard wizardB = new wizard("Voldemort", 30);

Console.WriteLine("Permainan Dimulai...\n");
wizardA.ShortStats();
wizardB.ShortStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

Console.WriteLine("Permainan Berakhir...\n");
wizardA.ShortStats();
wizardB.ShortStats();


public class wizard
{
    //deklarasi field
    public string Name;
    public int Energy;
    public int Damage;

    //deklarasi construktor
    public wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }

    public void ShortStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energi : {Energy} \n");
    }

    public void Attack(wizard Wizard_lawanobj)
    {
        //mengurangi energi wizard lawanobj sebesar energi
        Wizard_lawanobj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {Wizard_lawanobj.Name}");
        Console.WriteLine($"Sisa energi {Wizard_lawanobj.Name} adalah {Wizard_lawanobj.Energy}");
    }
    public void Heal()
    {
        if (Energy <= 100)
        {
            Energy += 5;
            Console.WriteLine(
        }
        else
        {
            Console.WriteLine($"{Name} tidak bisa menyembuhkan diri karena energi sudah penuh.");
        }
    }
}







