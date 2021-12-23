using System.Text.RegularExpressions;
using System;


/*acceuil de l'utilisateur. au - 2 QCM (caractèristique supplémentaire : 1. ajouter
*de la couleur aux caractères dans la console (ex : réponse fausse = rouge & réponse
bonne = vert*/
Console.WriteLine("Bonjour, bienvenue sur le test d'admission du cinéphile !" +
    "\n\nDes questions sur le thème du cinéma vous serrons posées." +
    "\n\nPour rappel un QCM est un Questionnaire à Choix Multiples." +
    " \nVous aurez le choix de la réponse parmis 4 propositions." +
"\n\n\nTaper Entrer pour commencer le questionnaire. ");


//appuyer sur Entrée pour commencer
Console.ReadLine();
int scoreOfCorrectAnswers = 0;






//-----------------------------------Première question------------------------------------
//Variables première question
string pinocchio = "Pinocchio";
string laBoiteAMusique = "La Boîte à musique";
string laPetiteSirene = "La Petite Sirène";
string blancheNeige = "Blanche-Neige et les Sept Nains";

Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nQuel est le plus vieux film des Studios Dysney ?" +
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
    Console.WriteLine("\nMauvaise réponse !" +
        "\nVotre réponse : " + pinocchio +
        "\nLe premier film des Studios Dysney est Blanche-Neige et les Sept Nains, sorti en 1937.");
} 

else if (rightAnswerQuestion1 == "2")
{
    Console.WriteLine("\nMauvaise réponse !"+
        "\nVotre réponse : " + laBoiteAMusique + 
        "\nLe premier film des Studios Dysney est Blanche-Neige et les Sept Nains, sorti en 1937.");
}

else if (rightAnswerQuestion1 == "3")
    {
    Console.WriteLine("\nMauvaise réponse !" +
        "\nVotre réponse : " + laPetiteSirene +
        "\nLe premier film des Studios Dysney est Blanche-Neige et les Sept Nains, sorti en 1937.");
}

else if (rightAnswerQuestion1 == "4")
    {
        Console.WriteLine("\nBonne réponse!" +
            "\nVotre réponse : " + blancheNeige +
        ".\nLe premier film des Studios Dysney est Blanche-Neige et les Sept Nains, sorti en 1937.");
        scoreOfCorrectAnswers++;
    }
    //reposé la question si chiffre 4<x
    else
    {
        Console.WriteLine("Chiffre incorrect, merci de taper le numéro " +
            "associé à la réponse (\"1\" ou \"2\" ou \"3\" ou \"4\")");
    }

//Transition question suivante
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nTaper Entrer pour lire la question suivante...");
Console.ReadLine();







//-----------------------------------Deuxième question------------------------------------
    string answerIsTrue = "Vrai";
    string answerIsFalse = "Faux";

    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\"Le Seigneur des anneaux : " +
        "La Communauté de l'anneau\"" +
        " est sorti dans les salles obscures en 2004 ?" +
        "\n1 : " + answerIsTrue +
        "\n2 : " + answerIsFalse +
        "\n\nTaper le numéro associé à la réponse (\"1\" pour vrai ou \"2\" pour faux)"
    );
    string rightAnswerQuestion2 = Console.ReadLine();

if (rightAnswerQuestion2 == "1")
{
    Console.WriteLine("\nMauvaise réponse!" +
        "\nVotre réponse : \"" + answerIsTrue +
        " \".Le Seigneur des anneaux : La Communauté de l'anneau\" est" +
        "sorti en 2001.");
}

    else if (rightAnswerQuestion2 == "2")
    {   
    Console.WriteLine("\nBonne réponse !");
    Console.Clear();
    Console.WriteLine("\nVotre réponse : \"" + answerIsFalse +
    " \".Le Seigneur des anneaux : La Communauté de l'anneau\" est" +
    "sorti en 2001.");
    }

    else
    {
        Console.WriteLine("Chiffre incorrect, merci de taper le numéro " +
            "associé à la réponse (\"1\" pour vrai ou \"2\" pour faux");
    }

//Transition question suivante
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nTaper Entrer pour lire la question suivante...");
Console.ReadLine();









//-----------------------------------Troisième question------------------------------------
string answerIsTenet = "Tenet";

Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nDans quel film John David Washington interprète le Protagoniste," +
    " propulser par la bande originale de Ludwig Göransson ?" +
    "\n\nTaper le nom du film : "
);
string rightAnswerQuestion3 = Console.ReadLine();

if (rightAnswerQuestion3 == "Tenet")
{
    Console.WriteLine("\nBonne réponse!" +
        "\nVotre réponse : \"" + answerIsTenet +
        " \". Il s'agit en effet de Tenet, de Christopher Nolan. Le long-métrage à remporter" +
        " un Oscar pour ses effets visuels époustouflants.");
        scoreOfCorrectAnswers++;
}

else
{
    Console.WriteLine("\nMauvaise réponse. \nIl s'agit de Tenet, de Christopher Nolan. " +
        "Le long-métrage à remporter un Oscar pour ses effets visuels époustouflants.");
}


//Transition question suivante
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nTaper Entrer pour lire la question suivante...");
Console.ReadLine();











//-----------------------------------Quatrième question------------------------------------
string answerIsEight = "8";

Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nCombien de film compte la sage Harry Potter au cinéma" +
    " (sans compter \"Les Animaux Fantastiques\") ?" +
    "\n\nTaper le nombre de film : "
);
string rightAnswerQuestion4 = Console.ReadLine();

if (rightAnswerQuestion4 == "8")
{
    Console.WriteLine("\nBonne réponse!" +
        "\nVotre réponse : \"" + answerIsEight +
        " \". Il exsite au total 8 films Harry Potter, les 2 derniers " +
        "films n'en forme qu'une seul intrigue.");
    scoreOfCorrectAnswers++;
}

else
{
    Console.WriteLine("\nMauvaise réponse. \nIl exsite au total 8 films Harry Potter, les 2 derniers " +
        "films n'en forme qu'une seul intrigue.");
}


//Transition question suivante
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nTaper Entrer pour lire la question suivante...");
Console.ReadLine();















//-----------------------------------Cinquième question----------------------------------
string answerIsTrueQuestion5 = "Vrai";
string answerIsFalseQuestion5 = "Faux";

Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nEst-ce que Robert De Niro" +
    " et Al Pacino ont déjà partager l'écran dans un film ?" +
    "\n1 : " + answerIsTrueQuestion5 +
    "\n2 : " + answerIsFalseQuestion5 +
    "\n\nTaper le numéro associé à la réponse (\"1\" pour vrai ou \"2\" pour faux)"
);
string rightAnswerQuestion5 = Console.ReadLine();

if (rightAnswerQuestion5 == "1")
{
    Console.WriteLine("\nBonne réponse !" +
        "\nVotre réponse : \"" + answerIsTrueQuestion5 +
        " \". Robert De Niro et Al Pacino ont joué ensemble qu'une seul fois. ");
}

else if (rightAnswerQuestion5 == "2")
{
    Console.WriteLine("\nMauvaise réponse!");
    Console.Clear();
    Console.WriteLine("\nVotre réponse : \"" + answerIsFalseQuestion5 +
    " \". ");
}

else
{
    Console.WriteLine("Chiffre incorrect, merci de taper le numéro " +
        "associé à la réponse (\"1\" pour vrai ou \"2\" pour faux");
}




//Transition question suivante
Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nTaper Entrer pour lire la question suivante...");
Console.ReadLine();








//-----------------------------------Sixième question----------------------------------


//-----------------------------------Septième question----------------------------------


//-----------------------------------Huitième question----------------------------------


//-----------------------------------Neuvième question----------------------------------


//-----------------------------------Dixième question----------------------------------


//Fin de la partie, afficher les statistiques (nbr de réponses bonnes)
Console.WriteLine("\n\nBravo ! Vous avez terminer le questionnaire." +
    "\n\nVotre score est de " + scoreOfCorrectAnswers + " sur 10.");
