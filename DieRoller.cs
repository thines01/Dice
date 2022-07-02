using System.Collections.Generic;
using System.Linq;

namespace Dice
{
   public static class CDieRoller
   {
      public static uint Roll(CDieObj die)
      {
         return die.Roll();
      }

      /*
      public static List<uint> Roll(List<CDieObj> dice)
      {
         List<uint> lst_uiRolls = new List<uint>(dice.Count);
         dice.ForEach(die => lst_uiRolls.Add(die.Roll()));
         return lst_uiRolls;
      }
      */
      public static List<uint> Roll(List<CDieObj> dice)
      {
         return dice.Select(die => die.Roll()).ToList();
      }

      public static string Roll(CPairOfDice dice)
      {
         return dice.Roll();
      }
   }
}
