import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

/* Write a program to generate n random hands of 5 different 
 * cards form a standard suit of 52 cards. */

public class P06RandomHandsOf5Cards {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	int n = scanner.nextInt();
	ArrayList<Card> cardsList = createDeck();
	for (int j = 0; j < n; j++) {
	    Card[] hand = randomHand(cardsList);
	    for (Card card : hand) {
		System.out.printf("%s%c ", card.getFace(), card.getSuit());
	    }
	    System.out.println();
	}
    }

    private static Card[] randomHand(ArrayList<Card> cardsList) {
	Random random = new Random();
	Card[] hand = new Card[5];
	for (int i = 0; i < hand.length; i++) {
	    int index = random.nextInt(cardsList.size());
	    hand[i] = cardsList.remove(index);
	}
	return hand;
    }

    private static ArrayList<Card> createDeck() {
	String[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J",
		"Q", "K", "A" };
	char[] suits = { '♣', '♦', '♥', '♠' };
	Card[] cards = new Card[52];
	ArrayList<Card> cardsList = new ArrayList<>();
	int x = 0;
	for (int i = 0; i < suits.length; i++) {
	    for (int j = 0; j < faces.length; j++) {
		cards[x] = new Card(faces[j], suits[i]);
		cardsList.add(cards[x]);
		x++;
	    }
	}
	return cardsList;
    }

}
