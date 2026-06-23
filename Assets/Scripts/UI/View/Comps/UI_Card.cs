using FairyGUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main
{
    public partial class UI_Card : GButton
    {
        private DeckCfg cfg;
        public void Init(DeckCfg cfg)
        {
            this.cfg = cfg;
            m_type.selectedIndex = (int)cfg.cardType;
            title = Cfg.i18n[cfg.cardID].data;
            m_txtCont.text = CardUtil.GetCardDesc(cfg);
        }
    }
}
