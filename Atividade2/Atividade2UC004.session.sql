 CREATE DATABASE IF NOT EXISTS Viagem;
 
use Viagem;

CREATE TABLE IF NOT EXISTS  usuario(id INT NOT NULL AUTO_INCREMENT  PRIMARY  KEY,
nome VARCHAR(100) NOT NULL,
dataNasc VARCHAR(10) NOT NULL,
login VARCHAR(40) NOT NULL,
senha VARCHAR(30) NOT NULL,
tipo INT
);

CREATE TABLE if not EXISTS pacote(id INT NOT NULL AUTO_INCREMENT  PRIMARY  KEY,
nome VARCHAR(100) NOT NULL,
origem VARCHAR(100) NOT NULL,
destino VARCHAR(100) NOT NULL,
atrativos text,
saida VARCHAR(100),
retorno VARCHAR(100),
usuario INT,
FOREIGN KEY (usuario)  REFERENCES usuario(id)
);

CREATE TABLE if not EXISTS compra(id INT NOT NULL AUTO_INCREMENT  PRIMARY  KEY,
    idcompra int,
    idusuario int,
    idpacote int,
    valor double(10,2),
    total double(12,2),
    pagamento int
); 

