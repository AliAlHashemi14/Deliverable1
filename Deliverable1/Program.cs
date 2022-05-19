var response = "";

do {
    Console.WriteLine("How many people are we making PB and J sandwiches for?");
    var peopleCount = Int32.Parse(Console.ReadLine());
    double totalSlicesNeeded = peopleCount * 2;
    double pbTbspNeeded = peopleCount * 2;
    double jellyTbspNeeded = peopleCount * 4;
    double slicesPerLoaf = 28;
    double pbPerJar = 32;
    double jellyPerJar = 48;

    double totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / slicesPerLoaf);
    double totalJarPbNeeded = Math.Ceiling(pbTbspNeeded / pbPerJar);
    double totalJarJellyNeeded = Math.Ceiling(jellyTbspNeeded / jellyPerJar);

    Console.WriteLine($"You need: \n{totalSlicesNeeded} slices of bread \n{pbTbspNeeded} tablespoons of peanut butter \n{jellyTbspNeeded} tablespoons of jelly");
    Console.WriteLine($"Which is: \n{totalLoavesNeeded} loaves of bread \n{totalJarPbNeeded} jars of peanut butter \n{totalJarJellyNeeded} jars of jelly");
    Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit");
    response = Console.ReadLine();
    }
while (response == "y" || response == "yes");

Console.WriteLine("Goodbye!");


