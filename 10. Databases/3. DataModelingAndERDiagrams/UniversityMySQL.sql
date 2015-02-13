-- MySQL Script generated by MySQL Workbench
-- 02/13/15 18:41:36
-- Model: New Model    Version: 1.0
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Faculties` (
  `idFaculties` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idFaculties`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Departments` (
  `idDepartment` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  `Faculties_idFaculties` INT NOT NULL,
  PRIMARY KEY (`idDepartment`),
  INDEX `fk_Departments_Faculties_idx` (`Faculties_idFaculties` ASC),
  CONSTRAINT `fk_Departments_Faculties`
    FOREIGN KEY (`Faculties_idFaculties`)
    REFERENCES `mydb`.`Faculties` (`idFaculties`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Titles` (
  `idTitles` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idTitles`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Courses` (
  `idCourses` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idCourses`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Proffesors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Proffesors` (
  `idProffesors` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  `Titles_idTitles` INT NOT NULL,
  `Departments_idDepartment` INT NOT NULL,
  `Courses_idCourses` INT NOT NULL,
  PRIMARY KEY (`idProffesors`),
  INDEX `fk_Proffesors_Titles1_idx` (`Titles_idTitles` ASC),
  INDEX `fk_Proffesors_Departments1_idx` (`Departments_idDepartment` ASC),
  INDEX `fk_Proffesors_Courses1_idx` (`Courses_idCourses` ASC),
  CONSTRAINT `fk_Proffesors_Titles1`
    FOREIGN KEY (`Titles_idTitles`)
    REFERENCES `mydb`.`Titles` (`idTitles`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Proffesors_Departments1`
    FOREIGN KEY (`Departments_idDepartment`)
    REFERENCES `mydb`.`Departments` (`idDepartment`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Proffesors_Courses1`
    FOREIGN KEY (`Courses_idCourses`)
    REFERENCES `mydb`.`Courses` (`idCourses`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Students` (
  `idStudents` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(45) NOT NULL,
  `Faculties_idFaculties` INT NOT NULL,
  PRIMARY KEY (`idStudents`),
  INDEX `fk_Students_Faculties1_idx` (`Faculties_idFaculties` ASC),
  CONSTRAINT `fk_Students_Faculties1`
    FOREIGN KEY (`Faculties_idFaculties`)
    REFERENCES `mydb`.`Faculties` (`idFaculties`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`CoursesStudents`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`CoursesStudents` (
  `Students_idStudents` INT NOT NULL,
  `Courses_idCourses` INT NOT NULL,
  INDEX `fk_CoursesStudents_Students1_idx` (`Students_idStudents` ASC),
  INDEX `fk_CoursesStudents_Courses1_idx` (`Courses_idCourses` ASC),
  CONSTRAINT `fk_CoursesStudents_Students1`
    FOREIGN KEY (`Students_idStudents`)
    REFERENCES `mydb`.`Students` (`idStudents`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_CoursesStudents_Courses1`
    FOREIGN KEY (`Courses_idCourses`)
    REFERENCES `mydb`.`Courses` (`idCourses`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
