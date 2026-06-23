/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Main
{
    public partial class UI_MainCont : GComponent
    {
        public UI_MainHand m_hand;
        public GButton m_btnAddCard;
        public UI_Player m_player;
        public GList m_lstSkill;
        public UI_Player m_enemy1;
        public GButton m_btnDraw;
        public GButton m_btnDiscard;
        public const string URL = "ui://6rc7w3nopcqv2";

        public static UI_MainCont CreateInstance()
        {
            return (UI_MainCont)UIPackage.CreateObject("Main", "MainCont");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_hand = (UI_MainHand)GetChildAt(0);
            m_btnAddCard = (GButton)GetChildAt(1);
            m_player = (UI_Player)GetChildAt(2);
            m_lstSkill = (GList)GetChildAt(3);
            m_enemy1 = (UI_Player)GetChildAt(4);
            m_btnDraw = (GButton)GetChildAt(5);
            m_btnDiscard = (GButton)GetChildAt(6);
        }
    }
}