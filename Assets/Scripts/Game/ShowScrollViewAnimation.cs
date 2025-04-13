using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class ShowScrollViewAnimation : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private Animator _animator;
        
        private readonly int _showHash = Animator.StringToHash("Show");
        private readonly int _hideHash = Animator.StringToHash("Hide");
        
        private bool _isShowed = false;

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            if (_isShowed)
            {
                _animator.Play(_hideHash);
            }
            else
            {
                _animator.Play(_showHash);
            }
            
            _isShowed = !_isShowed;
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClicked);
        }
    }
}