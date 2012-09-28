CREATE DATABASE IF NOT EXISTS `Edocsys`;

GRANT ALL PRIVILEGES ON *.* TO root@localhost IDENTIFIED BY 'po12jein45bf';

CREATE  TABLE IF NOT EXISTS `Edocsys`.`Agents` (
  `idAgents` INT NOT NULL AUTO_INCREMENT ,
  `Ag_fullname` VARCHAR(45) NULL ,
  `Ag_shortname` VARCHAR(45) NULL ,
  `Ag_addr` VARCHAR(45) NULL ,
  `Ag_tel` VARCHAR(45) NULL ,
  `Ag_fax` VARCHAR(45) NULL ,
  `Ag_mail` VARCHAR(45) NULL ,
  `Ag_INN` VARCHAR(45) NULL ,
  `Ag_OGRN` VARCHAR(45) NULL ,
  `Ag_KPP` VARCHAR(45) NULL ,
  `Ag_OKPO` VARCHAR(45) NULL ,
  `Ag_Rcou` VARCHAR(45) NULL ,
  `Ag_Kcou` VARCHAR(45) NULL ,
  `Ag_BIK` VARCHAR(45) NULL ,
  `Ag_bank` VARCHAR(45) NULL ,
  `Ag_doc` VARCHAR(45) NULL ,
  `Ag_pers_status` VARCHAR(45) NULL ,
  `Ag_pers_fullname` VARCHAR(45) NULL ,
  `Ag_pers_shortname` VARCHAR(45) NULL ,
  PRIMARY KEY (`idAgents`) )
ENGINE = InnoDB;
CREATE  TABLE IF NOT EXISTS `Edocsys`.`Experts` (
  `idExperts` INT NOT NULL AUTO_INCREMENT ,
  `Expert_Lastname` VARCHAR(45) NULL ,
  `Expert_Firstname` VARCHAR(45) NULL ,
  `Expert_Middlename` VARCHAR(45) NULL ,
  PRIMARY KEY (`idExperts`) )
ENGINE = InnoDB;
CREATE  TABLE IF NOT EXISTS `Edocsys`.`Products` (
  `idProducts` INT NOT NULL AUTO_INCREMENT ,
  `Product_name` VARCHAR(45) NULL ,
  `Product_OKP` VARCHAR(45) NULL ,
  `Product_TNVED` VARCHAR(45) NULL ,
  PRIMARY KEY (`idProducts`) )
ENGINE = InnoDB;
CREATE  TABLE IF NOT EXISTS `Edocsys`.`ProdGost` (
  `id` INT NOT NULL ,
  `idProducts` INT NULL ,
  `GOST_numb` VARCHAR(45) NULL ,
  `Prod_type` VARCHAR(45) NULL ,
  PRIMARY KEY (`id`) ,
  INDEX `fk_ProdGost_1` (`idProducts` ASC) ,
  CONSTRAINT `fk_ProdGost_1`
    FOREIGN KEY (`idProducts` )
    REFERENCES `Edocsys`.`Products` (`idProducts` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;
CREATE  TABLE IF NOT EXISTS `Edocsys`.`Contracts` (
  `idContract` INT NOT NULL AUTO_INCREMENT ,
  `idProducts` INT NULL ,
  `emission_type` VARCHAR(45) NULL ,
  `Client_docs` VARCHAR(45) NULL ,
  `Schem_type` INT NULL ,
  `Add_data` VARCHAR(45) NULL ,
  `Contract_type` TINYINT NULL ,
  `Contract_value_1` MEDIUMINT NULL ,
  `Contract_value_full` MEDIUMINT NULL ,
  `agent_id` INT NULL ,
  `Contract_number` INT NULL ,
  `Contract_status` TINYINT(1) NULL ,
  `Bid_type` TINYINT NULL ,
  `expert_id` INT NULL ,
  `Cash_income` TINYINT(1) NULL ,
  PRIMARY KEY (`idContract`) ,
  INDEX `fk_Contracts_1` (`agent_id` ASC) ,
  INDEX `fk_Contracts_2` (`expert_id` ASC) ,
  INDEX `fk_Contracts_3` (`idProducts` ASC) ,
  CONSTRAINT `fk_Contracts_1`
    FOREIGN KEY (`agent_id` )
    REFERENCES `Edocsys`.`Agents` (`idAgents` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Contracts_2`
    FOREIGN KEY (`expert_id` )
    REFERENCES `Edocsys`.`Experts` (`idExperts` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Contracts_3`
    FOREIGN KEY (`idProducts` )
    REFERENCES `Edocsys`.`Products` (`idProducts` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;
CREATE  TABLE IF NOT EXISTS `Edocsys`.`Exec_contracts` (
  `idContract` INT NOT NULL ,
  `Contract_start` DATE NULL ,
  `Contract_1_reatt` DATE NULL ,
  `Contract_2_reatt` DATE NULL ,
  `Contract_resume` DATE NULL ,
  `exec_1_reatt` DATE NULL ,
  `exec_2_reatt` DATE NULL ,
  `exec_resume` DATE NULL ,
  `sample_income` DATE NULL ,
  `protocol_income` DATE NULL ,
  PRIMARY KEY (`idContract`) ,
  INDEX `fk_Exec_contracts_1` (`idContract` ASC) ,
  CONSTRAINT `fk_Exec_contracts_1`
    FOREIGN KEY (`idContract` )
    REFERENCES `Edocsys`.`Contracts` (`idContract` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;
CREATE  TABLE IF NOT EXISTS `Edocsys`.`users` (
  `login` VARCHAR(50) NULL ,
  `password` VARCHAR(50) NULL ,
  `type` INT NULL ,
  `log_database` VARCHAR(50) NULL )
ENGINE = InnoDB;
CREATE  TABLE IF NOT EXISTS `Edocsys`.`log_journal` (
  `sessid` int NOT NULL AUTO_INCREMENT ,
  `time_in` DATETIME NULL ,
  `time_out` DATETIME NULL ,
  `uname` VARCHAR(50) NULL ,
  PRIMARY KEY (`sessid`) )
ENGINE = InnoDB

