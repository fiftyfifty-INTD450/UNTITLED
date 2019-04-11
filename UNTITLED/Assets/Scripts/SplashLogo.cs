using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashLogo : MonoBehaviour
{

    void Start()
    {
		StartCoroutine(WaitAndChange());
    }

    IEnumerator WaitAndChange()
	{
		yield return new WaitForSeconds(2.5f);

		SceneManager.LoadScene("TitleScreen");
	}
}
