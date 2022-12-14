using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Character
  {
    public string Name { get; set; }
    public int Food { get; set; } = 100;
    public int Attention { get; set; } = 100;
    public int Rest { get; set; } = 100;

    public int Id { get; }

    private static List<Character> _instances = new List<Character> { };

    public Character(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public void PassTime ()
    {
      Food -= 10;
      Rest -= 10;
      Attention -= 10;
    } 

    public void Feed ()
    {
      Food += 10;
    } 

        public void Feed ()
    {
      Food += 10;
    } 

    public void Feed ()
    {
      Food += 10;
    } 

  }
}