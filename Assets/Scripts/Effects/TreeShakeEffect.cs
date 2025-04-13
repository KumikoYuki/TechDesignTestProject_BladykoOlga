using DG.Tweening;
using UnityEngine;

namespace Effects
{
    public sealed class TreeShakeEffect : MonoBehaviour, IShakeEffect
    {
        [SerializeField] private float _duration = 0.25f;
        [SerializeField] private float _strength = 1f;
        [SerializeField] private ParticleSystem _particleSystem;

        private Vector3 _initialPosition;
        private Tweener _tween;

        private void Awake()
        {
            _initialPosition = transform.localPosition;
        }

        public void Play()
        {
            if (_tween != null && _tween.active)
            {
                _tween.Kill();
            }
            
            _tween = transform.DOShakePosition(_duration, _strength).OnComplete(() => transform.localPosition = _initialPosition);
            _particleSystem.Play();
        }
    }
}