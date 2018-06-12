using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_559 : SimTemplate //archmageantonidas
	{

//    erhaltet jedes mal einen Feuerball auf die Hand, wenn ihr einen zauber wirkt.

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard == triggerEffectMinion.own && hc.card.type == CardDB.cardtype.SPELL)
            {
                p.drawACard(CardDB.cardName.fireball, wasOwnCard, true);
                p.evaluatePenality -= 40;
            }
        }

	}
}