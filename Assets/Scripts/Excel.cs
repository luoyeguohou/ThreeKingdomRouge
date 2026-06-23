using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class StringToEnum
{
    public static Dictionary<string, CardType> cardTypes = new()
    {
        { "base",CardType.Base},
        { "skill",CardType.Skill},
        { "item",CardType.Item},
    };

    public static Dictionary<string, UseCondition> useConditions = new()
    {
        { "can_use_attack",UseCondition.CanUseAttack},
        { "",UseCondition.None},
        { "not_full_hp",UseCondition.NotFullHP},
        { "target_has_hand",UseCondition.TargetHasHand},
        { "target_has_item",UseCondition.TargetHasItem},
    };

    public static Dictionary<string, CardTarget> cardTarget = new()
    {
        { "none",CardTarget.None},
        { "",CardTarget.None},
        { "self",CardTarget.Self},
        { "all",CardTarget.All},
        { "all_enemy",CardTarget.AllEnemy},
        { "enemy",CardTarget.Enemy},
    };

    public static Dictionary<int, CardSuit> cardSuit = new()
    {
        { 3,CardSuit.Club},
        { 2,CardSuit.Diamond},
        { 4,CardSuit.Spade},
        { 1,CardSuit.Heart},
    };

    public static Dictionary<string, Timing> timings = new()
    {
        { "ON_GAIN",               Timing.ON_GAIN },
        { "AFT_DEAL_DMG_BY_RED_ATK", Timing.AFT_DEAL_DMG_BY_RED_ATK },
        { "AFT_ATKED",             Timing.AFT_ATKED },
        { "AFT_ATKED_BY_BLACK",    Timing.AFT_ATKED_BY_BLACK },
        { "AFT_DEAL_DMG_BY_ATK",   Timing.AFT_DEAL_DMG_BY_ATK },
        { "AFT_GAIN_DMG_BY_SKILL", Timing.AFT_GAIN_DMG_BY_SKILL },
        { "AFT_ATK_GET_DOUGED",    Timing.AFT_ATK_GET_DOUGED },
    };
}

public class RawDeckCfg 
{
    public string id;
    public string type;
    public int usable;
    public string condition;
    public string target;
    public int number;
    public int suit;
    public string card_id;
}


public class DeckCfg
{
    public string id;
    public CardType cardType;
    public bool useable;
    public UseCondition condition;
    public CardTarget target;
    public int number;
    public CardSuit suit;
    public string cardID;
}

public enum CardType 
{ 
    Base,
    Skill,
    Item
}

public enum UseCondition 
{
    None,
    CanUseAttack,
    NotFullHP,
    TargetHasHand,
    TargetHasItem,
}

public enum CardTarget 
{ 
    Enemy,
    None,
    Self,
    AllEnemy,
    All,
}

public enum CardSuit 
{
    Heart,
    Diamond,
    Club,
    Spade,
}

public class CardCfg 
{
    public string id;
    public string effect;
}

public class RawEffectCfg
{
    public string id;
    public string action;
    public string linked_1;
    public string linked_2;
    public string linked_3;
    public string linked_4;
}

public class EffectCfg
{
    public string id;
    public string action;
    public List<string> linked;
}

public class I18NCfg 
{
    public string id;
    public string data;
}

public class WeaponRawCfg 
{
    public string id;
    public string skill;
}

public class WeaponCfg 
{
    public string id;
    public SkillCfg skill;
}

public class SkillRawCfg
{
    public string id;
    public string skill_usage_1;
    public string skill_usage_2;
    public string skill_usage_3;
    public string skill_usage_4;
}

public class SkillCfg 
{
    public string id;
    public List<SkillUsageCfg> skillUsageCfg;
}

public class SkillRawUsageCfg
{
    public string id;
    public string timing;
    public int cardChoose;
    public string unitChoose;
    public string effect;
}

public class SkillUsageCfg 
{
    public string id;
    public Timing timing;
    public int cardChoose;
    public CardTarget unitChoose;
    public CardCfg effect;
}

public enum Timing 
{
    ON_GAIN,
    AFT_DEAL_DMG_BY_RED_ATK,
    AFT_ATKED,
    AFT_ATKED_BY_BLACK,
    AFT_DEAL_DMG_BY_ATK,
    AFT_GAIN_DMG_BY_SKILL,
    AFT_ATK_GET_DOUGED,
}