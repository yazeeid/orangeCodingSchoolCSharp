using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Car
{
    private string carsMake;
    private int year;
    private string type;
    private double price;
    private string model;
    private string pallet;
    private string color;

    public Car(string s1, int s2, string s3, double s4, string s5, string s6, string s7)
    {
        this.carsMake = s1;
        this.year = s2;
        this.type = s3;
        this.price = s4;
        this.model = s5;
        this.pallet = s6;
        this.color = s7;
    }

    public string startEngin()
    {
        return "the engin is start ";
    }

    public string stopEngin()
    {
        return "the engin is stop ";
    }

    public string details()
    {
        return $"Company : {carsMake}\nYear : {year}\nType : {type}\nPrice: {price}\nModel: {model}\npallet: {pallet}\nColor: {color}  ";
    }

}

class toyota : Car
{
    public toyota(string s1, int s2, string s3, double s4, string s5, string s6, string s7) 
        : base(s1,s2,s3,s4,s5,s6,s7)
    {

    }
}

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            toyota obj = new toyota("Toyota", 2020, "Sedan", 25000.00, "Camry", "1234ABC", "Red");
            
            Console.WriteLine(obj.details());


        }
    }
}
