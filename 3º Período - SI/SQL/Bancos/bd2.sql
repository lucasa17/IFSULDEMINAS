/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para banco2025
DROP DATABASE IF EXISTS `bancobd22025`;
CREATE DATABASE IF NOT EXISTS `bancobd22025` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `bancobd22025`;

-- Copiando estrutura para tabela bancobd22025.cliente
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `idCLIENTE` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `cpf` varchar(45) NOT NULL,
  `rg` varchar(45) DEFAULT NULL,
  `dataNascimento` date NOT NULL,
  `telefone` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idCLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela bancobd22025.cliente: ~13 rows (aproximadamente)
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` (`idCLIENTE`, `nome`, `cpf`, `rg`, `dataNascimento`, `telefone`) VALUES
	(1, 'Telma Almeida', '123.456.789-10', 'MG 999.999-99', '1980-11-25', '(35)3295-9700'),
	(2, 'Roberto Silva', '035.888.888-24', 'MG 10.100.777', '1975-05-21', '(35)3295-1234'),
	(3, 'Amanda Carvalho', '036.036.036-66', NULL, '1980-06-23', NULL),
	(4, 'Pedro Augusto Telles', '999.036.036-66', NULL, '1956-12-23', NULL),
	(5, 'Rosália Pereira', '777.036.036-77', NULL, '1977-07-12', NULL),
	(6, 'Lúcia Silviano', '444.036.444-77', NULL, '1974-04-24', NULL),
	(7, 'Rosângela Alves', '777.777.777-77', 'SP 10.100.100', '1978-12-02', '(35)98811-1234'),
	(8, 'Rosângela Silva', '777.777.777-88', 'SP 10.100.900', '1978-11-02', '(35)98822-4444'),
	(9, 'Felipe Guimarães', '123.123.123-12', NULL, '1969-05-20', NULL),
	(10, 'Flávia Guimarães', '123.123.999-12', NULL, '1969-05-25', NULL),
	(11, 'Fabiana Silva', '999.999.999-99', NULL, '1970-12-02', NULL),
	(12, 'Tales Silva', '8888.888.888-88', NULL, '1975-12-02', NULL),
	(13, 'Flávio Almeida', '456.456.456-56', NULL, '1985-03-28', NULL);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;

-- Copiando estrutura para tabela bancobd22025.conta
DROP TABLE IF EXISTS `conta`;
CREATE TABLE IF NOT EXISTS `conta` (
  `idCONTA` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` enum('Salário','Corrente','Poupança') NOT NULL,
  `saldo` float(10,2) NOT NULL,
  `senha` char(8) NOT NULL,
  PRIMARY KEY (`idCONTA`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela bancobd22025.conta: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `conta` DISABLE KEYS */;
INSERT INTO `conta` (`idCONTA`, `tipo`, `saldo`, `senha`) VALUES
	(1, 'Salário', 805.50, 'abc123'),
	(2, 'Poupança', 1250.00, 'teste'),
	(3, 'Poupança', 3005.00, 'senha12'),
	(4, 'Corrente', 125.10, '*23AB*');
/*!40000 ALTER TABLE `conta` ENABLE KEYS */;

-- Copiando estrutura para tabela bancobd22025.contavinculada
DROP TABLE IF EXISTS `contavinculada`;
CREATE TABLE IF NOT EXISTS `contavinculada` (
  `CLIENTE_idCLIENTE` int(11) NOT NULL,
  `CONTA_idCONTA` int(11) NOT NULL,
  `dataAbertura` date NOT NULL,
  PRIMARY KEY (`CLIENTE_idCLIENTE`,`CONTA_idCONTA`),
  KEY `fk_CLIENTE_has_CONTA_CONTA1_idx` (`CONTA_idCONTA`),
  KEY `fk_CLIENTE_has_CONTA_CLIENTE_idx` (`CLIENTE_idCLIENTE`),
  CONSTRAINT `fk_CLIENTE_has_CONTA_CLIENTE` FOREIGN KEY (`CLIENTE_idCLIENTE`) REFERENCES `cliente` (`idCLIENTE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_CLIENTE_has_CONTA_CONTA1` FOREIGN KEY (`CONTA_idCONTA`) REFERENCES `conta` (`idCONTA`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela bancobd22025.contavinculada: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `contavinculada` DISABLE KEYS */;
INSERT INTO `contavinculada` (`CLIENTE_idCLIENTE`, `CONTA_idCONTA`, `dataAbertura`) VALUES
	(1, 1, '2022-12-20'),
	(2, 3, '2023-01-05');
/*!40000 ALTER TABLE `contavinculada` ENABLE KEYS */;


/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
bd2_banco.sql
Exibindo bd2_banco.sql…
Todos os temas
CENTRAL DE INFORMAÇÕES
CENTRAL DE INFORMAÇÕES
Material
Cronograma da disciplina
Item postado: 7 de mar.
Material
Distribuição de Notas
Item postado: 7 de mar.
Material
Página Oficial MySQL
Item postado: 7 de mar.
Material
Manual Referência MySQL 8
Item postado: 7 de mar.
Material
MATERIAL - Banco de Dados 1 e 2
Item postado: 7 de mar.
Material
Banco de Dados (Exemplos)
Última edição: 10 de jun.
Vide arquivo anexo.

sakila-db.zip
Arquivo compactado

world-db.zip
Arquivo compactado

bd2_banco.sql
SQL

burger.sql
SQL
CONTEÚDOS DISPONIBILIZADOS
CONTEÚDOS DISPONIBILIZADOS
Concluída Atividade
ENVIO - Stored Procedure (Parte 2)
Data de entrega: Ontem
Material
MATERIAL - Store Procedure (Parte 1)
Item postado: 11 de jun.
Material
MATERIAL - Trigger (parte 2) - Respostas
Item postado: 10 de jun.
Concluída Atividade
