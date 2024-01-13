using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;

namespace BAGONG_IPAPASA
{
    class FINAL_NA
    {
        static void Main(string[] args)
        {
            Chronologics PAPASA_NA = new Chronologics();
        }
        
    }

    public class Chronologics
    {
        public Chronologics()
        {
            DataBase data = new DataBase();
            Intial_V value = new Intial_V();
            Messenger Message = new Messenger();
            Visual_Arts V = new Visual_Arts();
            Last_Phase last = new Last_Phase();
            SqlConnection connector = new SqlConnection(data.FilePath);
            connector.Open();
            Opening_Visuals OV = new Opening_Visuals(Message, Message.characterArray, Message.C_PJOB, connector, data.ColumnRay, data);
            OV.Introductions();
            OV.Opening(ref value,connector);
            Message.PritingName(value);
            OV.Start_Up();
            V.A_Age(ref value);
            V.A_Height(ref value);
            V.A_BodyType(ref value);
            V.A_Gender(ref value);
            V.A_SkinTone(ref value);
            V.A_HairStyle(ref value);
            V.A_HairColor(ref value);
            V.A_isHeto(ref value);
            V.A_SetEyeColor(ref value);
            V.A_Race(ref value);
            V.A_Class(ref value);
            V.A_Mastery(ref value);
            V.A_HeadGear(ref value);
            V.A_Garments(ref value);
            V.A_HeadAccessory(ref value);
            V.A_BodyAccessory(ref value);
            V.A_ArmAccessory(ref value);
            last.Finale(value, Message);
            data.InsertData(data.ColumnRay, Message.Combined(value), data.TableCounter(connector), connector);
            data.OptionDB(Message.characterArray, Message.C_PJOB, connector, data.ColumnRay, data);
        }
    }

    public struct Intial_V
    {
        private string Nickname;
        private string AgeGroup;
        private string Height;
        private string BodyType;
        private string Gender;
        private string SkinTone;
        private string HairStyle;
        private string HairColor;
        private bool isHetos;
        private string EyeColor;
        private string Race;
        private string Class;
        public string UpperGarment;
        public string LowerGarment;
        public string Shoes;
        public string HeadGear;
        public string HeadAccessory;
        public string BodyAccessory;
        public string ArmAccessory;
        private int FishermanPoints;
        private int BlacksmithPoints;
        private int FarmerPoints;
        private int LibrarianPoints;
        private int CartographerPoints;

        public string getE_Nickname()
        {
            return this.Nickname;
        }

        public void setE_Nickname(string Nickname)
        {
            this.Nickname = Nickname;
        }

        public string getE_Age()
        {
            return AgeGroup;
        }

        public void setE_Age(string AgeGroup)
        {
            this.AgeGroup = AgeGroup;
        }

        public string getE_Height()
        {
            return Height;
        }

        public void setE_Height(string Height)
        {
            this.Height = Height;
        }

        public string getE_BodyType()
        {
            return BodyType;
        }

        public void setE_BodyType(string BodyType)
        {
            this.BodyType = BodyType;
        }

        public string getE_Gender()
        {
            return Gender;
        }

        public void setE_Gender(string Gender)
        {
            this.Gender = Gender;
        }

        public string getE_SkinTone()
        {
            return SkinTone;
        }

        public void setE_SkinTone(string SkinTone)
        {
            this.SkinTone = SkinTone;
        }

        public string getE_HairStyle()
        {
            return HairStyle;
        }

        public void setE_HairStyle(string HairStyle)
        {
            this.HairStyle = HairStyle;
        }

        public string getE_HairColor()
        {
            return HairColor;
        }

        public void setE_HairColor(string HairColor)
        {
            this.HairColor = HairColor;
        }

        public bool getE_IsHetos()
        {
            return isHetos;
        }

        public void setE_IsHetos(bool IsHetos)
        {
            this.isHetos = IsHetos;
        }

        public string getE_EyeColor()
        {
            return EyeColor;
        }

        public void setE_EyeColor(string EyeColor)
        {
            this.EyeColor = EyeColor;
        }

        public string getE_Race()
        {
            return Race;
        }

        public void setE_Race(string Race)
        {
            this.Race = Race;
        }

        public string getE_Class()
        {
            return Class;
        }

        public void setE_Class(string Class)
        {
            this.Class = Class;
        }

        public int getE_FishermanPoints()
        {
            return FishermanPoints;
        }

        public void setE_FishermanPoints(int FishermanPoints)
        {
            this.FishermanPoints += FishermanPoints;
        }

        public int getE_BlacksmithPoints()
        {
            return BlacksmithPoints;
        }

        public void setE_BlacksmithPoints(int BlacksmithPoints)
        {
            this.BlacksmithPoints += BlacksmithPoints;
        }

        public int getE_FarmerPoints()
        {
            return FarmerPoints;
        }

        public void setE_FarmerPoints(int FarmerPoints)
        {
            this.FarmerPoints += FarmerPoints;
        }

        public int getE_LibrarianPoints()
        {
            return LibrarianPoints;
        }

        public void setE_LibrarianPoints(int LibrarianPoints)
        {
            this.LibrarianPoints += LibrarianPoints;
        }

        public int getE_CartographerPoints()
        {
            return CartographerPoints;
        }

        public void setE_CartographerPoints(int CartographerPoints)
        {
            this.CartographerPoints += CartographerPoints;
        }



    }


    public abstract class Choice : IUtility2
    {

        public string[] C_Start = { "New Game", "Exit" };
        public string[] C_AgeGroup = { "Teenager", "Adult", "Senior" };
        public string[] C_Height = { "Short", "Average", "Tall" };
        public string[] C_BodyType = { "Masculine", "Thin", "Stout", "Default" };
        public string[] C_Gender = { "Male", "Female", "Others" };
        public string[] C_SkinTone = { "White", "Tan", "Dark", "Blue", "Green" };
        public string[] C_HairStyle = { "Afro", "Side-swept", "Twin-tails", "Twin Drill", "Spiky" };
        public string[] C_HairColor = { "Purple", "Pink", "Orange", "White", "Black" };
        public string[] C_isHeto = { "Yes", "No" };
        public string[] C_HetoCombination = { "Red + Yellow", "Red + Blue", "Black + White", "Yellow + Green", "Blue + Yellow" };
        public string[] C_EyeColor = { "Violet", "White", "Black", "Green", "Red" };
        public string[] C_Race = { "Human", "Dwarf", "Giant", "Elf", "Beastkin" };
        public string[] C_Class = { "Warrior", "Mage", "Ranger", "Summoner", "Priest" };
        public string[] C_PJOB = { "Fisherman", "Blacksmith", "Farmer", "Librarian", "Cartographer" };
        public string[] C_HeadGear = { "Hat", "Helmet", "Bucket", "Jack-O-Lantern", "Hood" };
        public string[] C_Garments = { "Santa Set", "Halloween Set", "Bunny Set", "Summer Set", "Chinese NY set" };
        public string[] C_HeadAccessory = { "Sunglasses", "Glass", "Horn", "Earrings", "Halo", };
        public string[] C_BodyAccessory = { "Necklace", "Wings", "Tattoo", "Chains", "Backpack" };
        public string[] C_ArmAccessory = { "Bracelets", "Armbands", "Watch", "Rosary", "Ring" };
        static string characterInfo = "Nickname, Age, Height, Body Type, Gender, Skin Tone, Hair Style, Hair Color, Heterochromia, Eye Color, Race, Class, Headgear, Upper Garment, Lower Garment, Shoes, Head Accessory, Body Accessory, Arm Accessory";
        public string[] characterArray = characterInfo.Split(',');

        public string[] StringPlayer(Intial_V value)
        {
            string[] Player_Values = { value.getE_Nickname(), value.getE_Age(), value.getE_Height(), value.getE_BodyType(), value.getE_Gender(),
                                         value.getE_SkinTone(),value.getE_HairStyle(),value.getE_HairColor(),value.getE_IsHetos().ToString(),value.getE_EyeColor(),value.getE_Race(),value.getE_Class(),
                                         value.HeadGear,value.UpperGarment,value.LowerGarment,value.Shoes,value.HeadAccessory,value.BodyAccessory,value.ArmAccessory};
            return Player_Values;
        }

        public int[] Master(Intial_V value)
        {
            int[] Player_Points = { value.getE_FishermanPoints(), value.getE_BlacksmithPoints(), value.getE_FarmerPoints(), value.getE_LibrarianPoints(), value.getE_CartographerPoints() };
            return Player_Points;
        }

        public object[] Combined(Intial_V value)
        {

            object[] combined = new object[StringPlayer(value).Length + Master(value).Length];

            Array.Copy(StringPlayer(value), combined, StringPlayer(value).Length);
            Array.Copy(Master(value), 0, combined, StringPlayer(value).Length, Master(value).Length);

            return combined;
        }




        public string ChoiceGet(String[] Choose, int Choice)
        {
            return Choose[Choice - 1];
        }

        public void CenterPrint()
        {
            Console.Write("\t\t\t\t");
        }

        public void PointingSystem(int points, ref Intial_V character)
        {

            switch (points)
            {
                case 1:
                    character.setE_FishermanPoints(1);
                    break;
                case 2:
                    character.setE_BlacksmithPoints(1);
                    break;
                case 3:
                    character.setE_FarmerPoints(1);
                    break;
                case 4:
                    character.setE_LibrarianPoints(1);
                    break;
                case 5:
                    character.setE_CartographerPoints(1);
                    break;
            }
        }

        public abstract void PrintChoice(String[] Choose);
    }

    public class Opening_Visuals : IUtility2, IUtility3, IUtility4
    {
        Validations valid = new Validations();
        Messenger Mess = new Messenger();

        public Opening_Visuals()
        {
        }


        public void Opening(ref Intial_V Value,SqlConnection connect)
        {
            
            Dialogue($"Hey there... umm, are you okay? You seem a little dazed. \tSorry to bother you, but do you remember your name? You just woke up.{SpaceGiver(2)} And I thought maybe you might've forgotten? What would you like to be called?. \t\t\t{SpaceGiver(3)}Can you Remember your nickname??");
            Value.setE_Nickname(valid.NullChecker(connect));
            Console.Clear();
        }

        public int Choice;
        public Opening_Visuals(Messenger Mess, string[] Features, string[] Passive, SqlConnection sqlConnection, string[] numb, DataBase data)
        {
            
            Thread Clicker = new Thread(Optioner);
            Thread thread = new Thread(Giver);
            CenterPrint("Starting Menu", 5);
            CenterPrint("[1] New Game", 8);
            CenterPrint("[2] Load Game ", 11);
            CenterPrint("[3] Exit Game", 14);
            CenterPrint("Choice: ", 50, 17);
            thread.Start();
            Clicker.Start();

            Clicker.Join();
            thread.Join();
            if (Choice == 2)
            {
                data.OptionDB(Features,Passive,sqlConnection,numb,data);
            }
            if (Choice == 3)
            {
                Dialogue(Mess.Exit);
                Dialogue("\t\tThank you for Playing!!");
                Console.SetCursorPosition(48, 20);
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

        }

        public void Giver()
        {

            int User_Int = 0;
            bool Valid = true;
            do
            {
                try
                {

                    CenterPrint("Choice: ", 50, 17);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    User_Int = int.Parse(Console.ReadLine());

                    Valid = false;
                }

                catch (Exception e)
                {
                    valid.InputClearLine();
                    Mess.M_Invalid();

                }
            } while (Valid || valid.Validator(User_Int, Mess.C_Start.Length));
            Choice = User_Int;
            valid.ErrorClearLine();
            Thread.Sleep(5000);
            Console.ResetColor();
            Console.Clear();
        }

        public void Optioner()
        {
            while (this.Choice == 0) { }
            if (this.Choice == 1)
            {
                PositionLine("[1] New Game", 8);
            }

            else if (this.Choice == 2)
            {
                PositionLine("[2] Load Game", 11);
            }
            else if (this.Choice == 3)
            {
                PositionLine("[2] Exit Game", 14);
            }
        }

        public void PositionLine(string Option, int yAxis)
        {
            int Count = 46;
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(100);
                Console.SetCursorPosition(Count, yAxis);
                Console.WriteLine("-");
                Count++;
                Thread.Sleep(500);
            }
            Console.SetCursorPosition(Count, yAxis);
            Console.WriteLine(">");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterPrint(Option, yAxis);
            Thread.Sleep(1000);
        }

        public void Rewrite(string word, int x, int y)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.SetCursorPosition(x++, y);
                Console.Write(word[i]);
                Thread.Sleep(100);
            }

            Thread.Sleep(1000);
            for (int i = 0; i <= word.Length; i++)
            {
                Console.SetCursorPosition(x--, y);
                Console.Write(" ");
                Thread.Sleep(100);
            }
            Thread.Sleep(1000);
        }

        public void Dialogue(string Message)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }
            Console.Write($"\t\t\t\t");
            for (int j = 0; j < Message.Length - 1; j++)
            {

                Console.Write(Message[j]);
                if (Message[j].Equals('.') && !(Message[j + 1].Equals('.')) && !(Message[j - 1].Equals('.')))
                {

                    Thread.Sleep(1000);
                    Console.WriteLine(); Console.Write($"\t\t");
                }

                if (Message[j].Equals('?')) { Thread.Sleep(1000); }
                Thread.Sleep(50);
            }
        }
        public void CenterPrint(string input)
        {
            Console.SetCursorPosition(53, 13);
            Console.WriteLine(input);
        }

        public void CenterPrint()
        {
            Console.Write("\t\t\t\t\t\t");
        }

        public void CenterPrint(string input, int yAxis)
        {
            Console.SetCursorPosition(53, yAxis);
            Console.Write(input);
        }

        public void CenterPrint(string input, int xAxis, int yAxis)
        {
            Console.SetCursorPosition(xAxis, yAxis);
            Console.Write(input);
        }

        public void CenterDown(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine();
            }
        }

        public string SpaceGiver(int i)
        {
            string car = " ";
            for (var j = 0; j < i; j++)
            {
                car += " ";
            }
            return car;
        }

        public void Introductions()
        {
            Rewrite("Group Members", 55, 13);
            Rewrite("Programmerist: Jetrix Siason", 50, 13);
            Rewrite("Documentationist: Ethan Cruz",50,13);
            Rewrite("Pancit Cantonist/Japanist: Dax Angeles",50,13);
        }


        public void Start_Up()
        {
            
            

            Rewrite("Welcome To The Game!", 55, 13);
            Thread.Sleep(1000);

            Rewrite("Customize Your Fantasy", 50, 13);

            CenterPrint("Loading", 58, 13);
            for (int i = 1; i <= 100; i++)
            {

                Console.SetCursorPosition(66, 13);
                Console.Write(i + "%");
                Thread.Sleep(100);

            }

            Console.Clear();
            CenterPrint("Finished!", 59, 13);
            Thread.Sleep(1000);
            Console.Clear();

            
        }


    }


    public class Visual_Arts : Choice
    {
        Messenger Utilize = new Messenger();
        Validations valid = new Validations();

        public override void PrintChoice(string[] Choose)
        {
            Utilize.CenterDown();
            Console.Write("\t");

            for (int i = 0; i < Choose.Length; i++)
            {
                Console.Write($"{"",5}[{i + 1}]. {Choose[i]}");
                Thread.Sleep(100);
            }
        }

        public void HeadLiner1(string Title, int X)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utilize.Simutaneus4("Select " + Title, X, 2);
            Console.ResetColor();
        }

        public void HeadLiner(string Title, int X)
        {

            Thread t1 = new Thread(() => HeadLiner1(Title, X));
            t1.Start();
            t1.Join();
        }
        
        public void HeadLiner(string Title, int X, int counter)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utilize.Simutaneus3("Select " + Title, counter, X, 2);
            Console.ResetColor();
        }

        public void PrintChoice(string[] Choose, int counter)
        {
            Utilize.CenterDown();
            Console.Write("\t");

            for (int i = 0; i < Choose.Length; i++)
            {
                Console.Write($"{"",5}[{i + 1}]. {Choose[i]}");
                if (counter == 0) { Thread.Sleep(100); }
            }
        }



        public void A_Age(ref Intial_V value)
        {
            HeadLiner("Age", 55);
            Utilize.Simutaneus(Utilize.M_Age);
            Utilize.PrintChoice(C_AgeGroup);
            value.setE_Age(Utilize.ChoiceGet(Utilize.C_AgeGroup, valid.Validator(Utilize.C_AgeGroup)));

        }

        public void A_Height(ref Intial_V value)
        {
            HeadLiner("Height", 55);
            Utilize.Simutaneus(Utilize.M_Height);
            Utilize.PrintChoice(Utilize.C_Height);
            value.setE_Height(Utilize.ChoiceGet(Utilize.C_Height, valid.Validator(Utilize.C_Height)));

        }

        public void A_BodyType(ref Intial_V value)
        {
            HeadLiner("Body Type", 50);
            Utilize.Simutaneus(Utilize.M_BodyType);
            Utilize.PrintChoicePlus(Utilize.C_BodyType, 11, 29, 12);
            value.setE_BodyType(Utilize.ChoiceGet(Utilize.C_BodyType, valid.Validator(Utilize.C_BodyType)));

        }

        public void A_Gender(ref Intial_V value)
        {
            HeadLiner("Gender", 55);
            Utilize.Simutaneus(Utilize.M_Gender);
            Utilize.PrintChoice(Utilize.C_Gender);
            value.setE_Gender(Utilize.ChoiceGet(Utilize.C_Gender, valid.Validator(Utilize.C_Gender)));

        }

        public void A_SkinTone(ref Intial_V value)
        {
            HeadLiner("Skin Tone", 55);
            Utilize.Simutaneus(Utilize.M_SkinTone);
            Utilize.PrintChoicePlus(Utilize.C_SkinTone, 11, 29, 12);
            value.setE_SkinTone(Utilize.ChoiceGet(Utilize.C_SkinTone, valid.Validator(Utilize.C_SkinTone)));

        }

        public void A_HairStyle(ref Intial_V value)
        {
            HeadLiner("Hair Style", 53);
            Utilize.Simutaneus(Utilize.M_HairStyle);
            Utilize.PrintChoice(Utilize.C_HairStyle);
            value.setE_HairStyle(Utilize.ChoiceGet(Utilize.C_HairStyle, valid.Validator(Utilize.C_HairStyle)));

        }

        public void A_HairColor(ref Intial_V value)
        {
            HeadLiner("Hair Color", 53);
            Utilize.Simutaneus(Utilize.M_HairColor);
            Utilize.PrintChoicePlus(Utilize.C_HairColor, 11, 29, 12);
            value.setE_HairColor(Utilize.ChoiceGet(Utilize.C_HairColor, valid.Validator(Utilize.C_HairColor)));
        }

        public void A_isHeto(ref Intial_V value)
        {
            HeadLiner("Enable Heterochromia", 45);
            Utilize.Simutaneus(Utilize.M_isHeto);
            Utilize.PrintChoice(Utilize.C_isHeto);
            valid.isHeto(ref value, Utilize.ChoiceGet(Utilize.C_isHeto, valid.Validator(Utilize.C_isHeto)));

        }

        public void A_SetEyeColor(ref Intial_V value)
        {
            if (value.getE_IsHetos())
            {
                HeadLiner("Heterochromia Color", 45);
                Utilize.Simutaneus(Utilize.M_Heto);
                Utilize.PrintHeto(Utilize.C_HetoCombination);
                value.setE_EyeColor(ChoiceGet(C_HetoCombination, valid.Validator(C_HetoCombination)));
            }
            else
            {
                HeadLiner("Eye Color", 50);
                Utilize.Simutaneus(Utilize.M_NoHeto);
                Utilize.PrintChoicePlus(Utilize.C_EyeColor, 11, 25, 12);
                value.setE_EyeColor(Utilize.ChoiceGet(C_EyeColor, valid.Validator(Utilize.C_EyeColor)));

            }
        }

        public void A_Race(ref Intial_V value)
        {
            HeadLiner("Race", 57);
            Utilize.Simutaneus(Utilize.M_Race);
            Utilize.PrintChoicePlus(Utilize.C_Race, 11, 29, 12);
            value.setE_Race(Utilize.ChoiceGet(Utilize.C_Race, valid.Validator(Utilize.C_Race)));

        }

        public void A_Class(ref Intial_V value)
        {
            HeadLiner("Class", 55);
            Utilize.Simutaneus(Utilize.M_Class);
            Utilize.PrintChoicePlus(Utilize.C_Class, 11, 25, 12);
            value.setE_Class(Utilize.ChoiceGet(Utilize.C_Class, valid.Validator(Utilize.C_Class)));

        }

        public void A_Mastery(ref Intial_V value)
        {
            int counter = 0;


            for (int i = 5; i > 0; i--)
            {
                Opening_Visuals O = new Opening_Visuals();
                HeadLiner("Passive Job", 50, counter);
                Utilize.Simutaneus3("Now distribute 5 mastery points to passive job, choose a passive job to allocate points", counter, 20, 5);
                Console.Write(O.SpaceGiver(20));
                Console.ForegroundColor = ConsoleColor.Yellow;
                CenterPrint();
                Utilize.Simutaneus3($"{i}", counter, 50, 6);
                Console.ResetColor();
                Utilize.Simutaneus3(" Remaining points", counter, 52, 6);
                PrintChoice(Utilize.C_PJOB, counter);
                Utilize.PointingSystem(valid.Validator(Utilize.C_PJOB), ref value);
                counter++;
            }

        }

        public void A_HeadGear(ref Intial_V value)
        {
            HeadLiner("Head Gear", 57);
            Utilize.Simutaneus(Utilize.M_HeadGear);
            Utilize.PrintChoicePlus(Utilize.C_HeadGear, 11, 32, 12);
            value.HeadGear = Utilize.ChoiceGet(Utilize.C_HeadGear, valid.Validator(Utilize.C_HeadGear));

        }


        public void A_Garments(ref Intial_V value)
        {
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                HeadLiner("Garment", 50, counter);
                Utilize.Simutaneus3("In the genesis of your character's tale, lies the critical choice of attire.", counter, 25, 5);
                Utilize.Simutaneus3("Your garments are more than fabric, they're reflections of your essence, expressions of your soul.", counter, 13, 6);
                Utilize.Simutaneus3("Choose attire that resonates with the chapters yet to be written.", counter, 26, 7);

                Console.ForegroundColor = ConsoleColor.Yellow;
                switch (counter)
                {
                    case 0:
                        Utilize.Simutaneus4("(Garment Torso)", 50, 8);
                        Console.ResetColor();
                        PrintChoice(C_Garments);
                        value.UpperGarment = Utilize.ChoiceGet(Utilize.C_Garments, valid.Validator(Utilize.C_Garments)) + " (Torso)";
                        break;

                    case 1:
                        Utilize.Simutaneus4("(Garment Pants)", 50, 8);
                        Console.ResetColor();
                        PrintChoice(C_Garments);
                        value.LowerGarment = Utilize.ChoiceGet(Utilize.C_Garments, valid.Validator(Utilize.C_Garments)) + " (Pants)";
                        break;

                    case 2:
                        Utilize.Simutaneus4("(Garment Shoes)", 50, 8);
                        Console.ResetColor();
                        PrintChoice(C_Garments);
                        value.Shoes = Utilize.ChoiceGet(Utilize.C_Garments, valid.Validator(Utilize.C_Garments)) + " (Shoes)";
                        break;
                }
                counter++;
            }

        }
        public void A_HeadAccessory(ref Intial_V value)
        {
            HeadLiner("Head Accessory", 50);
            Utilize.Simutaneus(Utilize.M_HeadAccessory);
            Utilize.PrintChoicePlus(Utilize.C_HeadAccessory, 9, 25, 12);
            value.HeadAccessory = ChoiceGet(C_HeadAccessory, valid.Validator(C_HeadAccessory));

        }

        public void A_BodyAccessory(ref Intial_V value)
        {
            HeadLiner("Body Accessory", 53);
            Utilize.Simutaneus(Utilize.M_BodyAccessory);
            Utilize.PrintChoice(C_BodyAccessory);
            value.BodyAccessory = ChoiceGet(C_BodyAccessory, valid.Validator(C_BodyAccessory));

        }

        public void A_ArmAccessory(ref Intial_V value)
        {
            HeadLiner("Arm Accessory", 50);
            Utilize.Simutaneus(Utilize.M_ArmAccessory);
            Utilize.PrintChoice(C_ArmAccessory);
            value.ArmAccessory = ChoiceGet(C_ArmAccessory, valid.Validator(C_ArmAccessory));

        }
    }

    public class Validations : IUtility
    {
        Messenger Message = new Messenger();
        public bool Validator(int Num, int arraySize)
        {

            if (Num > 0 && Num < arraySize + 1)
            {
                return false;
            }
            else
            {
                InputClearLine();
                Message.M_Invalid();
                return true;
            }
        }

        public void InputClearLine()
        {
            InputClearLine(57, 17);
        }

        public void InputClearLine(int xAxis, int yAxis)
        {
            for (int i = xAxis; i < 115; i++)
            {
                Opening_Visuals s = new Opening_Visuals();
                s.CenterPrint(" ", i, yAxis);
            }
        }

        public void ErrorClearLine()
        {
            ErrorClearLine(40, 20);
        }

        public void ErrorClearLine(int xAxis, int yAxis)
        {
            for (int i = xAxis; i < 115; i++)
            {
                Opening_Visuals s = new Opening_Visuals();
                s.CenterPrint(" ", i, yAxis);
            }
        }

        public string NullChecker(SqlConnection connect)
        {
            Opening_Visuals s = new Opening_Visuals();
            string Name;
            bool Valid = true;
            do
            {
                s.CenterPrint("Your Name: ", 48, 13);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Name = Console.ReadLine();

                if (string.IsNullOrEmpty(Name))
                {
                    ShortMessage("Error! Expected Output is Null!");

                }
                else if (Regex.IsMatch(Name, @"[^a-zA-Z]"))
                {
                    ShortMessage("Error! Dont include Special/Numerical Characters!");
                }
                else if (3 > Name.Length)
                {
                    ShortMessage("Enter at least 3 Characters");
                }
                else if (20<Name.Length)
                {
                    ShortMessage("Character Exceeded the Limit (20)");
                }
                else if (NameDupe(connect, Name))
                {
                    ShortMessage("Name have been already taken!");
                }
                else Valid = false;

            } while (Valid);
            Console.ResetColor();
            return Name;
        }

        public bool NameDupe(SqlConnection connect,string name)
        {
            
            SqlCommand checking = new SqlCommand($"SELECT nickname FROM Creation WHERE nickname = '{name}'", connect);
            SqlDataReader outing = checking.ExecuteReader();
            bool getter = outing.HasRows;
            outing.Close();

            return getter;
        }

        public void ShortMessage(string Quote)
        {
            Messenger Message = new Messenger();
            InputClearLine(57, 13);
            Message.M_Estring(Quote);
            ErrorClearLine(42 + Quote.Length, 15);



        }
        public int Validator(string[] Chose)
        {

            Messenger invl = new Messenger();
            Opening_Visuals s = new Opening_Visuals();
            int User_Int = 0;
            bool Valid = true;
            do
            {
                try
                {

                    s.CenterPrint("Choice: ", 50, 17);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    User_Int = int.Parse(Console.ReadLine());

                    Valid = false;
                }

                catch (Exception e)
                {
                    InputClearLine();
                    invl.M_Invalid();

                }
            } while (Valid || Validator(User_Int, Chose.Length));

            ErrorClearLine();
            invl.Simutaneus4("You have Chosen " + invl.ChoiceGet(Chose, User_Int), 43, 19);
            Thread.Sleep(1000);
            Console.ResetColor();
            Console.Clear();
            return User_Int;
        }



        public void isHeto(ref Intial_V chracter, string isHetog)
        {
            if (isHetog == "Yes")
            {

                chracter.setE_IsHetos(true);
            }
            else if (isHetog == "No")
            {

                chracter.setE_IsHetos(false);
            }

        }

    }

    public class Messenger : Choice
    {

        public int Cooldown = 50;
        public int Cooldown2 = 1000;
        public string M_Age = $"Hello! we'd like to know which age group best represents you. Please select an Age category that resonates with your adventurous spirit.";
        public string Exit = "As your journey through concludes, we bid you a fond farewell.\t  Your adventures have left an indelible mark, Until we cross paths again. " +
            "\t\t\t  Safe travels and endless discoveries await.";
        public string M_Height = "Your preferred height can add a unique touch to your adventure. Kindly pick a height category that resonates with your vision for the character";
        public string M_BodyType = "\tWe're looking to match your physique. \tA body type that suits your adventuring style, perhaps?";
        public string M_Gender = $"\tAh, the very essence of your character.\t We'd like to know more about your gender What defines you?";
        public string M_SkinTone = "\t\tEach shade tells a unique story.\t The canvas of your identity! What color represents your skin?";
        public string M_HairStyle = "The palette of your style! It's a canvas for expression.\t\t\tAny style resonating with you?";
        public string M_HairColor = "\tIt's your chance to stand out! define your vibe. Feel free to pick the color that that speaks your style and truly represents you";
        public string M_isHeto = "Embrace uniqueness! Do your eyes sport different hues. Like jewels set apart? Select 'Yes' you want to enable Heterochromia. \t\t'No' if you want a matching eye colors.";
        public string M_Heto = "Ah, an intriguing choice! Heterochromia it is. Select the captivating fusion of colors for your heterochromia. Let your choice paint a mesmerizing blend that's uniquely yours.";
        public string M_NoHeto = "\tYou've decided to keep your eyes the same color. Beauty in uniformity there's something serene about symmetry, don't you think?. \t\tChoose the color that mirrors your essence";
        public string M_Race = "\tThe world welcomes you in various forms and shapes. Choose wisely your race is the foundation of your tale in this vast and diverse realm.";
        public string M_Class = "\tSelecting from a range of distinctive paths. \tEach bearing its unique essence Embrace your chosen calling.\t\t\t    Pick your Desired Class.";
        public string M_HeadGear = "In a world brimming with possibility, your headgear stands as a statement. It's not just an accessory it's a symbol of your journey, a signature of your resilience.\t  Choose wisely, for your headgear holds the essence of your tale.";
        public string M_HeadAccessory = "A headpiece, perhaps? It's a reflection of your uniqueness.   Enhancing your charm and presence in this vast world choose wisely.\tFor it shall accompany you through countless adventures.";
        public string M_BodyAccessory = "Amidst the grand diversity of our world, each carrying its own tale. Select one that speaks to your heart Every bauble, every charm, will add a flair.\t\tYour choice will shape the story that unfolds. ";
        public string M_ArmAccessory = "Gleam with potential as you gear up for your grand journey. \t\tA mere accessory? No, they are statements.\t      Echoes of your character waiting to be chosen.";
        public void M_Invalid()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n");
            CenterPrint();
            Console.Write("\t\tAn Error has Occured Try Again! ");
            Console.ResetColor();
        }

        public void M_Estring(string Error)
        {
            Opening_Visuals o = new Opening_Visuals();
            Console.ForegroundColor = ConsoleColor.Red;
            o.CenterPrint(Error, 42, 15);
            Console.ResetColor();
        }




        public void CenterDown()
        {
            CenterDown(5);
        }

        public void CenterDown(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine();
            }
        }

        public bool IsOpen = true;
        public void UserInput()
        {
            IsOpen = true;
            int Cool = 0;
            while (IsOpen)
            {
                Thread.Sleep(Cool);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Cooldown = 0;
                    Cooldown2 = 0;
                    Cool = 2000;
                }
            }
        }



        public void Simutaneus(string Message)
        {
            Thread t2 = new Thread(UserInput);
            Thread t1 = new Thread(() => Dialogue(Message));
            t1.Start();
            Thread.Sleep(1);
            t2.Start();
            t1.Join();


        }

        public void Dialogue(string Message)
        {

            CenterDown();
            Console.Write($"\t\t\t\t");
            for (int j = 0; j < Message.Length; j++)
            {
                Cooldown2 = 1000;
                Console.Write(Message[j]);
                if (Message[j].Equals('.'))
                {

                    Cooldown = 50;
                    Thread.Sleep(Cooldown2);
                    Console.WriteLine(); Console.Write($"\t\t\t");
                }
                Thread.Sleep(Cooldown);
            }
            IsOpen = false;
        }

        public void Simutaneus2(string Message)
        {
            Thread t2 = new Thread(UserInput);
            Thread t1 = new Thread(() => DialogueType2(Message));
            t1.Start();
            Thread.Sleep(1);
            t2.Start();
            t1.Join();
        }

        public void DialogueType2(string Message)
        {
            Cooldown = 50;
            int x = 37, y = 11;
            for (int j = 0; j < Message.Length; j++)
            {
                Console.SetCursorPosition(x += 1, y);
                Console.Write(Message[j]);
                Thread.Sleep(Cooldown);
            }
            IsOpen = false;
        }
        public void Simutaneus3(string Message, int counter, int x, int y)
        {
            Thread t2 = new Thread(UserInput);
            Thread t1 = new Thread(() => DialogueType3(Message, counter, x, y));
            t1.Start();
            Thread.Sleep(1);
            t2.Start();
            t1.Join();
        }
        public void DialogueType3(string Message, int counter, int x, int y)
        {
            Cooldown = 50;
            for (int j = 0; j < Message.Length; j++)
            {
                Console.SetCursorPosition(x += 1, y);
                Console.Write(Message[j]);
                if (counter == 0) { Thread.Sleep(Cooldown); }
            }
            IsOpen = false;
        }

        public void Simutaneus4(string Message, int x, int y)
        {
            Thread t2 = new Thread(UserInput);
            Thread t1 = new Thread(() => DialogueType3(Message, x, y));
            t1.Start();
            Thread.Sleep(1);
            t2.Start();
            t1.Join();
        }

        public void DialogueType3(string Message, int x, int y)
        {
            Cooldown = 50;
            for (int j = 0; j < Message.Length; j++)
            {
                Console.SetCursorPosition(x += 1, y);
                Console.Write(Message[j]);
                Thread.Sleep(Cooldown);
            }
            IsOpen = false;
        }


        public override void PrintChoice(String[] Choose)
        {

            CenterDown(3);
            if (Choose.Length == 2)
            {
                Console.Write("\t\t\t\t\t");
            }
            else if (Choose.Length == 3)
            {
                Console.Write("\t\t\t\t");
            }
            else if (Choose.Length == 4)
            {
                Console.Write($"\t\t");
            }
            else if (Choose.Length == 5)
            {
                Console.Write("\t\t");
            }


            for (int i = 0; i < Choose.Length; i++)
            {
                Console.Write(Choose.Length == 2 ? $"{"",8}[{i + 1}]. {Choose[i]}" : $"{"",5}[{i + 1}]. {Choose[i]}");
                Thread.Sleep(500);
            }
        }

        public void PrintChoicePlus(String[] Choose, int Space, int x, int y)
        {
            for (int i = 0; i < Choose.Length; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write($"[{i + 1}]. {Choose[i]}");
                x += Space + Choose[i].Length;
                Thread.Sleep(500);
            }
        }

        public void PrintHeto(String[] Choose)
        {
            Opening_Visuals o = new Opening_Visuals();
            CenterDown(3);
            Console.Write("\t\t\t\t");
            o.SpaceGiver(10);
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"{"",5}[{i + 1}]. {Choose[i]}");
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t\t");
            for (int i = 2; i < 5; i++)
            {
                Console.Write($"{"",5}[{i + 1}]. {Choose[i]}");
                Thread.Sleep(500);
            }

        }
        public void PritingName(Intial_V name)
        {
            Opening_Visuals Op = new Opening_Visuals();

            Op.CenterDown(10);
            Op.CenterPrint();
            Console.Write("\t");
            Op.SpaceGiver(2);
            for (int i = 0; i < name.getE_Nickname().Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(name.getE_Nickname()[i]);
                Thread.Sleep(500);
            }
            Console.Write('?');
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.WriteLine();
            Simutaneus2("Hope we can make your journey memorable!");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }

    public class Last_Phase
    {
        Messenger m = new Messenger();
        public void Backward(int cd, int Message, int x, int y)
        {

            for (int j = 0; j < Message; j++)
            {
                Console.SetCursorPosition(x -= 1, y);
                Console.Write(j % 2 == 0 ? "-" : "=");
                Thread.Sleep(cd);
            }
        }

        public void Straight(int cd, int Message, int x, int y)
        {

            for (int j = 0; j < Message; j++)
            {
                Console.SetCursorPosition(x += 1, y);
                Console.Write(j % 2 == 0 ? "-" : "=");
                Thread.Sleep(cd);
            }
        }

        public void Down(int cd, int Message, int x, int y)
        {

            for (int j = 0; j < Message; j++)
            {
                Console.SetCursorPosition(x, y += 1);
                Console.Write(j % 2 == 0 ? "-" : "=");
                Thread.Sleep(cd);
            }
        }

        public void Up(int cd, int Message, int x, int y)
        {

            for (int j = 0; j < Message; j++)
            {
                Console.SetCursorPosition(x, y -= 1);
                Console.Write(j % 2 == 0 ? "-" : "=");
                Thread.Sleep(cd);
            }
        }
        public void Player_Info(string[] Features, string[] Player)
        {
            int x = 5;
            int Height = 0;
            for (int k = 0; k < 2; k++)
            {
                int count = 0;
                if (k == 1) { x = +30; Console.ForegroundColor = ConsoleColor.Yellow; }
                for (int j = 0; j < Player.Length; j++)
                {
                    if (count % 10 == 0) Height = 0;
                    m.Simutaneus4(k == 0 ? Features[count] + ":" : Player[count], x, Height += 2);
                    Thread.Sleep(50);
                    count++;
                    Thread.Sleep(50);
                    if (count % 10 == 0) x += 65;
                }
                x = 5;
                Console.ResetColor();
            }

        }

        public void MasteryPrint(string[] Passive, int[] Points)
        {

            for (int j = 0; j < 2; j++)
            {
                int x = 3;
                for (int i = 0; i < Passive.Length; i++)
                {
                    if (j == 0)
                    {
                        m.Simutaneus4(Passive[i] + ":", x, 25);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        m.Simutaneus4(Points[i].ToString(), Passive[i].Length + x + 2, 25);
                    }

                    x += 25;
                    Thread.Sleep(50);
                }
            }

        }

        public void BorderDesign(int cd)
        {
            Straight(cd, 45, 0, 0);
            Backward(cd, 50, 120, 22);
            Backward(cd, 45, 120, 0);
            Straight(cd, 50, 0, 22);
            Up(cd, 23, 120, 23);
            Down(cd, 23, 0, -1);
        }

        public void Headlining()
        {
            m.Simutaneus4("Mastery Points", 52, 22);
            m.Simutaneus4("Character Created", 52, 0);
            Console.ResetColor();
        }

        public void Finale(Intial_V value, Messenger a)
        {

            BorderDesign(20);
            Player_Info(a.characterArray, a.StringPlayer(value));
            MasteryPrint(a.C_PJOB, a.Master(value));
            Headlining();
            m.Simutaneus4("Press Any Key to Continue...", 50, 28);
            Console.ReadKey(true);
            Console.Clear();
            LastMessage();

        }

        public void LastMessage()
        {
            Opening_Visuals M = new Opening_Visuals();
            M.Rewrite("Inserting Data to Data Base",52,13);
            M.Rewrite("Updating Table...", 52, 13);
            M.Rewrite("Done...", 60, 13);
        }
    }

    public interface IUtility
    {
        void InputClearLine();
    }

    public interface IUtility2
    {
        void CenterPrint();
    }

    public interface IUtility3
    {
        void CenterDown(int i);
    }

    public interface IUtility4
    {
        string SpaceGiver(int i);
    }
    public class DataBase : DataBase_Visuals
    {
        public string FilePath = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jetrix\\source\\repos\\HULING_PAGDUDUSA_TOTOO_NA\\HULING_PAGDUDUSA_TOTOO_NA\\MyData.mdf;Integrated Security=True";
        public string Table1 = "Creation";
        public string Table2 = "TempC";
        static string Column = "nickname,AgeGroup,Height,BodyType,Gender,SkinTone,HairStyle,HairColor,Heterochromia,EyeColor,Race,Class,HeadGear,UpperGarment,LowerGarment,Shoes,HeadAccessory,BodyAccessory,ArmAccessory,FishermanP,BlacksmithP,FarmerP,LibrarianP,CartographerP";
        public string[] ColumnRay = Column.Split(',');
        public string[] TemporaryS;
        public int[] TemporaryP = new int[5];

        public void Commander(SqlConnection connector, string commader)
        {
            SqlCommand cmd = new SqlCommand(commader, connector);
            cmd.ExecuteNonQuery();
        }

        public SqlConnection Connector(string FilePath)
        {
            SqlConnection sqlConnection = new SqlConnection(FilePath);
            sqlConnection.Open();
            return sqlConnection;
        }

        public int bitConverter(bool bull)
        {
            if (bull) return 1;
            return 0;
        }

        public int TableCounter(SqlConnection connector)
        {
            SqlCommand SELECT = new SqlCommand("SELECT COUNT(player_id) FROM Creation", connector);
            SqlDataReader read = SELECT.ExecuteReader();
            read.Read();
            int Colus = read.GetInt32(0);
            read.Close();
            return Colus + 1;
        }

        public void IdResetter(SqlConnection connector, string table1, string table2, string values)
        {
            SqlCommand Reset = new SqlCommand($"INSERT INTO {table1}  ({values}) SELECT {values} FROM {table2} ORDER BY player_id ASC", connector);
            SqlCommand Reset2 = new SqlCommand($"TRUNCATE table {table2}", connector);
            Reset.ExecuteNonQuery();
            Reset2.ExecuteNonQuery();
        }

        public void ResetID(SqlConnection connector, string table1, string table2)
        {
            IdResetter(connector, table2, table1, Column);
            IdResetter(connector, table1, table2, Column);
        }

        public void InsertData(string[] Column, object[] val, int id, SqlConnection connector)
        {
            for (int i = 0; i < val.Length; i++)
            {
                string Check = val[i] is string ? $"'{val[i]}'" : $"{val[i]}";
                bool DoubleCheck = Check.Contains("True") || Check.Contains("False");
                string TripleCheck = DoubleCheck ? bitConverter(Check.Contains("True")).ToString() : Check;
                string Insertion = $"INSERT INTO dbo.Creation({Column[i]}) VALUES({TripleCheck})";
                string AddOns = $"UPDATE Creation SET {Column[i]}= {TripleCheck} WHERE player_id ={id}";

                SqlCommand Insert = new SqlCommand(Insertion, connector);
                SqlCommand Add = new SqlCommand(AddOns, connector);
                if (i == 0)
                {
                    Insert.ExecuteNonQuery();
                }
                else
                {
                    Add.ExecuteNonQuery();
                }

            }

        }

        public void Reader(SqlConnection sqlConnection, string[] numb, int id)
        {
            SqlCommand SELECT = new SqlCommand($"SELECT {Column} FROM Creation WHERE player_id={id} ", sqlConnection);
            SqlDataReader read = SELECT.ExecuteReader();
            TemporaryS = new string[ColumnRay.Length - 5];
            int j = 0;
            read.Read();
            for (int i = 0; i < numb.Length; i++)
            {
                object getter = read[numb[i]];

                if (getter is string || getter is bool)
                {
                    TemporaryS[i] = getter.ToString();
                }
                else
                {
                    TemporaryP[j] = Convert.ToInt32(getter);
                    j++;
                }

            }
            read.Close();
        }

        public void AvailableNames(SqlConnection connect)
        {
            int x = 5;
            int y = 3;
            int num = 1;
            Last_Phase decor = new Last_Phase();
            SqlCommand GetName = new SqlCommand("SELECT nickname FROM Creation", connect);
            SqlDataReader NameReader = GetName.ExecuteReader();
            decor.BorderDesign(0);
            while (NameReader.Read())
            {
                if (x > 110) { x = 5; y = 5; }
                Console.SetCursorPosition(x, y);
                Console.WriteLine(num + ". " + NameReader.GetString(0));
                num++;
                x += 20;
            }
            NameReader.Close();
        }

        public void optionY()
        {
            Console.SetCursorPosition(20, 25);
            Console.WriteLine("YES");
        }

        public void optionN()
        {
            Console.SetCursorPosition(100, 25);
            Console.WriteLine("NO");
        }

        public void ClearCaptor(int x, int y, int space)
        {
            Opening_Visuals O = new Opening_Visuals();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(O.SpaceGiver(space));
        }

        public void Questioning()
        {
            Console.SetCursorPosition(54, 22);
            Console.WriteLine("Are you sure?");
        }

        public void Qxit()
        {
            Console.SetCursorPosition(53, 22);
            Console.WriteLine("Enter Q to Exit");
        }

        public void SuccessMessage(string name)
        {
            Console.SetCursorPosition(52, 13);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(name);
            Console.ResetColor();
            Console.WriteLine(" Successfully Deleted!");
        }

        public void DNE()
        {
            Console.SetCursorPosition(48, 24);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Character Does Not Exist!");
            Console.ResetColor();
        }

        public void HeadsUP()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(46, 0);
            Console.WriteLine(" Enter a Character To Delete");
            Console.ResetColor();
        }
        public string isAvailable(SqlConnection connect)
        {
            
            string name = "";
            SqlCommand checking = new SqlCommand($"SELECT nickname FROM Creation WHERE nickname = '{name}'", connect);

            SqlDataReader outing = checking.ExecuteReader();

            do
            {
                try
                {
                    if (!outing.IsClosed) outing.Close();
                    ClearCaptor(55, 21, 64);
                    Console.SetCursorPosition(55, 21);
                    name = Console.ReadLine();
                    checking = new SqlCommand($"SELECT nickname FROM Creation WHERE nickname = '{name}'", connect);
                    outing = checking.ExecuteReader();
                    if (!outing.HasRows) { DNE(); }
                    if (outing.HasRows || name.Equals("q", StringComparison.OrdinalIgnoreCase)) break;
                }
                catch (Exception ex) { DNE(); }
            } while (true);

            outing.Close();
            return name;
        }



        public void DELETERS(SqlConnection connnect)
        {
            bool breaker1;
            bool breaker2;

            do
            {
                breaker1 = true;
                breaker2 = true;

                int id = 0;
                HeadsUP();
                AvailableNames(connnect);
                Qxit();
                string name = isAvailable(connnect);
                SqlCommand del = new SqlCommand($"DELETE FROM Creation WHERE nickname ='{name}'", connnect);
                ClearCaptor(55, 21, 64);
                ClearCaptor(48, 24, 25);
                ClearCaptor(53, 22, 15);
                Questioning();
                optionN();
                optionY();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                

                do
                {
                    optionN();
                    optionY();
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        id++;
                        id = Checker(id, 2);

                    }
                    else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        id--;
                        id = Checker(id, 2);
                    }

                    if (id == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        optionY();
                        Console.ResetColor();
                        
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            if ((name.Equals("q", StringComparison.OrdinalIgnoreCase)))
                            {
                                Console.Clear();
                                QuitMessage();
                                breaker1 = false;
                                breaker2 = false;
                                
                            }
                            else
                            {
                                Console.Clear();
                                del.ExecuteNonQuery();
                                ResetID(connnect, Table1, Table2);
                                SuccessMessage(name);
                                breaker1 = false;
                                breaker2 = false;
                            }
                            

                        }
                    }

                    else if (id == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        optionN();
                        Console.ResetColor();
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            ClearCaptor(20, 25, 20);
                            ClearCaptor(100, 25, 20);
                            ClearCaptor(54, 22, 13);
                            Qxit();
                            Console.SetCursorPosition(55, 21);
                            breaker2 = false;
                        }
                    }

                    if (breaker1) keyInfo = Console.ReadKey(true);


                } while (breaker2);



            } while (breaker1);
        }




    }



    public class DataBase_Visuals
    {
        public Messenger Fixer = new Messenger();

        public void Player_InfoMinus(string[] Features, string[] Player, string[] Passive, int[] Points)
        {
            int x = 5;
            int Height = 0;
            MasteryPrintMinus(Passive, Points);
            for (int k = 2; k > 0; k--)
            {
                int count = 0;

                if (k == 1) { x = +30; Console.ForegroundColor = ConsoleColor.Yellow; }

                for (int j = 0; j < Player.Length; j++)
                {

                    if (count % 10 == 0) Height = 0;
                    Fixer.Simutaneus3(k == 2 ? Features[count] + ":" : Player[count], k - 1, x, Height += 2);

                    count++;


                    if (count % 10 == 0) x += 65;
                }
                x = 5;
                Console.ResetColor();
            }

        }

        public void MasteryPrintMinus(string[] Passive, int[] Points)
        {

            for (int j = 0; j < 2; j++)
            {
                int x = 3;
                for (int i = 0; i < Passive.Length; i++)
                {
                    if (j == 0)
                    {
                        Fixer.Simutaneus3(Passive[i] + ":", 1, x, 25);
                    }
                    else
                    {
                        Thread.Sleep(200);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Fixer.Simutaneus4(Points[i].ToString(), Passive[i].Length + x + 2, 25);
                        Console.ResetColor();
                    }

                    x += 25;

                }
            }

        }

        public void ReadingDisplay(int id, string[] Features, string[] Passive, SqlConnection sqlConnection, string[] numb, DataBase data)
        {
            Opening_Visuals OV = new Opening_Visuals();
            Last_Phase last = new Last_Phase();
            last.BorderDesign(0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            OV.CenterPrint("Character " + id, 52, 0);
            OV.CenterPrint("Mastery Points", 53, 22);
            Console.ResetColor();
            data.Reader(sqlConnection, numb, id);
            data.Player_InfoMinus(Features, data.TemporaryS, Passive, data.TemporaryP);

        }

        public int Checker(int i, int Max)
        {
            if (i <= 0) { return 1; }
            else if (i > Max) { return Max; }

            return i;
        }

        public void EscapeUs()
        {
            Opening_Visuals M = new Opening_Visuals();
            Console.ForegroundColor = ConsoleColor.Yellow;
            M.CenterPrint("Press Esc to Exit!",52, 29);
            Console.ResetColor();
        }

        public void PlayerDisplayer(string[] Features, string[] Passive, SqlConnection sqlConnection, string[] numb, DataBase data)
        {


            int id = 1;
            int Max = data.TableCounter(sqlConnection) - 1;
            EscapeUs();
            ReadingDisplay(id, Features, Passive, sqlConnection, numb, data);
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            while (keyInfo.Key != ConsoleKey.Escape)
            {

                
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    id++;
                    Trigger(id, Max, Features, Passive, sqlConnection, numb, data);
                    id = Checker(id, Max);

                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    id--;
                    Trigger(id, Max, Features, Passive, sqlConnection, numb, data);
                    id = Checker(id, Max);
                }
                keyInfo = Console.ReadKey(true);
            }
            Console.Clear();
            QuitMessage();
        }
        public void QuitMessage()
        {
            Console.SetCursorPosition(52, 13);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Successfully Quitted!");
            Console.ResetColor();
        }

        public void Trigger(int id, int Max, string[] Features, string[] Passive, SqlConnection sqlConnection, string[] numb, DataBase data)
        {
            if (!(id <= 0 || id > Max))
            {
                Console.Clear();
                EscapeUs();
                ReadingDisplay(id, Features, Passive, sqlConnection, numb, data);

            }
        }

        public void OptionDB(string[] Features, string[] Passive, SqlConnection sqlConnection, string[] numb, DataBase data)
        {

            int id = 0;
            int counter = 0;
            Options();
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            while (true)
            {
                if (counter>0)
                    Console.Clear();
                counter++;
                Options();

                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    id++;
                    id = Checker(id, 3);

                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    id--;
                    id = Checker(id, 3);

                }


                if (id == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Option1();
                    Console.ResetColor();
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        data.PlayerDisplayer(Features, Passive, sqlConnection, numb, data);

                    }
                }


                else if (id == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Option2();
                    Console.ResetColor();
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        data.DELETERS(sqlConnection);
                        id = 0;
                    }

                }


                else if (id == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Option3();
                    Console.ResetColor();
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Exitting();
                    }
                }

                keyInfo = Console.ReadKey(true);
            }
        }
        public void Options()
        {
            Title();
            Option1();
            Option2();
            Option3();
        }
        public void Title()
        {
            Console.SetCursorPosition(60, 5);
            Console.WriteLine("Choose Option");
        }
        public void Option1()
        {
            Console.SetCursorPosition(25, 12);
            Console.WriteLine("Display All Character");
        }

        public void Option2()
        {
            Console.SetCursorPosition(60, 12);
            Console.WriteLine("Delete Chracter");
        }

        public void Option3()
        {
            Console.SetCursorPosition(95, 12);
            Console.WriteLine("Exit Game");
        }

        public void Heart()
        {
            for (int i = 0; i < 7; i++) { Console.WriteLine(); }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                             ███   ███");
            Console.WriteLine("                                                           █████████████");
            Console.WriteLine("                                                          ███████████████");
            Console.WriteLine("                                                            ████████████");
            Console.WriteLine("                                                              ████████");
            Console.WriteLine("                                                                ███");
            Console.ResetColor();
        }

        public void Exitting()
        {
            Opening_Visuals OV = new Opening_Visuals();
            OV.Dialogue(Fixer.Exit);
            Heart();
            Console.SetCursorPosition(55, 25);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Thank You for Playing!");
            Console.ResetColor();
            Thread.Sleep(10000);
            Environment.Exit(0);
        }
    }
}