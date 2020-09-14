using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene2 : MonoBehaviour
{

	// Update is called once per frame
	void Update()
	{

		bool buttonA = OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.Touch);

		if (Input.GetMouseButtonDown(0) || buttonA)

		{
			Level2();
		}
	}

	public void Level2()
	{
        Debug.Log("Loading scene 2");
		SceneManager.LoadScene("2") ;
	}
}
