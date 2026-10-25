using UnityEngine;

public class cadenas_manageur : MonoBehaviour
{
    public string type_cadenas;
    public
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cle_jaune" && type_cadenas=="jaune")
        {
            
        }
        if (other.gameObject.tag == "cle_rouge" && type_cadenas == "rouge")
        {

        }
        if (other.gameObject.tag == "cle_bleu" && type_cadenas == "bleu")
        {

        }
    }
}
