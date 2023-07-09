using UnityEngine;
using UnityEngine.SceneManagement;

namespace Root
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public GameObject Menu;
        private void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
                return;
            }
        }
        private void Start()
        {
            if(Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
        }
        public void PlayAgain(string NombreEscena)
        {
            SceneManager.LoadScene(NombreEscena,LoadSceneMode.Single);
        }
        public void ExitGame()
        {
            Application.Quit();
        }
        public void MainMenu()
        {

            if (Time.timeScale == 0)
            {
                Menu.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                Menu.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
