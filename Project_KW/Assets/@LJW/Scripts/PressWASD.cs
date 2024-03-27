using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressWASD : PressTip
{
    protected override IEnumerator CoShowTip()
    {
        Main.Game.Player.GetComponent<CharacterController>().enabled = false;
        yield return new WaitForSeconds(21f);
        gameScene.ShowMoveTip();
        Main.Game.Player.GetComponent<CharacterController>().enabled = true;
        yield return new WaitForSeconds(5.0f);
        gameScene.HideMoveTip();
    }
}
