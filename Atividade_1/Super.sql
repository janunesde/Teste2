CREATE DATABASE Super;

Use Super;

CREATE TABLE `Produtos` (
  `idProduto` int(11) NOT NULL AUTO_INCREMENT,
  `nomeProduto` varchar(200) DEFAULT NULL,
  `valorProduto` double(9,2) DEFAULT NULL,
  `quantidadeProduto` int(11) DEFAULT NULL,
  PRIMARY KEY (`idProduto`));


CREATE TABLE `Fornecedores` (
  `idfornecedor` int(9) NOT NULL AUTO_INCREMENT,
  `nomeProduto` varchar(200) DEFAULT NULL,
  `valorProduto` double(9,2) DEFAULT NULL,
  `quantidadeProduto` int(9) DEFAULT NULL,
  `setor` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idfornecedor`));
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Açucar Cristal',4.60,100,'Padaria');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Arroz Cristal',13.40,150,'Padaria');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Cebola',3.00,150,'Padaria');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Doce de morango',2.50,70,'Padaria');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Queijo fatiado',18.90,60,'Padaria');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Desodorante',6.25,200,'Perfumaria');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Xampu',8.59,180,'Perfumaria');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Condicionador',7.95,50,'Perfumaria');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Sabonete',1.19,900,'Perfumaria');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Cotonete',1.75,200,'Perfumaria');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Batata-branca',2.05,200,'Hortifruti');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Tomate',2.80,150,'Hortifruti');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Cebola roxa',3.10,80,'Hortifruti');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Abóbora cabutia',1.25,120,'Hortifruti');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Pimentão',3.70,140,'Hortifruti');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Arroz integral',18.50,200,'Alimentos');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Feijão',4.25,210,'Alimentos');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Farinha',2.00,400,'Alimentos');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Açúcar mascavo',4.39,80,'Alimentos');
INSERT INTO `Fornecedores`(nomeProduto, valorProduto, quantidadeProduto, setor) VALUES ('Óleo de soja',3.89,500,'Alimentos');

/* Inserindo todos os dados da tabela Fornecedores em Produtos */
INSERT INTO Produtos (nomeProduto, valorProduto, quantidadeProduto)
SELECT nomeProduto, valorProduto, quantidadeProduto FROM Fornecedores;


/*Acrescentando 20% ao valorProduto */
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 1;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 2;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 3;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 4;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 5;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 6;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 7;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 8;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 9;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 10;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 11;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 12;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 13;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 14;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 15;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 12;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 13;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 14;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 15;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 16;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 17;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 18;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 19;
UPDATE Produtos SET valorProduto = (valorProduto +(valorProduto*(20/100))) WHERE idProduto = 20;


CREATE TABLE `Candidatos` (
  `idCandidato` int(9) NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) DEFAULT NULL,
  `experiencia` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idcandidato`));
INSERT INTO `Candidatos`(nome, experiencia)  VALUES ('João Paulo','Atendente de padaria');
INSERT INTO `Candidatos`(nome, experiencia)  VALUES ('Adamastor Júnior','Repositor');
INSERT INTO `Candidatos`(nome, experiencia)  VALUES ('Ana Cláudia','Atendente de caixa');
INSERT INTO `Candidatos`(nome, experiencia)  VALUES ('Daltron Silva','Mecânico de carros');
INSERT INTO `Candidatos`(nome, experiencia)  VALUES ('Tiel Evandro','Lavador de carros');
INSERT INTO `Candidatos`(nome, experiencia)  VALUES ('Amanda Carvalho','Atendente de caixa');
INSERT INTO `Candidatos`(nome, experiencia)  VALUES ('Clóvis Nogueira','Atendente de padaria');
INSERT INTO `Candidatos`(nome, experiencia)  VALUES ('Jorge Pereira','Coveiro');

CREATE TABLE Funcionarios(
idFuncionario INT AUTO_INCREMENT,
nomeFuncionario VARCHAR(200),
setorFuncionario VARCHAR(80),
PRIMARY KEY(idFuncionario));

INSERT INTO `Funcionarios`(nomeFuncionario, setorFuncionario) VALUES ('João Paulo', 'Atendente de padaria');
INSERT INTO `Funcionarios`(nomeFuncionario, setorFuncionario) VALUES ('Ana Cláudia','Atendente de caixa');
INSERT INTO `Funcionarios`(nomeFuncionario, setorFuncionario) VALUES ('Adamastor Júnior','Repositor');

/*Adicionando a coluna cpf a tabela Funcionarios */
ALTER TABLE Funcionarios ADD COLUMN cpf int(11); 
UPDATE Funcionarios SET cpf = 14347219435 WHERE idFuncionario = 1;
UPDATE Funcionarios SET cpf = 73216054141 WHERE idFuncionario = 2;
UPDATE Funcionarios SET cpf = 81540252316 WHERE idFuncionario = 3;


CREATE TABLE `Consumidor` (
  `idConsumidor` int(11) NOT NULL AUTO_INCREMENT,
  `tipoConsumidor` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`idConsumidor`));

CREATE TABLE `Venda` (
  `idVenda` int(11) NOT NULL AUTO_INCREMENT,
  `idConsumidor` int(11) DEFAULT NULL,
  `valorTotalVenda` double(9,2) DEFAULT NULL,
  PRIMARY KEY (`idVenda`),
  KEY `idConsumidor` (`idConsumidor`),
  CONSTRAINT `Venda_ibfk_1` FOREIGN KEY (`idConsumidor`) REFERENCES `Consumidor` (`idConsumidor`));

CREATE TABLE `itensVendidos` (
  `idVenda` int(11) NOT NULL,
  `idProduto` int(11) NOT NULL,
  `quantidadeVendida` int(11) DEFAULT NULL,
  `valorProduto` double(9,2) DEFAULT NULL,
  `valorTotalProduto` double(9,2) DEFAULT NULL,
  PRIMARY KEY (`idVenda`,`idProduto`),
  KEY `idProduto` (`idProduto`),
  CONSTRAINT `itensVendidos_ibfk_1` FOREIGN KEY (`idVenda`) REFERENCES `Venda` (`idVenda`),
  CONSTRAINT `itensVendidos_ibfk_2` FOREIGN KEY (`idProduto`) REFERENCES `Produtos` (`idProduto`));