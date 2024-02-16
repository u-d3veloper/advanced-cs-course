public class Enseignant{
    public string Nom{get;set;}
    public string Matiere{get;set;}
    
    public Enseignant(string nom,string matiere){
        this.Nom = nom;
        this.Matiere = matiere;
    }
    public override string ToString(){
        string info = (Matiere!=null)? $"Nom : {Nom}, Discipline : {Matiere}": $"Nom : {Nom}, Discipline : non renseignée";
        return info;
    }

}