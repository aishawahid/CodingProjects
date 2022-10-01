package chess;
import java.util.regex.Pattern;

public class CheckInput {

	public static boolean checkCoordinateValidity(String input){
		String regex = "^[1-8]{1}[a-h]{1}$";
		boolean matches = Pattern.matches(regex, input);
		if(matches == true){
			return true;
		}
		else {
			return false;
		}
	}
}
