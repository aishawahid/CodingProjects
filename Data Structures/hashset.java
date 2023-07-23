package comp26120;

public class hashset implements set<String> {
    int verbose;
    HashingModes mode;

    speller_config config;
    cell[] cells;
    int size;
    int num_entries; // number of cells in_use


    // TODO add any other fields that you need
    int hashedvalue = 0;
    float loadFactor = 0;
    int totalCollisions = 0;
    int totalInserts = 0;
    int totalRehashes = 0;

    // This is a cell structure assuming Open Addressing
    // You wil need alternative data-structures for separate chaining
    public class cell { // hash-table entry
	String element; // only data is the key itself
	state state;
    }

    public static enum state {
	empty,
	in_use,
	deleted;
    }

    public hashset(speller_config config) {
        verbose = config.verbose;
        mode = HashingModes.getHashingMode(config.mode);
        size =  config.init_size;
        size = nextPrime(size);
        cells = new cell[size];
        for (int i = 0; i < cells.length ; i++) {
            cell newCell = new cell();
            newCell.state = state.empty;
            cells[i] = newCell;
        }
        // TODO: create initial hash table

    }

    // Helper functions for finding prime numbers
    public boolean isPrime (int n)
    {
	for (int i = 2; i*i <= n; i++)
	    if (n % i == 0)
		return false;
	return true;
    }

    public int nextPrime(int n)
    {
	int i = n;
	while (!isPrime(i)) {
	    i++;
	}
	return i;
    }

    public void insert (String value)
    {
        inUse();
        loadFactor = (float) num_entries / (float) size;
        if(loadFactor > 0.75){
            rehash();
        }

        int primeNumber = nextPrime(size);

        if (find(value) == false){
            if(mode.equals( HashingModes.HASH_1_LINEAR_PROBING) || mode.equals( HashingModes.HASH_2_LINEAR_PROBING)){
                if (mode.equals( HashingModes.HASH_1_LINEAR_PROBING)){
                    hash1(value);
                }
                else {
                    hash2(value);
                }

                while (cells[hashedvalue].state != state.empty) {
                    hashedvalue = hashedvalue + 1;
                    hashedvalue %= primeNumber;
                    totalCollisions ++;
                }
                cells[hashedvalue].state = state.in_use;
                cells[hashedvalue].element = value;
                totalInserts++;
            }
            else if(mode.equals( HashingModes.HASH_1_QUADRATIC_PROBING) || mode.equals( HashingModes.HASH_2_QUADRATIC_PROBING) ){
                if (mode.equals( HashingModes.HASH_1_QUADRATIC_PROBING)){
                    hash1(value);
                }
                else {
                    hash2(value);
                }
                int nexthashedvalue = hashedvalue;
                int counter = 1;
                while (cells[nexthashedvalue].state != state.empty) {
                    nexthashedvalue = hashedvalue + (counter * counter);
                    nexthashedvalue %= primeNumber;
                    counter ++;
                    totalCollisions ++;
                }
                cells[nexthashedvalue].state = state.in_use;
                cells[nexthashedvalue].element = value;
                totalInserts++;
            }
            else if(mode.equals( HashingModes.HASH_1_DOUBLE_HASHING)){
                hash1(value);
                int hash1value = hashedvalue;
                hash2(value);
                int hash2value = hashedvalue;

                int nexthashedvalue = hashedvalue;
                int counter = 1;
                while (cells[nexthashedvalue].state != state.empty) {
                    nexthashedvalue = hash1value + (counter * hash2value);
                    nexthashedvalue %= primeNumber;
                    counter ++;
                    totalCollisions ++;
                }
                cells[nexthashedvalue].state = state.in_use;
                cells[nexthashedvalue].element = value;
                totalInserts++;
            }
            else if(mode.equals( HashingModes.HASH_2_DOUBLE_HASHING)){
                hash2(value);
                int hash2value = hashedvalue;
                hash1(value);
                int hash1value = hashedvalue;

                int nexthashedvalue = hashedvalue;
                int counter = 1;
                while (cells[nexthashedvalue].state != state.empty) {
                    nexthashedvalue = hash2value + (counter * hash1value);
                    nexthashedvalue %= primeNumber;
                    counter ++;
                    totalCollisions ++;
                }
                cells[nexthashedvalue].state = state.in_use;
                cells[nexthashedvalue].element = value;
                totalInserts++;
            }
        }
    }

    public boolean find (String value)
    {
        int primeNumber = nextPrime(size);
        if(mode.equals( HashingModes.HASH_1_LINEAR_PROBING) || mode.equals( HashingModes.HASH_2_LINEAR_PROBING)){
            if(mode.equals( HashingModes.HASH_1_LINEAR_PROBING)){
                hash1(value);
            }
            else{
                hash2(value);
            }

            while (cells[hashedvalue].state != state.empty) {
                if(cells[hashedvalue].element.equals(value)){
                    return true;
                }
                hashedvalue = hashedvalue + 1;
                hashedvalue %= primeNumber;
            }
        }
        else if(mode.equals( HashingModes.HASH_1_QUADRATIC_PROBING) || mode.equals( HashingModes.HASH_2_QUADRATIC_PROBING)){
            if(mode.equals( HashingModes.HASH_1_QUADRATIC_PROBING)){
                hash1(value);
            }
            else {
                hash2(value);
            }
            int nexthashedvalue = hashedvalue;
            int counter = 1;
            //System.out.println(compressedValue);

            while (cells[nexthashedvalue].state != state.empty) {
                if(cells[nexthashedvalue].element.equals(value)){
                    return true;
                }
                nexthashedvalue = hashedvalue + (counter * counter);
                nexthashedvalue %= primeNumber;
                //System.out.println(nexthashedvalue + " " + hashedvalue);
                counter ++;
                //hashedvalue = hashedvalue + 1;
                //hashedvalue %= primeNumber;
                //System.out.println(compressedValue);
            }
        }
        else if(mode.equals( HashingModes.HASH_1_DOUBLE_HASHING)){
            hash1(value);
            int hash1value = hashedvalue;
            hash2(value);
            int hash2value = hashedvalue;
            int nexthashedvalue = hashedvalue;
            int counter = 1;

            while (cells[nexthashedvalue].state != state.empty) {
                if(cells[nexthashedvalue].element.equals(value)){
                    return true;
                }
                nexthashedvalue = hash1value + (counter * hash2value);
                nexthashedvalue %= primeNumber;
                counter ++;
            }
        }else if(mode.equals( HashingModes.HASH_2_DOUBLE_HASHING)){
            hash2(value);
            int hash2value = hashedvalue;
            hash1(value);
            int hash1value = hashedvalue;
            int nexthashedvalue = hashedvalue;
            int counter = 1;

            while (cells[nexthashedvalue].state != state.empty) {
                if(cells[nexthashedvalue].element.equals(value)){
                    return true;
                }
                nexthashedvalue = hash2value + (counter * hash1value);
                nexthashedvalue %= primeNumber;
                counter ++;
            }
        }
	return false;
    }

    public void print_set ()
    {
        for (int i = 0; i < cells.length; i++) {
            System.out.println("Index " + i + " :" + cells[i].element);
        }
    }

    public void print_stats ()
    {
        System.out.println("Total Collisons: " + totalCollisions);
        System.out.println("Total Inserts: " + totalInserts);
        System.out.println("Total Rehashes: " + totalRehashes);
        System.out.println("Average Collisions per insert: " + (float)totalCollisions/(float)totalInserts);
    }

    // Hashing Modes

    public enum HashingModes {
	HASH_1_LINEAR_PROBING, // =0 in mode flag
        HASH_1_QUADRATIC_PROBING, // =1,
        HASH_1_DOUBLE_HASHING, //=2,
        HASH_1_SEPARATE_CHAINING, // =3,
        HASH_2_LINEAR_PROBING, // =4,
        HASH_2_QUADRATIC_PROBING, // =5,
        HASH_2_DOUBLE_HASHING, // =6,
        HASH_2_SEPARATE_CHAINING; // =7

	public static HashingModes getHashingMode(int i) {
	    switch (i) {
	    case 1:
		return HASH_1_QUADRATIC_PROBING;
	    case 2:
		return HASH_1_DOUBLE_HASHING;
	    case 3:
		return HASH_1_SEPARATE_CHAINING;
	    case 4:
		return HASH_2_LINEAR_PROBING;
	    case 5:
		return HASH_2_QUADRATIC_PROBING;
	    case 6:
		return HASH_2_DOUBLE_HASHING;
	    case 7:
		return HASH_2_SEPARATE_CHAINING;
	    default:
		return HASH_1_LINEAR_PROBING;
	    }
	}
    }

    // Your code

    public void hash1(String value){
        int primeNumber = nextPrime(size);
        hashedvalue = 0;
        char[] charValue = value.toCharArray();
        for (int i = 0; i < charValue.length; i++) {
            hashedvalue = hashedvalue + (int) charValue[i];
        }

        hashedvalue = hashedvalue % primeNumber;
    }

    public void hash2(String value){
        int primeNumber = nextPrime(size);
        int pow = 1;
        hashedvalue = 0;
        char[] charValue = value.toCharArray();
        for (int i = 0; i < charValue.length; i++) {
            hashedvalue = (int)((hashedvalue + (charValue[i] - 'a' + 1) * pow) % primeNumber);
            pow = (pow * 31) % primeNumber;
        }
    }

    public void inUse(){
        num_entries = 0;
        for (int i = 0; i < cells.length; i++) {
            if (cells[i].state == state.in_use){
                num_entries = num_entries + 1;
            }
        }
    }

    public void rehash(){
        String[] oldValues = new String[num_entries];
        int counter = 0;

        for (int i = 0; i < cells.length; i++) {
            if (cells[i].state == state.in_use){
                oldValues[counter] = cells[i].element;
                counter ++;
            }
        }

        size = size * 2;
        size = nextPrime(size);

        cells = new cell[size];
        for (int i = 0; i < cells.length ; i++) {
            cell newCell = new cell();
            newCell.state = state.empty;
            cells[i] = newCell;
        }

        for (int i = 0; i < oldValues.length; i++) {
            insert(oldValues[i]);
        }

        if (verbose > 2){
            System.out.println("Rehashing\n");
            print_stats();
        }
        totalRehashes++;

    }



}
