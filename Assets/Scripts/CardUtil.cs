using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardUtil
{
    public static string GetCardDesc(DeckCfg deck)
    {
        switch (deck.cardType)
        {
            case CardType.Base:
                return "";
            case CardType.Skill:
                return GetCardDesc(Cfg.cards[deck.cardID]);
            case CardType.Item:
                return GetWeaponDesc(Cfg.weapon[deck.cardID]);
            default:
                return "";
        }
    }

    public static string GetCardDesc(CardCfg card)
    {
        EffectCfg effect = Cfg.effect[card.effect];
        return GetEffectDesc(effect) + "。";
    }

    private static string GetEffectDesc(EffectCfg effect)
    {
        string text = Cfg.i18n[effect.action].data;
        for (int i = 0; i < effect.linked.Count; i++)
        {
            text = text.Replace("&" + (i + 1), ResolveLinked(effect.linked[i]));
        }
        return text;
    }

    private static string ResolveLinked(string linked)
    {
        // 纯数字，原样返回
        if (int.TryParse(linked, out _))
            return linked;

        // id开头，递归解析对应effect
        if (linked.StartsWith("id"))
            return GetEffectDesc(Cfg.effect[linked]);

        // 普通字符串，查i18n
        return Cfg.i18n[linked].data;
    }

    public static string GetWeaponDesc(WeaponCfg weapon)
    {
        return GetSkillDesc(weapon.skill);
    }

    public static string GetSkillDesc(SkillCfg skill)
    {
        return string.Join("", skill.skillUsageCfg.ConvertAll(su => GetSkillUasgeDesc(su) + "。"));
    }

    public static string GetSkillUasgeDesc(SkillUsageCfg usage)
    {
        string timingText = Cfg.i18n[usage.timing.ToString()].data;
        string cardChooseText = Cfg.i18n["SKILL_USAGE_CARD_CHOOSE"].data;
        string targetText = usage.unitChoose == CardTarget.None?"": Cfg.i18n["su_" + usage.unitChoose.ToString()].data;
        cardChooseText = usage.cardChoose == 0 ? "" : cardChooseText.Replace("&1", usage.cardChoose.ToString());

        EffectCfg eCfg = Cfg.effect[Cfg.cards[usage.effect.id].effect];
        return timingText + cardChooseText + targetText + GetEffectDesc(eCfg);
    }
}
