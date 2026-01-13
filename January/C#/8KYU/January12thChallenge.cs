using System.Collections;

public class January12thChallenge : MonoBehaviour{

//Instructions - Grasshopper - Terminal game move function
//Source: https://www.codewars.com/kata/563a631f7cbbc236cf0000c2/train/csharp

/*
    Terminal game move function
        In this game, the hero moves from left to right. The player rolls the die and 
        moves the number of spaces indicated by the die two times.

    Create a function for the terminal game that takes the current position of the hero
         and the roll (1-6) and return the new position.

    Example:
        move(3, 6) should equal 15


*/


 public static int Move(int position, int roll) //this line was provided.
  {
    //My solution - start
    int newPosition = position + roll * 2;
    
    return newPosition;

    // -end
  	throw new NotImplementedException(); //this line was provided.
    
    
  }
}
