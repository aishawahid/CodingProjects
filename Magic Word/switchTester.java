class SwitchTester {
    public static void main(String args[]) {
        int a = 1;
        int b = 1;
        for (int i=1; i<6; i++) {
          a = i;
          b = a*a;
          switchExperiment(a, b);
        }
        System.out.println(((Object)a).getClass().getName());
        System.out.println(((Object)b).getClass().getName());

        String[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        for (int i=0; i<12; i++){
          seasonTest(months[i]);
        }
    }

    public static void switchExperiment(int a, int b) {
        switch (a) {
            case 1:
                b -= 4;
                break;
            case 2:
                b += 4;
                break;
            case 3:
                b /= 4;
                break;
            case 4:
                b *= 4;
                break;
            default:
                b = 0;
                break;
        }
        System.out.println("b is " + b);
    }

    public static void seasonTest(String season) {
        switch (season) {
            case "December":
                System.out.println("Winter");
                break;
            case "February":
                System.out.println("Winter");
                break;
            case "January":
                System.out.println("Winter");
                System.out.println("New Year, New Me!");
                break;
            case "March":
                System.out.println("Spring");
                break;
            case "April":
                System.out.println("Spring");
                break;
            case "May":
                System.out.println("Spring");
                break;
            case "June":
                System.out.println("Summer");
                break;
            case "July":
                System.out.println("Summer");
                break;
            case "August":
                System.out.println("Summer");
                System.out.println("Summer Vacation");
                break;
            case "September":
                System.out.println("Autumn");
                break;
            case "October":
                System.out.println("Autumn");
                break;
            case "November":
                System.out.println("Autumn");
                break;
            default:
                System.out.println("Invalid input");
                break;
        }
    }
}
