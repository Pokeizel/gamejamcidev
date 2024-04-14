using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{

    public Texture2D texture2D_normal;
    public Vector2 vector2;

    public Texture2D texture2D_cambio;
    public Vector2 vector2_cambio;

    public Vector2 onBottonCursorHotSpot = new Vector2(0, 0);


    public void OncursorEn() {

        Cursor.SetCursor(texture2D_cambio, onBottonCursorHotSpot, CursorMode.Auto);
    
    }

    public void OncursorEx()
    {

        Cursor.SetCursor(texture2D_normal, onBottonCursorHotSpot, CursorMode.Auto);

    }
}

