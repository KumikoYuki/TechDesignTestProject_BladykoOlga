using UnityEngine;
using UnityEngine.SceneManagement;

namespace Services
{
    public class LoadSceneService : MonoBehaviour
    {
        public void LoadScene(SceneType scene)
        {
            SceneManager.LoadScene((int)scene);
        }
    }
}