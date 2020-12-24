-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: tabela
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `korisnici`
--

DROP TABLE IF EXISTS `korisnici`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `korisnici` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Ime` varchar(15) NOT NULL,
  `Prezime` varchar(20) NOT NULL,
  `KorIme` varchar(50) NOT NULL,
  `SifraBol` varchar(40) NOT NULL,
  `SHA256Hash` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `KorIme` (`KorIme`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `korisnici`
--

LOCK TABLES `korisnici` WRITE;
/*!40000 ALTER TABLE `korisnici` DISABLE KEYS */;
INSERT INTO `korisnici` VALUES (1,'Jelena','Stojanović','doc1','A122',''),(2,'Pera','Mitić','doc2','A12',''),(3,'Mika','Mitic','doc3','A11',''),(4,'Laza','Lazic','doc4','A13',''),(5,'Marija','Savic','doc5','A14',''),(6,'Marija','Minic','doc6','A14',''),(7,'Jovan','Kesic','doc7','A14',''),(8,'Nikola','Dinic','doc8','A11',''),(9,'Milos','Antic','doc9','A15',''),(10,'Sasa','Savic','doc10','A16',''),(11,'Goran','Jovanovic','doc11','A16',''),(12,'Slobodan','Bjelic','doc12','A12',''),(13,'Ilija','Milic','doc13','A13',''),(14,'Nina','Todorovic','doc14','A13',''),(15,'Zoi','Nedic','doc15','A14',''),(16,'Katarina','Lazic','doc16','A15',''),(17,'Marija','Krunic','doc17','A15',''),(18,'Jelena','Bosic','doc18','A17',''),(19,'Jelena','Mitic','proba','proba',''),(20,'Pera','Peric','Pera','A11',''),(21,'','','ana','A12',''),(22,'Jelena','Mitic','doc20','A12',''),(23,'Sava','Savic','doc25','A12',''),(24,'Sava ','Savić','doc124','A123',''),(25,'jelena','stojanov','jjj','dasd',''),(26,'dffdsf','dgd','fdsf','gdgd',''),(27,'proba','','','proba',''),(28,'proba','proba','proba2','proba',''),(29,'proba','proba','proba3','proba',''),(30,'Sloba','Andon','doc111','A12',''),(31,'Sloba','Andon','doc123','A12',''),(32,'Jelena','Jelena','Jelena','A256','2cd8723806548a63923b0dbb23e783b09077f64d23b84064c8f9580d593ca20d'),(33,'Jelena','Mitić','Jelena111','A22','6f47319f9344aab1670fbd2dddd18f87ab031dae81f02d2a34699942441ee921'),(34,'Ognjen','Tajcic','dr123','A123','03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4');
/*!40000 ALTER TABLE `korisnici` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacijenti`
--

DROP TABLE IF EXISTS `pacijenti`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pacijenti` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Ime` varchar(20) NOT NULL,
  `Prezime` varchar(30) NOT NULL,
  `JMBG` varchar(13) NOT NULL,
  `BrTel` varchar(12) NOT NULL,
  `LBO` varchar(11) NOT NULL,
  `PoslednjiTest` varchar(10) NOT NULL,
  `RezultatTesta` varchar(10) NOT NULL,
  `Oporavljen` varchar(3) NOT NULL,
  `PodlegaoBolesti` varchar(3) NOT NULL,
  `BezSimptoma` varchar(3) NOT NULL,
  `Dijabetes` varchar(3) NOT NULL,
  `KVProblemi` varchar(3) NOT NULL,
  `PlucneBolesti` varchar(3) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacijenti`
--

LOCK TABLES `pacijenti` WRITE;
/*!40000 ALTER TABLE `pacijenti` DISABLE KEYS */;
INSERT INTO `pacijenti` VALUES (1,'Milan','Mitić','2205995735920','0605070022','002255333','1/5/2020','Negativan','Da','Ne','Da','Ne','Da','Ne'),(2,'Petar','Merić','1205995733024','0605070000','002255322','2/10/2020','Pozitivan','Ne','Ne','Ne','Da','Ne','Ne'),(3,'Jovan','Savić','1105965732211','0636020022','002235333','9/12/2020','Pozitivan','Ne','Da','Ne','Da','Da','Da'),(4,'Sanja','Lazić','1210961122432','0605030022','023255333','17/12/2020','Pozitivan','Da','Ne','Da','Ne','Ne','Da'),(7,'Ana','Stevic','4636345','54334343','43643645','5/11/2020','Negativan','Ne','Ne','Ne','Ne','Da','Ne'),(8,'Misa','Kostic','0107963963214','060235478','00214532','4/11/2020','Pozitivan','Ne','Ne','Ne','Ne','Ne','Da'),(9,'Mina','Ilic','2601989635214','063258741','5521456321','12/11/2020','Negativan','Da','Ne','Da','Ne','Ne','Ne'),(12,'Sima ','Simic','1205995735028','063258978','123146','25/12/2020','Negativan','Ne','Ne','Ne','Ne','Da','Da'),(13,'Misa','Misic','1205995735029','062154845','123548454','25/12/2020','Negativan','Da','Ne','Da','Ne','Ne','Ne'),(14,'Mima','Minic','0501998730073','063256321','1122334455','16/12/2020','Negativan','Ne','Ne','Ne','Ne','Ne','Da'),(15,'Filip','Filipovic','1205995735029','16466434','3648348364','4/12/2020','Negativan','Ne','Ne','Ne','Ne','Ne','Ne'),(16,'Petar','Merić','1205995735028','0605070000','00225532221','2/10/2020','Pozitivan','Ne','Ne','Ne','Da','Ne','Ne'),(17,'Milan','Mitić','1205995735028','0605070022','00225533311','1/5/2020','Negativan','Da','Ne','Da','Ne','Da','Ne'),(18,'Milan','Mitić','1205995735028','0605070022','00225533311','1/5/2020','Negativan','Da','Ne','Da','Ne','Da','Ne'),(19,'Milan','Mitić','1205995735028','0605070022','00225533312','1/5/2020','Negativan','Da','Ne','Da','Ne','Da','Ne'),(20,'Milan','Mitić','1205995735028','0605070022','00225533325','1/5/2020','Negativan','Da','Ne','Da','Ne','Da','Ne');
/*!40000 ALTER TABLE `pacijenti` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-24  1:09:41
