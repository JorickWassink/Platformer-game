using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    [SerializeField] private TMP_Text ScoreText; // maakt een nieuwe private tmp_text object aan
    public int coin; // maakt een nieuwe public int
    [SerializeField] Rigidbody2D rb; // maakt een nieuwe object aan
    float speed = 7;// maakt een nieuwe float var aan
    public Collider2D CoinCollider; 

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // koppelt de rb object met het rigidbody van de ufo
    }

    // Update is called once per frame
    void Update()
    {
        float Xmove = Input.GetAxisRaw("Horizontal") * speed; // zorgt ervoor dat de speler met de a en d knop kan bewegen
        

        rb.velocity = new Vector2(Xmove, rb.velocity.y); // maakt een nieuwe vector aan voor vertikale beweging

        if (coin >= 10) // als de conditie klopt wat in dit geval coin = hoger of staat gelijk aan 10
        {
            SceneManager.LoadScene("end screen"); // laat andere scene
        }

        if (Input.GetKeyDown(KeyCode.Space)) // als spatiebalk ingedrukt
        {            
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.9f); // schiet een ray naar onderen om te zien of er een object staat

            if (hit.collider != null) // als niet niks is
            {
                if (hit.collider.tag == "meteor") // als geraakte object de tag meteor heeft
                {

                    rb.AddForce(Vector3.up * 10, ForceMode2D.Impulse); // gebruikt addforce om object omhoog te schieten
                }
            }                                         
        }

       




    }
    public void OnTriggerEnter2D(Collider2D other) // method die aangeroepen word als object collide met een ander object die de trigger setting aan heeft
    {

        if (other.tag == "coin")
        {
           
            coin++; // doet 1 bij coin
            
            
            Destroy(other.gameObject); // verwijderdt de object
            print(coin); // print de waarde van coin in de console
            ScoreText.text = coin.ToString(); //veranderdt de text in een text object naar de waarde van coin
        }
        else if (other.tag == "raket")
        {
            transform.position = new Vector3(4.05f, -2.85f); // verplaatst object naar coordinaten

        }

    }


}
