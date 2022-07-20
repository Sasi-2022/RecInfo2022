using system;


public class OpenPanel : MonoBehaviour
{
    public GameObject gameObject;
    bool active;

    public void OpenandClose()
    {
        if (active == false)
        {
            gameObject.transform.gameObject.SetActive(true);
            active = true;

        }
        else
        {
            gameObject.transform.gameObject.SetActive(false);
            active = false;
        }



    }

}