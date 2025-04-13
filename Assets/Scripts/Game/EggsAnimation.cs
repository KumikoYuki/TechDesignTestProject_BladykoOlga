using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class EggsAnimation : MonoBehaviour, IEggAnimation
    {
        [SerializeField] private Image _uiEggImage;
        [SerializeField] private Vector3 _targetScale;
        [SerializeField] private float _duration;


        public void Play()
        {
            _uiEggImage.gameObject.SetActive(true);
            
            transform.DOScale(_targetScale, _duration).OnComplete(() => transform.DOScale(Vector3.zero, 0.15f).OnComplete(() => Object.Destroy(gameObject)));
        }
    }
}