using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    Vector2 mouseWorldPosition;
    Vector2 direction;

    Transform bodytrans;
    public SpriteRenderer bodyRenderer;
    public SpriteRenderer armRenderer;
    public GameObject holder;
    public Vector3 directionCross;

    // Start is called before the first frame update
    void Awake()
    {
        bodytrans = transform.parent.gameObject.GetComponent<Transform>();
        bodyRenderer = transform.parent.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // get direction you want to point at
        direction = (mouseWorldPosition - (Vector2)transform.position).normalized;

        // set vector of transform directly
        transform.right = -direction;


        directionCross = Vector3.Cross((Vector3)direction, bodytrans.up);
        if (directionCross.z >= 0)
        {
            Vector3 Scaler1 = armRenderer.transform.localScale;
            Scaler1.x = -1;
            armRenderer.transform.localScale = Scaler1;

            Vector3 Scaler2 = armRenderer.transform.localScale;
            Scaler2.y = -1;
            armRenderer.transform.localScale = Scaler2;


            Vector3 Scaler = holder.transform.localScale;
            Scaler.x = -1;
            holder.transform.localScale = Scaler;

        }
        else
        {
            Vector3 Scaler1 = armRenderer.transform.localScale;
            Scaler1.x = 1;
            armRenderer.transform.localScale = Scaler1;

            Vector3 Scaler2 = armRenderer.transform.localScale;
            Scaler2.y = 1;
            armRenderer.transform.localScale = Scaler2;

            Vector3 Scaler = holder.transform.localScale;
            Scaler.x = 1;
            holder.transform.localScale = Scaler;

        }


    }
}
