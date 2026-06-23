/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Main
{
    public partial class UI_Card : GButton
    {
        public Controller m_type;
        public GTextField m_txtCont;
        public const string URL = "ui://6rc7w3nopcqv3";

        public static UI_Card CreateInstance()
        {
            return (UI_Card)UIPackage.CreateObject("Main", "Card");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(1);
            m_txtCont = (GTextField)GetChildAt(2);
        }
    }
}