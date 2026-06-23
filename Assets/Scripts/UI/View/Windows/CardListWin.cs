using FairyGUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main
{
    public partial class UI_CardListWin : FairyWindow
    {
        private List<Card> cards;
        public override void ConstructFromResource()
        {
            base.ConstructFromResource();
            m_cont.m_lstCard.itemRenderer = CardIR;
            m_cont.m_btnClose.onClick.Add(Dispose);
        }

        public void Init(List<Card> cards)
        {
            this.cards = cards;
            m_cont.m_lstCard.numItems = cards.Count;
        }

        private void CardIR(int index, GObject g)
        {
            DeckCfg cfg = Cfg.deck[cards[index].id];
            UI_Card ui = (UI_Card)g;
            ui.Init(cfg);
        }
    }
}