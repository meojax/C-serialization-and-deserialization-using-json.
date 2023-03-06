using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Atom
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Proton { get; set; }
        public int Neutron { get; set; }
        public double Weight { get; set; }


        public Atom()
        {


        }


        public Atom(string name,
                         int proton,
                         int neutron,
                         double weight,
                         string symbol)

        {
            Name = name;
            Proton = proton;
            Neutron = neutron;
            Weight = weight;
            Symbol = symbol;
        }

        public static Atom Parse(string line)
        {
            string[] theLineNeom = line.Split(' ');

            Atom atomC = new Atom();
           
            string Name = theLineNeom[0];
            int proton = int.Parse(theLineNeom[1]);
            int neutron = int.Parse(theLineNeom[2]);
            double weight = double.Parse(theLineNeom[3]);
            string symbol = theLineNeom[4];
            if (theLineNeom.Length != 5)
            {
                throw new Exception("the argument input does not yield five parts");
            }

            return new Atom(Name, proton, neutron, weight, symbol);
        }

        public override string ToString()
        {
            return $" Element Name:  {Name}   Proton:  {Proton}  Neutron:  {Neutron}   Weight:  {Weight}  Symbol:  {Symbol}";
        }







    }
}
