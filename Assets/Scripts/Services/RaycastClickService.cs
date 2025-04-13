using System;
using Game;
using UnityEngine;

namespace Effects
{
    public class RaycastClickService : MonoBehaviour
    {
        private Camera _camera;

        private void Awake()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var position = _camera.ScreenToWorldPoint(Input.mousePosition);
                var ray = _camera.ScreenPointToRay(Input.mousePosition);
                var result = Physics2D.Raycast(position, ray.direction);
                
                if (result.collider != null)
                {
                    if (result.collider.gameObject.TryGetComponent(out IShakeEffect effect))
                    {
                        effect.Play();
                    }
                    else if (result.collider.gameObject.TryGetComponent(out IEggAnimation egg))
                    {
                        egg.Play();
                    }
                }
            }
        }
    }
}