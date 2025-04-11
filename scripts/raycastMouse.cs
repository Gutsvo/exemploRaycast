using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEngine.Analytics.IAnalytic;


public class raycastMouse : MonoBehaviour
{
    Ray ray;
    RaycastHit hitData;
    Vector3 point;
    UnityEngine.Color color;
    public Camera _camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Inicio!");
        StartCoroutine(GerarTarget());

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            color = UnityEngine.Color.green;
            Lancar(ray, color, 1);

        }
        if (UnityEngine.Input.GetKey(KeyCode.Space))
        {
            ray = new Ray(transform.position, transform.forward);
            color = UnityEngine.Color.yellow; 
            Lancar(ray, color, 2);
        }
        if (UnityEngine.Input.GetKey(KeyCode.Return))
        {
            point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            ray = _camera.ScreenPointToRay(point);
            color = UnityEngine.Color.blue;
            Lancar(ray, color, 3);
        }

    }
    private void Lancar(Ray ray, UnityEngine.Color color, int tipo)
    {
        Debug.Log("Origem: " + ray.origin);
        Debug.Log("Direção: " + ray.direction);

        if (Physics.Raycast(ray, out hitData))
        {
            Vector3 hitPosition = hitData.point;
            Debug.Log(" hitPosition:" + hitPosition);


            float hitDistance = hitData.distance;
            Debug.Log("Distancia: " + hitDistance);
            string tag = hitData.collider.tag;
            Debug.Log("Tag:" + tag);
            GameObject hitObject = hitData.transform.gameObject;
            Debug.DrawRay(ray.origin, hitPosition * hitDistance, color);
            StartCoroutine(SphereIndicator(hitPosition, tipo));

            if (tag == "Alvo")
                Destroy(hitObject);
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction * 1000, UnityEngine.Color.magenta);
            Debug.Log("Errou mano");
        }
    }
    private IEnumerator SphereIndicator(Vector3 pos, int tipo)
    {
        GameObject gameObj = null;
        switch (tipo)
        {
            case 1:
                gameObj = CriaObject(pos, "cherry");
                break;
            case 2:
                gameObj = CriaObject(pos, "yellow");
                break;
            case 3:
                gameObj = CriaObject(pos, "blue");
                break;

        }


        yield return new WaitForSeconds(1);
        Destroy(gameObj);
    }
    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = UnityEngine.Color.red;

        Gizmos.DrawRay(ray);
    }

    GameObject CriaObject(Vector3 pos, string material)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;
        sphere.transform.localScale = new Vector3(3, 3, 3);
        string src = string.Concat("material/", material);
        Material bombMaterial = Resources.Load(src, typeof(Material)) as Material;

        sphere.GetComponent<Renderer>().material = bombMaterial;
        return sphere;
    }

    /*GameObject InstanciaPrefab(Vector3 pos)
    {

        GameObject prefab = Resources.Load("prefab/bomba", typeof(GameObject)) as GameObject;

        return Instantiate(prefab, pos, Quaternion.identity);
    }*/

    private IEnumerator GerarTarget()
    {
        while (true)
        {
            float x = Random.Range(-5.0f, 5.0f);
            float y = Random.Range(1.0f, 5.0f);
            float z = Random.Range(-5.0f, 5.0f);
            Vector3 position = new Vector3(x, y, z);
            Instantiate(Resources.Load("prefab/target", typeof(GameObject)) as GameObject, position, Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
}

