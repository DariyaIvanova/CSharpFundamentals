using System;
using System.Collections.Generic;
using System.Linq;
/*
 */
namespace _09.PokemonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int summedPokemons = 0;
            while (pokemons.Count>0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index>=0 && index<=pokemons.Count-1)
                {
                    int valueRemovedPokemon = pokemons[index];
                    summedPokemons += valueRemovedPokemon;
                    pokemons.RemoveAt(index);                  
                    ManipulatePokemons(valueRemovedPokemon, pokemons);
                    
                }
                else if (index<0)
                {
                    int firstElement = pokemons[0];
                    int lastElement = pokemons[pokemons.Count-1];
                    summedPokemons += firstElement;
                    pokemons.RemoveAt(0);                   
                    pokemons.Insert(0, lastElement);                   
                    ManipulatePokemons(firstElement, pokemons);

                }
                else if (index>pokemons.Count-1)
                {
                    int firstElement = pokemons[0];
                    int lastElement = pokemons[pokemons.Count - 1];
                    summedPokemons += lastElement;
                    pokemons.RemoveAt(pokemons.Count - 1);                   
                    pokemons.Add(firstElement);                    
                    ManipulatePokemons(lastElement, pokemons);
                }
            }
            Console.WriteLine(summedPokemons);
        }
        static void ManipulatePokemons(int valueRemovedPokemon, List<int> pokemons)
        {
           
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i]<=valueRemovedPokemon)
                {
                    pokemons[i] += valueRemovedPokemon;
                }
                else
                {
                    pokemons[i] -= valueRemovedPokemon;
                }
            }
        }
    }
}
