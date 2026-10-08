using System;


namespace ClassObject
{
   public class Sorcerer // this will be the name of my class
   {
       public string name;
       public int age;
       public bool isIncarnated;
       public string cursedTechnique;
       public bool hasDomain;
       public string domainName;
       public string isAlive; // all these fields are the "attributes" of the class Sorcerer


       public void displayNames() //this method displays the name of the Sorcerer in the dictionary display
       {
           Console.WriteLine(name);
       }


       public void forDictionary() //this method is for displaying the Sorcerer's name in the information section
       {
           Console.WriteLine("Sorcerer Name: " + name);
       }


       public void ageDisplay() //this method displays the Sorcerer's age
       {
           Console.WriteLine("Age: " + age);
       }


       public void sorcererCT() //this method displays the Sorcerer's Cursed Technique
       {
           Console.WriteLine("Cursed Technique: " + cursedTechnique);
       }


       public void doTheyHaveDomain()
       {
           if (hasDomain == true && domainName != "unknown")
           {
               Console.WriteLine("This sorcerer has a domain! Watch out! It's called " + domainName + "!");
           }
           else if (hasDomain == true && domainName == "unknown")
           {
               Console.WriteLine("This sorcerer has a domain! However, their domain name is unknown!");
           }
           else
           {
               Console.WriteLine("This sorcerer doesn't have a Domain. Regardless, be cautious!");
           }
       }
       public void areTheyAlive() //this method tell us is the Sorcerer is dead or not
       {
           Console.WriteLine("Status: " + isAlive + "\n");
       }
       public void isSorcererOld() //if the Sorcerer is old (more than 100 years old), we assume that they are reincarnated
       {
           if (age > 100)
           {
               isIncarnated = true;
           }
           else
           {
               isIncarnated = false;
           }
       }
       public void reincarnationCheck() //this method basically cross checks if the Sorcerer is a reincarnate, and if they are alive or not.
       {
           if (isIncarnated == true && isAlive == "Dead")
           {
               Console.WriteLine("This sorcerer was on their own league...");
           }
           else if (isIncarnated == true && isAlive == "Alive")
           {
               Console.WriteLine("This sorcerer is an incarnation! Take cover!");
           }
           else if (isIncarnated == false && isAlive == "Alive")
           {
               Console.WriteLine("This is a modern day sorcerer!");
           }
           else if (isIncarnated == false && isAlive == "Dead")
           {
               Console.WriteLine("They were a modern day sorcerer. May their soul find peace.");
           }
       }


   public static void Main()
       {
           Sorcerer Satoru = new Sorcerer(); //these are all the 'objects' that I created under the Sorcerer class.
           Sorcerer Ryomen = new Sorcerer(); //each object name derives from the name of the Sorcerer
           Sorcerer Itadori = new Sorcerer();
           Sorcerer Okkotsu = new Sorcerer();
           Sorcerer Ishigori = new Sorcerer();
           Sorcerer Hajime = new Sorcerer();


           Satoru.name = "Satoru Gojo"; //this is the information field for Satoru Gojo
           Satoru.age = 29;
           Satoru.cursedTechnique = "Limitless";
           Satoru.hasDomain = true;
           Satoru.domainName = "Infinite Void";
           Satoru.isAlive = "Dead";
           Satoru.isSorcererOld();


           Ryomen.name = "Ryomen Sukuna"; //this is the information field for Ryomen Sukuna
           Ryomen.age = 1000;
           Ryomen.cursedTechnique = "Shrine";
           Ryomen.hasDomain = true;
           Ryomen.domainName = "Malevolent Shrine";
           Ryomen.isAlive = "Dead";
           Ryomen.isSorcererOld();


           Itadori.name = "Itadori Yuji"; //this is the information field for Itadori Yuji
           Itadori.age = 83;
           Itadori.cursedTechnique = "Engrained Shrine, Blood Manipulation";
           Itadori.hasDomain = true;
           Itadori.domainName = "unknown";
           Itadori.isAlive = "Alive";
           Itadori.isSorcererOld();


           Okkotsu.name = "Okkotsu Yuta"; //this is the information field for Okkotsu Yuta
           Okkotsu.age = 79;
           Okkotsu.cursedTechnique = "Copy";
           Okkotsu.hasDomain = true;
           Okkotsu.domainName = "Authentic Mutual Love";
           Okkotsu.isAlive = "Dead";
           Okkotsu.isSorcererOld();


           Ishigori.name = "Ishigori Ryu"; //this is the information field for Ishigori Ryu
           Ishigori.age = 400;
           Ishigori.cursedTechnique = "Cursed Energy Discharge";
           Ishigori.hasDomain = true;
           Ishigori.domainName = "unknown";
           Ishigori.isAlive = "Dead";
           Ishigori.isSorcererOld();


           Hajime.name = "Hajime Kashimo"; //this is the information field for Hajime Kashimo
           Hajime.age = 400;
           Hajime.cursedTechnique = "Lightning";
           Hajime.hasDomain = false;
           Hajime.isAlive = "Dead";
           Hajime.isSorcererOld();
          
           while (true) //this loop is for the whole program if the user wants to retry
           {
               // this is the actual section where everything starts to print and display
               Console.WriteLine(">>> Classes and Objects: Sorcerer Edition");
               Console.WriteLine("\nWelcome to the program! This is a short system designed to feature classes and objects.\n" +
               "Feel free to answer and explore what I made!");
               while (true) //this while loop is for to ensure that the user still gets an output even after a misinput
               {
                   Console.WriteLine("--------------------------");
                   Console.WriteLine(">>> Sorcerer Dictionary");
                   Satoru.displayNames();
                   Ryomen.displayNames();
                   Itadori.displayNames();
                   Okkotsu.displayNames();
                   Ishigori.displayNames();
                   Hajime.displayNames();
                   Console.WriteLine("--------------------------");

                   Console.Write("Choose a sorcerer to view their information: \n" +
                   ">>> ");
                   string sorcererChoice = Console.ReadLine();
                   string sorcererChoiceLW = sorcererChoice.ToLower();
                   //to ensure that we get a correct input, we use the .ToLower() function


                   //this section starts the WHOLE checklist for the Sorcerer that the user wants to view the information of
                   if (sorcererChoiceLW == "satoru gojo" || sorcererChoiceLW == "gojo satoru") //this || operator was put in place just in case the user writes a different name format
                   {
                       Console.WriteLine();
                       Satoru.forDictionary(); //every single Sorcerer has their information displayed on here
                       Satoru.ageDisplay();
                       Satoru.sorcererCT();
                       Satoru.doTheyHaveDomain();
                       Satoru.reincarnationCheck();
                       Satoru.areTheyAlive();
                       break;
                   }
                   else if (sorcererChoiceLW == "ryomen sukuna" || sorcererChoiceLW == "sukuna ryomen")
                   {
                       Console.WriteLine();
                       Ryomen.forDictionary();
                       Ryomen.ageDisplay();
                       Ryomen.sorcererCT();
                       Ryomen.doTheyHaveDomain();
                       Ryomen.reincarnationCheck();
                       Ryomen.areTheyAlive();
                       break;
                   }
                   else if (sorcererChoiceLW == "itadori yuji" || sorcererChoiceLW == "yuji itadori")
                   {
                       Console.WriteLine();
                       Itadori.forDictionary();
                       Itadori.ageDisplay();
                       Itadori.sorcererCT();
                       Itadori.doTheyHaveDomain();
                       Itadori.reincarnationCheck();
                       Itadori.areTheyAlive();
                       break;
                   }
                   else if (sorcererChoiceLW == "okkotsu yuta" || sorcererChoiceLW == "yuta okkotsu")
                   {
                       Console.WriteLine();
                       Okkotsu.forDictionary();
                       Okkotsu.ageDisplay();
                       Okkotsu.sorcererCT();
                       Okkotsu.doTheyHaveDomain();
                       Okkotsu.reincarnationCheck();
                       Okkotsu.areTheyAlive();
                       break;
                   }
                   else if (sorcererChoiceLW == "ishigori ryu" || sorcererChoiceLW == "ryu ishigori")
                   {
                       Console.WriteLine();
                       Ishigori.forDictionary();
                       Ishigori.ageDisplay();
                       Ishigori.sorcererCT();
                       Ishigori.doTheyHaveDomain();
                       Ishigori.reincarnationCheck();
                       Ishigori.areTheyAlive();
                       break;
                   }
                   else if (sorcererChoiceLW == "hajime kashimo" || sorcererChoiceLW == "kashimo hajime")
                   {
                       Console.WriteLine();
                       Hajime.forDictionary();
                       Hajime.ageDisplay();
                       Hajime.sorcererCT();
                       Hajime.doTheyHaveDomain();
                       Hajime.reincarnationCheck();
                       Hajime.areTheyAlive();
                       break;
                   }
                   else
                   {
                       Console.WriteLine("Enter a valid sorcerer name!"); //this to just see if the user inputs a Sorcerer name that is not on the list
                   }
               }


               Console.Write("Continue? [Y/N]\n>>> "); //after all that, we ask the user if they want to retry the program.
               string restartProgram = Console.ReadLine(); //this is just a simple algorithm to trigger a retry or a termination


               if (restartProgram == "Y")
               {
                   Console.WriteLine("Restarting program!");
               }
               else if (restartProgram == "N")
               {
                   Console.WriteLine("Okay, see you!");
                   break;
               }
               else
               {
                   throw new Exception("Enter a valid option! Terminating!"); //exception error to catch a non-valid input
               }
           }
       }
   }
}
