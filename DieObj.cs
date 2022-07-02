using System;

namespace Dice
{
   public class CDieObj
   {
      public uint FaceNum { get; set; }
      public uint NumSides { get; set; }
      //
      protected Random random { get; set; }
      //
      public CDieObj()
      {
         random = new Random(DateTime.Now.Millisecond);
         NumSides = 6;
         FaceNum = 1;
      }

      public CDieObj(uint uiNumSides)
      {
         random = new Random(DateTime.Now.Millisecond);
         this.NumSides = uiNumSides;
         FaceNum = 1;
      }

      public CDieObj(uint uiNumSides, Random rand)
      {
         random = rand;
         this.NumSides = uiNumSides;
         FaceNum = 1;
      }

      virtual public uint Roll()
      {
         FaceNum = (uint)random.Next(0, 256) % NumSides + 1;
         return FaceNum;
      }
   }
}
