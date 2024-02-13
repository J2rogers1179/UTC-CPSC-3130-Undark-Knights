/*
 * You have recently been hired as a programmer at HeatWave Inc. 
 * This is a leading game development company specialized in fantasy role playing games. 
 * You have been assigned to a department working on a brand new game called Underdark Knights. 
 * Multiple teams are working together in this department to create and design this game. 
 * The team you have been assigned is tasked with writing the character generator.
 */ 



namespace CharCreatorFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            public void class CharCreator
            {
                public string Name { get; set; }

            }
            */

            bool exit = false;


            while (exit = false)
            {
                Console.Clear();
                Console.WriteLine("Underdark Knights");
                Console.WriteLine("Pre-pre-pre-pre-pre-pre alpha version, only $59.99");
                Console.WriteLine("---------------------");
                Console.WriteLine("Main Menu:");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Create User Account");
                Console.WriteLine("2. Load User Account");
                Console.WriteLine("");
                Console.WriteLine("3. Create Character");
                Console.WriteLine("4. Display Character");
                Console.WriteLine("5. Modify Character's Race");
                Console.WriteLine("6. Save Character");
                Console.WriteLine("7. Load Character");
                Console.WriteLine("0. Exit");
                Console.Write(": ");
                int choice = Convert.ToInt32(Console.ReadLine().Trim());

                switch (choice)
                {
                    case 1:
                        // Code to create user account
                        CreateUserAccount();
                        break;
                    case 2:
                        // Code to load user account
                        LoadUserAccount();
                        break;
                    case 3: 
                        // Code to create character
                        CreateCharacter();
                        break;
                    case 4:
                        // Code to display character
                        DisplayCharacter();
                        break;
                    case 5:
                        // Code to modify character
                        ModifyCharacter();
                        break;
                    case 6:
                        // Code to save character
                        SaveCharacter();
                        break;
                    case 7:
                        // Code to load character
                        LoadCharacter();
                        break;
                    case 0:
                        // Code to exit
                        exit = true;
                        Console.WriteLine("Thanks for paying $50 to get fisted, chump");
                        break;




                } // close menu switch
            } // close while loop for menu
        } // close main

        static void WriteAllText(string filePath, string email, string username, string password)
        {
            throw new NotImplementedException();
        }

        static void CreateUserAccount()
        {

            Console.WriteLine("Choose a username. (Max 10 characters, no symbols)");
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine().ToLower().Trim();           
            
            Console.WriteLine("Create a password (Max 10 characters, no symbols, no spaces)");
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine().Trim();

            Console.WriteLine("An email address is required to create your account.");
            Console.WriteLine("We will never share your email with anyone.");
            Console.WriteLine("Enter e-mail address: ");
            string email = Console.ReadLine().ToLower().Trim();

            string filePath = $"{username}.txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine("User account already exists. Please try again.");
            }
            else
            {   
                // Create user account file, NEEDS WORK //
                // Maybe create an array to store this shit in? SQL? idk
                File.WriteAllText(filePath, email, username, password);

                Console.WriteLine("User account created successfully.");
            }

            Console.ReadLine();                                                             // ??
        } 

        static void LoadUserAccount() // See if email exists in table, ask for password, if match, load saved variables into active variables
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine().ToLower().Trim();

            string filePath = $"{username}.txt";


            if (File.Exists(filePath))
            {
                string password = File.ReadAllText(filePath);                           // fix password implementation
                Console.WriteLine($"Welcome back, {username}!");
            }
            else
            {
                Console.WriteLine("User account not found. Please try again.");
            }

            Console.ReadLine();                                                        // fix default
        }


        static void CreateCharacterAbilities()                                  // this is the big one
        {
            // Code to create character
            Console.WriteLine("CHARACTER CREATION");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. NAME");
            Console.WriteLine("2. GENDER");
            Console.WriteLine("3. CORE STATS");
            Console.WriteLine("4. ");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt16(Console.ReadLine().Trim());

            /*
            switch (choice)
            {
                case 1:
                    // 
                    break;
                case 2:
                    // 
                    break;
                case 3:
                    // 
                    break;
                case 4:
                    // 
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            } */
        }

        static void DisplayCharacter()
        {
            // Code to display character
            Console.WriteLine("Display Character Info:");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Name: \t{c_name}");
            Console.WriteLine($"Gender: \t{c_gender}");
            Console.WriteLine($"Core Stat Points Total: \t {c_total_points} points");
            // Console.WriteLine($"");
            Console.WriteLine($"\tStrength: \t{c_strength}");
            Console.WriteLine($"\tDexterity: \t{c_dexterity}");
            Console.WriteLine($"\tConstitution: \t{c_constitution}");
            Console.WriteLine($"\tIntelligence: \t{c_intelligence}");
            Console.WriteLine($"\tWisdom: \t{c_wisdom}");
            Console.WriteLine($"\tCharisma: \t{c_charisma}");
            Console.WriteLine($"");
            Console.WriteLine($"Alignment: \t{c_alignment}");

            Console.Write("0. Return to main menu");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Code to display Character
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            } // close switch
        } // close display character

        static void ModifyCharacter()
        {
            // Code to modify character
            Console.WriteLine("Character modification menu:");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Modify Character Race");
            Console.WriteLine("2. Modify Character Name");                          // !! Optional
            Console.WriteLine("0. Back to main menu");
            Console.WriteLine("");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine().Trim());

            switch (choice)
            {
                case 1:
                    // Code to modify character race
                    break;

                case 2:                                                             // !! Optional
                    // Code to modify character name
                    break;

                case 0:
                    // Code to return to main menu
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            } // close switch
        } // close modify character

        static void SaveCharacter()
        {
            // Code to save character
            Console.WriteLine("Character save menu:");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Save Character to your account");
            Console.WriteLine("0. Back to main menu");
            Console.WriteLine("");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Code to save character
                    // Place all active variables (attributes, abilities, etc) into a file, clearly delineated (csv file?)
                    break;

                case 0:
                    // Code to return to main menu
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            } // close switch
        } // close save character

        static void CharacterAlignment()
        {
            // Code to select character alignment, a solitary choice
            // make the choice ---> save it to a variable ---> use that variable to determine the character's alignment
            Console.WriteLine("Choose Character Alignment");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Lawful Good");
            Console.WriteLine("2. Lawful Evil");
            Console.WriteLine("3. Neutral Good");
            Console.WriteLine("4. Neutral Evil");
            Console.WriteLine("5. Chaotic Good");
            Console.WriteLine("6. Chaotic Evil");
            Console.WriteLine("---------------------");
            Console.Write("Enter your choice: ");

            // I'd really like to scrub this input, but I'm not sure how to do that yet
            int alignment_choice = Convert.ToInt32(Console.ReadLine().Trim());

            switch (choice) // this is a solitary choice of character alignment, it cannot be changed
            {
                case 1:
                    alignment_choice = 1;
                    string CharacterAlignment = "Lawful Good";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            } // close switch
        } // close load character

    } // close internal
}   // close namespace
