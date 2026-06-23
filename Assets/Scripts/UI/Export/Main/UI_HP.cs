/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Main
{
    public partial class UI_HP : GComponent
    {
        public Controller m_hp;
        public GTextField m_txtNum;
        public const string URL = "ui://6rc7w3nopcqv6";

        public static UI_HP CreateInstance()
        {
            return (UI_HP)UIPackage.CreateObject("Main", "HP");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_hp = GetControllerAt(0);
            m_txtNum = (GTextField)GetChildAt(7);
        }
    }
}