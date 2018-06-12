using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_044 : SimTemplate //Bladed Gauntlet
	{
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_044);

// Has Attack equal to your Armor. Can't attack heroes.

            public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
            {
              p.equipWeapon(card,ownplay);
            }

	}
}