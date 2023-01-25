using HashidsNet;
using System;

namespace CodHash
{
    public class ObterHash
    {
        public ObterHash()
        {
            this.hashID = Guid.NewGuid().ToString();
        }
        public string hashID{get; set;}
        public string hashCode{get; set;}
        public int nonHashCode{get; set;}
        public ObterHash CriarComando(int number)
        {
            var hashids = new Hashids("salt");
            var hash = hashids.Encode(number);
            var hashDecode = hashids.DecodeSingle(hash);

            var comando = new ObterHash();
            hashCode = hash;
            nonHashCode = number; 

            return comando;
        }

        public static void Main(string [] args)
        {
            var teste = new ObterHash();
            teste.CriarComando(66565741);
            Console.WriteLine(teste.hashID); //9a7fd9df-62c9-4cfa-8a3b-fd2ef588225b
            Console.WriteLine(teste.hashCode); //K09eX9
            Console.WriteLine(teste.nonHashCode); // 66565741
        }

    }
}
