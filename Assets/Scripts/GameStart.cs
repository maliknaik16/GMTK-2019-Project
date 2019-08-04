
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
	private void Update() {
		if(Input.anyKeyDown) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
