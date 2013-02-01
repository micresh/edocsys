DROP DATABASE IF EXISTS `edocbase`;

CREATE DATABASE IF NOT EXISTS `edocbase`;

GRANT ALL PRIVILEGES ON *.* TO root@localhost IDENTIFIED BY 'po12jein45bf';

                        -- DB
-- Группы пользователей
CREATE TABLE IF NOT EXISTS `edocbase`.`user_types` (
    `id`                INT NOT NULL ,
    `name`              VARCHAR(20) ,
    PRIMARY KEY (`id`)
) ENGINE = InnoDB;


-- Пользователи
CREATE TABLE IF NOT EXISTS `edocbase`.`users` (
  `id`                  INT NOT NULL AUTO_INCREMENT,
  `login`               VARCHAR(32) NULL,
  `password`            VARCHAR(32) NULL,
  `lastname`            VARCHAR(32) NULL,
  `firstname`           VARCHAR(32) NULL,
  `middlename`          VARCHAR(32) NULL,
  `user_types_id`       INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_users_user_types` (`user_types_id` ASC) ,
  CONSTRAINT `fk_users_user_types`
    FOREIGN KEY (`user_types_id`) 
    REFERENCES `user_types` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;


-- Типы правового: ООО/ОАО/ЗАО
CREATE TABLE IF NOT EXISTS `edocbase`.`agent_types` (
  `id`                  INT(11) NOT NULL AUTO_INCREMENT,
  `name`                VARCHAR(8) NULL,
  PRIMARY KEY (`id`)
) ENGINE = InnoDB;


-- Контрагенты
CREATE TABLE IF NOT EXISTS `edocbase`.`agents` (
  `id`                  INT(11) NOT NULL AUTO_INCREMENT,
  `agent_types_id`      INT(11) DEFAULT 0,
  `name`                VARCHAR(63) DEFAULT NULL,
  `inn`                 VARCHAR(15) DEFAULT NULL,
  `phone`               VARCHAR(15) NULL ,
  `fax`                 VARCHAR(15) NULL ,
  `email`               VARCHAR(31) NULL ,
  `address`             VARCHAR(255) DEFAULT NULL,
  `ogrn`                VARCHAR(15) DEFAULT NULL,
  `kpp`                 VARCHAR(15) DEFAULT NULL,
  `okpo`                VARCHAR(15) DEFAULT NULL,
  `rs`                  VARCHAR(15) DEFAULT NULL,
  `ks`                  VARCHAR(15) DEFAULT NULL,
  `bik`                 VARCHAR(15) DEFAULT NULL,
  `bank`                VARCHAR(127) DEFAULT NULL,
  -- Основание деятельности (документ)
  `signing_authority_doc`  VARCHAR(45) DEFAULT NULL,
  `pers_status`         VARCHAR(45) NULL ,
  `pers_lastname`       VARCHAR(30) NULL ,
  `pers_firstname`      VARCHAR(30) NULL ,
  `pers_middlename`     VARCHAR(30) NULL ,
  PRIMARY KEY (`id`),
  INDEX `fk_agents_agent_types` (`agent_types_id` ASC) ,
  CONSTRAINT `fk_agents_agent_types`
    FOREIGN KEY (`agent_types_id`) 
    REFERENCES `agent_types` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE=InnoDB;


-- Контакны контрагентов
CREATE TABLE IF NOT EXISTS `edocbase`.`agents_contacts` (
  `id`                  INT NOT NULL AUTO_INCREMENT,
  `agents_id`           INT DEFAULT 0,
  `person`              VARCHAR(75) DEFAULT NULL,
  `status`              VARCHAR(45) DEFAULT NULL,
  `phone`               VARCHAR(15) DEFAULT NULL,
  `fax`                 VARCHAR(15) DEFAULT NULL,
  `email`               VARCHAR(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_agents_agents_contacts` (`agents_id` ASC) ,
  CONSTRAINT `fk_agents_agents_contacts`
      FOREIGN KEY (`agents_id`)
      REFERENCES `agents` (`id`)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
) ENGINE=InnoDB;


-- Области сертификации/лаб. исследования
CREATE TABLE IF NOT EXISTS `edocbase`.`product_areas` (
    `id`                INT NOT NULL,
    `name`              VARCHAR(40),
    PRIMARY KEY (`id`)
) ENGINE = InnoDB;


-- Продукция
CREATE TABLE IF NOT EXISTS `edocbase`.`products` (
  `id`                  INT NOT NULL AUTO_INCREMENT,
  `name`                VARCHAR(45) NULL,
  `okp`                 VARCHAR(31) NULL,
  `tnved`               VARCHAR(31) NULL,
  `product_araes_id`    INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_products_product_areas` (`product_araes_id` ASC) ,
  CONSTRAINT `fk_products_product_areas`
    FOREIGN KEY (`product_araes_id` )
    REFERENCES `edocbase`.`product_areas` ( `id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;


-- ГОСТы продукции
CREATE TABLE IF NOT EXISTS `edocbase`.`product_gosts` (
  `id`                  INT NOT NULL ,
  `products_id`         INT NULL ,
  `number`              VARCHAR(15) NULL ,
  `type`                VARCHAR(80) NULL ,
  PRIMARY KEY (`id`),
  INDEX `fk_product_gosts_products` (`products_id` ASC) ,
  CONSTRAINT `fk_product_gosts_products`
    FOREIGN KEY (`products_id`)
    REFERENCES `edocbase`.`products` (`id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;



-- Типы договоров
CREATE TABLE IF NOT EXISTS `edocbase`.`contract_types` (
    `id`                INT NOT NULL ,
    `name`              VARCHAR(55) ,
    PRIMARY KEY (`id`)
) ENGINE = InnoDB;


-- Статус договора
CREATE TABLE IF NOT EXISTS `edocbase`.`contract_status` (
    `id`                INT NOT NULL ,
    `name`              VARCHAR(45) ,
    PRIMARY KEY (`id`)
) ENGINE = InnoDB;


-- Шаблоны документов
CREATE TABLE IF NOT EXISTS `edocbase`.`doc_templates`(
  `id`                  INT NOT NULL AUTO_INCREMENT ,
  `contract_types_id`   INT NOT NULL,
  `template`            MEDIUMBLOB NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_doc_templates_contracts`
    FOREIGN KEY (`contract_types_id`)
    REFERENCES `edocbase`.`contract_types` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;


-- Тип выпуска продукции: серияная или партия фиксированного размера
CREATE TABLE IF NOT EXISTS `edocbase`.`emission_types` (
    `id`                INT NOT NULL ,
    `name`              VARCHAR(45) ,
    PRIMARY KEY (`id`)
) ENGINE = InnoDB;


-- Источники получения договоров
CREATE TABLE IF NOT EXISTS `edocbase`.`source_types` (
    `id`                INT NOT NULL ,
    `name`              VARCHAR(45) ,
    PRIMARY KEY (`id`)
) ENGINE = InnoDB;


-- Договора
CREATE TABLE IF NOT EXISTS `edocbase`.`contracts` (
  `id`                  INT NOT NULL AUTO_INCREMENT ,
  `products_id`         INT NOT NULL DEFAULT 0,
  `agents_id`           INT NOT NULL DEFAULT 0,
  `experts_id`          INT NOT NULL DEFAULT 0,
  `contract_types_id`   INT NOT NULL DEFAULT 0,
  `contract_status_id`  INT NOT NULL DEFAULT 0,
  -- Тип выпуска продукции: серияная или партия фиксированного размера
  `emission_types_id`   INT NULL DEFAULT 0,
  -- Номер договора
  `number`              VARCHAR(9) NULL ,
  -- Датаподачи заявки
  `date_proposal`       DATE NULL ,
  -- Дата заключения договора
  `date_contract`       DATE NULL ,
  -- Схема сертификации
  `scheme_type`         VARCHAR(45) NULL ,
  -- Дополнительная информация о заявке
  `add_data_proposal`   TEXT NULL,
  -- Дополнительная информация о договоре
  `add_data_contract`   TEXT NULL,
  -- Стоимость первого этапа
  `cost`                INT NULL ,
  -- Общая стоимость
  `total_cost`          INT NULL ,
  -- Признак оплаты
  `cash_income`         TINYINT(1) NULL ,
  -- Дата начала поступления оплаты
  `date_cash_income`    DATE NULL ,
  -- Дата начала работ
  `date_start`          DATE NULL ,
  -- Поступление образца
  `date_sample_income`  DATE NULL ,
  -- Дата поступления протокола
  `date_protocol_income`  DATE NULL ,
  -- Планируема дата первого инспекционного контроля/реаттестации
  `date_planed_reatt_1` DATE NULL ,
  -- Реальная дата перого инспекционного контроля/реаттестации
  `date_real_reatt_1`   DATE NULL ,
  -- Планируема дата второго инспекционного контроля/реаттестации
  `date_planed_reatt_2` DATE NULL ,
  -- Реальная дата второго инспекционного контроля/реаттестации
  `date_real_reatt_2`   DATE NULL ,
  -- Планируема дата ресертефикации
  `date_planed_resert`  DATE NULL ,
  -- Реальная дата ресертефикации
  `date_real_resert`    DATE NULL ,
  -- Источник поступления договора
  `source_types_id`     INT NULL DEFAULT 0,   -- UNUSED
  PRIMARY KEY (`id`) ,
  INDEX `fk_contracts_agents` (`agents_id` ASC) ,
  INDEX `fk_contracts_users` (`experts_id` ASC) ,
  INDEX `fk_contracts_products` (`products_id` ASC) ,
  INDEX `fk_contracts_contract_types` (`contract_types_id` ASC) ,
  INDEX `fk_contracts_contract_status` (`contract_status_id` ASC) ,
  INDEX `fk_contracts_emission_types` (`emission_types_id` ASC) ,
  INDEX `fk_contracts_source_types` (`source_types_id` ASC) ,
  CONSTRAINT `fk_contracts_agents`
    FOREIGN KEY (`agents_id`)
    REFERENCES `edocbase`.`agents` (`id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_contracts_users`
    FOREIGN KEY (`experts_id` )
    REFERENCES `edocbase`.`users` (`id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_contracts_products`
    FOREIGN KEY (`products_id` )
    REFERENCES `edocbase`.`products` (`id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_contracts_contract_types`
    FOREIGN KEY (`contract_types_id` )
    REFERENCES `edocbase`.`contract_types` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_contracts_contract_status`
    FOREIGN KEY (`contract_status_id` )
    REFERENCES `edocbase`.`contract_status` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_contracts_emission_types`
    FOREIGN KEY (`emission_types_id` )
    REFERENCES `edocbase`.`emission_types` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_contracts_source_types`
    FOREIGN KEY (`source_types_id` )
    REFERENCES `edocbase`.`source_types` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;

-- Выбраные ГОСТы для проведения работ
CREATE TABLE IF NOT EXISTS `edocbase`.`selected_gosts` (
  `id`                  INT NOT NULL AUTO_INCREMENT,
  `contracts_id`        INT NOT NULL ,
  `product_gosts_id`    INT NOT NULL ,
  PRIMARY KEY (`id`),
  INDEX `fk_selected_gosts_contracts` (`contracts_id` ASC) ,
  INDEX `fk_selected_gosts_product_gosts` (`product_gosts_id` ASC) ,
  CONSTRAINT `fk_product_gosts_contracts`
    FOREIGN KEY (`contracts_id`)
    REFERENCES `edocbase`.`contracts` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_selected_gosts_product_gosts`
    FOREIGN KEY (`product_gosts_id`)
    REFERENCES `edocbase`.`product_gosts` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;


-- Лог полсещений
CREATE TABLE IF NOT EXISTS `edocbase`.`log_journal` (
  `id`                  INT NOT NULL AUTO_INCREMENT ,
  `time_enter`          DATETIME NULL ,
  `time_leave`          DATETIME NULL ,
  `users_id`            INT NULL ,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_log_journal_users`
    FOREIGN KEY (`users_id` )
    REFERENCES `edocbase`.`users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;


-- Докуметнция
CREATE TABLE IF NOT EXISTS `edocbase`.`documents`(
  `id`                  INT NOT NULL AUTO_INCREMENT ,
  `contracts_id`        INT NOT NULL,
  `contract_types_id`   INT NOT NULL,
  `users_id`            INT NOT NULL,
  `date_modify`         DATETIME NULL ,
  `document`            MEDIUMBLOB NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_documents_contracts` (`contracts_id` ASC) ,
  CONSTRAINT `fk_documents_contracts`
    FOREIGN KEY (`contracts_id`)
    REFERENCES `edocbase`.`contracts` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_documents_contract_types`
    FOREIGN KEY (`contract_types_id`)
    REFERENCES `edocbase`.`contract_types` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_documents_users`
    FOREIGN KEY (`users_id`)
    REFERENCES `edocbase`.`users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
) ENGINE = InnoDB;