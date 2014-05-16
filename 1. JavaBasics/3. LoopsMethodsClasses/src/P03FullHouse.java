/* In most Poker games, the "full house" hand is defined as three 
 * cards of the same face + two cards of the same face, other than the 
 * first, regardless of the card's suits. Write a program to generate 
 * and print all full houses and print their number. */

public class P03FullHouse {

    public static void main(String[] args) {
	String[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J",
		"Q", "K", "A" };
	char[] suits = { '♣', '♦', '♥', '♠' };
	int counter = 0;
	for (int i = 0; i < faces.length; i++) {
	    for (int j = 0; j < faces.length; j++) {
		for (int k = 0; k < suits.length; k++) {
		    for (int m = k + 1; m < suits.length; m++) {
			for (int l = m + 1; l < suits.length; l++) {
			    for (int n = 0; n < suits.length; n++) {
				for (int o = n + 1; o < suits.length; o++) {
				    if (i != j) {
					System.out.printf(
						"(%s%c %s%c %s%c %s%c %s%c) ",
						faces[i], suits[k], faces[i],
						suits[m], faces[i], suits[l],
						faces[j], suits[n], faces[j],
						suits[o]);
					counter++;
				    }
				}
			    }
			}
		    }
		}
	    }
	}
	System.out.println();
	System.out.println(counter + " full houses");
    }

}
