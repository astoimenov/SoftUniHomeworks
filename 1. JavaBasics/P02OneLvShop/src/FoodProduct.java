import java.text.*;
import java.util.Date;
import java.util.concurrent.TimeUnit;

public class FoodProduct extends Product implements Expirable {

    private Date expirationDate;
    private boolean isExpired;

    public FoodProduct(String name, double price, int quantity,
	    AgeRestriction ageRestriction, String expirationDate)
	    throws ParseException {
	super(name, price, quantity, ageRestriction);
	this.setExpirationDate(expirationDate);
    }

    public void setExpirationDate(String expirationDate) throws ParseException {
	String target = expirationDate;
	DateFormat formatter = new SimpleDateFormat("dd-MM-yyyy");
	try {
	    Date date = formatter.parse(target);
	    this.expirationDate = date;
	} catch (ParseException e) {
	    throw new ParseException("Can't parse the date!", 0);
	}
    }

    @Override
    public Date getExpirationDate() {
	return this.expirationDate;
    }

    @Override
    public double getPrice() {
	long now = new Date().getTime();
	long period = (this.getExpirationDate().getTime() - now);
	int days = (int) TimeUnit.DAYS.convert(period, TimeUnit.MILLISECONDS);
	if (days < 15) {
	    return (this.price * 0.7);
	}

	return this.price;
    }

    public boolean isExpired() {
	Date now = new Date();
	if (this.expirationDate.before(now)) {
	    return true;
	}

	return false;
    }

    public void setExpired(boolean isExpired) {
	this.isExpired = isExpired;
    }
}
