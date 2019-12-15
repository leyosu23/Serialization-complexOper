using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    class Lizard
    {
        public string Species;
        public int Quantity;
        public bool IsDangerous;
        public override string ToString()
        {
            return string.Format($"{Species} {Quantity} {(IsDangerous ? "dangerous" : "not dangerous")}");
        }
        public static List<Lizard> GetLizards()
        {
            return new List<Lizard>()
            {
                new Lizard() { Species = "Leopard gecko", Quantity = 3, IsDangerous = true },
                new Lizard() { Species = "Bearded dragon", Quantity = 1, IsDangerous = true },
                new Lizard() { Species = "Crested gecko", Quantity = 4, IsDangerous = false },
                new Lizard() { Species = "Argentine tegu", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Thorny devil", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Casquehead lizard", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Panther chameleon", Quantity = 6, IsDangerous = false },
                new Lizard() { Species = "Veiled chameleon", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Water monitor", Quantity = 4, IsDangerous = false },
                new Lizard() { Species = "Komodo dragon", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Green iguana", Quantity = 4, IsDangerous = false },
                new Lizard() { Species = "Blotched blue-tongue lizard", Quantity = 4, IsDangerous = true },
                new Lizard() { Species = "Gila monster", Quantity = 4, IsDangerous = true }
            };
        }
    }
}
