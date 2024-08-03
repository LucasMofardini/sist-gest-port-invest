CREATE DATABASE IF NOT EXISTS gest_port_invest;

use gest_port_invest;

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `CustomerId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(120) NOT NULL,
  `PhoneNumber` varchar(14) DEFAULT NULL,
  `IdentificationNumber` varchar(14) NOT NULL,
  `PostalCode` varchar(8) DEFAULT NULL,
  `Email` varchar(60) NOT NULL,
  `Balance` decimal(15,2) NOT NULL,
  `IsActive` tinyint DEFAULT NULL,
  PRIMARY KEY (`CustomerId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `EmployeeId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(90) NOT NULL,
  `Email` varchar(65) NOT NULL,
  `AdmissionDate` datetime NOT NULL,
  `Sallary` decimal(15,2) NOT NULL,
  `Role` int NOT NULL,
  PRIMARY KEY (`EmployeeId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `financialproduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `financialproduct` (
  `FinancialProductId` int NOT NULL AUTO_INCREMENT,
  `UnitPrice` decimal(10,0) NOT NULL,
  `Quantity` int NOT NULL,
  `Description` varchar(100) NOT NULL,
  `CreatedDate` datetime NOT NULL,
  `LastUpdatedDate` datetime NOT NULL,
  `CategoryType` int NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Status` int NOT NULL,
  PRIMARY KEY (`FinancialProductId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `investmentpurchase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `investmentpurchase` (
  `InvestmentId` int NOT NULL AUTO_INCREMENT,
  `FinancialProductId` int NOT NULL,
  `CustomerId` int NOT NULL,
  `EmployeeId` int NOT NULL,
  `Quantity` int NOT NULL,
  `ProductUnitPrice` decimal(15,2) NOT NULL,
  `ProductAmountPrice` decimal(15,2) NOT NULL,
  `IsActive` tinyint(1) DEFAULT NULL,
  `MaturityDate` datetime NOT NULL,
  PRIMARY KEY (`InvestmentId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


INSERT INTO Customer (Name, PhoneNumber, IdentificationNumber, PostalCode, Email, Balance, IsActive) VALUES ('Alice Smith', '11987654321', '12345678901', '98765432', 'alice.smith@gmail.com', 250000.50, true);
INSERT INTO Customer (Name, PhoneNumber, IdentificationNumber, PostalCode, Email, Balance, IsActive) VALUES ('Bob Johnson', '21987654322', '23456789012', '87654321', 'bob.johnson@outlook.com', 50000.75, false);
INSERT INTO Customer (Name, PhoneNumber, IdentificationNumber, PostalCode, Email, Balance, IsActive) VALUES ('Charlie Williams', '31987654323', '34567890123', '76543210', 'charlie.williams@yahoo.com.br', 750000.00, true);
INSERT INTO Customer (Name, PhoneNumber, IdentificationNumber, PostalCode, Email, Balance, IsActive) VALUES ('Diana Brown', '71987654324', '45678901234', '65432109', 'diana.brown@gmail.com', 120000.25, false);
INSERT INTO Customer (Name, PhoneNumber, IdentificationNumber, PostalCode, Email, Balance, IsActive) VALUES ('Edward Jones', '81987654325', '56789012345', '54321098', 'edward.jones@outlook.com', 300000.00, true);
INSERT INTO Customer (Name, PhoneNumber, IdentificationNumber, PostalCode, Email, Balance, IsActive) VALUES ('Fiona Garcia', '61987654326', '67890123456', '43210987', 'fiona.garcia@yahoo.com.br', 450000.10, true);
INSERT INTO Customer (Name, PhoneNumber, IdentificationNumber, PostalCode, Email, Balance, IsActive) VALUES ('George Miller', '81987654327', '78901234567', '32109876', 'george.miller@gmail.com', 85000.55, false);
INSERT INTO Customer (Name, PhoneNumber, IdentificationNumber, PostalCode, Email, Balance, IsActive) VALUES ('Hannah Davis', '31987654328', '89012345678', '21098765', 'hannah.davis@outlook.com', 920000.35, true);
INSERT INTO Customer (Name, PhoneNumber, IdentificationNumber, PostalCode, Email, Balance, IsActive) VALUES ('Isabel Martin', '11987654329', '90123456789', '10987654', 'isabel.martin@yahoo.com.br', 370000.00, true);
INSERT INTO Customer (Name, PhoneNumber, IdentificationNumber, PostalCode, Email, Balance, IsActive) VALUES ('Jack Thompson', '21987654330', '01234567890', '09876543', 'jack.thompson@gmail.com', 800000.75, false);


INSERT INTO employee (Name, Email, Role, AdmissionDate, Sallary)
VALUES ('João Silva', 'joao.silva@example.com', 1, '2024-08-01 09:00:00', 5000.00);

INSERT INTO employee (Name, Email, Role, AdmissionDate, Sallary)
VALUES ('Maria Oliveira', 'maria.oliveira@example.com', 2, '2024-07-15 08:30:00', 6000.00);

INSERT INTO employee (Name, Email, Role, AdmissionDate, Sallary)
VALUES ('Carlos Santos', 'carlos.santos@example.com', 3, '2024-06-20 10:00:00', 4500.00);

INSERT INTO financialproduct (UnitPrice, Quantity, Description, Name, CreatedDate, LastUpdatedDate, CategoryType, Status)
VALUES (100.00, 50, 'Criptomoeda', 'BITCOIN', '2024-08-01 08:00:00', '2024-08-01 08:00:00', 1, 1);