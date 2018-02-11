using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Canvas mainMenu;
	public Button startText;
	public Button exitText;
	public Button aboutText;
	public Text about;
	public Text aboutTwo;
	public Button back;
	public Button next;

	void Start()
	{
		startText.gameObject.SetActive(true);
		exitText.gameObject.SetActive(true);
		aboutText.gameObject.SetActive(true);
		about.enabled = false;
		aboutTwo.enabled = false;
		back.gameObject.SetActive(false);
		next.gameObject.SetActive(false);
	}

	public void ExitPress()
	{
		Application.Quit();
	}

	public void StartLevel()
	{
		SceneManager.LoadScene(1);
	}

	public void About()
	{
		startText.gameObject.SetActive(false);
		exitText.gameObject.SetActive(false);
		aboutText.gameObject.SetActive(false);
		about.enabled = true;
		aboutTwo.enabled = false;
		back.gameObject.SetActive(true);
		next.gameObject.SetActive(true);
	}

	public void ToMainMenu()
	{
		Start();
	}

	public void GoNextPage()
	{
		startText.gameObject.SetActive(false);
		exitText.gameObject.SetActive(false);
		aboutText.gameObject.SetActive(false);
		about.enabled = false;
		aboutTwo.enabled = true;
		back.gameObject.SetActive(true);
		next.gameObject.SetActive(false);
	}
}
