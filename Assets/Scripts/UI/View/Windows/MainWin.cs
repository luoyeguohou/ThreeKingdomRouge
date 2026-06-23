using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main {
    public partial class UI_MainWin : FairyWindow
    {
        public override void ConstructFromResource()
        {
            base.ConstructFromResource();
            m_cont.m_btnAddCard.onClick.Add(OnClickAddCard);
            m_cont.m_btnDraw.onClick.Add(OnClickViewDeck);
        }

        public void Init() {
            m_cont.m_hand.Init();
        }

        private void OnClickAddCard() { 
            PlayerComp pComp = World.e.sharedConfig.GetComp<PlayerComp>();
            pComp.hand.Add(new Card("1"));
            Msg.Dispatch((int)MsgID.AfterCardChanged);
        }

        private void OnClickViewDeck() 
        {
            DeckComp pComp = World.e.sharedConfig.GetComp<DeckComp>();
            FGUIUtil.CreateWindow<UI_CardListWin>("CardListWin").Init(pComp.deck);
        }
    }
}
