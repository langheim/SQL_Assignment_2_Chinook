/*Adding superheroPowers*/
INSERT INTO Superpower (nameSuperpower, descriptionSuperpower)
VALUES ('Telekinesis','Being able to move simple and large objects with their mind to moving entire planets if she desired.')

INSERT INTO Superpower (nameSuperpower, descriptionSuperpower)
VALUES ('Super Strength','Be able to pick up a car and throw it the length of a football field.')

INSERT INTO Superpower (nameSuperpower, descriptionSuperpower)
VALUES ('Super Speed','Being able to move quickly means that a hero is also one step ahead of the villain')

INSERT INTO Superpower (nameSuperpower, descriptionSuperpower)
VALUES ('Healing','A superhero who can heal never has to worry about a heart attack, kidney failure, infection, or the like')

INSERT INTO Superpower (nameSuperpower, descriptionSuperpower)
VALUES ('Shapeshifting','Be able to infiltrate high levels of government, concealment, and align with whomever they choose')

INSERT INTO Superpower (nameSuperpower, descriptionSuperpower)
VALUES ('Invisibility','Invisibility does exactly what it sounds like it does. It allows the superhero to disappear from plain sight')

INSERT INTO LinkSuperheroAndSuperpower (idSuperhero, idSuperpower)
VALUES (1, 1)
INSERT INTO LinkSuperheroAndSuperpower (idSuperhero, idSuperpower)
VALUES (2,2)
INSERT INTO LinkSuperheroAndSuperpower (idSuperhero, idSuperpower)
VALUES (3, 3)
INSERT INTO LinkSuperheroAndSuperpower (idSuperhero, idSuperpower)
VALUES (4, 4)
INSERT INTO LinkSuperheroAndSuperpower (idSuperhero, idSuperpower)
VALUES (5, 5)
GO


/* One superhero can have multiple powers*/

INSERT INTO LinkSuperheroAndSuperpower (idSuperhero, idSuperpower)
VALUES (3, 2)

SELECT * FROM LinkSuperheroAndSuperpower
