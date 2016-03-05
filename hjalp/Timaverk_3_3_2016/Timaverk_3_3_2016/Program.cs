using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Timaverk_3_3_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            string strSkrNafn, strSvar1, tempnafn, tempage, tempskrnr;
            int age;


            Console.Write("Gemmér skráarnafn: ");
            strSkrNafn = Console.ReadLine();

            strSkrNafn = @"C:\Temp\" + strSkrNafn + ".xml";

            

            Console.Write("Nýtt dýr eða sækja annað. Nýtt eða sækja");
            strSvar1 = Console.ReadLine();

            if ((strSvar1 == "nýtt") || (strSvar1 == "Nýtt"))
            {
                var dyr = new Dyr();
                
                while (true)
                {

                    
                    Console.Write("Nafn? ");
                    tempnafn = Console.ReadLine();
                    Console.Write("Aldur? ");
                    tempage = Console.ReadLine();

                    while (!Int32.TryParse(tempage, out age))
                    {
                        Console.Write("Not a valid number, try again.");

                        tempage = Console.ReadLine();
                    }

                    Console.Write("SkrNúmer? ");
                    tempskrnr = Console.ReadLine();
                    

                    dyr.dyralisti.Add(new Animal()
                    {
                        name = tempnafn,
                        age = tempage,
                        skrnNr = tempskrnr
                    });


                   


                    Console.Write("Má bjóða þér að gera annað dýr? já eða nei ");
                    string dyrSvar = Console.ReadLine();
                    if ((dyrSvar == "nei") || (dyrSvar == "Nei"))
                    {
                        
                        var fs = new FileStream(strSkrNafn, FileMode.Create);
                        new XmlSerializer(typeof(Dyr)).Serialize(fs, dyr);
                        fs.Close();
                        Console.ReadKey();
                        
                        break;
                    }


                }

            }
            else if ((strSvar1 == "sækja") || (strSvar1 == "Sækja"))
            {

                var dyr = new Dyr();
                //XmlSerializer serializer = new
                //XmlSerializer(typeof(Animal));

                //// A FileStream is needed to read the XML document.
                //FileStream fs = new FileStream(strSkrNafn, FileMode.Open);
                //XmlReader reader = XmlReader.Create(fs);

                //// Declare an object variable of the type to be deserialized.
                //Animal a;

                //// Use the Deserialize method to restore the object's state.
                //a = (Animal)serializer.Deserialize(reader);
                //fs.Close();

                //// Write out the properties of the object.

                //XmlSerializer serializer = new XmlSerializer(typeof(Animal));

                //Stream fs = File.OpenRead(strSkrNafn);

                // Use the Deserialize method to restore the object's state.
                //Animal a = serializer.Deserialize(fs) as Animal;

                // foreach (Animal an in animal)
                // {

                //}

                //    Console.WriteLine("The name: ", a.name);
                //Console.WriteLine("The age: ", a.age);
                //Console.WriteLine("Licensssss nr: ", a.skrnNr);
                //fs.Close();
                //XmlSerializer xmlserializer = new XmlSerializer(typeof());
                //StreamReader sr = new StreamReader(strSkrNafn);
                //Animal an = (Animal)xmlserializer.Deserialize(sr);



                XmlSerializer myDeserializer = new XmlSerializer(typeof(Animal));
                FileStream myFileStream = new FileStream(strSkrNafn, FileMode.Open);
                var loadedData = (List<Animal>)myDeserializer.Deserialize(myFileStream);
                myFileStream.Close();

                //foreach ( pr in p)
                //Console.WriteLine("--------------Animal----------");
                //Console.WriteLine("Name of the animal: ", pr.name);
                //Console.WriteLine("Age of the animal: ", pr.age);
                //Console.WriteLine("Animal number is: ", pr.skrnNr);




                Console.ReadKey();

            }
        }
    }
}
