using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Root
{
    public class CursorCam : MonoBehaviour
    {
        Vector3 mousePositionOffset;
        [SerializeField] Texture2D Cursor2;
        public Vector2 hotSpot = Vector2.zero;

        private Vector3 GetMouseWorldPosition()
        {
            return Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        private void OnMouseDown()
        {
            mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
            Cursor.visible = false;
        }
        private void OnMouseDrag()
        {
            transform.position = GetMouseWorldPosition() + mousePositionOffset;
        }
        private void OnMouseUp()
        {
            Cursor.visible = true;
        }
    }
}
