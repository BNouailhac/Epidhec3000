using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map : MonoBehaviour
{
    public GameObject maps;
    public GameObject inf;
    public GameObject ici1;
    public GameObject ici2;
    int i = 0;
    int pos = 0;
    public Vector3 newpos;

    void Start()
    {
        inf = GameObject.Find("New Sprite");
        inf.SetActive(false);
        ici1 = GameObject.Find("vous1");
        ici1.SetActive(true);
        ici2 = GameObject.Find("vous2");
        ici2.SetActive(false);
        maps = GameObject.Find("MAP");
        maps.SetActive(false);
    }
    
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider != null)
                {
                    if (hit.transform.name == "map")
                    {
                        inf.SetActive(false);
                        if (i == 0)
                        {
                            maps.SetActive(true);
                            if (pos == 0)
                            {
                                ici1.SetActive(true);
                                ici2.SetActive(false);
                            } else
                            {
                                ici2.SetActive(true);
                                ici1.SetActive(false);
                            }
                            i = 1;
                        }
                        else
                        {
                            i = 0;
                            maps.SetActive(false);
                        }
                    }
                    if (hit.transform.name == "to_1" && i == 0)
                    {
                        inf.SetActive(false);
                        newpos = GameObject.Find("Gyro Control").transform.position;
                        newpos.z += 60;
                        GameObject.Find("Gyro Control").transform.position = newpos;
                        pos = 1;
                    }
                    if (hit.transform.name == "to_2" && i == 0)
                    {
                        inf.SetActive(false);
                        newpos = GameObject.Find("Gyro Control").transform.position;
                        newpos.z -= 60;
                        GameObject.Find("Gyro Control").transform.position = newpos;
                        pos = 0;
                    }

                    if (hit.transform.name == "info" && i == 0)
                    {
                        inf.SetActive(true);
                    }
                    
                }
            }
        }
    }
}
