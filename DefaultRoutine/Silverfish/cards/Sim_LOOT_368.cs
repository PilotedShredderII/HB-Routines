using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_368 : SimTemplate //* Voidlord
    {
        //Taunt Deathrattle: Summon three 1/3 Demons with Taunt.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_065);
        public override void onDeathrattle(Playfield p, Minion m)
        {
            int pos = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, m.own);
            p.callKid(kid, pos, m.own);
            p.callKid(kid, pos, m.own);
        }
    }
}