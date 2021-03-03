using Microsoft.VisualStudio.TestTools.UnitTesting;
using TamagotchiGame.Models;

namespace TamagotchiGame.Tests
{
  [TestClass]
  public class TamagotchiTests
  {
    [TestMethod]
    public void TamagotchiConstructor_CreateInstanceOfTamagotchi_Tamagotchi()
    {
      Tamagotchi newTamagotchi = new Tamagotchi("Daniel");
      Assert.AreEqual(typeof(Tamagotchi), newTamagotchi.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Daniel";
      Tamagotchi newTamagotchi = new Tamagotchi(name);
      string result = newTamagotchi.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetHunger_ReturnsHunger_Int()
    {
      int Hunger = 0;
      Tamagotchi newTamagotchi = new Tamagotchi(Hunger);
      int result = newTamagotchi.Hunger;
      Assert.AreEqual(Hunger, result);
    }
  }
}