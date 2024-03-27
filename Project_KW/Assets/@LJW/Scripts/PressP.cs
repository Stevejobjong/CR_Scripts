using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PressP : PressTip
{
    protected override IEnumerator CoShowTip()
    {
        Main.Game.Player.GetComponent<CharacterController>().enabled = false;
        yield return new WaitForSeconds(7.5f);
        gameScene.HideMoveTip();
        gameScene.ShowKeyboardTip();
    }
}
