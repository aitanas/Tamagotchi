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
      Random rnd = new Random();
      Food -= rnd.Next(1, 21);
      Rest -= rnd.Next(1, 21);
      Attention -= rnd.Next(1, 21);
    } 

    public void Feed ()
    {
      Food += 10;
    } 

    public void Nap ()
    {
      Rest += 10;
    } 

    public void Play ()
    {
      Attention += 10;
    } 

    public bool CheckIfAlive()
    {
      if (this.Food <= 0 || this.Rest <= 0 || this.Attention <= 0)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

  }
}