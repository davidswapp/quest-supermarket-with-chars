using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene3 : MonoBehaviour
{

	// Update is called once per frame
	void Update()
	{

		bool buttonA = OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.Touch);

		if (Input.GetMouseButtonDown(0) || buttonA)

		{
			Level3();
		}
	}

	public void Level3()
	{
        Debug.Log("Loading scene 3");
        SceneManager.LoadScene("3");
	}
}
