// sherti yaza bilmedim
internal class Car
{
    public string Model { get; set; }
    public double Km { get; set; }
    public int Topspeed { get; set; }
    public double Motor { get; set; }
    public int Hp { get; set; }


    public Car(string model, double km, int topspeed, double motor, int hp)
    {
        Model = model;
        Km = km;
        Topspeed = topspeed;
        Motor = motor;
        Hp = hp;
    }
}
class Bmw : Car
{
    public bool isMpower;

    public Bmw(string model, double km, int topspeed, double motor, int hp, bool isMpower) : base(model, km, topspeed, motor, hp)
    {
        this.Model = model;
        this.Km = km;
        this.Topspeed = topspeed;
        this.Motor = motor;
        this.Hp = hp;
        this.isMpower = isMpower;
    }
    
    public void GetFullInfoBmw(string model, double km, int topspeed, double motor, int hp, bool isMpower)
    {
        Console.WriteLine($"Model"+ ":  " + this.Model+"   Km"+ ":  " + this.Km+"   TopSpeed"+ ":  " + this.Topspeed+"   Motor"+ ":  " + this.Motor+"   Hp"+":  "+this.Hp);
        if (isMpower)
        {
            Console.WriteLine("is Mpower");
        }
        else
        {
            Console.WriteLine("is not Mpower");
        }
    }
}

class Mercedes : Car
{

    public bool isAmg;
    public Mercedes(string model, double km, int topspeed, double motor, int hp, bool isAmg) : base(model, km, topspeed, motor, hp)
    {
        this.Model = model;
        this.Km = km;
        this.Topspeed = topspeed;
        this.Motor = motor;
        this.Hp = hp;
        this.isAmg = isAmg;
    }

    public void GetFullInfoMercedes(string model, double km, int topspeed, double motor, int hp, bool isAmg)
    {
        Console.WriteLine($"Model" + ":  " + this.Model + "   Km" + ":  " + this.Km + "   TopSpeed" + ":  " + this.Topspeed + "   Motor" + ":  " + this.Motor + "   Hp" + ":  " + this.Hp);
        if (isAmg)
        {
            Console.WriteLine("is Amg");
        }
        else
        {
            Console.WriteLine("is not Amg");
        }
    }
}
