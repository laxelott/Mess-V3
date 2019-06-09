-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.1.30-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win32
-- HeidiSQL Version:             10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for messv3
DROP DATABASE IF EXISTS `messv3`;
CREATE DATABASE IF NOT EXISTS `messv3` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `messv3`;

-- Dumping structure for procedure messv3.p_create_user
DROP PROCEDURE IF EXISTS `p_create_user`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `p_create_user`(
	IN `i` NVARCHAR(200),
	IN `n` NVARCHAR(200),
	IN `u` NVARCHAR(200),
	IN `p` NVARCHAR(200)


)
BEGIN

	DECLARE errorCode INT DEFAULT 0;
	DECLARE num INT;
	DECLARE message VARCHAR(200);
	
	SET num = (SELECT COUNT(*) FROM t_users WHERE t_users .id = i);
	
	IF (num = 0) THEN
		SET num = (SELECT COUNT(*) FROM t_users  WHERE t_users .username = u);
		
		IF (num = 0) THEN
			
			INSERT INTO t_users (t_users .id, t_users .username, t_users .NAME, t_users .PASSWORD)
				VALUES( i, u, n, p );
			
			SET message = "User registered";
			
		ELSE 
			## Error Code 2 mean that the username is already occupied
			SET errorCode = 1;
			SET message = "Username taken";
		END IF;
	ELSE
		## errorCode 1 means that this id is already occupied
		SET errorCode = 2;
		SET message = "Id occupied";
	END IF;
	
	SELECT num AS 'id', errorCode, message;
	
END//
DELIMITER ;

-- Dumping structure for procedure messv3.p_delete_user
DROP PROCEDURE IF EXISTS `p_delete_user`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `p_delete_user`(
	IN `i` INT

)
BEGIN

	DECLARE num INT;
	DECLARE message VARCHAR(200);
	
	SET num = (SELECT COUNT(*) FROM t_users  WHERE t_users .id = i);
	
	IF (num != 0) THEN
	
		# First delete messages made by this user
		DELETE FROM t_messages
			WHERE t_messages.userId = i;
	
		# Then delete user
		DELETE FROM t_users 
			WHERE t_users .id = i;
		
		SET message = "User deleted";
		SET num = 0;
							
	ELSE
		SET message = "User does not exist";
		SET num = 1;
	END IF ;

	SELECT message, num AS 'errorCode';

END//
DELIMITER ;

-- Dumping structure for procedure messv3.p_edit_user
DROP PROCEDURE IF EXISTS `p_edit_user`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `p_edit_user`(
	IN `i` INT,
	IN `n` VARCHAR(250)


)
BEGIN

	DECLARE num INT;
	DECLARE message VARCHAR(200);
	
	SET num = (SELECT COUNT(*) FROM t_users WHERE t_users.id = i);
	
	IF (num != 0) THEN
	
		UPDATE t_users
			SET t_users.name = n
			WHERE t_users.id = i;
		
		SET message = "User altered";
		SET num = 1;
							
	ELSE
		SET message = "User does not exist";
		SET num = 0;
	END IF ;

	SELECT message, num AS 'isValid';

END//
DELIMITER ;

-- Dumping structure for procedure messv3.p_validate_user
DROP PROCEDURE IF EXISTS `p_validate_user`;
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `p_validate_user`(
	IN `u` NVARCHAR(200),
	IN `p` INT



)
BEGIN

	DECLARE num INT;
	DECLARE message VARCHAR(250);
	DECLARE name VARCHAR(250);
	DECLARE id INT;
	
	
	SET num = (SELECT COUNT(*) FROM t_users WHERE t_users.username = u AND t_users.PASSWORD = p);
	
	IF (num != 0) THEN
		SET message = "Correct credentials";
		SET num = 1;
		
		SET name = (select t_users.name from t_users where t_users.username = u and t_users.password = p);
		SET id = (select t_users.id from t_users where t_users.username = u and t_users.password = p);
	ELSE
		SET message = "Incorrect credentials";
		SET num = 0;
		SET name = "";
		SET id = 0;
	END IF ;

	SELECT message, num AS 'login', name as 'name', id;

END//
DELIMITER ;

-- Dumping structure for table messv3.t_messages
DROP TABLE IF EXISTS `t_messages`;
CREATE TABLE IF NOT EXISTS `t_messages` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `userId` int(11) NOT NULL,
  `content` varchar(250) CHARACTER SET utf8 DEFAULT NULL,
  `TYPE` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `userId` (`userId`),
  CONSTRAINT `t_messages_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `t_users` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table messv3.t_messages: ~0 rows (approximately)
DELETE FROM `t_messages`;
/*!40000 ALTER TABLE `t_messages` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_messages` ENABLE KEYS */;

-- Dumping structure for table messv3.t_users
DROP TABLE IF EXISTS `t_users`;
CREATE TABLE IF NOT EXISTS `t_users` (
  `id` int(4) NOT NULL,
  `username` varchar(200) CHARACTER SET utf8 NOT NULL,
  `name` varchar(200) CHARACTER SET utf8 NOT NULL,
  `password` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table messv3.t_users: ~3 rows (approximately)
DELETE FROM `t_users`;
/*!40000 ALTER TABLE `t_users` DISABLE KEYS */;
INSERT INTO `t_users` (`id`, `username`, `name`, `password`) VALUES
	(2170, 'b', 'Password', -1623739142),
	(3756, 'peepee', 'pepe', -1623739142),
	(8903, 'laxelott', 'Axel', -1623739142);
/*!40000 ALTER TABLE `t_users` ENABLE KEYS */;

-- Dumping structure for view messv3.v_messages
DROP VIEW IF EXISTS `v_messages`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `v_messages` (
	`name` VARCHAR(200) NOT NULL COLLATE 'utf8_general_ci',
	`content` VARCHAR(250) NULL COLLATE 'utf8_general_ci',
	`type` INT(11) NOT NULL,
	`time` TIMESTAMP NOT NULL
) ENGINE=MyISAM;

-- Dumping structure for view messv3.v_messages
DROP VIEW IF EXISTS `v_messages`;
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `v_messages`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_messages` AS SELECT 
		t_users.NAME AS "name",
		t_messages.content, t_messages.`TYPE` AS "type", t_messages.TIME AS "time"
	FROM t_messages
	INNER JOIN t_users ON
		t_messages.userId = t_users.id ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
