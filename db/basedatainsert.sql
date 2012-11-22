INSERT INTO `Edocbase`.`Experts` VALUES (1,'Иванов','Иван','Иванович');

INSERT INTO `Edocbase`.`Agents` (`idAgents`, `Ag_type_id`, `Ag_fullname`, `Ag_INN`, `Ag_tel`, `Ag_fax`, `Ag_mail`, `Ag_addr`, `Ag_OGRN`, `Ag_KPP`,
                                 `Ag_OKPO`, `Ag_Rcou`, `Ag_Kcou`, `Ag_BIK`, `Ag_bank`, `Ag_doc`, `Ag_pers_status`, `Ag_pers_fullname`, `Ag_pers_shortname`) VALUES
                                ( 0, 1, 'Организация', 'INN56655465', 't2223333', 'f2223333','pochta@domen.dom', '350000, Краснодар ул. Красная 1', 'OGRN4564','KPP4645',
                                 'OKPO65465','RS4545665656565', 'KS566556566556','BIK6556','Сбербанк','Устав от 01.01.2012','Директор','Петров Петр Петрович', 'Петров П.П.');

INSERT INTO `Edocbase`.`Agents_contacts` VALUES (0, 1, 'Сидоров Макар Сёмович', 'Манагер', 't8-800-2000-500','f8-800-2000-501', 'manager@domen.dom');

INSERT INTO `Edocbase`.`Products` VALUES (0,'Кирпич','65546-8974','551565-9559',0);
INSERT INTO `Edocbase`.`ProdGost` VALUES (0,1,'13805-98','проверка на влажность');
INSERT INTO `Edocbase`.`ProdGost` VALUES (1,1,'13805-98','проверка на термостойкость');
INSERT INTO `Edocbase`.`Contracts` VALUES (0,1,'серийный','устав какой-то','схема 3а','Это самый лучший клиент',0,5000,20000,1,1,0,0,1,0);
INSERT INTO `Edocbase`.`Exec_contracts` VALUES (1,'1999-12-19','1999-12-19','1999-12-19','1999-12-19','1999-12-19','1999-12-19','1999-12-19','1999-12-19','1999-12-19');
