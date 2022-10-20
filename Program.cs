

bool runAgain = true;
    while(runAgain == true)
    {
        string response = "beep";
        Console.WriteLine("Please enter something of your choice for each aspect of the story");

        Console.WriteLine("A persons name");
        string name = Console.ReadLine();
        Console.WriteLine("A second persons name");
        string name2 = Console.ReadLine();
        Console.WriteLine("What time is it");
        string time = Console.ReadLine();
        Console.WriteLine("Where did they go");
        string place = Console.ReadLine();
        Console.WriteLine("An item");
        string item = Console.ReadLine();
        Console.WriteLine("Wizard name");
        string wizard = Console.ReadLine();
        Console.WriteLine("Magic spell name");
        string magicSpell = Console.ReadLine();
        Console.WriteLine("Wizard familiars name");
        string wizardFamiliar = Console.ReadLine();
        Console.WriteLine("A consistency/element");
        string consistency = Console.ReadLine();
        Console.WriteLine("A liquid");
        string liquid = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"{name} went to meet up with {name2} at their meething time of {time} so they could go to {place} together.");
        Console.WriteLine($"While there, they found {item} they werent sure what to do with it.");
        Console.WriteLine("...");
        Console.WriteLine($"So they took it to {wizard} the wizard! he has seen this item before.");
        Console.WriteLine($"{wizard} casts {magicSpell} a spell capable of identifying the purpose of an item aswell as where it came from.");
        Console.WriteLine($"Sadly the spell was cut short as the wizard was low on power, he could restore his power with {wizardFamiliar} a magic companion capible of assisting and enhancing magical power.");
        Console.WriteLine($"The wizard than casts the spell again with an explotion of magic energy leaving the object {consistency}.");
        Console.WriteLine($"{name} ask {wizard} why this is the case, he explains that there are some side affects. {name} and {name2} look at eachother each understanding what they must do next with their newly {consistency} item.");
        Console.WriteLine($"you take it to {liquid} lake and toss the item in expecting to be rewarded.");
        Console.WriteLine($"The {consistency} {item} interacts with the {liquid} in such a way that it causes a rift to be created within the area swallowing up both the {item} and the {liquid} from the lake");
        Console.WriteLine($"left behind is a lone glowing egg, {name2} is frustrated with {name}'s actions for a moment before picking up the egg and taking it home.");

        Console.WriteLine("---------------");
        Console.WriteLine("Would you like to play again?");
        Console.WriteLine("Please type yes or no");

        string choice = "";
	    Console.WriteLine("Would you like to run again? (y/n)");
        while(choice != "yes" & choice != "y" & choice != "no" & choice != "n")
        {
            choice = Console.ReadLine().ToLower();
        }
        
        if(choice == "y" || choice == "yes")
        {
            runAgain = true;
        }
        else if(choice == "n" || choice == "no")
        {
            runAgain = false;
            Console.WriteLine("Now exiting");
        }
    }