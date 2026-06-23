/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Main
{
    public partial class UI_CardListWin : FairyWindow
    {
        public UI_CardListCont m_cont;
        public const string URL = "ui://6rc7w3noymjrc";

        public static UI_CardListWin CreateInstance()
        {
            return (UI_CardListWin)UIPackage.CreateObject("Main", "CardListWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_cont = (UI_CardListCont)GetChildAt(0);
        }
    }
}