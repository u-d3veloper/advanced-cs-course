public class Etudiant{
        public string Nom{get; set;}
        public string Prenom{get;set;}
        public string Login{get;}

        public string genererLogin(){
            return $"{Prenom[0]}{Nom}";
        }

        public Etudiant(string nom,string prenom){
            Nom = nom;
            Prenom = prenom;
            Login = (Nom=="" && Prenom=="")?"inconnu" : genererLogin();
        }

        public Etudiant(string nom, string prenom, string login){
            Nom = nom;
            Prenom = prenom;
            Login = login;
        }

        public override string ToString(){
            string info = (Login!=null)? $"Nom : {Nom}, Prenom : {Prenom}, Login: {Login}": $"Nom : {Nom}, Prenom : {Prenom}";
            return info;
        }

}

