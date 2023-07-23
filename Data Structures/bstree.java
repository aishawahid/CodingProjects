package comp26120;


public class bstree implements set<String> {
    int verbose;

    String value;
    bstree left;
    bstree right;

    speller_config config;

    // TODO add fields for statistics
    float totalComparisonsInsert = 0;
    float totalInserts = 0;
    float totalComparisonsFind = 0;
    float totalFind = 0;

    public bstree(speller_config config) {
	verbose = config.verbose;
	this.config = config;
        left = null;
        right = null;
    }


    public int size(){
	// This presumes that if value is not null then (possibly empty) left and right trees exist.
	if(tree()){
	    return 1 + left.size() + right.size();
	}
	return 0;
    }

    public void insert (String value) {
        if (tree()) {
            if (this.value.compareTo(value) > 0) {
                if(left != null){
                    this.left.insert(value);
                    totalInserts++;
                }
                else {
                    this.left = new bstree(config);
                }
                totalComparisonsInsert++;
            } else if (this.value.compareTo(value) < 0) {
                if(right != null){
                    this.right.insert(value);
                    totalInserts++;
                }
                else {
                    this.right = new bstree(config);
                }
                totalComparisonsInsert++;
            }
        } else {
            this.left = new bstree(config);
            this.right = new bstree(config);
            this.value = value;
            totalInserts++;
        }
    }

    public boolean find (String value){
        if(tree()){
            //TODO complete the find function
            if(this.value.compareTo(value) == 0){
                totalComparisonsFind++;
                totalFind++;
                return true;
            }
            else if (this.value.compareTo(value) > 0 && left != null)  {
                totalComparisonsFind++;
                if (this.left.find(value) == true){
                    totalFind++;
                    return true;
                }
            } else if (this.value.compareTo(value) < 0 && right != null) {
                totalComparisonsFind++;
                if (this.right.find(value) == true){
                    totalFind++;
                    return true;
                }
            }
        }
        // if tree is NULL then it contains no values
        return false;
    }

    private boolean tree() {
	return (value != null);
    }

    // You can update this if you want
    public void print_set_recursive(int depth)
    {
        if(tree()){
            for(int i=0;i<depth;i++){ System.out.print(" "); }
            System.out.format("%s\n",value);
            left.print_set_recursive(depth+1);
            right.print_set_recursive(depth+1);
        }
    }
    // You can update this if you want
    public void print_set ()
    {
        System.out.print("Tree:\n");
        print_set_recursive(0);
    }


    public int height(){
        if (!tree()){
            return 0;
        }

        return 1 + Math.max(this.left.height(), this.right.height());
    }

    public void print_stats ()
    {
        int height = height();

        System.out.println("Height: " + height);
        System.out.println("Average comparisons per insert: " + (totalComparisonsInsert)/totalInserts);
        System.out.println(totalFind);
        System.out.println("Average comparisons per find: " + totalComparisonsFind/totalFind);
	// TODO update code to record and print statistics
    }
}
