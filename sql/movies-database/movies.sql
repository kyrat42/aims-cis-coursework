CREATE DATABASE  IF NOT EXISTS `movies` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `movies`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: movies
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `actor`
--

DROP TABLE IF EXISTS `actor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `actor` (
  `ACTOR_ID` decimal(3,0) NOT NULL,
  `FIRST_NAME` char(20) NOT NULL,
  `LAST_NAME` char(20) NOT NULL,
  `BIRTH_DATE` char(10) DEFAULT NULL,
  `DEATH_DATE` char(10) DEFAULT NULL,
  `BIRTH_PLACE` char(30) DEFAULT NULL,
  PRIMARY KEY (`ACTOR_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actor`
--

LOCK TABLES `actor` WRITE;
/*!40000 ALTER TABLE `actor` DISABLE KEYS */;
INSERT INTO `actor` VALUES (1,'Gene','Hackman','01/30/1930',NULL,'San Bernardino, CA'),(2,'Roy','Scheider','11/10/1932','02/10/2008','Orange, NJ'),(3,'Harrison','Ford','07/13/1942',NULL,'Chicago, IL'),(4,'Mark','Hamill','09/25/1951',NULL,'Concord, CA'),(5,'Carrie','Fisher','10/21/1956','12/27/2016','Burbank, CA'),(6,'Daniel','Radcliffe','07/23/1989',NULL,'UK'),(7,'Rupert','Grint','08/24/1988',NULL,'UK'),(8,'Emma','Watson','04/15/1990',NULL,'France'),(9,'Elijah','Wood','01/28/1981',NULL,'Cedar Rapids, IA'),(10,'Viggo','Mortensen','08/20/1958',NULL,'New York, NY'),(11,'Marlon','Brando','04/03/1924','07/01/2004','Omaha, NE'),(12,'Al','Pacino','04/25/1940',NULL,'New York, NY'),(13,'James','Caan','03/26/1940',NULL,'The Bronx, NY'),(14,'Diane','Keaton','01/05/1946',NULL,'Los Angeles, CA'),(15,'Anthony','Hopkins','12/31/1937',NULL,'UK'),(16,'Jodi','Foster','11/19/1962',NULL,'Los Angeles, CA'),(17,'Charlize','Theron','08/07/1975',NULL,'South Africa'),(18,'Frances','McDormand','06/23/1957',NULL,'Chicago, IL'),(19,'Ziyi','Zhang','02/09/1979',NULL,'China'),(20,'Ken','Watanabe','10/21/1959',NULL,'Japan'),(21,'Hillary','Swank','07/30/1974',NULL,'Lincoln, NE'),(22,'Clint','Eastwood','05/31/1930',NULL,'San Francisco, CA'),(23,'Leonardo','DiCaprio','11/11/1974',NULL,'Hollywood, CA'),(24,'Cate','Blanchett','05/14/1969',NULL,'Australia'),(25,'Forest','Whitaker','07/15/1961',NULL,'Longview, TX'),(26,'Kristen','Stewart','04/09/1990',NULL,'Los Angeles, CA'),(27,'George','Clooney','05/06/1962',NULL,'Lexington, KY'),(28,'John','Turturro','02/2//1957',NULL,'Brooklyn, NY'),(29,'Holly','Hunter','03/20/1958',NULL,'Conyers, GA'),(30,'Frances','McDormand','06/23/1957',NULL,'Chicago, IL'),(31,'William H','Macy','03/13/1950',NULL,'Miami, FL'),(32,'Steven','Buscemi','12/13/1957',NULL,'Brooklyn, NY'),(33,'Diane','Lane','01/22/1965',NULL,'New York, NY'),(34,'Sandra','Oh','07/20/1971',NULL,'Canada'),(35,'Lindsey','Duncan','11/07/1950',NULL,'UK'),(36,'Raoul','Bova','08/14/1971',NULL,'Italy');
/*!40000 ALTER TABLE `actor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `actor_role`
--

DROP TABLE IF EXISTS `actor_role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `actor_role` (
  `ACTOR_ID` decimal(3,0) NOT NULL,
  `MOVIE_ID` decimal(2,0) NOT NULL,
  PRIMARY KEY (`ACTOR_ID`,`MOVIE_ID`),
  KEY `MOVIE_ID` (`MOVIE_ID`),
  CONSTRAINT `actor_role_ibfk_1` FOREIGN KEY (`ACTOR_ID`) REFERENCES `actor` (`ACTOR_ID`),
  CONSTRAINT `actor_role_ibfk_2` FOREIGN KEY (`MOVIE_ID`) REFERENCES `movie` (`MOVIE_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actor_role`
--

LOCK TABLES `actor_role` WRITE;
/*!40000 ALTER TABLE `actor_role` DISABLE KEYS */;
INSERT INTO `actor_role` VALUES (1,1),(2,1),(3,2),(4,2),(5,2),(6,3),(7,3),(8,3),(9,4),(10,4),(11,5),(12,5),(13,5),(14,5),(15,6),(16,6),(17,7),(18,7),(19,8),(20,8),(21,9),(22,9),(23,10),(24,10),(16,11),(25,11),(26,11),(6,12),(7,12),(8,12),(27,13),(28,13),(29,13),(30,14),(31,14),(32,14),(33,15),(34,15),(35,15),(36,15);
/*!40000 ALTER TABLE `actor_role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `director`
--

DROP TABLE IF EXISTS `director`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `director` (
  `DIRECTOR_ID` decimal(3,0) NOT NULL,
  `FIRST_NAME` char(20) NOT NULL,
  `LAST_NAME` char(20) NOT NULL,
  `BIRTH_DATE` char(10) DEFAULT NULL,
  `DEATH_DATE` char(10) DEFAULT NULL,
  PRIMARY KEY (`DIRECTOR_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `director`
--

LOCK TABLES `director` WRITE;
/*!40000 ALTER TABLE `director` DISABLE KEYS */;
INSERT INTO `director` VALUES (1,'William','Friedkin','08/25/1935',NULL),(2,'Richard','Marquand','04/17/1938','09/04/1987'),(3,'Mike','Newell','03/28/1942',NULL),(4,'Peter','Jackson','08/31/1961',NULL),(5,'Francis Ford','Coppola','04/07/1939',NULL),(6,'Jonathan','Demme','02/22/1944','04/26/2017'),(7,'Niki','Caro','01/01/1967',NULL),(8,'Rob','Marshall','10/17/1960',NULL),(9,'Clint','Eastwood','05/31/1930',NULL),(10,'Martin','Scorsese','11/17/1942',NULL),(11,'David','Fincher','09/28/1962',NULL),(12,'Chris','Colombus','09/10/1958',NULL),(13,'Joel','Coen','11/29/1954',NULL),(14,'Ethan','Coen','09/21/1957',NULL),(15,'Audrey','Wells','04/29/1960',NULL);
/*!40000 ALTER TABLE `director` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `director_role`
--

DROP TABLE IF EXISTS `director_role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `director_role` (
  `DIRECTOR_ID` decimal(3,0) NOT NULL,
  `MOVIE_ID` decimal(2,0) NOT NULL,
  PRIMARY KEY (`DIRECTOR_ID`,`MOVIE_ID`),
  KEY `MOVIE_ID` (`MOVIE_ID`),
  CONSTRAINT `director_role_ibfk_1` FOREIGN KEY (`DIRECTOR_ID`) REFERENCES `director` (`DIRECTOR_ID`),
  CONSTRAINT `director_role_ibfk_2` FOREIGN KEY (`MOVIE_ID`) REFERENCES `movie` (`MOVIE_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `director_role`
--

LOCK TABLES `director_role` WRITE;
/*!40000 ALTER TABLE `director_role` DISABLE KEYS */;
INSERT INTO `director_role` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9),(10,10),(11,11),(12,12),(13,13),(14,13),(13,14),(14,14),(15,15);
/*!40000 ALTER TABLE `director_role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movie`
--

DROP TABLE IF EXISTS `movie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movie` (
  `MOVIE_ID` decimal(2,0) NOT NULL,
  `TITLE` char(60) DEFAULT NULL,
  `YEAR` decimal(4,0) DEFAULT NULL,
  `TYPE` set('Sci-Fi','Romance','Action','Horror','Drama','Fantasy','Comedy') DEFAULT NULL,
  `RATING` char(5) DEFAULT NULL,
  `AWARD_NOMINATIONS` decimal(3,0) DEFAULT NULL,
  `AWARDS_WON` decimal(3,0) DEFAULT NULL,
  PRIMARY KEY (`MOVIE_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movie`
--

LOCK TABLES `movie` WRITE;
/*!40000 ALTER TABLE `movie` DISABLE KEYS */;
INSERT INTO `movie` VALUES (1,'French Connection',1971,'Action','R',8,5),(2,'Star Wars - Return of the Jedi',1983,'Sci-Fi','PG',11,4),(3,'Harry Potter and the Goblet of Fire',2005,'Fantasy','PG 13',28,9),(4,'Lord of the Rings: The Fellowship of the Ring',2001,'Fantasy','PG 13',76,65),(5,'The Godfather',1972,'Drama','R',17,3),(6,'Silence of the Lambs',1991,'Horror','R',27,5),(7,'North Country',2005,'Drama','R',2,1),(8,'Memoirs of a Geisha',2005,'Drama','PG 13',27,3),(9,'Million Dollar Baby',2004,'Drama','PG 13',44,4),(10,'The Aviator',2004,'Drama','PG 13',62,5),(11,'Panic Room',2002,'Drama','R',7,1),(12,'Harry Potter and the Sorcerer\'s Stone',2001,'Fantasy','PG',46,13),(13,'O Brother Where Art Thou',2000,'Comedy','PG 13',29,6),(14,'Fargo',1996,'Comedy','R',52,2),(15,'Under the Tuscan Sun',2003,'Romance','PG 13',5,0);
/*!40000 ALTER TABLE `movie` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-07-31 11:36:35
