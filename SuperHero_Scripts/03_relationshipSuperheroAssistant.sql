/* Adding relationship*/
USE SuperheroesDb
GO
ALTER TABLE Assistant
	ADD idSuperhero int
GO
ALTER TABLE Assistant
	ADD CONSTRAINT FK_Assistant_Superhero
	FOREIGN KEY (idSuperhero) REFERENCES Superhero(idSuperhero)
