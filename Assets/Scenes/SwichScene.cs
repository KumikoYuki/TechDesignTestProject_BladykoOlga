using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class SwichScene : MonoBehaviour
{
     
	public void scenLoad(int numdScen)
	{
	  SceneManager.LoadScene(numdScen);
	}
}
