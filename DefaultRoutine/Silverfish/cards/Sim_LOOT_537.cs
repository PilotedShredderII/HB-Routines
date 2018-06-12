using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
  class Sim_LOOT_537 : SimTemplate //* Leyline Manipulator
  {
        // Battlecry: If you're holding any cards that didn't start in your deck, reduce their Cost by (2).

    public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
    {
      if(m.own)
      {
        int partInHand = 0;
        foreach (Handmanager.Handcard hc in p.owncards)
        {
          if (hc.card.type == CardDB.cardtype.SPELL && hc.manacost < 2)
          {
            partInHand++;
            hc.manacost = Math.Max(0, hc.manacost - 2);
          }
        }
        p.evaluatePenality += 30;
        p.evaluatePenality -= 20 * partInHand;
      }
    }
  }
}