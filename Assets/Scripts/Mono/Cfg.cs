using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cfg
{
    public static Dictionary<string, CardCfg> cards = new();
    public static Dictionary<string, EffectCfg> effect = new();
    public static Dictionary<string, DeckCfg> deck = new();
    public static Dictionary<string, I18NCfg> i18n = new();
    public static Dictionary<string, SkillUsageCfg> skillUsage = new();
    public static Dictionary<string, SkillCfg> skill = new();
    public static Dictionary<string, WeaponCfg> weapon = new();


    public static void Init()
    {
        TextAsset ta = Resources.Load<TextAsset>("ExcelCfg/design");
        JsonData jd = JsonMapper.ToObject(ta.text);

        JsonData cardData = jd["DataCards"];
        foreach (JsonData d in cardData)
        {
            CardCfg cCfg = JsonUtility.FromJson(d.ToJson().ToString(), typeof(CardCfg)) as CardCfg;
            cards[cCfg.id] = cCfg;
        }

        JsonData effectData = jd["DataEffects"];
        foreach (JsonData d in effectData)
        {
            RawEffectCfg rCfg = JsonUtility.FromJson(d.ToJson().ToString(), typeof(RawEffectCfg)) as RawEffectCfg;
            EffectCfg eCfg = new()
            {
                id = rCfg.id,
                action = rCfg.action,
                linked = new List<string> { rCfg.linked_1, rCfg.linked_2, rCfg.linked_3, rCfg.linked_4 }
                    .FindAll(s => !string.IsNullOrEmpty(s)),
            };
            effect[eCfg.id] = eCfg;
        }

        JsonData deckData = jd["Deck"];
        foreach (JsonData d in deckData)
        {
            RawDeckCfg rCfg = JsonUtility.FromJson(d.ToJson().ToString(), typeof(RawDeckCfg)) as RawDeckCfg;
            DeckCfg dCfg = new()
            {
                id = rCfg.id,
                cardType = StringToEnum.cardTypes[rCfg.type],
                useable = rCfg.usable == 1,
                condition = StringToEnum.useConditions[rCfg.condition],
                target = StringToEnum.cardTarget[rCfg.target],
                number = rCfg.number,
                suit = StringToEnum.cardSuit[rCfg.suit],
                cardID = rCfg.card_id,
            };

            deck[dCfg.id] = dCfg;
        }

        JsonData i18nData = jd["I18n"];
        foreach (JsonData d in i18nData)
        {
            I18NCfg i18nCfg = JsonUtility.FromJson(d.ToJson().ToString(), typeof(I18NCfg)) as I18NCfg;
            i18n[i18nCfg.id] = i18nCfg;
        }

        JsonData skillUsageData = jd["SkillUsage"];
        foreach (JsonData d in skillUsageData)
        {
            SkillRawUsageCfg rCfg = JsonUtility.FromJson(d.ToJson().ToString(), typeof(SkillRawUsageCfg)) as SkillRawUsageCfg;
            SkillUsageCfg suCfg = new()
            {
                id = rCfg.id,
                timing = StringToEnum.timings[rCfg.timing],
                cardChoose = rCfg.cardChoose,
                unitChoose = StringToEnum.cardTarget[rCfg.unitChoose],
                effect = cards[rCfg.effect],
            };
            skillUsage[suCfg.id] = suCfg;
        }

        JsonData skillData = jd["Skill"];
        foreach (JsonData d in skillData)
        {
            SkillRawCfg rCfg = JsonUtility.FromJson(d.ToJson().ToString(), typeof(SkillRawCfg)) as SkillRawCfg;
            SkillCfg sCfg = new()
            {
                id = rCfg.id,
                skillUsageCfg = new List<string> { rCfg.skill_usage_1, rCfg.skill_usage_2, rCfg.skill_usage_3, rCfg.skill_usage_4 }
                    .FindAll(s => !string.IsNullOrEmpty(s))
                    .FindAll(s => s != "0")
                    .ConvertAll(s => skillUsage[s]),
            };
            skill[sCfg.id] = sCfg;
        }

        JsonData weaponData = jd["Weapon"];
        foreach (JsonData d in weaponData)
        {
            WeaponRawCfg rCfg = JsonUtility.FromJson(d.ToJson().ToString(), typeof(WeaponRawCfg)) as WeaponRawCfg;
            WeaponCfg wCfg = new()
            {
                id = rCfg.id,
                skill = skill[rCfg.skill],
            };
            weapon[wCfg.id] = wCfg;
        }
    }
}
