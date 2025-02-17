
using UnityEngine;

public class ContainerExample : MonoBehaviour
{
    public int[] age;

    private void Start()
    {
        int mean = CalculateMean(age);
        Debug.Log("The average age is :" + mean);

        int range = CalculateRange(age);
            Debug.Log("The range of age is :" + range);
    }

    int CalculateMean(int[] values)
    {
        //1. add all the values together
        //2. divide by number of values
        int sum = 0;
        for(int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }



        return sum / values.Length;
    }

    int CalculateRange(int[] values)
    {
        //biggest value take away smallest
        System.Array.Sort(values);
        int range = values[values.Length - 1] - values[0];
        return range;

        
    }
}
