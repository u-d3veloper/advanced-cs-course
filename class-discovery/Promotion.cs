public class Promotion{
    public string Nom{get; set;}
    public int Annee{get;set;}
    private List<Etudiant> Etudiants{get;}
    private List<Enseignant> Enseignants{get;}

    public Promotion(string nom, int annee, List<Etudiant> etudiants, List<Enseignant> enseignants){
        this.Nom = nom;
        this.Annee = annee;
        this.Etudiants = etudiants;
        this.Enseignants = enseignants;
    }

    public override string ToString(){
        string infos = $"Promotion {Nom}, année {Annee} \n Nombre d'étudiants : {Etudiants.Count()}";
        foreach(Etudiant etudiant in Etudiants){
            infos += $"\n - {etudiant.ToString()}";
        }
        infos += "\n Nombre d'étudiants : {Etudiants.Count()}";
        foreach(Enseignant enseignant in Enseignants){
            infos += $"\n - {enseignant.ToString()}";
        }
        return infos;
    }

}