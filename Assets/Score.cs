using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreDispaly;
    public Animator scoreAnimator;
    public int threeStars = 3;
    public int twoStars = 5;
    public int nextLevel = 0;

    public void EndLevel(){
        
        Cannon cannon = FindObjectOfType<Cannon>();
        if (cannon){
            int numProjectiles = cannon.numProjectiles;

            if (numProjectiles <= threeStars) 
            {
                scoreDispaly.text = "Three Stars";
                scoreAnimator.SetInteger("Stars", 3);
            } else if (numProjectiles <= twoStars) 
            {
                scoreDispaly.text = "Two Stars";
                scoreAnimator.SetInteger("Stars", 2);
            } else 
            {
                scoreDispaly.text = "One Star";
                scoreAnimator.SetInteger("Stars", 1);
            }

            Invoke("NextLevel", 2);
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
