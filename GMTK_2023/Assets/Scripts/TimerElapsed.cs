using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace Root
{
    public class TimerElapsed : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI timerText;
        [SerializeField, Tooltip("Tiempo en segundos")] private float timerElapsed;
        public int minutes, seconds, cents;
        public static  TimerElapsed instance;
        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
                return;
            }
        }

        private void Update()
        {
            timerElapsed += Time.deltaTime;
            minutes = (int)(timerElapsed / 60f);
            seconds = (int)(timerElapsed - minutes * 60f);
            cents = (int)((timerElapsed - (int)timerElapsed) * 100f);


            timerText.text = string.Format("{0:00}:{1:00}", seconds, cents);
        }

    }
}
