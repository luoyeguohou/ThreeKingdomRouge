using System.Collections;
using System.Collections.Generic;
using TinyECS;
using UnityEngine;

public class GameInitSys : ISystem
{
    public override void OnAddToEngine()
    {
        base.OnAddToEngine();
        Msg.Bind((int)MsgID.GameInit, Init);
    }

    public override void OnRemoveFromEngine()
    {
        base.OnRemoveFromEngine();
        Msg.UnBind((int)MsgID.GameInit, Init);
    }

    private void Init(object[] p = null) 
    {
        // deck
        InitDeck();
        // map
        InitMap();
        // player
        InitPlayer();
    }

    private void InitDeck() 
    {
        DeckComp dComp = World.e.sharedConfig.GetComp<DeckComp>();
        foreach (DeckCfg cfg in Cfg.deck.Values)
        {
            dComp.deck.Add(new Card(cfg.id));
        }
        Util.Shuffle(dComp.deck,new System.Random());
        
    }
    private void InitMap() { }
    private void InitPlayer() 
    {
        PlayerComp pComp = World.e.sharedConfig.GetComp<PlayerComp>();
        pComp.hp = 4;
        pComp.hand = new();
    }
}
