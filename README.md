# Application Mediatek86  
Application C# écrite sous Visual Studio 2019 Entreprise et exploitant une BDD MySQL.
## Présentation de l'application
### Présentation du contexte
L'entreprise cliente (MediaTek86) est un réseau qui gère les médiathèques de la Vienne, et qui a pour rôle de fédérer les prêts de livres, DVD et CD et de développer la médiathèque numérique pour l’ensemble des médiathèques du département.
### But de l'application
MediaTek86 souhaite avoir une application de bureau qui permettra de gérer le personnel de chaque médiathèque, leur affectation à un service et leurs absences.  
L'application doit permettre de :
* Présenter la liste du personnel avec le service auquel ils sont affectés
* Ajouter, supprimer ou modifier les membres du personnel
* Présenter les absences pour chaque membre du personnel avec le motif
* Ajouter, supprimer ou modifier les absences
### Structure de la BDD
Voici le schéma conceptuel de données présentant la structure de la BDD qui est au format MySQL :
<img width="545" height="485" alt="image" src="https://github.com/user-attachments/assets/9507b612-aa75-46da-a290-68191cef7ffe" />
### Interface
Voici à quoi ressemble l'interface de l'application :
<img width="740" height="892" alt="image" src="https://github.com/user-attachments/assets/4c50bf6c-008f-45f6-ab9e-6d7ab7129fa1" />
### Diagramme de paquetage
L'application est structurée dans le respect du pattern MVC.
<img width="937" height="656" alt="image" src="https://github.com/user-attachments/assets/7be08c1d-9e96-4a66-bc37-00c06980ea07" />
### Explication sur les couches supplémentaire
L'application contient 2 paquetages supplémentaires par rapport au MVC classique :  
. 'bddmanager' : contient la classe qui permet d'accéder à la base de données MySQL et d'exécuter les requêtes (classe indépendante et réutilisable).  
. 'dal' (Data Access Layer) : répond aux demandes du paquetage 'controller' et exploite 'bddmanager' en lui demandant d'exécuter des requêtes.  
L'avantage de cette architecture est l'isolement de la connexion (bddmanager) par rapport au reste de l'application. Le controleur ne sait pas d'où viennent les données (cela pourrait être un autre SGBDR, voire un autre type de fichier, comme XML). Le paquetage 'dal' fait l'intermédiaire en préparant des requêtes SQL. Donc on sait dans les classes de ce paquetage, qu'il est question d'une base de données relationnelle, mais ne sait pas non plus quel est le SGBDR utilisé.  
Changer de SGBDR reviendrait à juste changer la classe BddManager (son contenu), donc ne travailler que sur le paquetage 'bddmanager'.  
Changer de type de fichier reviendrait à changer aussi les classes du paquetage 'dal', sans toucher au reste de l'application.  
## Installation
Il est possible de tester l'application étape par étape (commit par commit) ou de tester directement la version finale.  
Pour tester une version dans un environnement de développement, il faut d'abord installer les outils suivants :  
. SGBDR MySQL (par exemple en installant WAMP ou un logiciel similaire)  
. De préférence un IDE pour manipuler le code (cette application a été réalisée sous Visual Studio 2022)  
Il faut ensuite :  
. Dans MySQL, exécuter le script contenu dans mediatek866_bdd.sql (présent en racine du dépôt) pour créer et remplir la BDD.
. Récupérer le code du commit voulu, l'ouvrir dans l'IDE et l'exécuter.  

__Voici le login et le mot de passe pour s'authentifier dans l'application:__  
. login: mediatekres  
. mdp: mediatek86
