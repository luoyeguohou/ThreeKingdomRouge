using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initer : MonoBehaviour
{
    private void Start()
    {
        Msg.Init();
        Cfg.Init();
        World.Init();
        UIManager.Init();

        Msg.Dispatch((int)MsgID.GameInit);
    }

    private void Update()
    {
        World.e.Update(Time.deltaTime);
    }
}
