public class Rationnel{
    public int Numerator{get;set;}
    public int Denominator{get;set;}

    public Rationnel(int numerator,int denominator){
        this.Numerator = numerator;
        this.Denominator = denominator;
    }
    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
    public void Ajouter(int number){
       this.Numerator += this.Denominator * number;
    }
    public void Soustraire(int number){
       this.Numerator -= this.Denominator * number;
    }
    public void Multiplier(int number){
        this.Numerator *= number;
    }
    public void Diviser(int number){
        this.Denominator *= number;
    }


}