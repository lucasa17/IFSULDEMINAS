-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.7.19 - MySQL Community Server (GPL)
-- OS do Servidor:               Win64
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para burger
DROP DATABASE IF EXISTS `burger`;
CREATE DATABASE IF NOT EXISTS `burger` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `burger`;

-- Copiando estrutura para tabela burger.categoria
DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `codCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  PRIMARY KEY (`codCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela burger.categoria: ~8 rows (aproximadamente)
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` (`codCategoria`, `nome`) VALUES
	(1, 'Salgados de fabricação própria'),
	(2, 'Sucos Naturais'),
	(3, 'Sucos industrializados'),
	(4, 'Refrigerantes'),
	(5, 'Bebidas quentes'),
	(6, 'Sobremesas'),
	(7, 'Ticket Alimentação'),
	(8, 'Carlos Silva');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;

-- Copiando estrutura para tabela burger.cliente
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `codCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `endereco` varchar(100) DEFAULT NULL,
  `bairro` varchar(100) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT 'Machado',
  `cep` varchar(20) DEFAULT '37.750-000',
  `uf` char(2) DEFAULT 'MG',
  `dataNascimento` date DEFAULT NULL,
  `cpf` varchar(20) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`codCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela burger.cliente: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` (`codCliente`, `nome`, `endereco`, `bairro`, `cidade`, `cep`, `uf`, `dataNascimento`, `cpf`, `email`) VALUES
	(1, 'Carlos Telles Silva', NULL, NULL, 'Machado', '37.750-000', 'MG', '1980-09-21', NULL, 'carlos2022@gmail.com'),
	(2, 'Ana Paula Teixeira', NULL, NULL, 'Machado', '37.750-000', 'MG', '1985-11-04', NULL, 'teste@gmail.com'),
	(3, 'João Victor Telles', NULL, NULL, 'Machado', '37.750-000', 'MG', '1974-04-29', NULL, NULL);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;

-- Copiando estrutura para tabela burger.itemvenda
DROP TABLE IF EXISTS `itemvenda`;
CREATE TABLE IF NOT EXISTS `itemvenda` (
  `VENDA_codVenda` int(11) NOT NULL,
  `PRODUTO_codProduto` int(11) NOT NULL,
  `quantidade` decimal(10,0) NOT NULL,
  PRIMARY KEY (`VENDA_codVenda`,`PRODUTO_codProduto`),
  KEY `fk_PRODUTO_has_VENDA_VENDA1_idx` (`VENDA_codVenda`),
  KEY `fk_PRODUTO_has_VENDA_PRODUTO1_idx` (`PRODUTO_codProduto`),
  CONSTRAINT `fk_PRODUTO_has_VENDA_PRODUTO1` FOREIGN KEY (`PRODUTO_codProduto`) REFERENCES `produto` (`codProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRODUTO_has_VENDA_VENDA1` FOREIGN KEY (`VENDA_codVenda`) REFERENCES `venda` (`codVenda`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela burger.itemvenda: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `itemvenda` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemvenda` ENABLE KEYS */;

-- Copiando estrutura para tabela burger.marca
DROP TABLE IF EXISTS `marca`;
CREATE TABLE IF NOT EXISTS `marca` (
  `codMarca` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  PRIMARY KEY (`codMarca`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela burger.marca: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` (`codMarca`, `nome`) VALUES
	(1, 'Nestlé'),
	(2, 'Garoto'),
	(4, 'Dolly'),
	(5, 'Frutty'),
	(6, 'Coetagri');
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;

-- Copiando estrutura para view burger.nascimentoclientes
-- DROP VIEW IF EXISTS `nascimentoclientes`;
-- Criando tabela temporária para evitar erros de dependência de VIEW
CREATE TABLE `nascimentoclientes` (
	`nome` VARCHAR(200) NOT NULL COLLATE 'utf8_general_ci',
	`nascimento` VARCHAR(10) NULL COLLATE 'utf8mb4_general_ci'
) ENGINE=MyISAM;

-- Copiando estrutura para tabela burger.produto
DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `codProduto` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `precoCusto` decimal(10,2) NOT NULL,
  `precoVenda` decimal(10,2) NOT NULL,
  `margemLucro` decimal(5,2) DEFAULT NULL,
  `dataValidade` date DEFAULT NULL,
  `quantidadeEstoque` decimal(10,2) DEFAULT NULL,
  `quantidadeMinima` decimal(10,2) DEFAULT NULL,
  `CATEGORIA_codCategoria` int(11) NOT NULL,
  `MARCA_codMarca` int(11) NOT NULL,
  PRIMARY KEY (`codProduto`,`CATEGORIA_codCategoria`,`MARCA_codMarca`),
  KEY `fk_PRODUTO_CATEGORIA_idx` (`CATEGORIA_codCategoria`),
  KEY `fk_PRODUTO_MARCA1_idx` (`MARCA_codMarca`),
  CONSTRAINT `fk_PRODUTO_CATEGORIA` FOREIGN KEY (`CATEGORIA_codCategoria`) REFERENCES `categoria` (`codCategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRODUTO_MARCA1` FOREIGN KEY (`MARCA_codMarca`) REFERENCES `marca` (`codMarca`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela burger.produto: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` (`codProduto`, `nome`, `precoCusto`, `precoVenda`, `margemLucro`, `dataValidade`, `quantidadeEstoque`, `quantidadeMinima`, `CATEGORIA_codCategoria`, `MARCA_codMarca`) VALUES
	(1, 'Empada de Palmito', 1.80, 3.60, 100.00, '2022-11-20', 30.00, 10.00, 1, 6);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;

-- Copiando estrutura para tabela burger.venda
DROP TABLE IF EXISTS `venda`;
CREATE TABLE IF NOT EXISTS `venda` (
  `codVenda` int(11) NOT NULL AUTO_INCREMENT,
  `dataHora` datetime NOT NULL,
  `desconto` decimal(5,2) DEFAULT NULL,
  `tipoVenda` enum('À vista','Cartão Débito','Cartão Crédito','PIX') NOT NULL,
  `CLIENTE_codCliente` int(11) NOT NULL,
  PRIMARY KEY (`codVenda`,`CLIENTE_codCliente`),
  KEY `fk_VENDA_CLIENTE1_idx` (`CLIENTE_codCliente`),
  CONSTRAINT `fk_VENDA_CLIENTE1` FOREIGN KEY (`CLIENTE_codCliente`) REFERENCES `cliente` (`codCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela burger.venda: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `venda` DISABLE KEYS */;
INSERT INTO `venda` (`codVenda`, `dataHora`, `desconto`, `tipoVenda`, `CLIENTE_codCliente`) VALUES
	(1, '2022-12-08 07:09:00', 6.00, 'À vista', 3);
/*!40000 ALTER TABLE `venda` ENABLE KEYS */;

INSERT INTO `categoria` (`codCategoria`, `nome`) VALUES
(9, 'Lanches'),
(10, 'Porções'),
(11, 'Bebidas Alcoólicas'),
(12, 'Águas e Chás'),
(13, 'Sorvetes'),
(14, 'Combos Promocionais'),
(15, 'Vegetarianos'),
(16, 'Veganos'),
(17, 'Sem Glúten'),
(18, 'Sem Lactose');

INSERT INTO `cliente` (`codCliente`, `nome`, `endereco`, `bairro`, `cidade`, `cep`, `uf`, `dataNascimento`, `cpf`, `email`) VALUES
(4, 'Maria Oliveira Santos', 'Rua das Flores, 123', 'Centro', 'Machado', '37750-000', 'MG', '1990-05-15', '123.456.789-01', 'maria.santos@email.com'),
(5, 'Pedro Henrique Costa', 'Av. Brasil, 456', 'Jardim América', 'Machado', '37750-000', 'MG', '1985-08-22', '234.567.890-12', 'ph.costa@email.com'),
(6, 'Ana Carolina Pereira', 'Rua Tiradentes, 789', 'São José', 'Machado', '37750-000', 'MG', '1995-03-10', '345.678.901-23', 'ana.pereira@email.com'),
(7, 'Lucas Martins Rodrigues', 'Rua XV de Novembro, 321', 'Centro', 'Machado', '37750-000', 'MG', '1988-11-30', '456.789.012-34', 'lucas.rodrigues@email.com'),
(8, 'Juliana Almeida Souza', 'Av. Paulista, 654', 'Jardim Paulista', 'Machado', '37750-000', 'MG', '1992-07-18', '567.890.123-45', 'juliana.souza@email.com'),
(9, 'Fernando Silva Lima', 'Rua das Palmeiras, 987', 'Alto da Boa Vista', 'Machado', '37750-000', 'MG', '1983-04-25', '678.901.234-56', 'fernando.lima@email.com'),
(10, 'Camila Ribeiro Gonçalves', 'Rua dos Ipês, 147', 'Vila Nova', 'Machado', '37750-000', 'MG', '1998-09-12', '789.012.345-67', 'camila.goncalves@email.com'),
(11, 'Ricardo Oliveira Castro', 'Av. das Nações, 258', 'Bela Vista', 'Machado', '37750-000', 'MG', '1979-12-05', '890.123.456-78', 'ricardo.castro@email.com'),
(12, 'Patrícia Nunes Ferreira', 'Rua das Acácias, 369', 'Jardim Primavera', 'Machado', '37750-000', 'MG', '1987-06-20', '901.234.567-89', 'patricia.ferreira@email.com'),
(13, 'Gustavo Henrique Mendes', 'Av. Rio Branco, 753', 'Centro', 'Machado', '37750-000', 'MG', '1993-02-14', '012.345.678-90', 'gustavo.mendes@email.com');

INSERT INTO `marca` (`codMarca`, `nome`) VALUES
(7, 'Sadia'),
(8, 'Perdigão'),
(9, 'Coca-Cola'),
(10, 'Pepsi'),
(11, 'Bauducco'),
(12, 'Parmalat'),
(13, 'Itambé'),
(14, 'JBS'),
(15, 'Vigor'),
(16, 'Friboi');

INSERT INTO `produto` (`codProduto`, `nome`, `precoCusto`, `precoVenda`, `margemLucro`, `dataValidade`, `quantidadeEstoque`, `quantidadeMinima`, `CATEGORIA_codCategoria`, `MARCA_codMarca`) VALUES
(2, 'X-Burger', 5.00, 12.00, 140.00, '2023-12-31', 50.00, 20.00, 9, 7),
(3, 'X-Salada', 6.00, 14.00, 133.33, '2023-12-31', 45.00, 15.00, 9, 7),
(4, 'Batata Frita Grande', 3.50, 10.00, 185.71, '2023-12-31', 30.00, 10.00, 10, 8),
(5, 'Coca-Cola Lata', 2.50, 6.00, 140.00, '2024-06-30', 100.00, 30.00, 4, 9),
(6, 'Suco de Laranja Natural', 1.80, 5.00, 177.78, '2023-12-15', 40.00, 15.00, 2, 5),
(7, 'Café Expresso', 0.80, 3.00, 275.00, '2024-12-31', 200.00, 50.00, 5, 12),
(8, 'Sorvete de Chocolate', 3.00, 8.00, 166.67, '2023-12-31', 25.00, 10.00, 6, 1),
(9, 'Água Mineral 500ml', 0.70, 3.00, 328.57, '2024-12-31', 80.00, 20.00, 12, 9),
(10, 'Porção de Nuggets', 4.50, 12.00, 166.67, '2023-12-31', 35.00, 15.00, 10, 7),
(11, 'Empada de Frango', 1.80, 3.60, 100.00, '2023-11-20', 40.00, 10.00, 1, 6);

INSERT INTO `venda` (`codVenda`, `dataHora`, `desconto`, `tipoVenda`, `CLIENTE_codCliente`) VALUES
(2, '2023-01-10 12:30:00', 0.00, 'Cartão Débito', 4),
(3, '2023-01-11 13:45:00', 2.00, 'PIX', 5),
(4, '2023-01-12 18:20:00', 0.00, 'Cartão Crédito', 6),
(5, '2023-01-13 19:15:00', 5.00, 'À vista', 7),
(6, '2023-01-14 20:30:00', 0.00, 'Cartão Débito', 7),
(7, '2023-01-15 12:45:00', 3.00, 'PIX', 9),
(8, '2023-01-16 13:20:00', 0.00, 'Cartão Crédito', 7),
(9, '2023-01-17 14:10:00', 4.00, 'À vista', 11),
(10, '2023-01-18 15:30:00', 0.00, 'Cartão Débito', 12),
(11, '2023-01-19 16:45:00', 2.50, 'PIX', 13);

INSERT INTO `itemvenda` (`VENDA_codVenda`, `PRODUTO_codProduto`, `quantidade`) VALUES
(1, 1, 2),
(2, 2, 1),
(2, 5, 1),
(3, 3, 1),
(3, 4, 1),
(3, 6, 1),
(4, 2, 2),
(4, 5, 2),
(5, 7, 1),
(5, 8, 1),
(6, 9, 1),
(6, 10, 1),
(7, 3, 1),
(7, 5, 1),
(8, 4, 1),
(8, 6, 1),
(9, 2, 1),
(9, 5, 1),
(10, 3, 1),
(10, 6, 1),
(11, 1, 3),
(11, 7, 1);




-- Copiando estrutura para view burger.nascimentoclientes
-- DROP VIEW IF EXISTS `nascimentoclientes`;
-- Removendo tabela temporária e criando a estrutura VIEW final
DROP TABLE IF EXISTS `nascimentoclientes`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `nascimentoclientes` AS (select `cliente`.`nome` AS `nome`,date_format(`cliente`.`dataNascimento`,'%d/%m/%Y') AS `nascimento` from `cliente`);

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
burger.sql
Exibindo burger.sql…
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
