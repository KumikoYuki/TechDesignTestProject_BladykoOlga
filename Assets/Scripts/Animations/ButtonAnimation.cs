using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Animations
{
    [RequireComponent(typeof(Button))]
    public class ButtonAnimation : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private Vector3 _targetScale;
        [SerializeField] private float _duration;

        private Vector3 _initialScale;

        private void Awake()
        {
            _initialScale = transform.localScale;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            PlayScaleAnimation(_targetScale);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            PlayScaleAnimation(_initialScale);
        }

        private void PlayScaleAnimation(Vector3 targetScale)
        {
            transform.DOScale(targetScale, _duration);
        }
    }
}