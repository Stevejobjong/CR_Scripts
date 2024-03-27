using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressTF : PressTip
{
    protected override IEnumerator CoShowTip()
    {
        yield return new WaitForSecondsRealtime(5f);
        gameScene.ShowTimeTip();
        yield return new WaitForSecondsRealtime(8f);
        gameScene.HideTimeTIp();
    }
}
