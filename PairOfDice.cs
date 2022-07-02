using System;

namespace Dice
{
   public class CPairOfDice
   {
      public CDieObj dieLeft { get; set; }
      public CDieObj dieRight { get; set; }

      public CPairOfDice()
      {
         // init the two dice with DIFFERENT random seeds
         dieLeft = new CDieObj(6, new Random(DateTime.Now.Millisecond + 7));
         dieRight = new CDieObj(6);
      }

      public CPairOfDice(uint uiNumSidesLeft, uint uiNumSidesRight)
      {
         // init the two dice with DIFFERENT random seeds
         dieLeft = new CDieObj(uiNumSidesLeft, new Random(DateTime.Now.Millisecond + 7));
         dieRight = new CDieObj(uiNumSidesRight);
      }

      public static string GetMaxMin(uint uiLeft, uint uiRight)
      {
         return string.Format("{0}-{1}",
               Math.Max(uiLeft, uiRight),
               Math.Min(uiLeft, uiRight));
      }

      public static string GetMaxMin(CPairOfDice dice)
      {
         return dice.GetMaxMin();
      }

      private string GetMaxMin()
      {
         return GetMaxMin(dieLeft.FaceNum, dieRight.FaceNum);
      }

      /*
      public static List<string> GetPermutations(CPairOfDice dice)
      {
         return dice.GetPermutations();
      }

      public List<string> GetPermutations()
      {
         List<string> lst_strMaxMin = new List<string>();
         string strMaxMin = "";
         for (uint i = dieLeft.NumSides; i >= 1; i--)
         {
            for (uint j = dieRight.NumSides; j >= 1; j--)
            {
               strMaxMin = CPairOfDice.GetMaxMin(i, j);
               if (!lst_strMaxMin.Contains(strMaxMin))
               {
                  lst_strMaxMin.Add(strMaxMin);
               }
            }
         }

         return lst_strMaxMin;
      }
      */
      public string Roll()
      {
         CDieRoller.Roll(dieLeft);
         CDieRoller.Roll(dieRight);
         return GetMaxMin();
      }
   }
}
