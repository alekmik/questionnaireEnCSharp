/*acceuil de l'utilisateur. au - 2 QCM (caractèristique supplémentaire : 1. ajouter
*de la couleur aux caractères dans la console (ex : réponse fausse = rouge & réponse
bonne = vert*/
Console.WriteLine("Bonjour, bienvenue sur le test d'admission du cinéphile !" +
    "\n\nDes questions sur le thème du cinéma vous serrons posez." +
    "\n\nPour rappel un QCM est un Questionnaire à Choix Multiples." +
    " \n\nVous aurez le choix de la réponse parmis 4 propositions." +
"\n\n\nTaper Entrer pour commencer le questionnaire. ");


//appuyer sur Entrée pour commencer
Console.ReadLine();
int scoreOfCorrectAnswers = 0;






//Première question
//Variables première question
string pinocchio = "Pinocchio";
string laBoiteAMusique = "La Boîte à musique";
string laPetiteSirene = "La Petite Sirène";
string blancheNeige = "Blanche-Neige et les Sept Nains";

Console.WriteLine("\n\nQuel est le plus vieux film des Studios Dysney ?" +
    "\n1 : " + pinocchio +
    "\n2 : " + laBoiteAMusique +
    "\n3 : " + laPetiteSirene +
    "\n4 : " + blancheNeige +
    "\n\nTaper le numéro associé à la réponse (\"1\" ou \"2\" ou \"3\" ou \"4\")"
);
string rightAnswerQuestion1 = Console.ReadLine();

//Associer la réponse à une variable
if (rightAnswerQuestion1 == "1")
{
    Console.WriteLine("\nVotre réponse : " + pinocchio +
        "\nMauvaise réponse !");
}

else if (rightAnswerQuestion1 == "2")
{
    Console.WriteLine("\nVotre réponse : " + laBoiteAMusique +
        "\nMauvaise réponse !");
}

else if (rightAnswerQuestion1 == "3")
    {
    Console.WriteLine("\nVotre réponse : " + laPetiteSirene +
        "\nMauvaise réponse !");
}

else if (rightAnswerQuestion1 == "4")
    {
        Console.WriteLine("\nBonne réponse!" +
            "\nVotre réponse : " + blancheNeige);
        scoreOfCorrectAnswers++;
    }
    //reposé la question si chiffre 4<x
    else
    {
        Console.WriteLine("Chiffre incorrect, merci de taper le numéro " +
            "associé à la réponse (\"1\" ou \"2\" ou \"3\" ou \"4\")");
    }

//Transition question suivante
Console.WriteLine("\n\n\n\n\n\nTaper Entrer pour lire la question suivante...");
Console.ReadLine();







//Deuxième question
    string answerIsTrue = "Vrai";
    string answerIsFalse = "Faux";

    Console.WriteLine("\n\n\"Le Seigneur des anneaux : La Communauté de l'anneau\"" +
        " est sorti au cinéma en 2004 ?" +
        "\n1 : " + answerIsTrue +
        "\n2 : " + answerIsFalse +
        "\n\nTaper le numéro associé à la réponse (\"1\" pour vrai ou \"2\" pour faux)"
    );
    string rightAnswerQuestion2 = Console.ReadLine();

    if (rightAnswerQuestion2 == "1")
    {
        Console.WriteLine("\nBonne réponse!" +
            "\nVotre réponse : " + answerIsTrue +
            " .Le Seigneur des anneaux : La Communauté de l'anneau\" est" +
            "sorti en 2001.");
    }

    else if (rightAnswerQuestion2 == "2")
    {
        Console.WriteLine("\nMauvaise réponse !" +
            "\nVotre réponse : " + answerIsFalse +
            " .Le Seigneur des anneaux : La Communauté de l'anneau\" est" +
            "sorti en 2001.");
    }

    else
    {
        Console.WriteLine("Chiffre incorrect, merci de taper le numéro " +
            "associé à la réponse (\"1\" pour vrai ou \"2\" pour faux");
    }


//Troisième question


//Quatrième question


//Cinquième question


//Sixième question


//Septième question


//Huitième question


//Neuvième question


//Dixième question


//Fin de la partie, afficher les statistiques (nbr de réponses bonnes)