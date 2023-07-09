using UnityEngine;
using UnityEngine.SceneManagement;

namespace Root
{
    public class MangerMENU : MonoBehaviour
    {
        private void Start()
        {
            AudioManager.instance.Play("Music");
        }
        public void PlayGame(string EscenaACambiar)
        {
            SceneManager.LoadSceneAsync(EscenaACambiar,LoadSceneMode.Single);
        }
        public void ExitGame()
        {
            Application.Quit();
        }
    }
}
