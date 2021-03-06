-- MySQL Script generated by MySQL Workbench
-- 10/20/15 23:21:07
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema library
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema library
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `library` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `library` ;

-- -----------------------------------------------------
-- Table `library`.`books`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`books` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `title` NVARCHAR(100) NOT NULL COMMENT '',
  `author` NVARCHAR(50) NOT NULL COMMENT '',
  `publishDate` DATETIME NULL COMMENT '',
  `isbn` NVARCHAR(17) NULL COMMENT '',
  PRIMARY KEY (`id`)  COMMENT '')
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `library`.`books`
-- -----------------------------------------------------
START TRANSACTION;
USE `library`;
INSERT INTO `library`.`books` (`id`, `title`, `author`, `publishDate`, `isbn`) VALUES (1, 'A Game of Thrones', 'George R. R. Martin', '1996-08-06', '0-553-10354-7 ');
INSERT INTO `library`.`books` (`id`, `title`, `author`, `publishDate`, `isbn`) VALUES (2, 'A Clash of Kings', 'George R. R. Martin', '1998-11-16', '0-553-10803-4');
INSERT INTO `library`.`books` (`id`, `title`, `author`, `publishDate`, `isbn`) VALUES (3, 'A Storm of Swords', 'George R. R. Martin', '2000-08-08', '0-553-10663-5');
INSERT INTO `library`.`books` (`id`, `title`, `author`, `publishDate`, `isbn`) VALUES (4, 'A Feast for Crows', 'George R. R. Martin', '2005-10-17', '0-553-80150-3');
INSERT INTO `library`.`books` (`id`, `title`, `author`, `publishDate`, `isbn`) VALUES (5, 'A Dance with Dragons', 'George R. R. Martin', '2011-07-12', '0-553-80147-3 ');
INSERT INTO `library`.`books` (`id`, `title`, `author`, `publishDate`, `isbn`) VALUES (6, 'The Winds of Winter', 'George R. R. Martin', NULL, NULL);

COMMIT;

