using Services;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LoadSceneButton : MonoBehaviour
{
	[SerializeField] private LoadSceneService _loadSceneService;
	[SerializeField] private SceneType _targetScene;
	
	private Button _button;

	private void Awake()
	{
		_button = GetComponent<Button>();
	}

	private void OnEnable()
	{
		_button.onClick.AddListener(OnLoadScene);
	}

	private void OnLoadScene()
	{
		_loadSceneService.LoadScene(_targetScene);
	}

	private void OnDisable()
	{
		_button.onClick.RemoveListener(OnLoadScene);
	}
}
