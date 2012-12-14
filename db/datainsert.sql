-- insert users into users table
INSERT INTO `Edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('admin', md5('123'),1,'admin');
INSERT INTO `Edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('expert', md5('123'),1,'expert');
INSERT INTO `Edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('direktor', md5('123'),1,'direktor');
INSERT INTO `Edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('defuser', md5('123'),1,'defuser');

-- insert contracttypes into ContractTypes table
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (0,'Заявка добавлена');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (1,'Ожидание прикрепления эксперта');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (2,'К заявке прикреплен эксперт');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (3,'Начата работа по заявке');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (4,'Оформлен акт выполненных работ');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (5,'Акт утвержден руководителем');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (20,'Невыполнение по вине заказчика');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (21,'Невыполнение по вине эксперта');

-- insert productareas into ProductAreas table
INSERT INTO `Edocbase`.`ProductAreas` (`id`, `name`) VALUES (0,'Область сертификации');
INSERT INTO `Edocbase`.`ProductAreas` (`id`, `name`) VALUES (1,'Область лабораторных исследований');

-- insert productareas into Agents_types table
INSERT INTO `Edocbase`.`Agents_types` (`idAgents_types`, `Agent_type`) VALUES (1, 'ООО');
INSERT INTO `Edocbase`.`Agents_types` (`idAgents_types`, `Agent_type`) VALUES (2, 'ОАО');
INSERT INTO `Edocbase`.`Agents_types` (`idAgents_types`, `Agent_type`) VALUES (3, 'ЗАО');
