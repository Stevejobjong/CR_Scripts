using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Tester))]
public class TesterGUIButton : Editor
{    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        // 현재 선택된 오브젝트
        Tester tester = (Tester)target;

        // 버튼을 생성하고 클릭되면 호출될 함수를 설정
        //if (GUILayout.Button("버튼 이름"))
        //{
        //    Tester.cs에 함수 작성 후에 여기서 호출하면 됩니다.
        //    tester.함수명();
        //}

        if (GUILayout.Button("플레이어 위치를 SceneView 카메라 위치로"))
        {
            tester.SetPlayerPosToSceneCamera();
        }

        if (GUILayout.Button("Stage 클리어"))
        {
            tester.ClearStage();
        }
        if (GUILayout.Button("NextScene 로드"))
        {
            tester.LoadNextScene();
        }
    }
}
