-- --------------------------------------------------------
-- Хост:                         NAS.LegioNTeaM.ru
-- Версия сервера:               5.1.73 - Source distribution
-- Операционная система:         none-linux-gnueabi
-- HeidiSQL Версия:              12.3.0.6589
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Дамп структуры базы данных DB_transport
CREATE DATABASE IF NOT EXISTS `DB_transport` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `DB_transport`;

-- Дамп структуры для таблица DB_transport.depots
CREATE TABLE IF NOT EXISTS `depots` (
  `id_depot` tinyint(4) NOT NULL AUTO_INCREMENT,
  `depot_number` tinyint(2) NOT NULL,
  `depot_name` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`id_depot`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8 COMMENT='депо/парк';

-- Дамп данных таблицы DB_transport.depots: ~23 rows (приблизительно)
REPLACE INTO `depots` (`id_depot`, `depot_number`, `depot_name`) VALUES
	(1, 1, 'Первый Автобусный парк г. Москвы'),
	(2, 2, 'Второй Автобусный парк г. Москвы'),
	(3, 3, 'Третий Автобусный парк г. Москвы'),
	(4, 4, 'Четвертый Автобусный парк г. Москвы'),
	(5, 5, 'Пятый Автобусный парк г. Москв'),
	(6, 6, 'Шестой Автобусный парк г. Москвы'),
	(7, 7, 'Седьмой Автобусный парк г. Москвы'),
	(8, 8, 'Восьмой Автобусный парк г. Москвы'),
	(9, 9, 'Девятый Автобусный парк г. Москвы'),
	(10, 10, 'Десятый Автобусный парк г. Москвы'),
	(11, 11, 'Одинадцатый Автобусный парк г. Москвы'),
	(12, 12, 'Двенадцатый Автобусный парк г. Москвы'),
	(13, 13, 'Тренадцатый Автобусный парк г. Москвы'),
	(14, 14, 'Четырнадцатый Автобусный парк г. Москвы'),
	(15, 15, 'Пятнадцатый Автобусный парк г. Москвы'),
	(16, 1, 'Первый Троллейбусный парк г. Москвы'),
	(17, 2, 'Второй Троллейбусный парк г. Москвы'),
	(18, 3, 'Третий Троллейбусный парк г. Москвы'),
	(19, 4, 'Четвертый Троллейбусный парк г. Москвы'),
	(20, 5, 'Пятый Троллейбусный парк г. Москвы'),
	(21, 6, 'Шестой Троллейбусный парк г. Москвы'),
	(22, 7, 'Седьмой Троллейбусный парк г. Москвы'),
	(23, 8, 'Восьмой Троллейбусный парк г. Москвы');

-- Дамп структуры для таблица DB_transport.depots_transports_type
CREATE TABLE IF NOT EXISTS `depots_transports_type` (
  `id_dtt` tinyint(1) NOT NULL AUTO_INCREMENT,
  `depot_id` tinyint(1) NOT NULL,
  `transport_id` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_dtt`) USING BTREE,
  UNIQUE KEY `depot_id_transport_id` (`depot_id`,`transport_id`),
  KEY `FK_depots_transports` (`transport_id`),
  CONSTRAINT `FK_depots_transports` FOREIGN KEY (`transport_id`) REFERENCES `transports` (`id_transport`) ON UPDATE CASCADE,
  CONSTRAINT `FK_depots_transpotrs_type_depots` FOREIGN KEY (`depot_id`) REFERENCES `depots` (`id_depot`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8 COMMENT='Тип траспорта в депо/парке ';

-- Дамп данных таблицы DB_transport.depots_transports_type: ~35 rows (приблизительно)
REPLACE INTO `depots_transports_type` (`id_dtt`, `depot_id`, `transport_id`) VALUES
	(1, 1, 1),
	(2, 1, 2),
	(3, 1, 3),
	(4, 2, 1),
	(5, 2, 3),
	(7, 3, 1),
	(6, 3, 2),
	(8, 3, 3),
	(9, 4, 2),
	(10, 5, 2),
	(11, 6, 1),
	(12, 6, 2),
	(13, 6, 3),
	(14, 7, 1),
	(15, 8, 1),
	(16, 8, 2),
	(17, 9, 2),
	(18, 10, 1),
	(19, 11, 2),
	(20, 12, 1),
	(21, 13, 2),
	(22, 14, 2),
	(23, 15, 1),
	(24, 15, 3),
	(25, 16, 5),
	(26, 17, 4),
	(27, 17, 5),
	(28, 18, 5),
	(30, 19, 4),
	(31, 19, 5),
	(32, 20, 5),
	(33, 21, 4),
	(34, 22, 4),
	(35, 23, 4),
	(36, 23, 5);

-- Дамп структуры для таблица DB_transport.depots_workers_on_routes
CREATE TABLE IF NOT EXISTS `depots_workers_on_routes` (
  `id_WoR` smallint(6) NOT NULL AUTO_INCREMENT,
  `worker_id` smallint(6) NOT NULL,
  `route_id` smallint(6) NOT NULL,
  PRIMARY KEY (`id_WoR`),
  UNIQUE KEY `worker_id_dtp_id_route_id` (`worker_id`,`route_id`) USING BTREE,
  KEY `FK_workers_on_routes_routes` (`route_id`),
  CONSTRAINT `FK_workers_on_routes_routes` FOREIGN KEY (`route_id`) REFERENCES `routes` (`id_route`) ON UPDATE CASCADE,
  CONSTRAINT `FK_workers_on_routes_workers` FOREIGN KEY (`worker_id`) REFERENCES `workers` (`id_worker`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;

-- Дамп данных таблицы DB_transport.depots_workers_on_routes: ~30 rows (приблизительно)
REPLACE INTO `depots_workers_on_routes` (`id_WoR`, `worker_id`, `route_id`) VALUES
	(1, 1, 12),
	(2, 2, 17),
	(3, 3, 8),
	(4, 4, 14),
	(5, 5, 11),
	(6, 6, 16),
	(7, 7, 7),
	(8, 8, 6),
	(9, 9, 5),
	(10, 10, 7),
	(11, 11, 3),
	(12, 12, 15),
	(13, 13, 1),
	(14, 14, 9),
	(15, 15, 3),
	(16, 16, 15),
	(17, 17, 8),
	(18, 18, 10),
	(19, 19, 9),
	(20, 20, 12),
	(21, 21, 16),
	(22, 22, 2),
	(23, 23, 11),
	(26, 24, 6),
	(25, 25, 4),
	(24, 26, 4),
	(27, 27, 2),
	(28, 28, 20),
	(30, 29, 22),
	(29, 30, 21);

-- Дамп структуры для таблица DB_transport.human_families
CREATE TABLE IF NOT EXISTS `human_families` (
  `id_family` smallint(6) NOT NULL AUTO_INCREMENT,
  `family` varchar(16) NOT NULL,
  PRIMARY KEY (`id_family`) USING BTREE,
  UNIQUE KEY `family` (`family`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8 COMMENT='Фамилия сотрудника';

-- Дамп данных таблицы DB_transport.human_families: ~29 rows (приблизительно)
REPLACE INTO `human_families` (`id_family`, `family`) VALUES
	(23, 'Бирт'),
	(21, 'Богословский'),
	(7, 'Брехайло'),
	(18, 'Буракшаева'),
	(10, 'Дояркина'),
	(4, 'Жожобайло'),
	(13, 'Иванова'),
	(2, 'Курочкин'),
	(5, 'Медведев'),
	(19, 'Мельникова'),
	(3, 'Огоньков'),
	(22, 'Перфильева'),
	(9, 'Петров'),
	(1, 'Петухов'),
	(16, 'Пименов'),
	(24, 'Писарев'),
	(15, 'Пискунова'),
	(20, 'Прокопенко'),
	(11, 'Пушкинов'),
	(26, 'Рудаков'),
	(17, 'Сапсан'),
	(14, 'Седенкова'),
	(6, 'Сноуден'),
	(12, 'Товароведова'),
	(25, 'Толстой'),
	(29, 'Трампов'),
	(28, 'Троцкий'),
	(27, 'Ульянов'),
	(8, 'Штокайло');

-- Дамп структуры для таблица DB_transport.human_names
CREATE TABLE IF NOT EXISTS `human_names` (
  `id_name` smallint(6) NOT NULL AUTO_INCREMENT,
  `name` varchar(16) NOT NULL,
  PRIMARY KEY (`id_name`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8 COMMENT='Имя сотрудника';

-- Дамп данных таблицы DB_transport.human_names: ~25 rows (приблизительно)
REPLACE INTO `human_names` (`id_name`, `name`) VALUES
	(20, 'Алина'),
	(12, 'Анастасия'),
	(5, 'Анахонт'),
	(7, 'Аркадий'),
	(27, 'Армен'),
	(21, 'Артем'),
	(4, 'Баунти'),
	(14, 'Валерия'),
	(1, 'Владимир'),
	(8, 'Дмитрий'),
	(3, 'Евстафий'),
	(23, 'Елизавета'),
	(10, 'Жанна'),
	(6, 'Иван'),
	(24, 'Ильгиз'),
	(19, 'Ксения'),
	(2, 'Макар'),
	(15, 'Максим'),
	(22, 'Милена'),
	(9, 'Петро'),
	(26, 'Роман'),
	(13, 'София'),
	(11, 'Стихоплетий'),
	(25, 'Тактогул'),
	(16, 'Юлия');

-- Дамп структуры для таблица DB_transport.human_surnames
CREATE TABLE IF NOT EXISTS `human_surnames` (
  `id_surname` smallint(6) NOT NULL AUTO_INCREMENT,
  `surname` varchar(16) NOT NULL,
  PRIMARY KEY (`id_surname`) USING BTREE,
  UNIQUE KEY `surname` (`surname`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8 ROW_FORMAT=COMPACT COMMENT='Отчество сотрудника';

-- Дамп данных таблицы DB_transport.human_surnames: ~24 rows (приблизительно)
REPLACE INTO `human_surnames` (`id_surname`, `surname`) VALUES
	(1, ''),
	(16, 'Александровна'),
	(18, 'Алексеевич'),
	(8, 'Анатольевич'),
	(10, 'Батькович'),
	(2, 'Богданович'),
	(4, 'Борисович'),
	(24, 'Вазгенович'),
	(20, 'Витальевна'),
	(11, 'Дарковна'),
	(21, 'Дмитриевна'),
	(17, 'Евгеньевич'),
	(23, 'Егоровна'),
	(14, 'Ивановна'),
	(7, 'Иваныч'),
	(15, 'Максимовна'),
	(13, 'Мамедовна'),
	(22, 'Михайлович'),
	(6, 'Огникович'),
	(12, 'Прозоплетович'),
	(3, 'Семенович'),
	(19, 'Сергеевна'),
	(9, 'Угрюмович'),
	(5, 'Эдмундович');

-- Дамп структуры для таблица DB_transport.jobs
CREATE TABLE IF NOT EXISTS `jobs` (
  `id_job` tinyint(1) NOT NULL AUTO_INCREMENT,
  `job_name` varchar(20) NOT NULL,
  PRIMARY KEY (`id_job`),
  UNIQUE KEY `job_name` (`job_name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COMMENT='Должность сотрудника';

-- Дамп данных таблицы DB_transport.jobs: ~3 rows (приблизительно)
REPLACE INTO `jobs` (`id_job`, `job_name`) VALUES
	(1, 'водитель автобуса'),
	(2, 'водитель тролейбуса\r'),
	(3, 'кондуктор\r\n');

-- Дамп структуры для таблица DB_transport.routes
CREATE TABLE IF NOT EXISTS `routes` (
  `id_route` smallint(6) NOT NULL AUTO_INCREMENT,
  `route_number` varchar(4) NOT NULL,
  `dtt_id` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_route`),
  UNIQUE KEY `route_number_dtp_id` (`route_number`,`dtt_id`) USING BTREE,
  KEY `FK_route_transport` (`dtt_id`) USING BTREE,
  CONSTRAINT `FK_routes_depots_transports_type` FOREIGN KEY (`dtt_id`) REFERENCES `depots_transports_type` (`id_dtt`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8 COMMENT='Маршруты';

-- Дамп данных таблицы DB_transport.routes: ~19 rows (приблизительно)
REPLACE INTO `routes` (`id_route`, `route_number`, `dtt_id`) VALUES
	(3, '199', 1),
	(14, '199', 3),
	(15, '2', 6),
	(20, '212', 21),
	(11, '256', 3),
	(4, '30', 5),
	(5, '399', 10),
	(9, '400м', 12),
	(8, '400т', 12),
	(12, '452', 24),
	(2, '52', 2),
	(7, '56т', 31),
	(10, '6', 2),
	(17, '70', 35),
	(1, '70', 36),
	(6, '70к', 35),
	(21, '751', 15),
	(22, '820', 21),
	(16, '8к', 9);

-- Дамп структуры для таблица DB_transport.transports
CREATE TABLE IF NOT EXISTS `transports` (
  `id_transport` tinyint(1) NOT NULL AUTO_INCREMENT,
  `transport_type` varchar(20) NOT NULL,
  PRIMARY KEY (`id_transport`),
  UNIQUE KEY `transport_name` (`transport_type`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COMMENT='Тип транспорта';

-- Дамп данных таблицы DB_transport.transports: ~5 rows (приблизительно)
REPLACE INTO `transports` (`id_transport`, `transport_type`) VALUES
	(1, 'автобус'),
	(3, 'маршрутное такси'),
	(2, 'микро автобус'),
	(4, 'троллейбус'),
	(5, 'электробус');

-- Дамп структуры для таблица DB_transport.workers
CREATE TABLE IF NOT EXISTS `workers` (
  `id_worker` smallint(6) NOT NULL AUTO_INCREMENT,
  `worker_family` smallint(6) NOT NULL,
  `worker_name` smallint(6) NOT NULL,
  `worker_surname` smallint(6) NOT NULL,
  `depot_id` tinyint(1) NOT NULL,
  `job_id` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_worker`) USING BTREE,
  KEY `FK_workers_human_names` (`worker_name`),
  KEY `FK_workers_human_families` (`worker_family`),
  KEY `FK_workers_jobs` (`job_id`),
  KEY `FK_workers_human_surnames` (`worker_surname`),
  KEY `FK_workers_depots` (`depot_id`),
  CONSTRAINT `FK_workers_depots` FOREIGN KEY (`depot_id`) REFERENCES `depots` (`id_depot`) ON UPDATE CASCADE,
  CONSTRAINT `FK_workers_human_families` FOREIGN KEY (`worker_family`) REFERENCES `human_families` (`id_family`) ON UPDATE CASCADE,
  CONSTRAINT `FK_workers_human_names` FOREIGN KEY (`worker_name`) REFERENCES `human_names` (`id_name`) ON UPDATE CASCADE,
  CONSTRAINT `FK_workers_human_surnames` FOREIGN KEY (`worker_surname`) REFERENCES `human_surnames` (`id_surname`) ON UPDATE CASCADE,
  CONSTRAINT `FK_workers_jobs` FOREIGN KEY (`job_id`) REFERENCES `jobs` (`id_job`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8 COMMENT='Сотрудники';

-- Дамп данных таблицы DB_transport.workers: ~30 rows (приблизительно)
REPLACE INTO `workers` (`id_worker`, `worker_family`, `worker_name`, `worker_surname`, `depot_id`, `job_id`) VALUES
	(1, 1, 1, 2, 15, 1),
	(2, 2, 2, 3, 23, 3),
	(3, 3, 3, 4, 6, 1),
	(4, 4, 4, 5, 1, 1),
	(5, 5, 5, 6, 1, 1),
	(6, 6, 6, 7, 4, 3),
	(7, 7, 7, 8, 19, 3),
	(8, 8, 8, 9, 23, 3),
	(9, 9, 9, 10, 5, 1),
	(10, 10, 10, 11, 19, 2),
	(11, 11, 11, 12, 1, 1),
	(12, 12, 12, 13, 3, 3),
	(13, 13, 13, 14, 23, 2),
	(14, 14, 14, 15, 6, 1),
	(15, 15, 14, 16, 1, 3),
	(16, 16, 15, 17, 3, 1),
	(17, 17, 6, 18, 6, 3),
	(18, 18, 16, 19, 1, 1),
	(19, 19, 19, 20, 6, 3),
	(20, 20, 20, 21, 15, 3),
	(21, 21, 21, 22, 4, 1),
	(22, 22, 22, 23, 1, 3),
	(23, 23, 23, 16, 1, 3),
	(24, 8, 20, 13, 23, 2),
	(25, 11, 8, 8, 2, 1),
	(26, 2, 8, 18, 2, 3),
	(27, 3, 8, 3, 1, 1),
	(28, 27, 25, 3, 13, 1),
	(29, 28, 5, 9, 13, 1),
	(30, 29, 27, 24, 8, 1);

-- Дамп структуры для представление DB_transport.View_Routes_Info
-- Создание временной таблицы для обработки ошибок зависимостей представлений
CREATE TABLE `View_Routes_Info` (
	`ID` SMALLINT(6) NOT NULL,
	`Number` VARCHAR(4) NOT NULL COLLATE 'utf8_general_ci',
	`Transport Type` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`Depots Name` VARCHAR(40) NULL COLLATE 'utf8_general_ci'
) ENGINE=MyISAM;

-- Дамп структуры для представление DB_transport.View_Workers_Info
-- Создание временной таблицы для обработки ошибок зависимостей представлений
CREATE TABLE `View_Workers_Info` (
	`Worker ID` SMALLINT(6) NOT NULL,
	`Family` VARCHAR(16) NOT NULL COLLATE 'utf8_general_ci',
	`Name` VARCHAR(16) NOT NULL COLLATE 'utf8_general_ci',
	`Surname` VARCHAR(16) NOT NULL COLLATE 'utf8_general_ci',
	`Depots Name` VARCHAR(40) NULL COLLATE 'utf8_general_ci',
	`Job` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci'
) ENGINE=MyISAM;

-- Дамп структуры для представление DB_transport.View_Workers_on_Routes
-- Создание временной таблицы для обработки ошибок зависимостей представлений
CREATE TABLE `View_Workers_on_Routes` (
	`Number` VARCHAR(4) NOT NULL COLLATE 'utf8_general_ci',
	`Transport Type` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`Depots Name` VARCHAR(40) NULL COLLATE 'utf8_general_ci',
	`Family` VARCHAR(16) NOT NULL COLLATE 'utf8_general_ci',
	`Name` VARCHAR(16) NOT NULL COLLATE 'utf8_general_ci',
	`Surname` VARCHAR(16) NOT NULL COLLATE 'utf8_general_ci',
	`Job` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci'
) ENGINE=MyISAM;

-- Дамп структуры для представление DB_transport.View_Routes_Info
-- Удаление временной таблицы и создание окончательной структуры представления
DROP TABLE IF EXISTS `View_Routes_Info`;
CREATE ALGORITHM=MERGE SQL SECURITY DEFINER VIEW `View_Routes_Info` AS select `Routes`.`id_route` AS `ID`,`Routes`.`route_number` AS `Number`,`Transports`.`transport_type` AS `Transport Type`,`Depots`.`depot_name` AS `Depots Name` from (((`routes` `Routes` join `depots_transports_type` `DTT`) join `depots` `Depots`) join `transports` `Transports`) where ((`Routes`.`dtt_id` = `DTT`.`id_dtt`) and (`DTT`.`depot_id` = `Depots`.`id_depot`) and (`DTT`.`transport_id` = `Transports`.`id_transport`)) WITH CASCADED CHECK OPTION;

-- Дамп структуры для представление DB_transport.View_Workers_Info
-- Удаление временной таблицы и создание окончательной структуры представления
DROP TABLE IF EXISTS `View_Workers_Info`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `View_Workers_Info` AS select `Worker`.`id_worker` AS `Worker ID`,`Family`.`family` AS `Family`,`Name`.`name` AS `Name`,`Surname`.`surname` AS `Surname`,`Depot`.`depot_name` AS `Depots Name`,`Jobs`.`job_name` AS `Job` from (((((`workers` `Worker` join `human_families` `Family`) join `human_names` `Name`) join `human_surnames` `Surname`) join `depots` `Depot`) join `jobs` `Jobs`) where ((`Family`.`id_family` = `Worker`.`worker_family`) and (`Name`.`id_name` = `Worker`.`worker_name`) and (`Surname`.`id_surname` = `Worker`.`worker_surname`) and (`Worker`.`job_id` = `Jobs`.`id_job`) and (`Worker`.`depot_id` = `Depot`.`id_depot`)) order by `Worker`.`id_worker`;

-- Дамп структуры для представление DB_transport.View_Workers_on_Routes
-- Удаление временной таблицы и создание окончательной структуры представления
DROP TABLE IF EXISTS `View_Workers_on_Routes`;
CREATE ALGORITHM=MERGE SQL SECURITY DEFINER VIEW `View_Workers_on_Routes` AS select `Routes`.`route_number` AS `Number`,`Transports`.`transport_type` AS `Transport Type`,`Depots`.`depot_name` AS `Depots Name`,`Family`.`family` AS `Family`,`Name`.`name` AS `Name`,`Surname`.`surname` AS `Surname`,`Jobs`.`job_name` AS `Job` from (((((((((`routes` `Routes` join `depots_transports_type` `DTT`) join `depots` `Depots`) join `transports` `Transports`) join `depots_workers_on_routes` `DWR`) join `workers` `Worker`) join `human_families` `Family`) join `human_names` `Name`) join `human_surnames` `Surname`) join `jobs` `Jobs`) where ((`Routes`.`dtt_id` = `DTT`.`id_dtt`) and (`DTT`.`depot_id` = `Worker`.`depot_id`) and (`DTT`.`depot_id` = `Depots`.`id_depot`) and (`DTT`.`transport_id` = `Transports`.`id_transport`) and (`DWR`.`route_id` = `Routes`.`id_route`) and (`DWR`.`worker_id` = `Worker`.`id_worker`) and (`Family`.`id_family` = `Worker`.`worker_family`) and (`Name`.`id_name` = `Worker`.`worker_name`) and (`Surname`.`id_surname` = `Worker`.`worker_surname`) and (`Worker`.`job_id` = `Jobs`.`id_job`)) order by `Routes`.`route_number`,`Jobs`.`job_name` WITH CASCADED CHECK OPTION;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
