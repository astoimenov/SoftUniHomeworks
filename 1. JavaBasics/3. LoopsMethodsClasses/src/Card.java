public class Card {
    private String face;
    private char suit;

    public Card(String face, char suit) {
	super();
	this.face = face;
	this.suit = suit;
    }

    public String getFace() {
	return face;
    }

    public char getSuit() {
	return suit;
    }

    public void setFace(String face) {
	this.face = face;
    }

    public void setSuit(char suit) {
	this.suit = suit;
    }
}
