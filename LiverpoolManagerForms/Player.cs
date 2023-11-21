namespace LiverpoolManagerForms
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public int ShirtNumber { get; set; }
        public string BestFoot { get; set; }
        public string Position { get; set; }

        public Player(string name, int age, string nationality, int shirtNumber, string bestFoot, string position)
        {
            Name = name;
            Age = age;
            Nationality = nationality;
            ShirtNumber = shirtNumber;
            BestFoot = bestFoot;
            Position = position;
        }

        public string getCSV()
        {
            return Name + "," + Age + "," + Nationality + "," + ShirtNumber + "," + BestFoot + "," + Position;
        }

        public override string? ToString()
        {
            return "Name: " + Name + "Age: " + Age + "Nationality: " + Nationality + "Shirtnumber: " + ShirtNumber +
                   "Best foot: " + BestFoot + "Position: " + Position;
        }
    }
}
