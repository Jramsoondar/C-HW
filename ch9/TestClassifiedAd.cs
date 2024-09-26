class ClassFieldAdd{
    public string[] words { get; set; }
    
    private const double PRICE = 0.09;
    public ClassFieldAdd(string[] words){
        this.words = words;
    }

    public double CalcTotalCost(){
        int count = words.Length;
        return count * PRICE;
    }
}