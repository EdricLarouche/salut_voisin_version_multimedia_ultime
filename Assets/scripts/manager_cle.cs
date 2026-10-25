using TMPro;
using UnityEngine;

public class manager_cle : MonoBehaviour
{
    public TextMeshPro Cle_Text;
    public int nbr_de_cle = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cle_Text.text = nbr_de_cle.ToString();
    }
}
