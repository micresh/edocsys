-- isnert users into users table
INSERT INTO `edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('admin', md5('123'),1,'admin');
INSERT INTO `edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('expert', md5('123'),1,'expert');
INSERT INTO `edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('direktor', md5('123'),1,'direktor');
INSERT INTO `edocbase`.`users` (`login`, `password`, `type`, `log_database`) VALUES ('defuser', md5('123'),1,'defuser');
