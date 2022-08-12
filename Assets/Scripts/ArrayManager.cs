using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayManager : MonoBehaviour
{

    [SerializeField] GameObject[] objectsCollection;
    [SerializeField] int randomNumber;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        objectsCollection = GameObject.FindGameObjectsWithTag("ObjetoLab");
        agregarColiderAElementosDelArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            IntanciarObjetoAlAzar();
        }
    }

    void DestruirElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            //Destroy(objectsCollection[i]);
        }
    }

    void MoverObjetosDelArray()
    {
        for(int i = 0; i< objectsCollection.Length; i++)
        {
            objectsCollection[i].transform.position = new Vector3(2.8f + i, 0.7f, 9f);
        }
    }

    void agregarColiderAElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].AddComponent<BoxCollider>();
        }
    }

    void GenerarNroAlAzar()
    {
        randomNumber = Random.Range(1,11);
    }

    void IntanciarObjetoAlAzar()
    {
      
        Instantiate(objectsCollection[Random.Range(0, objectsCollection.Length)], spawnPoint.position, Quaternion.identity);
    }
}
