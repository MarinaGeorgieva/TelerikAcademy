-- MySQL Script generated by MySQL Workbench
-- 10/07/15 02:26:35
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema university
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema university
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `university` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `university` ;

-- -----------------------------------------------------
-- Table `university`.`universities`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`universities` (
  `UniversityId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(100) NOT NULL COMMENT '',
  PRIMARY KEY (`UniversityId`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`faculties` (
  `FacultyId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(100) NOT NULL COMMENT '',
  `UniversityId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`FacultyId`)  COMMENT '',
  INDEX `_idx` (`UniversityId` ASC)  COMMENT '',
  CONSTRAINT ``
    FOREIGN KEY (`UniversityId`)
    REFERENCES `university`.`universities` (`UniversityId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`departments` (
  `DepartmentId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(100) NOT NULL COMMENT '',
  `FacultyId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`DepartmentId`)  COMMENT '',
  INDEX `FacultyId_idx` (`FacultyId` ASC)  COMMENT '',
  CONSTRAINT `FacultyId`
    FOREIGN KEY (`FacultyId`)
    REFERENCES `university`.`faculties` (`FacultyId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`professors` (
  `ProfessorId` INT NOT NULL COMMENT '',
  `Name` NVARCHAR(100) NOT NULL COMMENT '',
  `DepartmentId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`ProfessorId`)  COMMENT '',
  INDEX `DepartmentId_idx` (`DepartmentId` ASC)  COMMENT '',
  CONSTRAINT `DepartmentId`
    FOREIGN KEY (`DepartmentId`)
    REFERENCES `university`.`departments` (`DepartmentId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`titles` (
  `TitleId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`TitleId`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`titles_professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`titles_professors` (
  `TitleId` INT NOT NULL COMMENT '',
  `ProfessorId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`TitleId`, `ProfessorId`)  COMMENT '',
  INDEX `ProfessorId_idx` (`ProfessorId` ASC)  COMMENT '',
  CONSTRAINT `ProfessorId`
    FOREIGN KEY (`ProfessorId`)
    REFERENCES `university`.`professors` (`ProfessorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `TitleId`
    FOREIGN KEY (`TitleId`)
    REFERENCES `university`.`titles` (`TitleId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`students_courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`students_courses` (
  `StudentId` INT NOT NULL COMMENT '',
  `CourseId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`StudentId`, `CourseId`)  COMMENT '',
  INDEX `CourseId_idx` (`CourseId` ASC)  COMMENT '',
  CONSTRAINT `CourseId`
    FOREIGN KEY (`CourseId`)
    REFERENCES `university`.`courses` (`CourseId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `StudentId`
    FOREIGN KEY (`StudentId`)
    REFERENCES `university`.`students` (`StudentId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`students` (
  `StudentId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(100) NOT NULL COMMENT '',
  `FacultyId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`StudentId`)  COMMENT '',
  INDEX `FacultyId_idx` (`FacultyId` ASC)  COMMENT '',
  CONSTRAINT `FacultyId`
    FOREIGN KEY (`FacultyId`)
    REFERENCES `university`.`faculties` (`FacultyId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`courses` (
  `CourseId` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(150) NOT NULL COMMENT '',
  `DepartmentId` INT NOT NULL COMMENT '',
  `ProfessorId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`CourseId`)  COMMENT '',
  INDEX `DepartmentId_idx` (`DepartmentId` ASC)  COMMENT '',
  INDEX `ProfessorId_idx` (`ProfessorId` ASC)  COMMENT '',
  CONSTRAINT `DepartmentId`
    FOREIGN KEY (`DepartmentId`)
    REFERENCES `university`.`departments` (`DepartmentId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ProfessorId`
    FOREIGN KEY (`ProfessorId`)
    REFERENCES `university`.`professors` (`ProfessorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;