using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tester : MonoBehaviour
{
    Transform Player;
    public Define.Scene NextScene;
    private void Awake()
    {
        Player = GameObject.FindWithTag("Player").transform;        
    }
    /// <summary>
    /// EDITOR에서만 동작하며 플레이어의 위치를 SceneView의 카메라 위치로 이동시킵니다.
    /// </summary>
    public void SetPlayerPosToSceneCamera()
    {
        CharacterController cc = Player.GetComponent<CharacterController>();
        cc.enabled = false;
#if UNITY_EDITOR
        Player.transform.position = SceneView.lastActiveSceneView.camera.transform.position;
#endif
        cc.enabled = true;
    }
    /// <summary>
    /// 첫번째 튜토리얼을 클리어시킵니다.
    /// </summary>
    public void ClearStage()
    {
        GameObject.Find("Goal").GetComponent<Stage_Goal>().StageClear();
    }
    public void LoadNextScene()
    {
        Main.Game.ClearGame();
        print(NextScene);
        Main.Scenes.LoadScene(NextScene);
    }
}
