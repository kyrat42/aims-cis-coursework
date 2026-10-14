CREATE DATABASE MOVIES;

USE MOVIES;

CREATE TABLE MOVIE
(
	MOVIE_ID DECIMAL(2,0) PRIMARY KEY,
	TITLE CHAR(60),
	YEAR DECIMAL(4,0),
	TYPE SET('Sci-Fi', 'Romance', 'Action', 'Horror', 'Drama', 'Fantasy', 'Comedy'),
	RATING CHAR(5),
	AWARD_NOMINATIONS DECIMAL(3,0),
	AWARDS_WON DECIMAL(3,0)
);

DESCRIBE MOVIE;

CREATE TABLE ACTOR
(
	ACTOR_ID DECIMAL(3,0) PRIMARY KEY,
	FIRST_NAME CHAR(20) NOT NULL,
	LAST_NAME CHAR(20) NOT NULL,
	BIRTH_DATE CHAR(10),
	DEATH_DATE CHAR	(10),
	BIRTH_PLACE CHAR(30)
);

DESCRIBE ACTOR;

CREATE TABLE DIRECTOR
(
	DIRECTOR_ID DECIMAL(3,0) PRIMARY KEY,
	FIRST_NAME CHAR(20) NOT NULL,
	LAST_NAME CHAR(20) NOT NULL,
	BIRTH_DATE CHAR(10),
	DEATH_DATE CHAR	(10)
);

DESCRIBE DIRECTOR;

CREATE TABLE ACTOR_ROLE 
(
	ACTOR_ID DECIMAL(3,0),
	MOVIE_ID DECIMAL(2,0),
	PRIMARY KEY (ACTOR_ID, MOVIE_ID)
);

ALTER TABLE ACTOR_ROLE
	ADD FOREIGN KEY (ACTOR_ID) REFERENCES ACTOR(ACTOR_ID),
	ADD FOREIGN KEY (MOVIE_ID) REFERENCES MOVIE(MOVIE_ID);

DESCRIBE ACTOR_ROLE;

CREATE TABLE DIRECTOR_ROLE 
(
	DIRECTOR_ID DECIMAL(3,0),
	MOVIE_ID DECIMAL(2,0),
	PRIMARY KEY (DIRECTOR_ID, MOVIE_ID)
);

ALTER TABLE DIRECTOR_ROLE
	ADD FOREIGN KEY (DIRECTOR_ID) REFERENCES DIRECTOR(DIRECTOR_ID),
	ADD FOREIGN KEY (MOVIE_ID) REFERENCES MOVIE(MOVIE_ID);

DESCRIBE DIRECTOR_ROLE;

CREATE USER Larry IDENTIFIED BY 'password';

CREATE USER Curly IDENTIFIED BY 'password';

CREATE USER Moe IDENTIFIED BY 'password';

GRANT SELECT, INSERT, UPDATE, DELETE, INDEX, ALTER ON MOVIE TO Larry;

GRANT SELECT, INSERT, UPDATE ON MOVIE TO Curly;

GRANT SELECT ON MOVIE TO Moe;

INSERT INTO MOVIE
	VALUES
		(01, "French Connection", 1971, "Action", "R", 8, 5),
		(02, "Star Wars - Return of the Jedi", 1983, "Sci-Fi", "PG", 11, 4),
		(03, "Harry Potter and the Goblet of Fire", 2005, "Fantasy", "PG 13", 28, 9),
		(04, "Lord of the Rings: The Fellowship of the Ring", 2001, "Fantasy", "PG 13", 76, 65),
		(05, "The Godfather", 1972, "Drama", "R", 17, 3),
		(06, "Silence of the Lambs", 1991, "Horror", "R", 27, 5),
		(07, "North Country", 2005, "Drama", "R", 2, 1),
		(08, "Memoirs of a Geisha", 2005, "Drama", "PG 13", 27, 3),
		(09, "Million Dollar Baby", 2004, "Drama", "PG 13", 44, 4),
		(10, "The Aviator", 2004, "Drama", "PG 13", 62, 5),
		(11, "Panic Room", 2002, "Drama", "R", 7, 1),
		(12, "Harry Potter and the Sorcerer's Stone", 2001, "Fantasy", "PG", 46, 13),
		(13, "O Brother Where Art Thou", 2000, "Comedy", "PG 13", 29, 6),
		(14, "Fargo", 1996, "Comedy", "R", 52, 2),
		(15, "Under the Tuscan Sun", 2003, "Romance", "PG 13", 5, 0);

INSERT INTO ACTOR
	VALUES
		(001, "Gene", "Hackman", "01/30/1930", NULL, "San Bernardino, CA"),
		(002, "Roy", "Scheider", "11/10/1932", "02/10/2008", "Orange, NJ"),
		(003, "Harrison", "Ford", "07/13/1942", NULL, "Chicago, IL"),
		(004, "Mark", "Hamill", "09/25/1951", NULL, "Concord, CA"),
		(005, "Carrie", "Fisher", "10/21/1956", "12/27/2016", "Burbank, CA"),
		(006, "Daniel", "Radcliffe", "07/23/1989", NULL, "UK"),
		(007, "Rupert", "Grint", "08/24/1988", NULL, "UK"),
		(008, "Emma", "Watson", "04/15/1990", NULL, "France"),
		(009, "Elijah", "Wood", "01/28/1981", NULL, "Cedar Rapids, IA"),
		(010, "Viggo", "Mortensen", "08/20/1958", NULL, "New York, NY"),
		(011, "Marlon", "Brando", "04/03/1924", "07/01/2004", "Omaha, NE"),
		(012, "Al", "Pacino", "04/25/1940", NULL, "New York, NY"),
		(013, "James", "Caan", "03/26/1940", NULL, "The Bronx, NY"),
		(014, "Diane", "Keaton", "01/05/1946", NULL, "Los Angeles, CA"),
		(015, "Anthony", "Hopkins", "12/31/1937", NULL, "UK"),
		(016, "Jodi", "Foster", "11/19/1962", NULL, "Los Angeles, CA"),
		(017, "Charlize", "Theron", "08/07/1975", NULL, "South Africa"),
		(018, "Frances", "McDormand", "06/23/1957", NULL, "Chicago, IL"),
		(019, "Ziyi", "Zhang", "02/09/1979", NULL, "China"),
		(020, "Ken", "Watanabe", "10/21/1959", NULL, "Japan"),
		(021, "Hillary", "Swank", "07/30/1974", NULL, "Lincoln, NE"),
		(022, "Clint", "Eastwood", "05/31/1930", NULL, "San Francisco, CA"),
		(023, "Leonardo", "DiCaprio", "11/11/1974", NULL, "Hollywood, CA"),
		(024, "Cate", "Blanchett", "05/14/1969", NULL, "Australia"),
		(025, "Forest", "Whitaker", "07/15/1961", NULL, "Longview, TX"),
		(026, "Kristen", "Stewart", "04/09/1990", NULL, "Los Angeles, CA"),
		(027, "George", "Clooney", "05/06/1962", NULL, "Lexington, KY"),
		(028, "John", "Turturro", "02/2//1957", NULL, "Brooklyn, NY"),
		(029, "Holly", "Hunter", "03/20/1958", NULL, "Conyers, GA"),
		(030, "Frances", "McDormand", "06/23/1957", NULL, "Chicago, IL"),
		(031, "William H", "Macy", "03/13/1950", NULL, "Miami, FL"),
		(032, "Steven", "Buscemi", "12/13/1957", NULL, "Brooklyn, NY"),
		(033, "Diane", "Lane", "01/22/1965", NULL, "New York, NY"),
		(034, "Sandra", "Oh", "07/20/1971", NULL, "Canada"),
		(035, "Lindsey", "Duncan", "11/07/1950", NULL, "UK"),
		(036, "Raoul", "Bova", "08/14/1971", NULL, "Italy");

INSERT INTO DIRECTOR
	VALUES
		(001, "William", "Friedkin", "08/25/1935", NULL),
		(002, "Richard", "Marquand", "04/17/1938", "09/04/1987"),
		(003, "Mike", "Newell", "03/28/1942", NULL),
		(004, "Peter", "Jackson", "08/31/1961", NULL),
		(005, "Francis Ford", "Coppola", "04/07/1939", NULL),
		(006, "Jonathan", "Demme", "02/22/1944", "04/26/2017"),
		(007, "Niki", "Caro", "01/01/1967", NULL),
		(008, "Rob", "Marshall", "10/17/1960", NULL),
		(009, "Clint", "Eastwood", "05/31/1930", NULL),
		(010, "Martin", "Scorsese", "11/17/1942", NULL),
		(011, "David", "Fincher", "09/28/1962", NULL),
		(012, "Chris", "Colombus", "09/10/1958", NULL),
		(013, "Joel", "Coen", "11/29/1954", NULL),
		(014, "Ethan", "Coen", "09/21/1957", NULL),
		(015, "Audrey", "Wells", "04/29/1960", NULL);

INSERT INTO ACTOR_ROLE
	VALUES
		(001, 01),
		(002, 01),
		(003, 02),
		(004, 02),
		(005, 02),
		(006, 03),
		(007, 03),
		(008, 03),
		(009, 04),
		(010, 04),
		(011, 05),
		(012, 05),
		(013, 05),
		(014, 05),
		(015, 06),
		(016, 06),
		(017, 07),
		(018, 07),
		(019, 08),
		(020, 08),
		(021, 09),
		(022, 09),
		(023, 10),
		(024, 10),
		(016, 11),
		(025, 11),
		(026, 11),
		(006, 12),
		(007, 12), 
		(008, 12),
		(027, 13),
		(028, 13),
		(029, 13), 
		(030, 14),
		(031, 14),
		(032, 14),
		(033, 15),
		(034, 15),
		(035, 15),
		(036, 15);

INSERT INTO DIRECTOR_ROLE
	VALUES
		(001, 01),
		(002, 02),
		(003, 03),
		(004, 04),
		(005, 05),
		(006, 06),
		(007, 07),
		(008, 08),
		(009, 09),
		(010, 10),
		(011, 11),
		(012, 12),
		(013, 13),
		(014, 13),
		(013, 14),
		(014, 14),
		(015, 15);

SELECT * FROM MOVIE;

SELECT * FROM ACTOR;

SELECT * FROM DIRECTOR;

SELECT * FROM ACTOR_ROLE;

SELECT * FROM DIRECTOR_ROLE;

CREATE VIEW READ_ONLY AS
	SELECT MOVIE_ID AS ID, TITLE, YEAR, TYPE
		FROM MOVIE;

SELECT * 
	FROM READ_ONLY
		WHERE YEAR = 2005;

CREATE VIEW AWARD_COUNTS AS
	SELECT MOVIE.MOVIE_ID AS ID, TITLE, DIRECTOR_ID, RATING, AWARD_NOMINATIONS, AWARDS_WON
		FROM MOVIE, DIRECTOR_ROLE
			WHERE DIRECTOR_ROLE.MOVIE_ID = MOVIE.MOVIE_ID;

SELECT * 
	FROM AWARD_COUNTS
		WHERE TITLE = "Million Dollar Baby";

CREATE VIEW ACTORS_IN_MOVIES AS
	SELECT ACTOR.ACTOR_ID, FIRST_NAME, LAST_NAME, ACTOR_ROLE.MOVIE_ID, TITLE
		FROM ACTOR, ACTOR_ROLE, MOVIE
			WHERE ACTOR.ACTOR_ID = ACTOR_ROLE.ACTOR_ID AND
				ACTOR_ROLE.MOVIE_ID = MOVIE.MOVIE_ID; 

SELECT *
	FROM ACTORS_IN_MOVIES
		WHERE FIRST_NAME = "Carrie" AND
			LAST_NAME = "Fisher";

SELECT MOVIE.MOVIE_ID, TITLE, YEAR, CONCAT(DIRECTOR.FIRST_NAME, ' ', DIRECTOR.LAST_NAME) AS DIRECTOR, CONCAT(ACTOR.FIRST_NAME, ' ', ACTOR.LAST_NAME) AS ACTOR
	FROM MOVIE, DIRECTOR_ROLE, DIRECTOR, ACTOR_ROLE, ACTOR
		WHERE RATING = "PG 13" AND
			DIRECTOR_ROLE.MOVIE_ID = MOVIE.MOVIE_ID AND
			DIRECTOR_ROLE.DIRECTOR_ID = DIRECTOR.DIRECTOR_ID AND
			ACTOR_ROLE.ACTOR_ID = ACTOR.ACTOR_ID AND
			ACTOR_ROLE.MOVIE_ID = MOVIE.MOVIE_ID;

SELECT TITLE, CONCAT(FIRST_NAME, ' ', LAST_NAME) AS DIRECTOR, YEAR, RATING
	FROM MOVIE, DIRECTOR, DIRECTOR_ROLE
		WHERE MOVIE.MOVIE_ID = DIRECTOR_ROLE.MOVIE_ID AND
			DIRECTOR_ROLE.DIRECTOR_ID = DIRECTOR.DIRECTOR_ID AND
			DIRECTOR.DIRECTOR_ID IN 
			(SELECT DIRECTOR_ID
				FROM DIRECTOR
					WHERE FIRST_NAME = "Clint" AND
					LAST_NAME = "Eastwood");