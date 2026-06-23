/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Main
{
    public partial class UI_CardListCont : GComponent
    {
        public GList m_lstCard;
        public GButton m_btnClose;
        public const string URL = "ui://6rc7w3noymjrb";

        public static UI_CardListCont CreateInstance()
        {
            return (UI_CardListCont)UIPackage.CreateObject("Main", "CardListCont");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_lstCard = (GList)GetChildAt(1);
            m_btnClose = (GButton)GetChildAt(2);
        }
    }
}