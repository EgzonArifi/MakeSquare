# MakeSquare
Make Square by dynamic programing

A string S is called a square if there is some string T such that S = T + T. For example, the strings &quot;&quot;,

aabaab&quot; and &quot;xxxx&quot; are squares, but &quot;a&quot;, &quot;aabb&quot; and &quot;aabbaa&quot; are not. 

You are given a String s. You want to change s into a square. You may do the following operations:

 Insert a new character anywhere into the string (including its beginning and end).

 Remove a single character.

 Replace a single character by another character.

Please compute and return the smallest number of operations needed to change the given s into a square.

Note that this is always possible: for example, you can remove all characters (one at a time).

Definition

Class: RepeatString

Method: minimalModify

Parameters: String

Returns: int

Method signature: int minimalModify(String s)

(be sure your method is public)

Constraints

- s will contain between 1 and 50 characters, inclusive.

- Each character in s will be a lowercase English letter (&#39;a&#39;-&#39;z&#39;).

Examples

0)

    

&quot;aba&quot;

Returns: 1

One of the optimal solutions is to remove the &#39;b&#39;. This changes the given s into the square &quot;aa&quot;.
