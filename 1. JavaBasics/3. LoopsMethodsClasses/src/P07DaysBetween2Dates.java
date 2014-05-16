import java.util.Scanner;

import org.joda.time.DateTime;
import org.joda.time.Days;

public class P07DaysBetween2Dates {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	String firstString = scanner.next();
	String secondString = scanner.next();
	int days = daysDifference(firstString, secondString);
	System.out.println(days);
    }

    private static int daysDifference(String firstString, String secondString) {
	String[] fTokens = firstString.split("-");
	String[] sTokens = secondString.split("-");
	int fYear = Integer.parseInt(fTokens[2]);
	int fMonth = Integer.parseInt(fTokens[1]);
	int fDay = Integer.parseInt(fTokens[0]);
	int sYear = Integer.parseInt(sTokens[2]);
	int sMonth = Integer.parseInt(sTokens[1]);
	int sDay = Integer.parseInt(sTokens[0]);
	DateTime firstDate = new DateTime(fYear, fMonth, fDay, 0, 0);
	DateTime secondDate = new DateTime(sYear, sMonth, sDay, 0, 0);
	int days = Days.daysBetween(firstDate, secondDate).getDays();
	return days;
    }

}
