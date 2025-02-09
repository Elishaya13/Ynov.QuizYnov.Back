# Backend du Quiz pour Ynov Campus

Ce d�p�t contient le backend d'une application de quiz d�velopp�e en .NET pour un projet scolaire � Ynov Campus. Ce backend g�re les questions et r�ponses des quiz class�es par cat�gories.

## � propos du projet

Ce projet de backend est d�velopp� en .NET et sert de base de donn�es et de logique m�tier pour un quiz en ligne. Il stocke les questions et r�ponses, organis�es en diff�rentes cat�gories, permettant ainsi une navigation et une interaction faciles pour l'utilisateur final.

## Frontend

Le frontend de l'application est d�velopp� en Angular et est con�u pour interagir avec ce backend. Il fournit une interface utilisateur pour participer aux quiz et g�re l'�valuation des r�ponses en comparant les choix de l'utilisateur avec la propri�t� `isCorrect` des r�ponses stock�es pour chaque question.

- **Lien du frontend**: [Frontend du Quiz](<https://github.com/Elishaya13/Ynov.QuizYnov>)

## Fonctionnalit�s

- Stockage et gestion des questions de quiz dans diff�rentes cat�gories.
- Fourniture des donn�es n�cessaires pour que le frontend puisse �valuer les r�ponses des utilisateurs et afficher les r�sultats.

## Comment d�marrer

Pour ex�cuter ce projet localement, suivez les �tapes ci-dessous :

1. Clonez ce d�p�t sur votre machine locale.
2. Ouvrez le dossier du projet dans votre IDE pr�f�r�.
3. Restaurez les d�pendances en ex�cutant `dotnet restore`.
4. Lancez le serveur en ex�cutant `dotnet run`.

