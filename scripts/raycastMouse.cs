using UnityEngine;

public class raycastMouse : MonoBehaviour
{
    Ray ray;
    RaycastHit hitdata;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);



            if (Physics.Raycast(ray, out hitdata))
            {
                if (hitdata.collider.tag == "Obj")
                {
                    Debug.Log("acertou!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                }
            }
        }

    }
}
