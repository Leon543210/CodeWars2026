using System.Collections;

public class January17thChallenge : MonoBehaviour{
    //Title: Beginner - Reduce but Grow
    //Source: https://www.codewars.com/kata/57f780909f7e8e3183000078/train/csharp
    //Instructions

    /*
        Given a non-empty array of integers, return the result of multiplying the values together in order.
         Example: [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
    */

    //Solution:
    public class Kata
    {
        public static int Grow(int[] x){
            int startingValue = 1;
            for(int i = 0; i < x.Length; i++){
                startingValue *= x[i];
            }
            return startingValue;
        }
    }
}