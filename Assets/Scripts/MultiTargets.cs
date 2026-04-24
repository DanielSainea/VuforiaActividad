using UnityEngine;

public class MultiTargets : MonoBehaviour

{
    [SerializeField] private GameObject StartModel;
    private int modelsCount;
    private int indexCurrentModel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        modelsCount = transform.childCount;
        indexCurrentModel= StartModel.transform.GetSiblingIndex();
        
    }

    public void ChangeModel(int index)
    {
        transform.GetChild(indexCurrentModel).gameObject.SetActive(false);
        int newIndex = indexCurrentModel + index;

        if (newIndex < 0)
        {
            newIndex = modelsCount - 1;
        }
             else if (modelsCount == 0)
        {
            newIndex = 0;
        }
        GameObject newModel = transform.GetChild(newIndex).gameObject;
        newModel.SetActive(true);
        indexCurrentModel = newModel.transform.GetSiblingIndex();
    }
}
