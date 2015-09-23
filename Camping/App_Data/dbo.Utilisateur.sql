CREATE TABLE [dbo].[Utilisateur]
(
	[id_user] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nom_user] VARCHAR(100) NOT NULL, 
    [prenom_user] VARCHAR(100) NOT NULL, 
    [mail_user] VARCHAR(100) NOT NULL, 
    [motdepasse_user] VARCHAR(100) NOT NULL
)
