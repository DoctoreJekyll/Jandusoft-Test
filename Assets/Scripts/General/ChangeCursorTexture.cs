using System;
using UnityEngine;

namespace General
{
    public class ChangeCursorTexture : MonoBehaviour
    {

        [SerializeField] private Texture2D cursorTexture;

        private Vector2 cursorSpot;

        private void Start()
        {
            cursorSpot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
            Cursor.SetCursor(cursorTexture, cursorSpot, CursorMode.Auto);
        }

        private void OnDisable()
        {
            Cursor.SetCursor(null, Vector2.zero,CursorMode.Auto);
        }
    }
}
