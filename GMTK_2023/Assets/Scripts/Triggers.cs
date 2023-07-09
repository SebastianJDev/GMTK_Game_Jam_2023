using UnityEngine;
using UnityEngine.SceneManagement;

namespace Root
{
    public class Triggers : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.tag == "Player")
            {
                SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
                AudioManager.instance.Play("Restart");
            }
        }
    }
}
