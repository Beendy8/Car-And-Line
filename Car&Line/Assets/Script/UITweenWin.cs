using UnityEngine;

public class UITweenWin : MonoBehaviour
{
    [SerializeField] GameObject backPanel, nextBtn, replayBtn, noStar1, noStar2, noStar3, yesStar1, yesStar2, yesStar3, colorWheel, levelSucess;
    [SerializeField] private GameObject canvasUIWin;
    [SerializeField] private GameObject[] stars;
    public int starsCount = 0;

    public static UITweenWin instance;

    private void Start()
    {
        instance = this;
        starsCount = GameObject.FindGameObjectsWithTag("Star").Length;
    }

    public void ActiveStars()
    {
        int starLeft = GameObject.FindGameObjectsWithTag("Star").Length;
        int starCollected = starsCount - starLeft;
        float percentage = float.Parse(starCollected.ToString()) / float.Parse(starsCount.ToString()) * 100f;

        if (percentage >= 33f && percentage < 66)
        {
            yesStar1.SetActive(true);
        }
        else if (percentage >= 66 && percentage < 70)
        {
            yesStar1.SetActive(true);
            yesStar2.SetActive(true);
        }
        else if (percentage >= 70)
        {
            yesStar1.SetActive(true);
            yesStar2.SetActive(true);
            yesStar3.SetActive(true);
        }
    }
    public void LevelSuccess()
    {
        LeanTween.rotateAround(colorWheel, Vector3.forward, -360f, 10f).setLoopClamp();
        LeanTween.scale(levelSucess, new Vector3(2f, 1.2f, 0.3f), 2f).setDelay(0.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(LevelComplete);
        LeanTween.moveLocal(levelSucess, new Vector3(-8f, 170f, 0f), 0.7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(levelSucess, new Vector3(2f, 1.2f, 0.3f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInOutCubic);
    }
    public void LevelComplete()
    {
        LeanTween.moveLocal(backPanel, new Vector3(0f, -15f, 0f), 0.7f).setDelay(.5f).setEase(LeanTweenType.easeOutCirc).setOnComplete(StarsAnim);
        LeanTween.scale(nextBtn, new Vector3(0.2f, 1f, 1f), 2f).setDelay(.8f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(replayBtn, new Vector3(0.2f, 1f, 1f), 2f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);
    }
    public void StarsAnim()
    {
        LeanTween.scale(noStar1, new Vector3(0.25f, 0.25f, 1f), 2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(noStar2, new Vector3(0.25f, 0.25f, 1f), 2f).setDelay(.1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(noStar3, new Vector3(0.25f, 0.25f, 1f), 2f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
    }
}
