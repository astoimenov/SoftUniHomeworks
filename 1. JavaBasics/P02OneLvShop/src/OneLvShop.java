import java.text.ParseException;
import java.util.*;
import java.util.stream.Collectors;

public class OneLvShop {

    public static void main(String[] args) throws ParseException {
	FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400,
		AgeRestriction.Adult, "29-11-2014");
	Customer pecata = new Customer("Pecata", 17, 30.00);
	Customer gopeto = new Customer("Gopeto", 18, 0.44);

	PurchaseManager.ProcessPurchase(pecata, cigars);
	PurchaseManager.ProcessPurchase(gopeto, cigars);

	System.out.println();

	List<Product> products = new ArrayList<Product>();
	products.add(new FoodProduct("Bread", 0.99, 10, AgeRestriction.None,
		"05-11-2014"));
	products.add(new FoodProduct("Smirnoff", 10, 2, AgeRestriction.Adult,
		"25-12-2015"));
	products.add(new FoodProduct("Durex", 3.25, 25,
		AgeRestriction.Teenager, "16-12-2016"));
	products.add(new Computer("Apple MacPro", 2699.90, 20,
		AgeRestriction.Adult));
	products.add(new Computer("Shtajga", 699.90, 2, AgeRestriction.None));
	products.add(new Appliance("Mouse", 29.90, 33, AgeRestriction.None));

	Comparator<Product> byDateOfExpire = (p1, p2) -> (((FoodProduct) p1)
		.getExpirationDate().after(
			((FoodProduct) p2).getExpirationDate()) ? -1
		: ((FoodProduct) p1).getExpirationDate().after(
			((FoodProduct) p2).getExpirationDate()) ? 1 : 0);
	Comparator<Product> byPrice = (p1, p2) -> Double.compare(p1.getPrice(),
		(p2.getPrice()));

	Product expirableProduct = products.stream()
		.filter(p -> p instanceof Expirable).sorted(byDateOfExpire)
		.findFirst().get();

	System.out.println("First expirable product:");
	System.out.println(expirableProduct.getName());

	System.out.println();

	List<Product> adultAgerestrictionByPrice = products.stream()
		.filter(p -> p.getAgeRestriction() == AgeRestriction.Adult)
		.sorted(byPrice).collect(Collectors.toList());

	System.out.println("Adult restricted items:");
	for (Product product : adultAgerestrictionByPrice) {
	    System.out.println(product.getName() + ", " + product.getPrice());
	}
	Integer[] nums = new Integer[]{1, 2, 3, 4, 5};
	ArrayList<Integer> numbers = new ArrayList<>(Arrays.asList(nums));
	for (int i = 0; i < nums.length; i++) {
	    System.out.println(numbers.get(i));
	    numbers.remove(i);
	    System.out.println(numbers);
	}
	
    }
    
    public static int myIterator(ArrayList<Integer> nums) {
	if (nums.iterator().hasNext()) {
	    Integer a = nums.get(0);
	    nums.remove(0);
	    myIterator(nums);
	    return a;
	} else {
	    return nums.get(0);
	}
    }
}
