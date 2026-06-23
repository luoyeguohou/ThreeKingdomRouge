/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Main
{
    public partial class UI_Player : GComponent
    {
        public UI_HP m_hp;
        public GComponent m_armor;
        public GComponent m_weapon;
        public const string URL = "ui://6rc7w3nopcqv8";

        public static UI_Player CreateInstance()
        {
            return (UI_Player)UIPackage.CreateObject("Main", "Player");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_hp = (UI_HP)GetChildAt(0);
            m_armor = (GComponent)GetChildAt(1);
            m_weapon = (GComponent)GetChildAt(2);
        }
    }
}