using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace Root
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI timerText;
        [SerializeField] public TextMeshProUGUI timerText2;
        [SerializeField, Tooltip("Tiempo en segundos")] private float timerTime;
        public int minutes, seconds, cents;
        public static Timer instance;
        void Awake()
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
        }
        private void Update()
        {
            timerTime -= Time.deltaTime;
            if (timerTime < 0) timerTime = 0;
            minutes = (int)(timerTime / 60f);
            seconds = (int)(timerTime - minutes * 60f);
            cents = (int)((timerTime - (int)timerTime) * 100f);

            
            timerText.text = string.Format("{0:00}:{1:00}",seconds, cents);
            if(timerTime == 0)
            {
                SceneManager.LoadSceneAsync(1,LoadSceneMode.Single);
            }
        }


    }
}
