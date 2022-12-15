using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class CharacterController : Controller
  {
    [HttpGet("/character")]
    public ActionResult Index()
    {
      List<Character> allCharacters = Character.GetAll();
      return View(allCharacters);
    }

    [HttpGet("/character/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/character")]
    public ActionResult Create(string name)
    {
      Character myCharacter = new Character(name);
      return RedirectToAction("Index");
    }

    // [HttpPost("/characters/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Item.ClearAll();
    //   return View();
    // }

    [HttpGet("/character/{id}")]
    public ActionResult Show(int id)
    {
      Character foundCharacter = Character.Find(id);
      return View(foundCharacter);
    }

    [HttpPost("/character/feed")]
    public ActionResult Feed(int feed)
    {
      Character.Feed(feed);
      Character foundCharacter = Character.Find(feed);
      return View(foundCharacter);
    }

       [HttpPost("/character/play")]
    public ActionResult Play(int play)
    {
      Character.Play(play);
      Character foundCharacter = Character.Find(play);
      return View(foundCharacter);
    }

    [HttpPost("/character/nap")]
    public ActionResult Nap(int nap)
    {
      Character.Nap(nap);
      Character foundCharacter = Character.Find(nap);
      return View(foundCharacter);
    }

    // [HttpPost("/character/{id}")]
    // public ActionResult Play(int id)
    // {
    //   Character.Play(id);
    //   Character foundCharacter = Character.Find(id);
    //   string strID = id.ToString();
    //   return RedirectToAction(strID);
    // }

    // [HttpPost("/character/{id}")]
    // public ActionResult Nap(int id)
    // {
    //   Character.Nap(id);
    //   Character foundCharacter = Character.Find(id);
    //   string strID = id.ToString();
    //   return RedirectToAction(strID);
    // }

    // [HttpGet("/character/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Item foundItem = Item.Find(id);
    //   return View(foundItem);
    // }

    // [HttpPost("/character/update")]
    // public ActionResult Feed(int id)
    // {
    //   Character.Delete(id);
    //   return RedirectToAction("Index");
    // }
  }
}