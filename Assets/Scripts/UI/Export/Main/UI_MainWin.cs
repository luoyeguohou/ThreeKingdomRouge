/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Main
{
    public partial class UI_MainWin : FairyWindow
    {
        public GGraph m_bg;
        public const string URL = "ui://6rc7w3noti390";

        public static UI_MainWin CreateInstance()
        {
            return (UI_MainWin)UIPackage.CreateObject("Main", "MainWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GGraph)GetChildAt(0);
        }
    }
}