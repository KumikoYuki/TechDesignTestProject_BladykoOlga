using UnityEngine;
using Object = UnityEngine.Object;

namespace Effects
{
    public class ClickEffectSystem : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _clickEffectPrefab;
        [SerializeField] private Camera _camera;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var createdEffect = Object.Instantiate(_clickEffectPrefab);
                var worldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
                
                worldPosition.z = 0;
                
                createdEffect.transform.position = worldPosition;
                createdEffect.Play();
            }
        }
    }
}