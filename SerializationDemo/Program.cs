using System;
using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;      //PART II

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lizard> lizards = Lizard.GetLizards();
            //SerializeOneLizard("one.json", lizards[0]);
            SerializeAllLizards("all.json", lizards);
            //DeserializeOneLizard("one.json");
        }
        static void SerializeOneLizard(string filename, Lizard lizard)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer(); //PART III
            using (TextWriter writer = new StreamWriter(filename))
            {
                string output = serializer.Serialize(lizard);
                writer.Write(output);
            }
        }
        static void SerializeAllLizards(string filename, List<Lizard> lizards)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer(); //PART III
            using (TextWriter writer = new StreamWriter(filename))
            {
                string output = serializer.Serialize(lizards);
                writer.Write(output);
            }
        }

        static void DeserializeOneLizard(string filename)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (TextReader reader = new StreamReader(filename))
            {
                string input = reader.ReadToEnd();
                Lizard lizard = serializer.Deserialize<Lizard>(input);
                Console.WriteLine(lizard);
            }
        }

        static void DeserializeAllLizards(string filename)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (TextReader reader = new StreamReader(filename))
            {
                string input = reader.ReadToEnd();
                List<Lizard> lizards = serializer.Deserialize<List<Lizard>>(input);
                int count = 1;
                foreach (Lizard lizard in lizards)
                {
                    Console.WriteLine($"{count++, -2} - {lizard}");
                }
            }
        }

    }
}
