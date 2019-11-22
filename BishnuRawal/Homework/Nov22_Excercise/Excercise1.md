# Let's do SOMETHING REAL!!! 
## _This exercise will contribute 25% of FINAL TEST_

### Write a program to read given [text file](https://github.com/binbsr/.NETClassesCotiviti/blob/master/BishnuRawal/Homework/Nov22_Excercise/Olympics_Athelete_Events.txt) in this folder and parse this file to make a in-memory list of players. For, you have to create new class named Player or Athelete or whatever :) with data columns as properties. Load all rows into `List<Player>` (Individual row in a file is a player, an object of class Player). For reference, data column description is given below:

| Column | Description|
|--------|------------|
|ID       | An ID number assigned to this athlete based on their sequential order in the dataset |
|Name|The name of the athlete|
|Sex|The gender of the athlete|
|Age|The age of the athlete|
|Height|The height of the athlete, in centimeters|
|Weight|The weight of the athlete, in kilograms|
|Team|The country this athlete represents|
|NOC|The three-letter abbreviation for the country represented by the athlete|
|Games|The year and season for this Olympic event|
|Year|The year of the event|
|Season|The season of the event (either Summer or Winter)|
|City|The city in which these Olympics was held|
|Sport|The sport of the event|
|Event|The name of the event|
|Medal|The medal won by the athlete ("NA" if no medal was won)|

### Once you have list of players, query the collection for following, print result to console (for <= 100 lines) and to new file (if too big for console to look at)
1. List all the players participated from our country.
1. List all chinese players who have won the GOLD.
1. List all players from USA and group them by sport they were in. Also order the result by sport.
1. List all countries with thier medal tally so far. Also, order the list by number of golds won.
