SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `optometria1` ;
CREATE SCHEMA IF NOT EXISTS `optometria1` DEFAULT CHARACTER SET latin1 COLLATE latin1_spanish_ci ;
USE `optometria1` ;

-- -----------------------------------------------------
-- Table `optometria1`.`pacientes`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `optometria1`.`pacientes` (
  `idpacientes` INT(11) NOT NULL ,
  `Nombre del paciente` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NOT NULL ,
  `Tèlefono` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NOT NULL ,
  `Dirección` VARCHAR(100) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NULL DEFAULT NULL ,
  `Correo Electrónico` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NULL DEFAULT NULL ,
  PRIMARY KEY (`idpacientes`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1
COLLATE = latin1_spanish_ci;

CREATE INDEX `idpacientes_UNIQUE` ON `optometria1`.`pacientes` (`idpacientes` ASC) ;


-- -----------------------------------------------------
-- Table `optometria1`.`especialidad`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `optometria1`.`especialidad` (
  `idEspecialidad` INT(11) NOT NULL AUTO_INCREMENT ,
  `Especialidad` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NOT NULL ,
  PRIMARY KEY (`idEspecialidad`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1
COLLATE = latin1_spanish_ci;

CREATE UNIQUE INDEX `idCurso_UNIQUE` ON `optometria1`.`especialidad` (`idEspecialidad` ASC) ;


-- -----------------------------------------------------
-- Table `optometria1`.`estudiantes`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `optometria1`.`estudiantes` (
  `Estudiantes` INT(11) NOT NULL ,
  `Nombre` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NOT NULL ,
  `Cédula` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NULL DEFAULT NULL ,
  `Correo Electrónico` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NULL DEFAULT NULL ,
  `Teléfono` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NULL DEFAULT NULL ,
  `Grupo` VARCHAR(45) NOT NULL ,
  `especialidad_idEspecialidad` INT(11) NOT NULL ,
  PRIMARY KEY (`Estudiantes`, `especialidad_idEspecialidad`) ,
  CONSTRAINT `fk_estudiantes_especialidad1`
    FOREIGN KEY (`especialidad_idEspecialidad` )
    REFERENCES `optometria1`.`especialidad` (`idEspecialidad` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1
COLLATE = latin1_spanish_ci;

CREATE UNIQUE INDEX `idtable1_UNIQUE` ON `optometria1`.`estudiantes` (`Estudiantes` ASC) ;

CREATE INDEX `fk_estudiantes_especialidad1_idx` ON `optometria1`.`estudiantes` (`especialidad_idEspecialidad` ASC) ;


-- -----------------------------------------------------
-- Table `optometria1`.`cita`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `optometria1`.`cita` (
  `Codigo de Cita` INT(11) NOT NULL AUTO_INCREMENT ,
  `pacientes_idpacientes` INT(11) NOT NULL ,
  `estudiantes_idestudiantes` INT(11) NOT NULL ,
  `Fecha` DATE NULL DEFAULT NULL ,
  `Hora Inicial` TIME NULL DEFAULT NULL ,
  `Hora Finalización` TIME NULL DEFAULT NULL ,
  PRIMARY KEY (`Codigo de Cita`, `pacientes_idpacientes`, `estudiantes_idestudiantes`) ,
  CONSTRAINT `fk_Cita_pacientes1`
    FOREIGN KEY (`pacientes_idpacientes` )
    REFERENCES `optometria1`.`pacientes` (`idpacientes` )
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_Cita_Estudiantes`
    FOREIGN KEY (`estudiantes_idestudiantes` )
    REFERENCES `optometria1`.`estudiantes` (`Estudiantes` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = latin1
COLLATE = latin1_spanish_ci;

CREATE INDEX `idCita_UNIQUE` ON `optometria1`.`cita` (`Codigo de Cita` ASC) ;

CREATE INDEX `fk_Cita_pacientes:idx1` ON `optometria1`.`cita` (`pacientes_idpacientes` ASC) ;

CREATE INDEX `fk_Cita_Estudiantes_idx` ON `optometria1`.`cita` (`estudiantes_idestudiantes` ASC) ;


-- -----------------------------------------------------
-- Table `optometria1`.`clínicas`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `optometria1`.`clínicas` (
  `idClinica` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NOT NULL ,
  PRIMARY KEY (`idClinica`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1
COLLATE = latin1_spanish_ci;


-- -----------------------------------------------------
-- Table `optometria1`.`usuarios`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `optometria1`.`usuarios` (
  `idUsuario` INT(11) NOT NULL ,
  `Contraseña` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NOT NULL ,
  `Nombre` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NOT NULL ,
  `Perfil` VARCHAR(45) CHARACTER SET 'latin1' COLLATE 'latin1_spanish_ci' NOT NULL ,
  PRIMARY KEY (`idUsuario`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1
COLLATE = latin1_spanish_ci;

USE `optometria1` ;

-- -----------------------------------------------------
-- Placeholder table for view `optometria1`.`VerCitas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `optometria1`.`VerCitas` (`Nombre del paciente` INT, `Nombre` INT, `Especialidad` INT, `Fecha` INT, `Hora Inicial` INT, `Hora Finalización` INT, `idClinica` INT);

-- -----------------------------------------------------
-- View `optometria1`.`VerCitas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `optometria1`.`VerCitas`;
USE `optometria1`;
CREATE  OR REPLACE VIEW `optometria1`.`VerCitas` AS
select `Nombre del paciente`, `Nombre`, `Especialidad`, `Fecha`, `Hora Inicial`, `Hora Finalización`,
`idClinica` from optometria1.pacientes, optometria1.estudiantes, optometria1.especialidad, optometria1.cita, 
optometria1.clínicas;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
