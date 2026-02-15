//Title: Beginner - Lost Without a Map

//Source: https://www.codewars.com/kata/57f781872e3d8ca2a000007e/train/javascript

//Instructions

/*
    Given an array of integers, return a new array with each value doubled.

    For example:

    [1, 2, 3] --> [2, 4, 6]
*/

//My Solution
function maps(x){
  let arr = x;
  return arr.map(num => num * 2)
}