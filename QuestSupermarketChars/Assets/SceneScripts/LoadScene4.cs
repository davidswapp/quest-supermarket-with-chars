using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene4 : MonoBehaviour
{

	// Update is called once per frame
	void Update()
	{

		bool buttonA = OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.Touch);

		if (Input.GetMouseButtonDown(0) || buttonA)

		{
			Level4();
		}
	}

	public void Level4()
	{
        Debug.Log("Loading scene 4");
        SceneManager.LoadScene("4");
	}
}
