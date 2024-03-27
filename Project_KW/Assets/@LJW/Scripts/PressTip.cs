using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressTip : MonoBehaviour
{
    protected UI_GameScene gameScene;
    protected BoxCollider _boxcollider;
    protected void Start()
    {
        gameScene = Main.Scenes.CurrentScene.CurSceneUI as UI_GameScene;
        _boxcollider = GetComponent<BoxCollider>();
    }
    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _boxcollider.enabled = false;
            StartCoroutine(CoShowTip());
        }
    }
    protected virtual IEnumerator CoShowTip()
    {
        Main.Game.Player.GetComponent<CharacterController>().enabled = false;
        yield return new WaitForSeconds(1f);
    }
}
