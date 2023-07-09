using TMPro;
using UnityEngine;

namespace Root
{
    public class Victoria : MonoBehaviour
    {
        public GameObject CartelVictoria;
        public static Victoria instance;
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
        public void VictoriaGame()
        {
            Cursor.visible = true;
            CartelVictoria.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
