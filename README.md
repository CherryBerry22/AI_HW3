# AI_HW3
Homework assignment 3 for CS3030: Intro to AI

The purpose of this homework assignment is to provide you some practice in using the minimax search algorithm to design an automated agent that can play a 2-agent game.  
Your goal is to design an agent that can play the version of the Three-men’s Morris game (https://en.wikipedia.org/wiki/Three_men%27s_morris (Links to an external site.)) 
described below:

The game board has 3 horizontal lines, 3 vertical lines and 2 diagonal lines as shown below.
![image](https://user-images.githubusercontent.com/40703691/161882117-fb00e082-72cb-46f2-aa89-5ae88e571214.png)

Each player has three pieces at the start of the game.
The board is empty to begin the game, and players take turns placing one piece on each turn. A piece can only be placed on an empty intersection.
Once all pieces are placed (assuming there is no winner by then), play proceeds with each player moving one of their pieces per turn. 
A piece may move to any adjacent linked position that is currently unoccupied. If no adjacent positions are empty, the player loses its turn and the other player makes their move.
The winner is the first player to align their three pieces on a line drawn on the board.
Your task is to write a computer program in the programming language of your choice that implements the heuristic minimax algorithm with 16-ply 
lookahead with alpha-beta pruning. Use the "difference in number of possible wins" heuristic to estimate the node values at level 16.  
A possible win for a player is a row, column, or diagonal that does not have any opponent pieces yet.  
The difference in possible wins = Number of possible wins for Max - Number of possible wins for Min. 
For the leaf nodes reached, please assign them values as follows.  Assign +8 to nodes that are wins for Max, -8 to losses for Max and 0 to draws. 
Run the algorithm twice: once with Max starting and another time with min starting, and compute the average time of the two runs.
