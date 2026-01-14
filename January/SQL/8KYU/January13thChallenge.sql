/*
    Title: Remove String Spaces
    Source: https://www.codewars.com/kata/57eae20f5500ad98e50002c5/train/sql
Instructions:
    -- # write your SQL statement here: you are given a table 'nospace' with column 'x', 
    return a table with column 'x' and your result in a column named 'res'.

*/

/* My solution */
Select x, Replace(x, ' ', '') as res from nospace;