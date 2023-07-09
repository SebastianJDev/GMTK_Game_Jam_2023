using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Root
{
    public class MoverPlataforna : MonoBehaviour
    {
        public GameObject Obj;
        public Transform startPoint;
        public Transform EndPoint;

        public float velocidad;

        private Vector3 MoverHacia;

        private void Start()
        {
            MoverHacia = EndPoint.position;
        }
        private void Update()
        {
            Obj.transform.position = Vector3.MoveTowards(Obj.transform.position, MoverHacia, velocidad * Time.deltaTime);
            if (Obj.transform.position == EndPoint.position)
            {
                MoverHacia = startPoint.position;
            }
            if (Obj.transform.position == startPoint.position)
            {
                MoverHacia = EndPoint.position;
            }
        }

    }
}
