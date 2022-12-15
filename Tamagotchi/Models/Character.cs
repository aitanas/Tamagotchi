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

    public static int FindAt(int id)
    { 
      for(int i = 0; i < _instances.Count; i++)
      {
        if (_instances[i].Id == id)
        {
          return i;
        }
      }
      return -1;
    }
    public static void Feed (int id)
    {
      int foundId = FindAt(id);
      if (foundId != -1)
      {
        _instances[foundId].Food += 10;
      }
    }

    public static void Nap(int id)
    {
      int foundId = FindAt(id);
      if (foundId != -1)
      {
        _instances[foundId].Rest += 10;
      }
    }

    public static void Play(int id)
    {
      int foundId = FindAt(id);
      if (foundId != -1)
      {
        _instances[foundId].Attention += 10;
      }
    }

    // public void Nap ()
    // {
    //   Rest += 10;
    // } 

    // public void Play ()
    // {
    //   Attention += 10;
    // } 

    public static List<Character> GetAll()
    {
      return _instances;
    }

    public static Character Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void Delete(int id)
    {
      int foundId = FindAt(id);
      if (foundId != -1)
      {
        _instances.RemoveAt(foundId);
      }
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