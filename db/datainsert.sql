-- insert user types into table
INSERT INTO `edocbase`.`user_types` (`id`, `name`) VALUES ('1', 'Администратор');
INSERT INTO `edocbase`.`user_types` (`id`, `name`) VALUES ('2', 'Эксперт');
INSERT INTO `edocbase`.`user_types` (`id`, `name`) VALUES ('3', 'Директор');


-- insert users into users table
INSERT INTO `edocbase`.`users` (`login`, `password`, `lastname`, `firstname`, `middlename`, `user_types_id`) VALUES ('admin',    md5('123'), 'A', 'A', 'A', 1);
INSERT INTO `edocbase`.`users` (`login`, `password`, `lastname`, `firstname`, `middlename`, `user_types_id`) VALUES ('expert',   md5('123'), 'E', 'E', 'E', 2);
INSERT INTO `edocbase`.`users` (`login`, `password`, `lastname`, `firstname`, `middlename`, `user_types_id`) VALUES ('direktor', md5('123'), 'D', 'D', 'D', 3);


-- insert contract_types into contract_types table
INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (0,'Заявка');
INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (1,'Акт выполненных работ');
INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (2,'Договор об инспекционном контроле (ЛД)');
-- INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (2,'Документ о первом инспекционном контроле/реаттестации');
-- INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (3,'Документ о втором инспекционном контроле/реаттестации');

INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (10,'Сертификация (ОС)');
INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (11,'Декларирование соответствия (Д)');
INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (12,'Сертификационные испытания (ИЛ)');
INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (13,'Сертификация c сертификационными испытаниями (ЛС)');
INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (14,'Разработка технических условий (ТУ)');
INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (15,'Договор на конкретные испытания (Г)');
INSERT INTO `edocbase`.`contract_types` (`id`, `name`) VALUES (16,'Лабораторный контроль (ЛК)');


-- insert contract statuses into contract_status table
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (0,'Подготовка заявки');
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (1,'Закрепление эксперта');
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (2,'Заключение договора');
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (3,'Подготовка к работе');
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (4,'В работе');
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (5,'Подтверждение выполнения руководителем');
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (6,'Подтверждение выполнения клиентом');
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (7,'Заключение договора реаттестации');
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (8,'Договора на инспекционном контроле');
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (9,'Завершенные договора');

INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (20,'Невыполнение по вине заказчика');
INSERT INTO `edocbase`.`contract_status` (`id`, `name`) VALUES (21,'Невыполнение по вине эксперта');


-- insert product_areas into product_areas table
INSERT INTO `edocbase`.`product_areas` (`id`, `name`) VALUES (0,'Область сертификации');
INSERT INTO `edocbase`.`product_areas` (`id`, `name`) VALUES (1,'Область лабораторных исследований');


-- insert agent types into agent_types table
INSERT INTO `edocbase`.`agent_types` (`id`, `name`) VALUES (1, 'ООО');
INSERT INTO `edocbase`.`agent_types` (`id`, `name`) VALUES (2, 'ОАО');
INSERT INTO `edocbase`.`agent_types` (`id`, `name`) VALUES (3, 'ЗАО');

-- insert emission types into emission_types table
INSERT INTO `edocbase`.`emission_types` (`id`, `name`) VALUES (1, 'еденичное производство');
INSERT INTO `edocbase`.`emission_types` (`id`, `name`) VALUES (2, 'серийный выпуск');

-- insert source types into source_types table
INSERT INTO `edocbase`.`source_types` (`id`, `name`) VALUES (1, 'лично в офисе');
INSERT INTO `edocbase`.`source_types` (`id`, `name`) VALUES (2, 'по телефону');
INSERT INTO `edocbase`.`source_types` (`id`, `name`) VALUES (3, 'через интернет');
