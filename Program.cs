using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars carsNoName = new Cars();
            Cars carsMazda = new Cars("Mazda Rx7");
            Cars carsToyota = new Cars("Toyota Supra", "2020", "Pink" );
            Cars carsNissan = new Cars("Nissan Silvia", "2002", "Green");

            carsNoName.WriteCars();
            carsMazda.WriteCars();
            carsToyota.WriteCars();
            carsNissan.WriteCars();

            Console.Read();
        }
    }
}
class Cars
{
    private string name;//название авто  
    private string year; // год авто
    private string color; // цвет авто
    public string Name { get { return name; } set { name = value; } }  // название авто 
    public string Year { get { return year; } set { year = value; } } // год авто
    public string Color { get { return color; } set { color = value; } } // цвет авто


    public Cars()
    {
        Name = "NoName";
        Year = "NoYear";
        Color = "Black";

    }

    public Cars(string name) : this()
    {
        Name = name;
    }
    public Cars(string name, string year) : this(name)
    {
        Color = color;


    }
    public Cars(string name, string year, string color)
    {
        Name = name;
        Year = year;
        Color = color;
    }
    public void WriteCars() // метод  -вывоит информацию о  студенте 
    {
        Console.WriteLine("Название авто: {0}\nГод выпуска: {1}\nЦвет: {2}\n", Name, Year, Color);
    }

}
