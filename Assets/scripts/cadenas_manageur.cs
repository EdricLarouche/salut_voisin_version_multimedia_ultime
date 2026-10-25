using UnityEngine;

public class cadenas_manageur : MonoBehaviour
{
    public string type_cadenas;
    public GameObject martin;
    public GameObject manager_cle;
    
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
            //Détruit la cle et le cadenas
            Instantiate(martin);
            manager_cle.GetComponent<manager_cle>().nbr_de_cle -= 1;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "cle_rouge" && type_cadenas == "rouge")
        {
            //Détruit la cle et le cadenas
            Instantiate(martin);
            manager_cle.GetComponent<manager_cle>().nbr_de_cle -= 1;

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "cle_bleu" && type_cadenas == "bleu")
        {
            Instantiate(martin);
            manager_cle.GetComponent<manager_cle>().nbr_de_cle -= 1;

            //Détruit la cle et le cadenas
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
