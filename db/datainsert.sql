-- isnert users into users table
INSERT INTO `Edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('admin', md5('123'),1,'admin');
INSERT INTO `Edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('expert', md5('123'),1,'expert');
INSERT INTO `Edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('direktor', md5('123'),1,'direktor');
INSERT INTO `Edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('defuser', md5('123'),1,'defuser');
-- isnert contracttypes into ContractTypes table
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (0,'заявка добавлена');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (1,'к заявке прикреплен эксперт');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (2,'начата работа по заявке');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (3,'оформлен акт выполненных работ');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (4,'акт утвержден руководителем');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (20,'невыполнение по вине заказчика');
INSERT INTO `Edocbase`.`ContractTypes` (`id`, `name`) VALUES (21,'невыполнение по вине эксперта');