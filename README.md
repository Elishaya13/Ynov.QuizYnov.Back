# Backend du Quiz pour Ynov Campus

Ce dépôt contient le backend d'une application de quiz développée en .NET pour un projet scolaire à Ynov Campus. Ce backend gère les questions et réponses des quiz classées par catégories.

## À propos du projet

Ce projet de backend est développé en .NET et sert de base de données et de logique métier pour un quiz en ligne. Il stocke les questions et réponses, organisées en différentes catégories, permettant ainsi une navigation et une interaction faciles pour l'utilisateur final.

## Frontend

Le frontend de l'application est développé en Angular et est conçu pour interagir avec ce backend. Il fournit une interface utilisateur pour participer aux quiz et gère l'évaluation des réponses en comparant les choix de l'utilisateur avec la propriété `isCorrect` des réponses stockées pour chaque question.

- **Lien du frontend**: [Frontend du Quiz](<https://github.com/Elishaya13/Ynov.QuizYnov>)

## Fonctionnalités

- Stockage et gestion des questions de quiz dans différentes catégories.
- Fourniture des données nécessaires pour que le frontend puisse évaluer les réponses des utilisateurs et afficher les résultats.

## Comment démarrer

Pour exécuter ce projet localement, suivez les étapes ci-dessous :

1. Clonez ce dépôt sur votre machine locale.
2. Ouvrez le dossier du projet dans votre IDE préféré.
3. Restaurez les dépendances en exécutant `dotnet restore`.
4. Lancez le serveur en exécutant `dotnet run`.

