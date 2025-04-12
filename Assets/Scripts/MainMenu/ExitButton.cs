using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace MainMenu
{
    [RequireComponent(typeof(Button))]
    public class ExitButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnExit);
        }

        private void OnExit()
        {
            #if UNITY_EDITOR
            
                EditorApplication.ExitPlaymode();
                return;
            #endif
            
            Application.Quit();
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnExit);
        }
    }
}