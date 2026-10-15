namespace Costume;

using System.IO;
class Costume
{
    public string _headwear = "";
    public string _upperGarment = "";
    public string _lowerGarment = "";
    public string _footwear = "";
    public string _accessories = "";
    // behavior
    public void Output()

    {
        Console.WriteLine("Hello, Costume World!");

        List<Costume> myCostumes = new List<Costume>();
        Costume detective = new Costume();
        detective._headwear = "fedora";
        detective._upperGarment = "trenchcoat";
        detective._lowerGarment = "slacks";
        detective._footwear = "dress shoes";
        detective._accessories = "magnifying glass";
        myCostumes.Add(detective);

        Costume snorkeler = new Costume();
        snorkeler._headwear = "Goggles";
        snorkeler._upperGarment = "Divesuit";
        snorkeler._lowerGarment = "Divesuit";
        snorkeler._footwear = "Flippers";
        snorkeler._accessories = "Camera";
        myCostumes.Add(snorkeler);

        foreach (Costume c in myCostumes)
        {
           // c.Output(myCostumes);
            Console.WriteLine(c);
        }

        // Don't forget to put this at the top, so C# knows where to find the StreamWriter class

        string filename = "Costume.csv";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }
}
