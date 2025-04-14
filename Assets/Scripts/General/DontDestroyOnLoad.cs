using UnityEngine;

namespace MainMenu
{
    public class DontDestroyOnLoad : MonoBehaviour
    {
	private void Awake()
	{
	    var count = Object.FindObjectsOfType<DontDestroyOnLoad>().Length;

	    if(count > 1)
            {
		Destroy(gameObject);

	    }
	}

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}